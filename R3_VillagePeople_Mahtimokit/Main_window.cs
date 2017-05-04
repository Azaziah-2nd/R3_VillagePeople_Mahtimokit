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
using System.Data.OleDb;


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
                    dtv_Customers_All.DataSource = data_set.Tables[0].DefaultView;
                    dtv_Order_Customers_All.DataSource = data_set.Tables[0].DefaultView;
                }
            }
        }

        private void Get_customer_names_to_grid_on_close_event(object sender, FormClosedEventArgs e)
        {
            // Suljetaan pääformi t3 formin sulkemisen yhteydessä, 
            // näin se ei jää kummittelemaan taustalle piilotettuna.
            Get_customer_names_to_grid();
        }


        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Main_window_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vP_DatabaseDataSet2.Palvelu' table. You can move, or remove it, as needed.
            this.palveluTableAdapter.Fill(this.vP_DatabaseDataSet2.Palvelu);
            this.toimipisteTableAdapter.Fill(this.vP_DatabaseDataSet1.Toimipiste);
            // Haetaan datagridvieweihin tiedot tietokannasta.
            this.Get_customer_names_to_grid();
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
            // Luodaan yhteys frm_t3:n sulkemiseen ja yhdistetään se funktioon "frm_t3_suljettiin".
            frm.FormClosed += new FormClosedEventHandler(Get_customer_names_to_grid_on_close_event);
        }

        // Asiakkaan muokkaus
        private void btn_Customer_edit_Click(object sender, EventArgs e)
        {
            frm_Customer_Popup frm = new frm_Customer_Popup(this);
            frm.Show();
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
            frm_Customer_Popup frm = new frm_Customer_Popup(this);
            frm.Show();
            // Luodaan yhteys Customer_Popup formiin ja päivitetään asiakaslistat sen sulkemisen yhteydessä.
            frm.FormClosed += new FormClosedEventHandler(Get_customer_names_to_grid_on_close_event);
        }

        private void btn_Services_Add_Click_1(object sender, EventArgs e)
        {
            frm_Services_Popup frm = new frm_Services_Popup();
            frm.Show();
        }

        private void btn_Cottages_Add_Click_1(object sender, EventArgs e)
        {
            frm_Cottage_Popup frm = new frm_Cottage_Popup();
            frm.Show();
        }

        private void btn_Office_Add_Click_1(object sender, EventArgs e)
        {
            frm_Office_Popup frm = new frm_Office_Popup();
            frm.Show();
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
            // Yhdistetään tietojen lähteeseen ja rajataan hakutuloksia hakutekstin perusteella.
            BindingSource binding_source = new BindingSource();
            binding_source.DataSource = dtv_Order_Customers_All.DataSource;
            binding_source.Filter = "[kokonimi] Like '%" + txt_Order_Customers_Search.Text + "%'";
            dtv_Order_Customers_All.DataSource = binding_source;
        }

        private void btn_Order_Customers_Search_Click(object sender, EventArgs e)
        {
            // Asiakkaiden rajaus kokonimen perusteella.
            // Yhdistetään tietojen lähteeseen ja rajataan hakutuloksia hakutekstin perusteella.
            BindingSource binding_source = new BindingSource();
            binding_source.DataSource = dtv_Order_Customers_All.DataSource;
            binding_source.Filter = "[kokonimi] Like '%" + txt_Order_Customers_Search.Text + "%'";
            dtv_Order_Customers_All.DataSource = binding_source;
        }

        private void txt_Customer_Search_TextChanged(object sender, EventArgs e)
        {
            // Asiakkaiden rajaus kokonimen perusteella.
            // Yhdistetään tietojen lähteeseen ja rajataan hakutuloksia hakutekstin perusteella.
            BindingSource binding_source = new BindingSource();
            binding_source.DataSource = dtv_Customers_All.DataSource;
            binding_source.Filter = "[kokonimi] Like '%" + txt_Order_Customers_Search.Text + "%'";
            dtv_Order_Customers_All.DataSource = binding_source;
        }

        private void btn_Customer_Search_Click(object sender, EventArgs e)
        {
            // Asiakkaiden rajaus kokonimen perusteella.
            // Yhdistetään tietojen lähteeseen ja rajataan hakutuloksia hakutekstin perusteella.
            BindingSource binding_source = new BindingSource();
            binding_source.DataSource = dtv_Customers_All.DataSource;
            binding_source.Filter = "[kokonimi] Like '%" + txt_Order_Customers_Search.Text + "%'";
            dtv_Order_Customers_All.DataSource = binding_source;
        }


        private void btn_Customer_Delete_Click_1(object sender, EventArgs e)
        {
            // Hakee nykyisen nimen ja poistaa tiedon tietokannasta sekä päivittää asiakaslistat.
            // Tämä ei toimi oikein jos tietokannassa on useita henkilöitä täsmälleen samoilla nimillä.
            if (dtv_Customers_All.CurrentCell.Value.ToString() != "")
            {
                string kokonimi = dtv_Customers_All.CurrentCell.Value.ToString();
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
            // Yhdistetään tietojen lähteeseen ja rajataan hakutuloksia hakutekstin perusteella.
            BindingSource binding_source = new BindingSource();
            binding_source.DataSource = dtv_Services_All.DataSource;
            binding_source.Filter = "[nimi] Like '%" + txt_Services_Search.Text + "%'";
            dtv_Order_Customers_All.DataSource = binding_source;
        }

        private void btn_Office_Edit_Click_1(object sender, EventArgs e)
        {
        }
    }
}
