using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace R3_VillagePeople_Mahtimokit
{
    public partial class Db_queries : frm_Main_Window
    {
        /// <summary>
        ///  1. = Common
        ///  2. = Load datagrids
        ///  3. = Create new
        ///  4. = Edit
        ///  5. = Delete
        /// </summary>
        //
        // 1. Common
        //
        frm_Main_Window main_window = new frm_Main_Window();
        SqlDataReader myReader = null;
        // Määritellään tietokantayhteyden muodostin.
        public SqlConnection db_connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                          AttachDbFilename=|DataDirectory|\VP_Database.mdf;
                          Integrated Security=True;
                          Connect Timeout=15;
                          User Instance=False");

        public void Update_log(string lisatieto_loki)
        {
            // Loki taulun päivitys
            SqlCommand database_query_loki = new SqlCommand("INSERT INTO [Loki] ([paivittaja], [lisatieto]) " +
                "VALUES(@paivittaja, @lisatieto_loki)");
            database_query_loki.Connection = db_connection;
            db_connection.Open();
            database_query_loki.Parameters.AddWithValue("@paivittaja", Properties.Settings.Default["user_name"].ToString());
            database_query_loki.Parameters.AddWithValue("@lisatieto_loki", lisatieto_loki);
            database_query_loki.ExecuteNonQuery();
            db_connection.Close();
        }
        public string Orders_within_dates = "";
        public void Get_history_orders_within_dates()
        {
            // Haetaan tietokannasta valitun aikavälin varaukset
            SqlDataReader myReader = null;
            List<string> orders_within_dates = new List<string>();
            SqlCommand database_query_get_orders_in_dates = new SqlCommand("SELECT varaus_id FROM Varaus WHERE varattu_pvm  >= @start AND varattu_pvm <= @end");
            database_query_get_orders_in_dates.Connection = db_connection;
            db_connection.Open();
            database_query_get_orders_in_dates.Parameters.AddWithValue("@start", dtp_History_Orders_Filter_Date_Start.Value);
            database_query_get_orders_in_dates.Parameters.AddWithValue("@end", dtp_History_Orders_Filter_Date_End.Value);
            database_query_get_orders_in_dates.ExecuteNonQuery();
            myReader = database_query_get_orders_in_dates.ExecuteReader();
            while (myReader.Read())
            {
                orders_within_dates.Add("'" + (myReader["varaus_id"].ToString() + "'"));
            }
            db_connection.Close();
            Orders_within_dates = string.Join(",", orders_within_dates.ToArray());
        }

        public string Cottages_within_orders = "";
        public void Get_order_cottages_within_dates()
        {
            // Haetaan tietokannasta valitun aikavälin varaukset
            SqlDataReader myReader = null;
            List<int> orders_within_dates = new List<int>();
            List<string> cottages_within_orders = new List<string>();
            SqlCommand database_query_get_orders_in_dates = new SqlCommand("SELECT varaus_id FROM Varaus WHERE varattu_loppupvm  >= @start AND varattu_loppupvm <= @end");
            database_query_get_orders_in_dates.Connection = db_connection;
            db_connection.Open();
            database_query_get_orders_in_dates.Parameters.AddWithValue("@start", dtp_Order_Start_Date.Value);
            database_query_get_orders_in_dates.Parameters.AddWithValue("@end", dtp_Order_End_Date.Value);
            database_query_get_orders_in_dates.ExecuteNonQuery();
            myReader = database_query_get_orders_in_dates.ExecuteReader();
            while (myReader.Read())
            {
                orders_within_dates.Add(Convert.ToInt32((myReader["varaus_id"])));
            }
            db_connection.Close();
            foreach (int varaus_id in orders_within_dates)
            {
                SqlCommand database_query_get_cottage_ids = new SqlCommand("SELECT majoitus_id FROM Varauksen_majoitus WHERE varaus_id = @varaus_id");
                database_query_get_cottage_ids.Connection = db_connection;
                db_connection.Open();
                database_query_get_cottage_ids.Parameters.AddWithValue("@varaus_id", varaus_id);
                database_query_get_cottage_ids.ExecuteNonQuery();
                myReader = database_query_get_cottage_ids.ExecuteReader();
                while (myReader.Read())
                {
                    cottages_within_orders.Add("'" + (myReader["majoitus_id"].ToString() + "'"));

                }
                db_connection.Close();
            }
            Cottages_within_orders = string.Join(", ", cottages_within_orders.ToArray());
        }

        public void Get_order_details()
        {
            if (dgv_Order_Services_All.SelectedCells.Count > 0)
            {
                // Tyhjennetään nykyiset palvelut ja mökit.
                lsv_History_Order_Cottages.Clear();
                lsv_History_Order_Services.Clear();
                // Alustetaan apumuuttujat ja haetaan varaus_id.
                string varaus_id = "";
                string toimipiste_id = "";
                string asiakas_id = "";
                SqlDataReader myReader = null;
                foreach (DataGridViewRow row in dgv_History_Orders_All.SelectedRows)
                {
                    varaus_id = row.Cells[0].Value.ToString();
                }
                lbl_History_Order_varaus_id.Text = "Varausnumero: " + varaus_id;
                // Varauksen perustietojen hakeminen.
                SqlCommand database_query_order_basic_details = new SqlCommand("SELECT * FROM Varaus WHERE varaus_id = @varaus_id ");
                database_query_order_basic_details.Connection = db_connection;
                db_connection.Open();
                database_query_order_basic_details.Parameters.AddWithValue("@varaus_id", varaus_id);
                database_query_order_basic_details.ExecuteNonQuery();
                myReader = database_query_order_basic_details.ExecuteReader();
                while (myReader.Read())
                {
                    toimipiste_id = (myReader["toimipiste_id"].ToString());
                    asiakas_id = (myReader["asiakas_id"].ToString());
                    lbl_History_Order_Start.Text = "Alkamispäivä: " + Convert.ToDateTime(myReader["varattu_alkupvm"]).ToString("dd.MM.yyyy");
                    lbl_History_Order_End.Text = "Päättymispäivä: " + Convert.ToDateTime(myReader["varattu_loppupvm"]).ToString("dd.MM.yyyy");
                    txt_History_Order_Additional_Details.Text = (myReader["lisatieto"].ToString());
                }
                db_connection.Close();
                // Toimipisteen nimen haku
                SqlCommand database_query_order_office_name = new SqlCommand("SELECT nimi FROM Toimipiste WHERE toimipiste_id = @toimipiste_id ");
                database_query_order_office_name.Connection = db_connection;
                db_connection.Open();
                database_query_order_office_name.Parameters.AddWithValue("@toimipiste_id", toimipiste_id);
                database_query_order_office_name.ExecuteNonQuery();
                myReader = database_query_order_office_name.ExecuteReader();
                while (myReader.Read())
                {
                    lbl_History_Selected_Order_Office.Text = "Toimipiste: " + (myReader["nimi"].ToString());
                }
                db_connection.Close();
                // Asiakkaan nimen haku
                SqlCommand database_query_order_customer_name = new SqlCommand("SELECT kokonimi FROM Asiakas WHERE asiakas_id = @asiakas_id ");
                database_query_order_customer_name.Connection = db_connection;
                db_connection.Open();
                database_query_order_customer_name.Parameters.AddWithValue("@asiakas_id", asiakas_id);
                database_query_order_customer_name.ExecuteNonQuery();
                myReader = database_query_order_customer_name.ExecuteReader();
                while (myReader.Read())
                {
                    lbl_History_Selected_Order_Customer.Text = "Asiakas: " + (myReader["kokonimi"].ToString());
                }
                db_connection.Close();
                // Majoitustietojen haku
                var cottage_ids_and_quantities = new Dictionary<int, int>();
                string majoitus_nimi = "";
                SqlCommand database_query_order_cottage_details = new SqlCommand("SELECT * FROM Varauksen_majoitus WHERE varaus_id = @varaus_id");
                database_query_order_cottage_details.Connection = db_connection;
                db_connection.Open();
                database_query_order_cottage_details.Parameters.AddWithValue("@varaus_id", varaus_id);
                database_query_order_cottage_details.ExecuteNonQuery();
                myReader = database_query_order_cottage_details.ExecuteReader();
                while (myReader.Read())
                {
                    cottage_ids_and_quantities.Add(Convert.ToInt32((myReader["majoitus_id"])), Convert.ToInt32((myReader["majoittujien_maara"])));
                }
                db_connection.Close();
                // Lisätään varauksen mökit varaushistorian yhteenvetoon
                // Luodaan läpikäytävä lista cottage_ids_and_quantities taulusta.
                List<int> order_cottages = new List<int>(cottage_ids_and_quantities.Keys);
                // Käydään kaikki taulun arvot läpi.
                foreach (int cottage_id in order_cottages)
                {
                    // Mökissä majoittuvien määrä
                    int persons = cottage_ids_and_quantities[cottage_id];
                    // Tietokantakomento on määriteltävä uudestaan jokaisessa silmukassa, muuten @majoitus_id ei ole uniikki ja johtaa virheeseen.
                    SqlCommand database_query_order_cottage_text_details = new SqlCommand("SELECT Nimi FROM Majoitus WHERE majoitus_id = @majoitus_id");
                    database_query_order_cottage_text_details.Connection = db_connection;
                    db_connection.Open();
                    // Haetaan majoitus_id:n perusteella majoituksen nimi.
                    database_query_order_cottage_text_details.Parameters.AddWithValue("@majoitus_id", cottage_id);
                    database_query_order_cottage_text_details.ExecuteNonQuery();
                    myReader = database_query_order_cottage_text_details.ExecuteReader();
                    while (myReader.Read())
                    {
                        majoitus_nimi = (myReader["nimi"]).ToString();

                    }
                    // Suljetaan yhteys ja lisätään varauksen mökki listview näkymään.
                    db_connection.Close();
                    lsv_History_Order_Cottages.Items.Add(majoitus_nimi + " [" + persons + "]");
                }

                // Palveluiden haku
                var service_ids_and_quantities = new Dictionary<int, int>();
                string palvelun_nimi = "";
                SqlCommand database_query_order_service_details = new SqlCommand("SELECT * FROM Varauksen_palvelut WHERE varaus_id = @varaus_id");
                database_query_order_service_details.Connection = db_connection;
                db_connection.Open();
                database_query_order_service_details.Parameters.AddWithValue("@varaus_id", varaus_id);
                database_query_order_service_details.ExecuteNonQuery();
                myReader = database_query_order_service_details.ExecuteReader();
                while (myReader.Read())
                {
                    service_ids_and_quantities.Add(Convert.ToInt32((myReader["palvelu_id"])), Convert.ToInt32((myReader["lkm"])));
                }
                db_connection.Close();
                // Lisätään varauksen palvelut varaushistorian yhteenvetoon
                List<int> order_services = new List<int>(service_ids_and_quantities.Keys);
                // Käydään kaikki taulun arvot läpi.
                foreach (int service_id in order_services)
                {
                    // Mökissä majoittuvien määrä
                    int quantity = service_ids_and_quantities[service_id];
                    // Tietokantakomento on määriteltävä uudestaan jokaisessa silmukassa, muuten @majoitus_id ei ole uniikki ja johtaa virheeseen.
                    SqlCommand database_query_order_service_text_details = new SqlCommand("SELECT Nimi FROM Palvelu WHERE palvelu_id = @palvelu_id");
                    database_query_order_service_text_details.Connection = db_connection;
                    db_connection.Open();
                    // Haetaan majoitus_id:n perusteella majoituksen nimi.
                    database_query_order_service_text_details.Parameters.AddWithValue("@palvelu_id", service_id);
                    database_query_order_service_text_details.ExecuteNonQuery();
                    myReader = database_query_order_service_text_details.ExecuteReader();
                    while (myReader.Read())
                    {
                        palvelun_nimi = (myReader["nimi"]).ToString();

                    }
                    // Suljetaan yhteys ja lisätään varauksen mökki listview näkymään.
                    db_connection.Close();
                    lsv_History_Order_Services.Items.Add(palvelun_nimi + " [" + quantity + "]");
                }
            }
        }

        //
        // 2. Load datagrids
        //
        // DataGriedView elementtien tietojen päivitys.
        public void Get_customer_names_to_grid()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT asiakas_id, kokonimi FROM Asiakas", db_connection))
            {
                DataSet data_set = new DataSet();
                database_query.Fill(data_set);
                if (data_set.Tables.Count > 0)
                {
                    dgv_Order_Customers_All.DataSource = data_set.Tables[0].DefaultView;
                    dgv_Customers_All.DataSource = data_set.Tables[0].DefaultView;
                    dgv_History_Customers_All.DataSource = data_set.Tables[0].DefaultView;
                    // Jos ei tyhjä datagridview, valitaan rivi, ohjelma kohtaa virheen jos riviä ei ole valittu ja painetaan: 
                    // "lisää varaukseen" tai "muokkaa" asiakas_id on piilotettu sarake, eli kokonimi = 1, ensimmäinen rivi listassa = 0.
                    if (dgv_Order_Customers_All.Rows.OfType<DataGridViewRow>().Any())
                    {
                        dgv_Order_Customers_All.CurrentCell = dgv_Order_Customers_All[1, 0];
                        dgv_Customers_All.CurrentCell = dgv_Customers_All[1, 0];
                        dgv_History_Customers_All.CurrentCell = dgv_History_Customers_All[1, 0];
                    }
                }
            }
        }

        public void Get_office_names_to_combo()
        {
            for (int i = 0; i < cbo_Order_Office_Select.Items.Count; i++)
            {
                cbo_Order_Office_Select.Items.RemoveAt(i);
                cbo_Office_Select.Items.RemoveAt(i);
                cbo_History_Office_Select.Items.RemoveAt(i);
                cbo_Common_Settings_Default_Office.Items.RemoveAt(i);
                i--;
            }
            SqlCommand database_query = new SqlCommand("SELECT toimipiste_id, nimi FROM Toimipiste");
            database_query.Connection = db_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            db_connection.Open();
            SqlDataReader myReader = null;
            myReader = database_query.ExecuteReader();
            while (myReader.Read())
            {
                Combo_box_item item = new Combo_box_item();
                item.Text = myReader[1].ToString();
                item.Value = myReader[0].ToString();
                cbo_Order_Office_Select.Items.Add(item);
                cbo_Office_Select.Items.Add(item);
                cbo_History_Office_Select.Items.Add(item);
                cbo_Common_Settings_Default_Office.Items.Add(item);
            }
            db_connection.Close();
            // Tarkistetaan, onko tietokannasta haettu yhtään toimipistettä
            if (cbo_Office_Select.Items.Count == 0)
            {
                // Jos ei, lopetetaan koodin suorittaminen
                return;
            }
            string default_office = Properties.Settings.Default["default_office"].ToString();
            // Jos asiakas poistaa toimipisteen, joka ei ole oletustoimipiste, ei seuraavaa toimipistettä valita ilman seuraavaa riviä.
            cbo_Common_Settings_Default_Office.SelectedIndex = 0;
            // Jos toimipistettä ei ole valittu, valitaan oletustoimipisteeksi ensimmäinen listassa oleva toimipiste.
            if (default_office == "")
            {
                // Tallennetaan valittu arvo asetuksiin.
                Properties.Settings.Default["default_office"] = cbo_Common_Settings_Default_Office.Text.ToString();
                Properties.Settings.Default.Save();
                default_office = Properties.Settings.Default["default_office"].ToString();
            }
            // Asetetaan toimipistevalintakenttien arvot vastaamaan oletustoimipistettä.
            cbo_Order_Office_Select.SelectedIndex = cbo_Order_Office_Select.FindStringExact(default_office);
            cbo_Office_Select.SelectedIndex = cbo_Office_Select.FindStringExact(default_office);
            cbo_History_Office_Select.SelectedIndex = cbo_History_Office_Select.FindStringExact(default_office);
            cbo_Common_Settings_Default_Office.SelectedIndex = cbo_History_Office_Select.FindStringExact(default_office);
        }

        public void Get_service_names_to_grid()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT palvelu_id, toimipiste_id, nimi, max_osallistujat FROM Palvelu", db_connection))
            {
                DataSet data_set = new DataSet();
                database_query.Fill(data_set);
                if (data_set.Tables.Count > 0)
                {
                    dgv_Order_Services_All.DataSource = data_set.Tables[0].DefaultView;
                    dgv_Services_All.DataSource = data_set.Tables[0].DefaultView;
                    // Valitaan rivi, ohjelma kohtaa virheen jos riviä ei ole valittu ja painetaan: "lisää varaukseen" tai "muokkaa".
                    // palvelu_id ja toimipiste_id ovat piilotettuja sarakeita, eli nimi = 2, ensimmäinen rivi listassa = 0.
                    if (dgv_Order_Services_All.Rows.OfType<DataGridViewRow>().Any())
                    {
                        dgv_Order_Services_All.CurrentCell = dgv_Order_Services_All[2, 0];
                        dgv_Services_All.CurrentCell = dgv_Services_All[2, 0];
                    }
                }
            }
        }
        public void Get_cottage_names_to_grid()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT majoitus_id, toimipiste_id, nimi, max_henkilot FROM Majoitus", db_connection))
            {
                DataSet data_set = new DataSet();
                database_query.Fill(data_set);
                if (data_set.Tables.Count > 0)
                {
                    dgv_Order_Cottages_All.DataSource = data_set.Tables[0].DefaultView;
                    dgv_Cottages_All.DataSource = data_set.Tables[0].DefaultView;
                    // Valitaan rivi, ohjelma kohtaa virheen jos riviä ei ole valittu ja painetaan: "lisää varaukseen" tai "muokkaa".
                    // majoitus_id ja toimipiste_id ovat piilotettuja sarakeita, eli nimi = 2, ensimmäinen rivi listassa = 0.
                    if (dgv_Order_Cottages_All.Rows.OfType<DataGridViewRow>().Any())
                    {
                        dgv_Order_Cottages_All.CurrentCell = dgv_Order_Cottages_All[2, 0];
                        dgv_Cottages_All.CurrentCell = dgv_Cottages_All[2, 0];
                    }
                }
            }
        }

        public void Get_order_history_to_grid()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT varaus_id, asiakas_id, toimipiste_id, varattu_pvm FROM Varaus", db_connection))
            {
                DataSet data_set = new DataSet();
                database_query.Fill(data_set);
                if (data_set.Tables.Count > 0)
                {
                    dgv_History_Orders_All.DataSource = data_set.Tables[0].DefaultView;
                    dgv_History_Orders_All.Columns[0].HeaderText = "Varausnumero";
                    dgv_History_Orders_All.Columns[3].HeaderText = "Varauksen luontipäivä";
                    dgv_History_Orders_All.Columns[3].DefaultCellStyle.Format = "dd.MM.yyyy";
                    dgv_History_Orders_All.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv_History_Orders_All.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                    dgv_History_Orders_All.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv_History_Orders_All.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                    dgv_History_Orders_All.Sort(dgv_History_Orders_All.Columns[0], ListSortDirection.Descending);
                }
            }
        }

        public void Get_log_events_to_grid()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT paivittaja, lisatieto FROM Loki", db_connection))
            {
                DataSet data_set = new DataSet();
                database_query.Fill(data_set);
                if (data_set.Tables.Count > 0)
                {
                    dgv_Log.DataSource = data_set.Tables[0].DefaultView;
                    dgv_Log.Columns[0].HeaderText = "Käyttäjä";
                    dgv_Log.Columns[1].HeaderText = "Selite";
                    dgv_Log.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv_Log.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                    dgv_Log.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv_Log.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
                }
            }
        }
        ///
        ///  3. = Create new
        ///


        ///
        ///  4. = Edit
        ///
        public void Edit_customer()
        {
            // Yhdistetään formiin ja asetetaan is_customer_edited arvoksi "tosi".
            frm_Customer_Popup frm = new frm_Customer_Popup(this);
            frm.is_customer_edited = true;
            // Haetaan valitun DataGridView kentän ID.
            foreach (DataGridViewRow row in dgv_Order_Customers_All.SelectedRows)
            {
                frm.Asiakas_id = row.Cells[0].Value.ToString();
            }
            SqlCommand database_query = new SqlCommand("SELECT * FROM Asiakas WHERE asiakas_id = @asiakas_id");
            database_query.Connection = db_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            db_connection.Open();
            database_query.Parameters.AddWithValue("@asiakas_id", frm.Asiakas_id);
            // Suoritetaan kysely
            database_query.ExecuteNonQuery();
            // Alustetaan tietojen lukija
            SqlDataReader myReader = null;
            myReader = database_query.ExecuteReader();
            // Avataan asiakkaan tietojen muokkaus formi
            frm.Show();
            // Asetetaan formiin tiedot tietokannasta.
            while (myReader.Read())
            {
                frm.txt_Customer_First_Name.Text = (myReader["etunimi"].ToString());
                frm.txt_Customer_Surname.Text = (myReader["sukunimi"].ToString());
                frm.txt_Customer_Email.Text = (myReader["email"].ToString());
                frm.txt_Customer_Phone_Number.Text = (myReader["puhelinnro"].ToString());
                frm.txt_Customer_Adress.Text = (myReader["lahiosoite"].ToString());
                frm.txt_Customer_Postal_Code.Text = (myReader["postinro"].ToString());
                frm.txt_Customer_City.Text = (myReader["postitoimipaikka"].ToString());
                frm.txt_Customer_Country.Text = (myReader["asuinmaa"].ToString());
            }
            db_connection.Close();
            // Luodaan yhteys Customer_Popup formiin ja päivitetään asiakaslistat sen sulkemisen yhteydessä.
            frm.FormClosed += new FormClosedEventHandler(Get_customer_names_to_grid_on_close_event);
        }

        public void Edit_office()
        {
            // Tarkistetaan ensin, onko järjestelmässä yhtään toimipistettä.
            if (cbo_Office_Select.Items.Count == 0)
            {
                // Jos ei, tulostetaan virheilmoitus ja perutaan uuden mökin luonti.
                MessageBox.Show("Virhe! Järjestelmässä ei ole yhtään toimipistettä, lisää ensin toimipiste.");
                return;
            }
            // Yhdistetään formiin ja asetetaan is_customer_edited arvoksi "tosi".
            frm_Office_Popup frm = new frm_Office_Popup();
            frm.Is_office_edited = true;
            string nimi = cbo_Office_Select.Text.ToString();
            SqlCommand database_query = new SqlCommand("SELECT * FROM Toimipiste WHERE nimi = @nimi");
            database_query.Connection = db_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            db_connection.Open();
            database_query.Parameters.AddWithValue("@nimi", nimi);
            // Suoritetaan kysely
            database_query.ExecuteNonQuery();
            // Alustetaan tietojen lukija
            SqlDataReader myReader = null;
            myReader = database_query.ExecuteReader();
            frm.Office_id = (cbo_Office_Select.SelectedItem as Combo_box_item).Value.ToString();
            frm.Show();
            // Asetetaan formiin tiedot tietokannasta.
            while (myReader.Read())
            {
                frm.txt_Office_Name.Text = (myReader["nimi"].ToString());
                frm.txt_Office_Adress.Text = (myReader["lahiosoite"].ToString());
                frm.txt_Office_Postal_Code.Text = (myReader["postinro"].ToString());
                frm.txt_Office_City.Text = (myReader["postitoimipaikka"].ToString());
                frm.txt_Office_Email.Text = (myReader["email"].ToString());
                frm.txt_Office_Phone.Text = (myReader["puhelinnro"].ToString());
            }
            db_connection.Close();
            // Luodaan yhteys formin sulkemiseen ja päivitetään toimipistelistat sulkemisen yhteydessä.
            frm.FormClosed += new FormClosedEventHandler(main_window.Get_office_names_to_combo_on_close_event);
        }

        public void Edit_cottage()
        {
            frm_Cottage_Popup frm = new frm_Cottage_Popup();
            frm.Is_Cottage_edited = true;
            // Haetaan valitun DataGridView kentän ID.
            if (dgv_Cottages_All.SelectedRows.Count > 0)
            {
                int selectedrowindex = dgv_Cottages_All.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_Cottages_All.Rows[selectedrowindex];
                frm.Cottage_id = Convert.ToString(selectedRow.Cells["majoitus_id"].Value);
                SqlCommand database_query = new SqlCommand("SELECT * FROM Majoitus WHERE majoitus_id = @majoitus_id");
                database_query.Connection = db_connection;
                // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
                db_connection.Open();
                database_query.Parameters.AddWithValue("@majoitus_id", frm.Cottage_id);
                // Suoritetaan kysely
                database_query.ExecuteNonQuery();
                // Alustetaan tietojen lukija
                SqlDataReader myReader = null;
                myReader = database_query.ExecuteReader();
                // Avataan asiakkaan tietojen muokkaus formi
                frm.Show();
                // Asetetaan formiin tiedot tietokannasta.
                // Huom! Customer_popup formissa textboxit = Public eikä private.
                string toimipiste_id = "";
                while (myReader.Read())
                {
                    toimipiste_id = (myReader["toimipiste_id"].ToString());
                    frm.txt_Cottage_Name.Text = (myReader["nimi"].ToString());
                    frm.txt_Cottage_Description.Text = (myReader["kuvaus"].ToString());
                    frm.txt_Cottage_Price.Text = (myReader["hinta"].ToString());
                    frm.txt_Cottage_Max_Visitors.Text = (myReader["max_henkilot"].ToString());
                    frm.txt_Cottage_Size.Text = (myReader["koko"].ToString());
                    if ((myReader["wlan"].ToString()) == "False")
                    {
                        frm.rbu_Cottage_Wlan_No.Checked = true;
                    }
                }
                db_connection.Close();
                SqlCommand database_query_get_toimipiste_id = new SqlCommand("SELECT * FROM Toimipiste WHERE toimipiste_id = @toimipiste_id");
                database_query_get_toimipiste_id.Connection = db_connection;
                // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
                db_connection.Open();
                database_query_get_toimipiste_id.Parameters.AddWithValue("@toimipiste_id", toimipiste_id);
                // Suoritetaan kysely
                database_query.ExecuteNonQuery();
                // Alustetaan tietojen lukija
                myReader = database_query_get_toimipiste_id.ExecuteReader();
                while (myReader.Read())
                {
                    frm.cbo_Cottage_Office_Select.Text = (myReader["nimi"].ToString());
                }
                db_connection.Close();
                frm.FormClosed += new FormClosedEventHandler(Get_cottage_names_to_grid_on_close_event);
            }
        }

        public void Edit_service()
        {
            frm_Services_Popup frm = new frm_Services_Popup();
            frm.Is_service_edited = true;
            int selectedrowindex = dgv_Services_All.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_Services_All.Rows[selectedrowindex];
            frm.Service_id = Convert.ToString(selectedRow.Cells["palvelu_id"].Value);
            SqlCommand database_query = new SqlCommand("SELECT * FROM Palvelu WHERE palvelu_id = @palvelu_id");
            database_query.Connection = db_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            db_connection.Open();
            database_query.Parameters.AddWithValue("@palvelu_id", frm.Service_id);
            // Suoritetaan kysely
            database_query.ExecuteNonQuery();
            myReader = database_query.ExecuteReader();
            // Asetetaan formiin tiedot tietokannasta.
            // Huom! Customer_popup formissa textboxit = Public eikä private.
            string toimipiste_id = "";
            while (myReader.Read())
            {
                toimipiste_id = (myReader["toimipiste_id"].ToString());
                frm.txt_Service_Name.Text = (myReader["nimi"].ToString());
                frm.txt_Service_Description.Text = (myReader["kuvaus"].ToString());
                frm.txt_Service_Price.Text = (myReader["hinta"].ToString());
                frm.txt_Service_Max_Visitors.Text = (myReader["max_osallistujat"].ToString());
                frm.txt_Service_alv.Text = (myReader["alv"].ToString());
            }
            db_connection.Close();
            SqlCommand database_query_get_toimipiste_id = new SqlCommand("SELECT * FROM Toimipiste WHERE toimipiste_id = @toimipiste_id");
            database_query_get_toimipiste_id.Connection = db_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            db_connection.Open();
            database_query_get_toimipiste_id.Parameters.AddWithValue("@toimipiste_id", toimipiste_id);
            // Suoritetaan kysely
            database_query.ExecuteNonQuery();
            // Alustetaan tietojen lukija
            myReader = database_query_get_toimipiste_id.ExecuteReader();
            while (myReader.Read())
            {
                frm.cbo_Service_Office_Select.Text = (myReader["nimi"].ToString());
            }
            db_connection.Close();
        }

        ///
        ///  5. = Delete
        ///

        public void Delete_customer()
        {

            string asiakas_id = "";
            // Haetaan valitun asiakkaan ID datagridviewistä.
            foreach (DataGridViewRow row in dgv_Order_Customers_All.SelectedRows)
            {
                asiakas_id = row.Cells[0].Value.ToString();
            }
            // Tarkistetaan, onko asiakas yhdistetty uuteen varaukseen.
            if (asiakas_id == main_window.Reservation_asiakas_id)
            {
                MessageBox.Show("Virhe! Olet luomassa asiakkaalle uutta varausta.\nJos haluat poista asiakkaan, muuta ensin varauksen asiakasta.");
                return;
            }
            // Yritetään poistaa asiakasta tietokannasta
            try
            {
                SqlCommand database_query = new SqlCommand("DELETE FROM Asiakas WHERE asiakas_id = @asiakas_id");
                database_query.Connection = db_connection;
                // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
                db_connection.Open();
                database_query.Parameters.AddWithValue("@asiakas_id", asiakas_id);
                // Suoritetaan kysely, suljetaan tietokantayhteys ja päivitetään kentät.
                database_query.ExecuteNonQuery();
                db_connection.Close();
                Get_customer_names_to_grid();
                // Loki taulun päivitys
                string lisatieto_loki = "Poistettiin asiakas nro: " + asiakas_id;
                database.Update_log(lisatieto_loki);
            }
            // Yritys epäonnistuu tietokannan viite-eheyden rikkoutumiseen.
            catch (SqlException)
            {
                // Suljetaan "try" lohkossa avattu tietokantayhteys ja alustetaan tietojen lukija.
                db_connection.Close();
                SqlDataReader myReader = null;
                // Luodaan lista asiakkaan varausnumeroita varten.
                List<int> customer_orders = new List<int>();
                SqlCommand database_query_get_customer_reservations = new SqlCommand("SELECT varaus_id FROM Varaus WHERE asiakas_id = @asiakas_id");
                database_query_get_customer_reservations.Connection = db_connection;
                db_connection.Open();
                // Haetaan asiakas_id:n perusteella tietokannasta varaukset ja lisätään ne listaan.
                database_query_get_customer_reservations.Parameters.AddWithValue("@asiakas_id", asiakas_id);
                database_query_get_customer_reservations.ExecuteNonQuery();
                myReader = database_query_get_customer_reservations.ExecuteReader();
                while (myReader.Read())
                {
                    customer_orders.Add(Convert.ToInt32((myReader["varaus_id"])));
                }
                // Suljetaan yhteys ja tulostetaan virheilmoitus.
                db_connection.Close();
                var all_customer_orders = string.Join(",  ", customer_orders);
                MessageBox.Show("Virhe! Asiakas on yhdistetty seuraaviin varausnumeroihin:\n\n" +
                    all_customer_orders + "\n\nJos haluat poistaa tämän asiakkaan, on sinun ensin " +
                    "poistettava\nkaikki tämän asiakkaan tekemät varaukset varaushistoriasta.");
            }
        }

        public void Delete_office()
        {
            // Tarkistetaan ensin, onko järjestelmässä yhtään toimipistettä.
            if (cbo_Office_Select.Items.Count == 0)
            {
                // Jos ei, tulostetaan virheilmoitus ja perutaan uuden mökin luonti.
                MessageBox.Show("Virhe! Järjestelmässä ei ole yhtään toimipistettä, lisää ensin toimipiste.");
                return;
            }
            string office_name = cbo_Office_Select.Text.ToString();
            DialogResult Confirm_delete = MessageBox.Show("Haluatko varmasti poistaa toimipisteen: \"" + office_name +
                "\"?", "Toimipisteen poistaminen", MessageBoxButtons.YesNo);
            if (Confirm_delete == DialogResult.No)
            {
                return;
            }
            string toimipiste_id = (cbo_Office_Select.SelectedItem as Combo_box_item).Value.ToString();
            // Tarkistetaan onko toimipisteeseen liitetty mökkejä tai palveluita
            if (dgv_Cottages_All.Rows.OfType<DataGridViewRow>().Any() || dgv_Services_All.Rows.OfType<DataGridViewRow>().Any())
            {
                MessageBox.Show("Virhe! Toimipisteeseen on liitetty mökkejä tai palveluita.\n\n" +
                    "Jos haluat poistaa toimipisteen, on sinun ensin poistettava sen mökit ja palvelut.");
                return;
            }
            // Yritetään poistaa toimipistettä tietokannasta
            try
            {
                SqlCommand database_query = new SqlCommand("DELETE FROM Toimipiste WHERE toimipiste_id = @toimipiste_id");
                database_query.Connection = db_connection;
                db_connection.Open();
                database_query.Parameters.AddWithValue("@toimipiste_id", toimipiste_id);
                database_query.ExecuteNonQuery();
                db_connection.Close();
                // Tarkistetaan, oliko toimipiste oletustoimipiste ja muutetaan asetus jos oli.
                string default_office = Properties.Settings.Default["default_office"].ToString();
                MessageBox.Show(default_office + "\n office:name: " + office_name);
                if (default_office == office_name)
                {
                    // Tallennetaan tyhjä arvo asetuksiin, toimipisteiden haku alustaa jonkin arvon mikäli järjestelmässä on toimipisteitä.
                    Properties.Settings.Default["default_office"] = "";
                    Properties.Settings.Default.Save();
                }
                // Tarkistetaan, oliko toimipiste liitetty uuteen varaukseen.
                if (lbl_Order_Summary_Office.Text.Contains(office_name))
                {
                    lbl_Order_Summary_Office.Text = "Toimipiste:";
                }
                database.Get_office_names_to_combo();
                // Loki taulun päivitys
                string lisatieto_loki = "Poistettiin toimipiste nro: " + toimipiste_id;
                database.Update_log(lisatieto_loki);
            }
            // Yritys epäonnistuu tietokannan viite-eheyden rikkoutumiseen.
            catch (SqlException)
            {
                // Suljetaan "try" lohkossa avattu tietokantayhteys ja alustetaan tietojen lukija.
                db_connection.Close();
                SqlDataReader myReader = null;
                // Luodaan lista asiakkaan varausnumeroita varten.
                List<int> office_orders = new List<int>();
                SqlCommand database_query_get_office_orders = new SqlCommand("SELECT varaus_id FROM Varaus WHERE toimipiste_id = @toimipiste_id");
                database_query_get_office_orders.Connection = db_connection;
                db_connection.Open();
                // Haetaan asiakas_id:n perusteella tietokannasta varaukset ja lisätään ne listaan.
                database_query_get_office_orders.Parameters.AddWithValue("@toimipiste_id", toimipiste_id);
                database_query_get_office_orders.ExecuteNonQuery();
                myReader = database_query_get_office_orders.ExecuteReader();
                while (myReader.Read())
                {
                    office_orders.Add(Convert.ToInt32((myReader["varaus_id"])));
                }
                // Suljetaan yhteys ja tulostetaan virheilmoitus.
                db_connection.Close();
                var all_office_orders = string.Join(",  ", office_orders);
                MessageBox.Show("Virhe! Toimipiste on yhdistetty seuraaviin varausnumeroihin:\n\n" +
                    all_office_orders + "\n\nJos haluat poistaa tämän toimipisteen, on sinun ensin " +
                    "poistettava\nkaikki tähän toimipisteeseen liitetyt varaukset varaushistoriasta.");
            }
        }

        public void Delete_order()
        {
            // Hakee varausnumeron "Varausnumero: x" labelista.
            var find_reservation_number = new Regex("\\d");
            Match match = find_reservation_number.Match(lbl_History_Order_varaus_id.Text);
            string varaus_id_to_delete = match.ToString();
            // Jos jokin varaus on valittuna:
            if (varaus_id_to_delete != "")
            {
                // Varauksen_majoitus poisto
                SqlCommand database_query_order_cottage_details = new SqlCommand("DELETE FROM Varauksen_majoitus WHERE varaus_id = @varaus_id");
                database_query_order_cottage_details.Connection = db_connection;
                db_connection.Open();
                database_query_order_cottage_details.Parameters.AddWithValue("@varaus_id", varaus_id_to_delete);
                database_query_order_cottage_details.ExecuteNonQuery();
                db_connection.Close();
                // Varauksen_palvelut poisto
                SqlCommand database_query_order_service_details = new SqlCommand("DELETE FROM Varauksen_palvelut WHERE varaus_id = @varaus_id");
                database_query_order_service_details.Connection = db_connection;
                db_connection.Open();
                database_query_order_service_details.Parameters.AddWithValue("@varaus_id", varaus_id_to_delete);
                database_query_order_service_details.ExecuteNonQuery();
                db_connection.Close();
                // Varaus poisto
                SqlCommand database_query_order_basic_details = new SqlCommand("DELETE FROM Varaus WHERE varaus_id = @varaus_id ");
                database_query_order_basic_details.Connection = db_connection;
                db_connection.Open();
                database_query_order_basic_details.Parameters.AddWithValue("@varaus_id", varaus_id_to_delete);
                database_query_order_basic_details.ExecuteNonQuery();
                db_connection.Close();
            }
            // Päivitetään historia ja resetoidaan kentät.
            lbl_History_Order_Start.Text = "Alkamispäivä";
            lbl_History_Order_End.Text = "Päättymispäivä:";
            lbl_History_Selected_Order_Office.Text = "Toimipiste:";
            lbl_History_Selected_Order_Customer.Text = "Asiakas:";
            txt_History_Order_Additional_Details.Clear();
            Get_order_history_to_grid();
            // Lokin päivitys
            string lisatieto_loki = "Poistettiin varaus nro.: " + varaus_id_to_delete;
            Update_log(lisatieto_loki);
        }

        public void Delete_cottage()
        {
            if (dgv_Cottages_All.SelectedRows.Count > 0)
            {
                // Haetaan valitun DataGridView kentän ID.
                int selectedrowindex = dgv_Cottages_All.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_Cottages_All.Rows[selectedrowindex];
                string majoitus_id = Convert.ToString(selectedRow.Cells["majoitus_id"].Value);
                // Tarkistetaan, onko mökki yhdistetty uuteen varaukseen.
                List<int> cottages_in_new_order = new List<int>();
                foreach (ListViewItem cottage_rows in lsv_Order_Summary_Cottages.Items)
                {
                    // Haetaan palvelun_id listan riviin liitetystä "Tag" arvosta.
                    cottages_in_new_order.Add(int.Parse(cottage_rows.Tag.ToString()));
                }
                if (cottages_in_new_order.Contains(int.Parse(majoitus_id)))
                {
                    MessageBox.Show("Virhe! Tämä mökki on lisätty uuteen varaukseen.\nJos haluat poistaa sen, poista se ensin varauksesta.");
                    return;
                }
                // Tarkistetaan, onko valittu mökki liitetty mihinkään varaukseen
                SqlDataReader myReader = null;
                List<int> orders_cottages = new List<int>();
                SqlCommand database_query_get_cottage_reservations = new SqlCommand("SELECT varaus_id FROM Varauksen_majoitus WHERE majoitus_id = @majoitus_id");
                database_query_get_cottage_reservations.Connection = db_connection;
                db_connection.Open();
                // Haetaan id:n perusteella tietokannasta varaukset ja lisätään ne listaan.
                database_query_get_cottage_reservations.Parameters.AddWithValue("@majoitus_id", majoitus_id);
                database_query_get_cottage_reservations.ExecuteNonQuery();
                myReader = database_query_get_cottage_reservations.ExecuteReader();
                while (myReader.Read())
                {
                    orders_cottages.Add(Convert.ToInt32((myReader["varaus_id"])));
                }
                // Suljetaan yhteys ja tulostetaan virheilmoitus.
                db_connection.Close();
                // Jos  palvelu löytyy jostakin varauksesta, tulostetaan palveluun yhdistetyt varaukset virheilmoituksessa.
                if (orders_cottages.Count > 0)
                {
                    var all_service_cottages = string.Join(",  ", orders_cottages);
                    MessageBox.Show("Virhe! Mökki on yhdistetty seuraaviin varausnumeroihin:\n\n" +
                        all_service_cottages + "\n\nJos haluat poistaa tämän mökin, on sinun ensin " +
                        "poistettava\nkaikki tämän mökin sisältävät varaukset varaushistoriasta.");
                }
                else
                {
                    // Tietokantakysely
                    SqlCommand database_query = new SqlCommand("DELETE FROM Majoitus WHERE majoitus_id = @majoitus_id");
                    database_query.Connection = db_connection;
                    // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
                    db_connection.Open();
                    database_query.Parameters.AddWithValue("@majoitus_id", majoitus_id);
                    // Suoritetaan kysely, suljetaan tietokantayhteys ja päivitetään kentät.
                    database_query.ExecuteNonQuery();
                    db_connection.Close();
                    Get_cottage_names_to_grid();
                    // Loki taulun päivitys
                    string lisatieto_loki = "Poistettiin mökki nro: " + majoitus_id;
                    database.Update_log(lisatieto_loki);
                }
                main_window.Filter_management_cottages_by_office_and_text();
            }
        }
        public void Delete_service()
        {
            if (dgv_Services_All.SelectedRows.Count > 0)
            {
                // Haetaan valitun DataGridView kentän ID.
                int selectedrowindex = dgv_Services_All.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_Services_All.Rows[selectedrowindex];
                string palvelu_id = Convert.ToString(selectedRow.Cells["palvelu_id"].Value);

                // Tarkistetaan, onko palvelu yhdistetty uuteen varaukseen.
                List<int> services_in_new_order = new List<int>();
                foreach (ListViewItem service_rows in lsv_Order_Summary_Services.Items)
                {
                    // Haetaan palvelun_id listan riviin liitetystä "Tag" arvosta.
                    services_in_new_order.Add(int.Parse(service_rows.Tag.ToString()));
                }
                if (services_in_new_order.Contains(int.Parse(palvelu_id)))
                {
                    MessageBox.Show("Virhe! Tämä palvelu on lisätty uuteen varaukseen.\nJos haluat poistaa sen, poista se ensin varauksesta.");
                    return;
                }
                // Tarkistetaan, onko valittu palvelu liitetty mihinkään varaukseen
                SqlDataReader myReader = null;
                List<int> service_orders = new List<int>();
                SqlCommand database_query_get_service_reservations = new SqlCommand("SELECT varaus_id FROM Varauksen_palvelut WHERE palvelu_id = @palvelu_id");
                database_query_get_service_reservations.Connection = db_connection;
                db_connection.Open();
                // Haetaan id:n perusteella tietokannasta varaukset ja lisätään ne listaan.
                database_query_get_service_reservations.Parameters.AddWithValue("@palvelu_id", palvelu_id);
                database_query_get_service_reservations.ExecuteNonQuery();
                myReader = database_query_get_service_reservations.ExecuteReader();
                while (myReader.Read())
                {
                    service_orders.Add(Convert.ToInt32((myReader["varaus_id"])));
                }
                // Suljetaan yhteys ja tulostetaan virheilmoitus.
                db_connection.Close();
                // Jos  palvelu löytyy jostakin varauksesta, tulostetaan palveluun yhdistetyt varaukset virheilmoituksessa.
                if (service_orders.Count > 0)
                {
                    var all_service_orders = string.Join(",  ", service_orders);
                    MessageBox.Show("Virhe! Palvelu on yhdistetty seuraaviin varausnumeroihin:\n\n" +
                        all_service_orders + "\n\nJos haluat poistaa tämän palvelun, on sinun ensin " +
                        "poistettava\nkaikki tätä palvelua sisältävät varaukset varaushistoriasta.");
                }
                else
                {
                    SqlCommand database_query = new SqlCommand("DELETE FROM Palvelu WHERE palvelu_id = @palvelu_id");
                    database_query.Connection = db_connection;
                    // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
                    db_connection.Open();
                    database_query.Parameters.AddWithValue("@palvelu_id", palvelu_id);
                    // Suoritetaan kysely, suljetaan tietokantayhteys ja päivitetään kentät.
                    database_query.ExecuteNonQuery();
                    db_connection.Close();
                    Get_service_names_to_grid();
                    // Filtteröidän myös varaus välilehden lista
                    main_window.Filter_management_services_by_office_and_text();
                    // Loki taulun päivitys
                    string lisatieto_loki = "Poistettiin palvelu nro: " + palvelu_id;
                    database.Update_log(lisatieto_loki);
                }
            }
        }
    }
}