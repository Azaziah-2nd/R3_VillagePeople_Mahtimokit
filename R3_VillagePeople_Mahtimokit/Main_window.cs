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


namespace R3_VillagePeople_Mahtimokit
{



    public partial class frm_Main_Window : Form
    {
        public frm_Main_Window()
        {
            InitializeComponent();
        }

        // Määritellään tietokantayhteyden muodostin.
        public SqlConnection database_connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                          AttachDbFilename=|DataDirectory|\VP_Database.mdf;
                          Integrated Security=True;
                          Connect Timeout=10;
                          User Instance=False");



        // DataGriedView elementtien tietojen päivitys.
        private void Get_customer_names_to_grid()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT asiakas_id, kokonimi FROM Asiakas", database_connection))
            {
                DataSet data_set = new DataSet();
                database_query.Fill(data_set);
                if (data_set.Tables.Count > 0)
                {
                    dgv_Customers_All.DataSource = data_set.Tables[0].DefaultView;
                    dgv_Order_Customers_All.DataSource = data_set.Tables[0].DefaultView;
                    dgv_History_Customers_All.DataSource = data_set.Tables[0].DefaultView;
                    dgv_Customers_All.Columns[0].Visible = false;
                    dgv_Order_Customers_All.Columns[0].Visible = false;
                    dgv_History_Customers_All.Columns[0].Visible = false;
                }
            }
        }
 
        private void Get_office_names_to_combo()
        {
            SqlCommand database_query = new SqlCommand("SELECT toimipiste_id, nimi FROM Toimipiste");
            database_query.Connection = database_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            database_connection.Open();
            SqlDataReader myReader = null;
            myReader = database_query.ExecuteReader();
            while (myReader.Read())
            {
                Combo_box_item item = new Combo_box_item();
                item.Text = myReader[1].ToString();
                item.Value = myReader[0].ToString();
                cbo_Order_Office_Select.Items.Add(item);
                // cbo_Order_Office_Select.SelectedIndex = 0;
                cbo_Office_Select.Items.Add(item);
                // cbo_Office_Select.SelectedIndex = 0;
                cbo_History_Office_Select.Items.Add(item);
                // cbo_History_Office_Select.SelectedIndex = 0;
                cbo_Common_Settings_Default_Office.Items.Add(item);
                // cbo_Common_Settings_Default_Office.SelectedIndex = 0;
            }
            database_connection.Close();

        }

        private void Get_service_names_to_grid()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT palvelu_id, nimi FROM Palvelu", database_connection))
            {
                DataSet data_set = new DataSet();
                database_query.Fill(data_set);
                if (data_set.Tables.Count > 0)
                {
                    dgv_Order_Services_All.DataSource = data_set.Tables[0].DefaultView;
                    dgv_Services_All.DataSource = data_set.Tables[0].DefaultView;
                    dgv_Order_Services_All.Columns[0].Visible = false;
                    dgv_Services_All.Columns[0].Visible = false;
                }
            }
        }
        private void Get_cottage_names_to_grid()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT majoitus_id, nimi FROM Majoitus", database_connection))
            {
                DataSet data_set = new DataSet();
                database_query.Fill(data_set);
                if (data_set.Tables.Count > 0)
                {
                    dgv_Order_Cottages_All.DataSource = data_set.Tables[0].DefaultView;
                    dgv_Cottages_all.DataSource = data_set.Tables[0].DefaultView;
                    dgv_Order_Cottages_All.Columns[0].Visible = false;
                    dgv_Cottages_all.Columns[0].Visible = false;
                }
            }
        }
        // Tietojen päivitys formien sulkemisen yhteydessä.
        private void Get_customer_names_to_grid_on_close_event(object sender, FormClosedEventArgs e)
        {
            Get_customer_names_to_grid();
        }

        private void Get_office_names_to_combo_on_close_event(object sender, FormClosedEventArgs e)
        {
            Get_office_names_to_combo();
        }
        private void Get_service_names_to_grid_on_close_event(object sender, FormClosedEventArgs e)
        {
            Get_service_names_to_grid();
        }
        private void Get_cottage_names_to_grid_on_close_event(object sender, FormClosedEventArgs e)
        {
            Get_cottage_names_to_grid();
        }

        private void Main_window_Load(object sender, EventArgs e)
        {
            // Haetaan päivämäärät varauksen yhteenvetoon.
            Get_start_date_to_order_summary();
            Get_end_date_to_order_summary();
            // Ladataan käyttäjän asetukset ja muutetaan kentät vastaamaan niitä.
            txt_Settings_User_Name.Text = Properties.Settings.Default["user_name"].ToString();
            // Oletustoimipiste
            string default_office = Properties.Settings.Default["default_office"].ToString();
            cbo_Common_Settings_Default_Office.SelectedIndex = cbo_Common_Settings_Default_Office.FindStringExact(default_office);
            cbo_Order_Office_Select.SelectedIndex = cbo_Order_Office_Select.FindStringExact(default_office);
            cbo_Office_Select.SelectedIndex = cbo_Office_Select.FindStringExact(default_office);
            cbo_History_Office_Select.SelectedIndex = cbo_History_Office_Select.FindStringExact(default_office);
            // Oletushistorian aikaväli
            dtp_History_Orders_Filter_Date_Start.Value = DateTime.Parse(Properties.Settings.Default["default_history_start_date"].ToString());
            dtp_Common_Settings_History_Start_Date.Value = DateTime.Parse(Properties.Settings.Default["default_history_start_date"].ToString());
            dtp_Common_Settings_History_End_Date_Custom.Value = DateTime.Parse(Properties.Settings.Default["default_history_end_date"].ToString());
            // Tarkistetaan käytetäänkö nykyistä päivää vai määriteltyä päivää.
            if (Convert.ToBoolean(Properties.Settings.Default["default_is_history_end_date_today"]) == false)
            {
                chk_Common_Settings_History_End_Date_Today.Checked = false;
                dtp_History_Orders_Filter_Date_End.Value = DateTime.Parse(Properties.Settings.Default["default_history_end_date"].ToString());
            }
            else
            {
                chk_Common_Settings_History_End_Date_Today.Checked = true;
            }
            // Haetaan tiedot tietokannasta eri kenttiin.
            this.Get_customer_names_to_grid();
            this.Get_office_names_to_combo();
            this.Get_service_names_to_grid();
            this.Get_cottage_names_to_grid();
        }

        // Asiakkaan lisäys
        private void btn_Customer_add_Click(object sender, EventArgs e)
        {
            frm_Customer_Popup frm = new frm_Customer_Popup(this);
            frm.Show();
            // Luodaan yhteys formin sulkemiseen ja päivitetään asiakaslistat sulkemisen yhteydessä.
            frm.FormClosed += new FormClosedEventHandler(Get_customer_names_to_grid_on_close_event);
        }

        // Asiakkaan muokkaus
        private void btn_Customer_edit_Click(object sender, EventArgs e)
        {
            frm_Customer_Popup frm = new frm_Customer_Popup(this);
            frm.Show();
            // Luodaan yhteys formin sulkemiseen ja päivitetään asiakaslistat sulkemisen yhteydessä.
            frm.FormClosed += new FormClosedEventHandler(Get_customer_names_to_grid_on_close_event);
        }

        // Toimipisteen lisäys
        private void btn_Office_add_Click(object sender, EventArgs e)
        {
            var form = new frm_Office_Popup();
            form.Show(this);
        }

        // Toimipisteen muokkaus
        private void btn_Office_edit_Click(object sender, EventArgs e)
        {
            var form = new frm_Office_Popup();
            form.Show(this);
        }

        // Toimipisteen poisto
        private void btn_Office_delete_Click(object sender, EventArgs e)
        {

        }

        // Palvelun lisäys
        private void btn_Services_add_Click(object sender, EventArgs e)
        {
            var form = new frm_Services_Popup();
            form.Show(this);
        }

        // Palvelun muokkaus
        private void btn_Services_edit_Click(object sender, EventArgs e)
        {
            var form = new frm_Services_Popup();
            form.Show(this);
        }

        // Palvelun poisto
        private void btn_Services_delete_Click(object sender, EventArgs e)
        {

        }

        // Mökin lisäys
        private void btn_Cottages_add_Click(object sender, EventArgs e)
        {
            var form = new frm_Cottage_Popup();
            form.Show(this);
        }
        
        // Mökin muokkaus
        private void btn_Cottages_edit_Click(object sender, EventArgs e)
        {
            var form = new frm_Cottage_Popup();
            form.Show(this);
        }

        // Mökin poisto
        private void btn_Cottages_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Customer_Add_Click_1(object sender, EventArgs e)
        {
            // Yhdistetään formiin ja asetetaan is_customer_edited arvoksi "epätosi".
            frm_Customer_Popup frm = new frm_Customer_Popup(this);
            frm.is_customer_edited = false;
            frm.Show();
            // Luodaan yhteys Customer_Popup formiin ja päivitetään asiakaslistat sen sulkemisen yhteydessä.
            frm.FormClosed += new FormClosedEventHandler(Get_customer_names_to_grid_on_close_event);
        }

        private void btn_Services_Add_Click_1(object sender, EventArgs e)
        {
            frm_Services_Popup frm = new frm_Services_Popup();
            frm.Is_service_edited = false;
            frm.Show();
            frm.FormClosed += new FormClosedEventHandler(Get_service_names_to_grid_on_close_event);
        }

        private void btn_Cottages_Add_Click_1(object sender, EventArgs e)
        {
            frm_Cottage_Popup frm = new frm_Cottage_Popup();
            frm.Is_Cottage_edited = false;
            frm.Show();
            frm.FormClosed += new FormClosedEventHandler(Get_cottage_names_to_grid_on_close_event);
        }

        private void btn_Office_Add_Click_1(object sender, EventArgs e)
        {
            frm_Office_Popup frm = new frm_Office_Popup();
            frm.Is_office_edited = false;
            frm.Show();
            // Luodaan yhteys formin sulkemiseen ja päivitetään toimipistelistat sulkemisen yhteydessä.
            frm.FormClosed += new FormClosedEventHandler(Get_office_names_to_combo_on_close_event);
        }


        private void cbo_Common_Settings_Default_Office_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tallennetaan valittu arvo asetuksiin.

            // HUOM! Tämä toiminnallisuus on toistaiseksi rikki.

            // Vanha toimiva koodi: 
            // Properties.Settings.Default["default_office"] = cbo_Common_Settings_Default_Office.SelectedItem.ToString();

            // Uuusi koodi joka ei toimi
            Properties.Settings.Default["default_office"] = cbo_Common_Settings_Default_Office.Text.ToString();
            // !!!
            Properties.Settings.Default.Save();
            // Asetetaan toimipistevalintakenttien arvot vastaamaan oletustoimipistettä.
            string default_office = Properties.Settings.Default["default_office"].ToString();
            cbo_Order_Office_Select.SelectedIndex = cbo_Order_Office_Select.FindStringExact(default_office);
            cbo_Office_Select.SelectedIndex = cbo_Office_Select.FindStringExact(default_office);
            cbo_History_Office_Select.SelectedIndex = cbo_History_Office_Select.FindStringExact(default_office);
        }

        private void dtp_Common_Settings_History_Start_Date_ValueChanged(object sender, EventArgs e)
        {
            // Poistetaan valitusta ajasta tarkka kellonaika ja tallennetaan arvo asetuksiin.
            Properties.Settings.Default["default_history_start_date"] = DateTime.Parse(dtp_Common_Settings_History_Start_Date.Value.ToShortDateString());
            Properties.Settings.Default.Save();
            // Muutetaan varaushistorian filtteröinnin aloituspäivämäärä vastaamaan uutta asetusta.
            dtp_History_Orders_Filter_Date_Start.Value = DateTime.Parse(Properties.Settings.Default["default_history_start_date"].ToString());
        }

        private void dtp_Common_Settings_History_End_Date_Custom_ValueChanged(object sender, EventArgs e)
        {
            // Poistetaan valitusta ajasta tarkka kellonaika ja tallennetaan muutokset asetuksiin.
            Properties.Settings.Default["default_history_end_date"] = DateTime.Parse(dtp_Common_Settings_History_End_Date_Custom.Value.ToShortDateString());
            Properties.Settings.Default.Save();
            // Muutetaan varaushistorian filtteröinnin aloituspäivämäärä vastaamaan uutta asetusta, jos nykyisen päivän asetus ei ole käytössä.
            if (Convert.ToBoolean(Properties.Settings.Default["default_is_history_end_date_today"]) == false)
            {
                dtp_History_Orders_Filter_Date_End.Value = DateTime.Parse(Properties.Settings.Default["default_history_end_date"].ToString());
            }
        }

        private void chk_Common_Settings_History_End_Date_Today_CheckedChanged(object sender, EventArgs e)
        {
            // Jos checkboxin tila vaihtuu tikkaamattomaksi.
            if (chk_Common_Settings_History_End_Date_Today.Checked == false)
            {
                Properties.Settings.Default["default_is_history_end_date_today"] = false;
                Properties.Settings.Default.Save();
                dtp_History_Orders_Filter_Date_End.Value = DateTime.Parse(Properties.Settings.Default["default_history_end_date"].ToString());
            }
            else
            {
                // Tallennetaan asetuksiin nykyisen päivän käyttö ja muutetaan se varaushistoriaan.
                Properties.Settings.Default["default_is_history_end_date_today"] = true;
                Properties.Settings.Default.Save();
                dtp_History_Orders_Filter_Date_End.Value = DateTime.Today;
            }
        }

        private void txt_Order_Customers_Search_TextChanged(object sender, EventArgs e)
        {
            // Asiakkaiden rajaus kokonimen perusteella.
            // Aloitetaan päivittämällä asiakkaiden hallinnan ja varaushistorian tekstikentät vastaamaan hakua.
            txt_Customer_Search.Text = txt_Order_Customers_Search.Text;
            txt_History_Customer_Search.Text = txt_Order_Customers_Search.Text;
            // Yhdistetään tietojen lähteeseen ja rajataan hakutuloksia hakutekstin perusteella.
            BindingSource binding_source = new BindingSource();
            binding_source.DataSource = dgv_Order_Customers_All.DataSource;
            binding_source.Filter = "[kokonimi] Like '%" + txt_Customer_Search.Text + "%'";
        }

        private void txt_Customer_Search_TextChanged(object sender, EventArgs e)
        {
            // Asiakkaiden rajaus kokonimen perusteella.
            // Aloitetaan päivittämällä asiakkaiden hallinnan ja varaushistorian tekstikentät vastaamaan hakua.
            txt_Order_Customers_Search.Text = txt_Customer_Search.Text;
            txt_History_Customer_Search.Text = txt_Customer_Search.Text;
            // Yhdistetään tietojen lähteeseen ja rajataan hakutuloksia hakutekstin perusteella.
            BindingSource binding_source = new BindingSource();
            binding_source.DataSource = dgv_Order_Customers_All.DataSource;
            binding_source.Filter = "[kokonimi] Like '%" + txt_Customer_Search.Text + "%'";
        }


        private void btn_Customer_Delete_Click_1(object sender, EventArgs e)
        {
            // Hakee nykyisen nimen ja poistaa tiedon tietokannasta sekä päivittää asiakaslistat.
            if (dgv_Customers_All.CurrentCell.Value.ToString() != "")
            {
                string asiakas_id = "";
                // Haetaan valitun DataGridView kentän ID.
                foreach (DataGridViewRow row in dgv_Order_Customers_All.SelectedRows)
                {
                    asiakas_id = row.Cells[0].Value.ToString();
                }
                SqlCommand database_query = new SqlCommand("DELETE FROM Asiakas WHERE asiakas_id = @asiakas_id");
                database_query.Connection = database_connection;
                // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
                database_connection.Open();
                database_query.Parameters.AddWithValue("@asiakas_id", asiakas_id);
                // Suoritetaan kysely, suljetaan tietokantayhteys ja päivitetään kentät.
                database_query.ExecuteNonQuery();
                database_connection.Close();
                this.Get_customer_names_to_grid();
            }
          
        }

        private void txt_Services_Search_TextChanged(object sender, EventArgs e)
        {
            // Palveluiden rajaus nimen perusteella.
            txt_Order_Services_Search.Text = txt_Services_Search.Text;
            // Yhdistetään tietojen lähteeseen ja rajataan hakutuloksia hakutekstin perusteella.
            BindingSource binding_source = new BindingSource();
            binding_source.DataSource = dgv_Order_Services_All.DataSource;
            binding_source.Filter = "[nimi] Like '%" + txt_Order_Services_Search.Text + "%'";
        }

        private void btn_Office_Edit_Click_1(object sender, EventArgs e)
        {
            // Yhdistetään formiin ja asetetaan is_customer_edited arvoksi "tosi".
            frm_Office_Popup frm = new frm_Office_Popup();
            frm.Is_office_edited = true;

            string nimi = cbo_Office_Select.Text.ToString();

            SqlCommand database_query = new SqlCommand("SELECT * FROM Toimipiste WHERE nimi = @nimi");
            database_query.Connection = database_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            database_connection.Open();
            database_query.Parameters.AddWithValue("@nimi", nimi);
            // Suoritetaan kysely
            database_query.ExecuteNonQuery();

            // Alustetaan tietojen lukija
            SqlDataReader myReader = null;
            myReader = database_query.ExecuteReader();


            frm.Office_id = (cbo_Office_Select.SelectedItem as Combo_box_item).Value.ToString();

            MessageBox.Show((cbo_Office_Select.SelectedItem as Combo_box_item).Value.ToString());

            // Avataan asiakkaan tietojen muokkaus formi
            frm.Show();
            // Asetetaan formiin tiedot tietokannasta.
            // Huom! Customer_popup formissa textboxit = Public eikä private.
            while (myReader.Read())
            {
                frm.txt_Office_Name.Text = (myReader["nimi"].ToString());
                frm.txt_Office_Adress.Text = (myReader["lahiosoite"].ToString());
                frm.txt_Office_Postal_Code.Text = (myReader["postinro"].ToString());
                frm.txt_Office_City.Text = (myReader["postitoimipaikka"].ToString());
                frm.txt_Office_Email.Text = (myReader["email"].ToString());
                frm.txt_Office_Phone.Text = (myReader["puhelinnro"].ToString());
            }
            database_connection.Close();
            // Luodaan yhteys formin sulkemiseen ja päivitetään toimipistelistat sulkemisen yhteydessä.
            frm.FormClosed += new FormClosedEventHandler(Get_office_names_to_combo_on_close_event);
        }

        private void btn_Customer_Edit_Click_1(object sender, EventArgs e)
        {
            // Yhdistetään formiin ja asetetaan is_customer_edited arvoksi "tosi".
            frm_Customer_Popup frm = new frm_Customer_Popup(this);
            frm.is_customer_edited = true;
            // Haetaan valitun DataGridView kentän ID.
            foreach (DataGridViewRow row in dgv_Order_Customers_All.SelectedRows)
            {
                frm.Asiakas_id = row.Cells[0].Value.ToString();
            }
            string kokonimi = dgv_Customers_All.CurrentCell.Value.ToString();
            SqlCommand database_query = new SqlCommand("SELECT * FROM Asiakas WHERE asiakas_id = @asiakas_id");
            database_query.Connection = database_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            database_connection.Open();
            database_query.Parameters.AddWithValue("@asiakas_id", frm.Asiakas_id);
            // Suoritetaan kysely
            database_query.ExecuteNonQuery();
            // Alustetaan tietojen lukija
            SqlDataReader myReader = null;
            myReader = database_query.ExecuteReader();
            // Avataan asiakkaan tietojen muokkaus formi
            frm.Show();
            // Asetetaan formiin tiedot tietokannasta.
            // Huom! Customer_popup formissa textboxit = Public eikä private.
            while (myReader.Read())
            {
                frm.txt_Customer_First_Name.Text = (myReader["etunimi"].ToString());
                frm.txt_Customer_Surname.Text = (myReader["sukunimi"].ToString());
                frm.txt_Customer_Email.Text = (myReader["email"].ToString());
                frm.txt_Customer_Phone_Number.Text = (myReader["puhelinnro"].ToString());
                frm.txt_Customer_Adress.Text = (myReader["lahiosoite"].ToString());
                frm.txt_Customere_Postal_Code.Text = (myReader["postinro"].ToString());
                frm.txt_Customer_City.Text = (myReader["postitoimipaikka"].ToString());
                frm.txt_Customer_Country.Text = (myReader["asuinmaa"].ToString());
            }
            database_connection.Close();
            // Luodaan yhteys Customer_Popup formiin ja päivitetään asiakaslistat sen sulkemisen yhteydessä.
            frm.FormClosed += new FormClosedEventHandler(Get_customer_names_to_grid_on_close_event);
        }

        private void btn_Services_Edit_Click_1(object sender, EventArgs e)
        {
            frm_Services_Popup frm = new frm_Services_Popup();
            frm.Is_service_edited = true;
            string nimi = dgv_Services_All.CurrentCell.Value.ToString();
            SqlCommand database_query = new SqlCommand("SELECT * FROM Palvelu WHERE nimi = @nimi");
            SqlCommand database_query_get_toimipiste_id = new SqlCommand("SELECT * FROM Toimipiste WHERE toimipiste_id = @toimipiste_id");
            database_query.Connection = database_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            database_connection.Open();
            database_query.Parameters.AddWithValue("@nimi", nimi);
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
                frm.Service_id = (myReader["palvelu_id"].ToString());
                frm.txt_Service_Name.Text = (myReader["nimi"].ToString());
                frm.txt_Service_Description.Text = (myReader["kuvaus"].ToString());
                frm.txt_Service_Price.Text = (myReader["hinta"].ToString());
                frm.txt_Service_Max_Visitors.Text = (myReader["max_osallistujat"].ToString());
                frm.txt_Service_alv.Text = (myReader["alv"].ToString());
            }
            database_connection.Close();
            database_query_get_toimipiste_id.Connection = database_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            database_connection.Open();
            database_query_get_toimipiste_id.Parameters.AddWithValue("@toimipiste_id", toimipiste_id);
            // Suoritetaan kysely
            database_query.ExecuteNonQuery();
            // Alustetaan tietojen lukija
            myReader = database_query_get_toimipiste_id.ExecuteReader();
            while (myReader.Read())
            {
                frm.cbo_Service_Office_Select.Text = (myReader["nimi"].ToString());
            }
            database_connection.Close();
            frm.FormClosed += new FormClosedEventHandler(Get_service_names_to_grid_on_close_event);
        }

        private void btn_Cottages_Edit_Click_1(object sender, EventArgs e)
        {
            frm_Cottage_Popup frm = new frm_Cottage_Popup();
            frm.Is_Cottage_edited = true;
            string nimi = dgv_Cottages_all.CurrentCell.Value.ToString();
            SqlCommand database_query = new SqlCommand("SELECT * FROM Majoitus WHERE nimi = @nimi");
            SqlCommand database_query_get_toimipiste_id = new SqlCommand("SELECT * FROM Toimipiste WHERE toimipiste_id = @toimipiste_id");
            database_query.Connection = database_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            database_connection.Open();
            database_query.Parameters.AddWithValue("@nimi", nimi);
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
                frm.Cottage_id = (myReader["majoitus_id"].ToString());
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
            database_connection.Close();
            database_query_get_toimipiste_id.Connection = database_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            database_connection.Open();
            database_query_get_toimipiste_id.Parameters.AddWithValue("@toimipiste_id", toimipiste_id);
            // Suoritetaan kysely
            database_query.ExecuteNonQuery();
            // Alustetaan tietojen lukija
            myReader = database_query_get_toimipiste_id.ExecuteReader();
            while (myReader.Read())
            {
                frm.cbo_Cottage_Office_Select.Text = (myReader["nimi"].ToString());
            }
            database_connection.Close();
            frm.FormClosed += new FormClosedEventHandler(Get_cottage_names_to_grid_on_close_event);
        }

        private void txt_History_Customer_Search_TextChanged(object sender, EventArgs e)
        {
            // Asiakkaiden rajaus kokonimen perusteella.
            // Aloitetaan päivittämällä asiakkaiden hallinnan ja varaushistorian tekstikentät vastaamaan hakua.
            txt_Order_Customers_Search.Text = txt_History_Customer_Search.Text;
            txt_Customer_Search.Text = txt_History_Customer_Search.Text;
            // Yhdistetään tietojen lähteeseen ja rajataan hakutuloksia hakutekstin perusteella.
            BindingSource binding_source = new BindingSource();
            binding_source.DataSource = dgv_Order_Customers_All.DataSource;
            binding_source.Filter = "[kokonimi] Like '%" + txt_Customer_Search.Text + "%'";
        }

        private void txt_Order_Services_Search_TextChanged(object sender, EventArgs e)
        {
            // Palveluiden rajaus nimen perusteella.
            txt_Services_Search.Text = txt_Order_Services_Search.Text;
            // Yhdistetään tietojen lähteeseen ja rajataan hakutuloksia hakutekstin perusteella.
            BindingSource binding_source = new BindingSource();
            binding_source.DataSource = dgv_Order_Services_All.DataSource;
            binding_source.Filter = "[nimi] Like '%" + txt_Order_Services_Search.Text + "%'";
        }

        private void txt_Order_Cottages_Search_TextChanged(object sender, EventArgs e)
        {
            txt_Cottages_Search.Text = txt_Order_Cottages_Search.Text;
            BindingSource binding_source = new BindingSource();
            binding_source.DataSource = dgv_Order_Cottages_All.DataSource;
            binding_source.Filter = "[nimi] Like '%" + txt_Order_Cottages_Search.Text + "%'";
        }

        private void txt_Cottages_Search_TextChanged(object sender, EventArgs e)
        {
            txt_Order_Cottages_Search.Text = txt_Cottages_Search.Text;
            BindingSource binding_source = new BindingSource();
            binding_source.DataSource = dgv_Cottages_all.DataSource;
            binding_source.Filter = "[nimi] Like '%" + txt_Cottages_Search.Text + "%'";
        }


        private void Get_start_date_to_order_summary()
        {
            // Haetaan päivämäärä ja asetetaan se varauksen päivämääräksi.
            DateTime start_date = dtp_Order_Start_Date.Value;
            string parsed_start_date = start_date.ToString("dd.MM.yyyy");
            lbl_Order_Summary_Start_Date.Text = "Alkamispäivä: " + parsed_start_date;
        }

        private void Get_end_date_to_order_summary()
        {
            // Haetaan päivämäärä ja asetetaan se varauksen päivämääräksi.
            DateTime start_date = dtp_Order_End_Date.Value;
            string parsed_end_date = start_date.ToString("dd.MM.yyyy");
            lbl_Order_Summary_End_Date.Text = "Päättymispäivä: " + parsed_end_date;
        }


        private void dtp_Order_Start_Date_ValueChanged(object sender, EventArgs e)
        {
            Get_start_date_to_order_summary();
        }

        private void dtp_Order_End_Date_ValueChanged(object sender, EventArgs e)
        {
            Get_end_date_to_order_summary();
        }

        private void cbo_Order_Office_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Order_Summary_Office.Text = "Toimipiste: " + cbo_Order_Office_Select.Text.ToString();
        }

        private void btn_Order_Customers_Add_Click(object sender, EventArgs e)
        {
            string customer_name = dgv_Order_Customers_All.CurrentCell.Value.ToString();
            lbl_Order_Summary_Customer.Text = ("Asiakas: " + customer_name);
        }

        private void Btn_Order_Cottage_Add_Click(object sender, EventArgs e)
        {
            string selected_cottage = dgv_Order_Cottages_All.CurrentCell.Value.ToString();
            string selected_quantity = txt_Order_Cottage_Persons_Quantity.Text.ToString();
            string[] row = { selected_cottage + " [" + selected_quantity + "]" };
            var listViewItem = new ListViewItem(row);
            lsv_Order_Summary_Cottages.Items.Add(listViewItem);
        }

        private void btn_Order_Service_add_Click(object sender, EventArgs e)
        {
            string selected_service = dgv_Order_Services_All.CurrentCell.Value.ToString();
            string selected_quantity = txt_Order_Services_Quantity.Text.ToString();
            string[] row = { selected_service + " [" + selected_quantity + "]" };
            var listViewItem = new ListViewItem(row);
            lsv_Order_Summary_Services.Items.Add(listViewItem);
        }

        private void txt_Settings_User_Name_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["user_name"] = txt_Settings_User_Name.Text.ToString();
            Properties.Settings.Default.Save();
        }

        private void btn_Order_Summary_Next_Page_Click(object sender, EventArgs e)
        {
            // Määritellään tietokantayhteys.
            frm_Main_Window main_window = new frm_Main_Window();
            SqlConnection database_connection = main_window.database_connection;
            // Loki taulun päivitys
            string paivittaja = txt_Settings_User_Name.Text.ToString();
            string lisatieto_loki = "WUBBALUBLUBDAA";
            SqlCommand database_query_loki= new SqlCommand("INSERT INTO [Loki] ([paivittaja], [lisatieto]) " +
                "VALUES(@paivittaja, @lisatieto_loki)");
            database_query_loki.Connection = main_window.database_connection;
            database_connection.Open();
            database_query_loki.Parameters.AddWithValue("@paivittaja", paivittaja);
            database_query_loki.Parameters.AddWithValue("@lisatieto_loki", lisatieto_loki);
            database_query_loki.ExecuteNonQuery();
            database_connection.Close();

            // Varaus taulun päivitys
            string asiakas_id = "1";
            string toimipiste_id = "2";
            DateTime varattu_pvm = DateTime.Now;
            DateTime vahvistus_pvm = DateTime.Now;
            DateTime varattu_alkupvm = dtp_Order_Start_Date.Value;
            DateTime varattu_loppupvm = dtp_Order_End_Date.Value;
            string lisatieto = txt_Order_Additional_Details.Text;
            // Määritellään tietokantakyselyt asiakkaiden lisäämiseksi ja muokkaamiseksi.
            SqlCommand database_query_varaus = new SqlCommand("INSERT INTO [Varaus] ([asiakas_id], [toimipiste_id], [varattu_pvm], " +
                "[vahvistus_pvm], [varattu_alkupvm], [varattu_loppupvm], [lisatieto]) " +
                " VALUES(@asiakas_id, @toimipiste_id, @varattu_pvm, @vahvistus_pvm, " +
                "@varattu_alkupvm, @varattu_loppupvm, @lisatieto)");
            database_query_varaus.Connection = main_window.database_connection;
            database_connection.Open();
            database_query_varaus.Parameters.AddWithValue("@asiakas_id", asiakas_id);
            database_query_varaus.Parameters.AddWithValue("@toimipiste_id", toimipiste_id);
            database_query_varaus.Parameters.AddWithValue("@varattu_pvm", varattu_pvm);
            database_query_varaus.Parameters.AddWithValue("@vahvistus_pvm", vahvistus_pvm);
            database_query_varaus.Parameters.AddWithValue("@varattu_alkupvm", varattu_alkupvm);
            database_query_varaus.Parameters.AddWithValue("@varattu_loppupvm", varattu_loppupvm);
            database_query_varaus.Parameters.AddWithValue("@lisatieto", lisatieto);
            database_query_varaus.ExecuteNonQuery();
            database_connection.Close();
            // Varauksen_palvelut taulun päivitys
            string varaus_id = "1";
            string palvelu_id = "2";
            string lkm = "1";
            SqlCommand database_query_Varauksen_palvelut = new SqlCommand("INSERT INTO [Varauksen_palvelut] ([varaus_id], [palvelu_id], [lkm]) " +
                "VALUES(@varaus_id, @palvelu_id, @lkm)");
            database_query_Varauksen_palvelut.Connection = main_window.database_connection;
            database_connection.Open();
            database_query_Varauksen_palvelut.Parameters.AddWithValue("@varaus_id", varaus_id);
            database_query_Varauksen_palvelut.Parameters.AddWithValue("@palvelu_id", palvelu_id);
            database_query_Varauksen_palvelut.Parameters.AddWithValue("@lkm", lkm);
            database_query_Varauksen_palvelut.ExecuteNonQuery();
            database_connection.Close();

            // Varauksen_majoitus taulun päivitys
            string majoitus_id = "2";
            string majoittujien_maara = "1";
            SqlCommand database_query_Varauksen_majoitus = new SqlCommand("INSERT INTO [Varauksen_majoitus] ([varaus_id], [majoitus_id], [majoittujien_maara]) " +
                "VALUES(@varaus_id, @majoitus_id, @majoittujien_maara)");
            database_query_Varauksen_majoitus.Connection = main_window.database_connection;
            database_connection.Open();
            database_query_Varauksen_majoitus.Parameters.AddWithValue("@varaus_id", varaus_id);
            database_query_Varauksen_majoitus.Parameters.AddWithValue("@majoitus_id", majoitus_id);
            database_query_Varauksen_majoitus.Parameters.AddWithValue("@majoittujien_maara", majoittujien_maara);
            database_query_Varauksen_majoitus.ExecuteNonQuery();
            database_connection.Close();
        }

        private void btn_Order_Summary_Delete_From_List_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_Order_Customers_All.SelectedRows)
            {
                string value1 = row.Cells[0].Value.ToString();
                string value2 = row.Cells[1].Value.ToString();
                MessageBox.Show(value1 + "  " + value2);
                MessageBox.Show((cbo_Order_Office_Select.SelectedItem as Combo_box_item).Value.ToString());
                string at = "1";
                MessageBox.Show((cbo_Order_Office_Select.SelectedItem as Combo_box_item).Value.ToString());

                SqlCommand database_query = new SqlCommand("SELECT toimipiste_id, nimi FROM Toimipiste");
                database_query.Connection = database_connection;
                // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
                database_connection.Open();
                SqlDataReader myReader = null;
                myReader = database_query.ExecuteReader();
                while (myReader.Read())
                {
                    Combo_box_item item = new Combo_box_item();
                    item.Text = myReader[1].ToString();
                    item.Value = myReader[0].ToString();
                    cbo_Order_Office_Select.Items.Add(item);
                    // cbo_Order_Office_Select.SelectedIndex = 0;
                    cbo_Office_Select.Items.Add(item);
                    // cbo_Office_Select.SelectedIndex = 0;
                    cbo_History_Office_Select.Items.Add(item);
                    // cbo_History_Office_Select.SelectedIndex = 0;
                    cbo_Common_Settings_Default_Office.Items.Add(item);
                    // cbo_Common_Settings_Default_Office.SelectedIndex = 0;
                }
                database_connection.Close();
                cbo_History_Office_Select.SelectedIndex = 0;

            }
        }
    }
}
