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
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT kokonimi FROM Asiakas", database_connection))
            {
                DataSet data_set = new DataSet();
                database_query.Fill(data_set);
                if (data_set.Tables.Count > 0)
                {
                    dgv_Customers_All.DataSource = data_set.Tables[0].DefaultView;
                    dgv_Order_Customers_All.DataSource = data_set.Tables[0].DefaultView;
                    dgv_History_Customers_All.DataSource = data_set.Tables[0].DefaultView;
                }
            }
        }
 
        private void Get_office_names_to_combo()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT nimi FROM toimipiste", database_connection))
            {
                DataSet data_set = new DataSet();
                database_query.Fill(data_set);
                if (data_set.Tables.Count > 0)
                {
                    cbo_Office_Select.DataSource = data_set.Tables[0].DefaultView;
                    cbo_Order_Office_Select.DataSource = data_set.Tables[0].DefaultView;
                    cbo_History_Office_Select.DataSource = data_set.Tables[0].DefaultView;
                    cbo_Common_Settings_Default_Office.DataSource = data_set.Tables[0].DefaultView;
                }
            }
        }

        private void Get_service_names_to_grid()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT nimi FROM Palvelu", database_connection))
            {
                DataSet data_set = new DataSet();
                database_query.Fill(data_set);
                if (data_set.Tables.Count > 0)
                {
                    dgv_Order_Services_All.DataSource = data_set.Tables[0].DefaultView;
                    dgv_Services_All.DataSource = data_set.Tables[0].DefaultView;
                }
            }
        }
        private void Get_cottage_names_to_grid()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT nimi FROM Majoitus", database_connection))
            {
                DataSet data_set = new DataSet();
                database_query.Fill(data_set);
                if (data_set.Tables.Count > 0)
                {
                    dgv_Order_Cottages_All.DataSource = data_set.Tables[0].DefaultView;
                    dgv_Cottages_all.DataSource = data_set.Tables[0].DefaultView;
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

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Main_window_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vP_DatabaseDataSet4.Asiakas' table. You can move, or remove it, as needed.
            this.asiakasTableAdapter1.Fill(this.vP_DatabaseDataSet4.Asiakas);
            // TODO: This line of code loads data into the 'vP_DatabaseDataSet3.Majoitus' table. You can move, or remove it, as needed.
            this.majoitusTableAdapter.Fill(this.vP_DatabaseDataSet3.Majoitus);

            // Haetaan tiedot tietokannasta eri kenttiin.
            this.Get_customer_names_to_grid();
            this.Get_office_names_to_combo();
            this.Get_service_names_to_grid();
            this.Get_cottage_names_to_grid();
            // Ladataan käyttäjän asetukset ja muutetaan kentät vastaamaan niitä.
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

        // Asiakkaan poisto
        private void btn_Customer_delete_Click(object sender, EventArgs e)
        {

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

        private void tbl_Order_Col_1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lbl_Order_Office_Click(object sender, EventArgs e)
        {

        }

        private void tbl_Order_2nd_Col_Cottage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbl_History_2nd_Col_Orders_Dates_Paint(object sender, PaintEventArgs e)
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

        private void tbl_Order_3rd_Col_Cottage_Summary_Services_Paint(object sender, PaintEventArgs e)
        {

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
        private void btn_Order_Customers_Search_Click(object sender, EventArgs e)
        {  
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

        private void btn_Customer_Search_Click(object sender, EventArgs e)
        {
        }


        private void btn_Customer_Delete_Click_1(object sender, EventArgs e)
        {
            // Hakee nykyisen nimen ja poistaa tiedon tietokannasta sekä päivittää asiakaslistat.
            // Tämä ei toimi oikein jos tietokannassa on useita henkilöitä täsmälleen samoilla nimillä.
            // Parempi ratkaisu olisi poistaa arvoja asiakas_id:n perusteella, mutta miten asiakas_id:n saa haettua datagridview kentän arvoista?
            if (dgv_Customers_All.CurrentCell.Value.ToString() != "")
            {
                string kokonimi = dgv_Customers_All.CurrentCell.Value.ToString();
                SqlCommand database_query = new SqlCommand("DELETE FROM Asiakas WHERE kokonimi = @kokonimi");
                database_query.Connection = database_connection;
                // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
                database_connection.Open();
                database_query.Parameters.AddWithValue("@kokonimi", kokonimi);
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

            // Avataan asiakkaan tietojen muokkaus formi
            frm.Show();
            // Asetetaan formiin tiedot tietokannasta.
            // Huom! Customer_popup formissa textboxit = Public eikä private.
            while (myReader.Read())
            {
                frm.Office_id = (myReader["toimipiste_id"].ToString());
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
            string kokonimi = dgv_Customers_All.CurrentCell.Value.ToString();
            SqlCommand database_query = new SqlCommand("SELECT * FROM Asiakas WHERE kokonimi = @kokonimi");
            database_query.Connection = database_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            database_connection.Open();
            database_query.Parameters.AddWithValue("@kokonimi", kokonimi);
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
                frm.Asiakas_id = (myReader["asiakas_id"].ToString());
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

        private void dgv_Order_Cottage_All_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void btn_Services_Search_Click(object sender, EventArgs e)
        {

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
    }
}
