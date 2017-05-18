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
                          Connect Timeout=15;
                          User Instance=False");

        private void Main_window_Load(object sender, EventArgs e)
        {
            Load_settings_and_dates();
            // Haetaan tiedot tietokannasta eri kenttiin.
            // Toimipisteiden haku täytyy suorittaa ensin, muuten mökkien ja palveluiden lisäys varaukseen ei toimi ennen
            // kuin listasta valitaan manuaalisesti jokin kohde. (null error, liittyy filtteröintiin)
            Get_office_names_to_combo();
            Get_customer_names_to_grid();
            Get_service_names_to_grid();
            Get_cottage_names_to_grid();
            Get_order_history_to_grid();
            Hide_datagridview_id_fields_and_reset_search();
        }

        private void Load_settings_and_dates()
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
                dtp_History_Orders_Filter_Date_End.Value = DateTime.Today;
            }
            // Varaus välilehden päivät.
            dtp_Order_Start_Date.Value = DateTime.Today;
            dtp_Order_End_Date.Value = DateTime.Today.AddDays(1);
        }

        // DataGriedView elementtien tietojen päivitys.
        private void Get_customer_names_to_grid()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT asiakas_id, kokonimi FROM Asiakas", database_connection))
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

        private void Get_office_names_to_combo()
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
                cbo_Office_Select.Items.Add(item);
                cbo_History_Office_Select.Items.Add(item);
                cbo_Common_Settings_Default_Office.Items.Add(item);
            }
            database_connection.Close();
            // Tarkistetaan, onko tietokannasta haettu yhtään toimipistettä
            if (cbo_Office_Select.Items.Count == 0)
            {
                // Jos ei, lopetetaan koodin suorittaminen
                return;
            }
            string default_office = Properties.Settings.Default["default_office"].ToString();
            // Jos toimipistettä ei ole valittu, valitaan oletustoimipisteeksi ensimmäinen listassa oleva toimipiste.
            if (default_office == "")
            {
                cbo_Common_Settings_Default_Office.SelectedIndex = 0;
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

        private void Get_service_names_to_grid()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT palvelu_id, toimipiste_id, nimi FROM Palvelu", database_connection))
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
        private void Get_cottage_names_to_grid()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT majoitus_id, toimipiste_id, nimi FROM Majoitus", database_connection))
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

        private void Get_order_history_to_grid()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT varaus_id, asiakas_id, toimipiste_id, varattu_pvm FROM Varaus", database_connection))
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

        private void Get_log_events_to_grid()
        {
            using (SqlDataAdapter database_query = new SqlDataAdapter("SELECT paivittaja, lisatieto FROM Loki", database_connection))
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

        // Tietojen päivitys formien sulkemisen yhteydessä.
        private void Get_customer_names_to_grid_on_close_event(object sender, FormClosedEventArgs e)
        {
            Get_customer_names_to_grid();
            Hide_datagridview_id_fields_and_reset_search();
        }

        private void Get_office_names_to_combo_on_close_event(object sender, FormClosedEventArgs e)
        {
            Get_office_names_to_combo();
            Hide_datagridview_id_fields_and_reset_search();
        }
        private void Get_service_names_to_grid_on_close_event(object sender, FormClosedEventArgs e)
        {
            Get_service_names_to_grid();
            Hide_datagridview_id_fields_and_reset_search();
        }
        private void Get_cottage_names_to_grid_on_close_event(object sender, FormClosedEventArgs e)
        {
            Get_cottage_names_to_grid();
            Hide_datagridview_id_fields_and_reset_search();
        }

        private void Hide_datagridview_id_fields_and_reset_search()
        {
            /* Tämä resetoi haut jap iilottaa datagridvieweistä asiakas_id, majoitus_id, palvelu_id 
             * sekä toimipiste_id kenttien näkyvyyden valitun välilehden perusteella.
             * Kenttien piilotus ei aina toimi jos ne piilotetaan tietokantojen lataamisen
             * yhteydessä, piilottaminen välilehden mukaan varmistaa halutun lopputuloksen.
             * Hakujen resetointi varaus ja tietojen hallinta välilehtiin:
             * Tietojen filtteröinti rajaa tiedot myös toisen välilehden datagrideistä,
             * asetetaan oikeat rajaukset uudestaan välilehden vaihtuessa.
             * 
             * tab_index arvot:
             * 0 = Uusi varaus
             * 1 = Tietojen hallinta
             * 2 = Varaushistoria
             * 3 = Asetukset
             */
            int tab_index = tab_Menu.SelectedIndex;
            if (tab_index == 0)
            {
                dgv_Order_Customers_All.Columns[0].Visible = false;
                dgv_Order_Services_All.Columns[0].Visible = false;
                dgv_Order_Cottages_All.Columns[0].Visible = false;
                dgv_Order_Services_All.Columns[1].Visible = false;
                dgv_Order_Cottages_All.Columns[1].Visible = false;
                Filter_order_cottages_by_office_and_text();
                Filter_order_services_by_office_and_text();
            }
            else if (tab_index == 1)
            {
                dgv_Customers_All.Columns[0].Visible = false;
                dgv_Services_All.Columns[0].Visible = false;
                dgv_Services_All.Columns[1].Visible = false;
                dgv_Cottages_All.Columns[0].Visible = false;
                dgv_Cottages_All.Columns[1].Visible = false;
                Filter_management_cottages_by_office_and_text();
                Filter_management_services_by_office_and_text();
            }
            else if (tab_index == 2)
            {
                dgv_History_Customers_All.Columns[0].Visible = false;
                dgv_History_Orders_All.Columns[1].Visible = false;
                dgv_History_Orders_All.Columns[2].Visible = false;
                // Varaushistoria filtteröidään tiettyyn päivään asti, oletuksena näytetään varaukset jotka on luotu ennen nykyistä päivämäärää.
                Filter_history_orders();
            }
        }

        private void Filter_order_cottages_by_office_and_text()
        {
            // Filtteröidään mökit toimipisteen + hakukentän mukaan.
            BindingSource cottage_list = new BindingSource();
            cottage_list.DataSource = dgv_Order_Cottages_All.DataSource;
            string filer_cottages = string.Format("CONVERT(toimipiste_id, 'System.String') LIKE '%{0}%' AND nimi LIKE '%{1}%'",
                                  Reservation_toimipiste_id, txt_Order_Cottages_Search.Text);
            cottage_list.Filter = filer_cottages;
        }

        private void Filter_order_services_by_office_and_text()
        {
            // Filtteröidään palvelut toimipisteen + hakukentän mukaan.
            BindingSource service_list = new BindingSource();
            service_list.DataSource = dgv_Order_Services_All.DataSource;
            string filter_services = string.Format("CONVERT(toimipiste_id, 'System.String') LIKE '%{0}%' AND nimi LIKE '%{1}%'",
            Reservation_toimipiste_id, txt_Order_Services_Search.Text);
            service_list.Filter = filter_services;
        }

        private void Filter_management_services_by_office_and_text()
        {
            // Filtteröidään palvelut toimipisteen + hakukentän mukaan.
            BindingSource service_list = new BindingSource();
            service_list.DataSource = dgv_Services_All.DataSource;
            string filter_services = string.Format("CONVERT(toimipiste_id, 'System.String') LIKE '%{0}%' AND nimi LIKE '%{1}%'",
            Management_toimipiste_id, txt_Services_Search.Text);
            service_list.Filter = filter_services;
        }

        private void Filter_management_cottages_by_office_and_text()
        {
            // Filtteröidään palvelut toimipisteen + hakukentän mukaan.
            BindingSource service_list = new BindingSource();
            service_list.DataSource = dgv_Cottages_All.DataSource;
            string filter_services = string.Format("CONVERT(toimipiste_id, 'System.String') LIKE '%{0}%' AND nimi LIKE '%{1}%'",
            Management_toimipiste_id, txt_Cottages_Search.Text);
            service_list.Filter = filter_services;
        }

        string history_asiakas_id = "";
        string history_toimipiste_id = "";
        private void Filter_history_orders()
        {
            // Alustetaan tarvittavat apumuuttujat ja haetaan eri rajaus mekanismien arvot.
            string filer_order_history = "";
            string filter_by_date = dtp_History_Orders_Filter_Date_End.Value.ToString();
            Combo_box_item item = new Combo_box_item();
            // Filtteröidään tiedot valittujen hakuarvojen mukaan.
            BindingSource order_history_list = new BindingSource();
            order_history_list.DataSource = dgv_History_Orders_All.DataSource;
            // Jos sekä asiakas, että toimipiste filtteröinti ovat asetettuja.
            if (history_asiakas_id != "" && history_toimipiste_id != "")
            {
                filer_order_history = string.Format("CONVERT(asiakas_id, 'System.String') LIKE '%{0}%' AND CONVERT"
                    + "(varattu_pvm, 'System.String') <= '{1:dd-MM-yyyy:}' AND CONVERT(toimipiste_id, 'System.String') LIKE '%{2}%'"
                    + " AND CONVERT(varaus_id, 'System.String') LIKE '%{3}%'",
                    history_asiakas_id, filter_by_date, history_toimipiste_id, txt_History_Order_Search.Text);
            }
            // Jos ainoastaan asiakasfiltteröinti on asetettu.
            else if (history_asiakas_id != "")
            {
                filer_order_history = string.Format("CONVERT(asiakas_id, 'System.String') LIKE '%{0}%' AND CONVERT"
                    + "(varattu_pvm, 'System.String') <= '{1:dd-MM-yyyy:}' AND CONVERT(varaus_id, 'System.String') LIKE '%{2}%'",
                    history_asiakas_id, filter_by_date, txt_History_Order_Search.Text);
            }
            // Jos ainoastaan  toimipiste filtteröinti on asetettu.
            else if (history_toimipiste_id != "")
            {
                filer_order_history = string.Format("CONVERT(toimipiste_id, 'System.String') LIKE '%{0}%' AND CONVERT"
                    + "(varattu_pvm, 'System.String') <= '{1:dd-MM-yyyy:}' AND CONVERT(varaus_id, 'System.String') LIKE '%{2}%'",
                     history_toimipiste_id, filter_by_date, txt_History_Order_Search.Text);
            }
            // Jos kumpikaan ei ole asetettu, tapahtuu filtteröinti pelkän hakukentän mukaan.
            else
            {
                filer_order_history = string.Format("CONVERT(varattu_pvm, 'System.String') <= '{0:dd-MM-yyyy:}' "
                    + "AND CONVERT(varaus_id, 'System.String') LIKE '%{1}%'",
                        filter_by_date, txt_History_Order_Search.Text);
            }
            // Toteutetaan filtteröinti.
            order_history_list.Filter = filer_order_history;
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


        private void btn_Customer_Add_Click(object sender, EventArgs e)
        {
            // Yhdistetään formiin ja asetetaan is_customer_edited arvoksi "epätosi".
            frm_Customer_Popup frm = new frm_Customer_Popup(this);
            frm.is_customer_edited = false;
            frm.Show();
            // Luodaan yhteys Customer_Popup formiin ja päivitetään asiakaslistat sen sulkemisen yhteydessä.
            frm.FormClosed += new FormClosedEventHandler(Get_customer_names_to_grid_on_close_event);
        }

        private void btn_Services_Add_Click(object sender, EventArgs e)
        {
            // Tarkistetaan ensin, onko järjestelmässä yhtään toimipistettä.
            if (cbo_Office_Select.Items.Count == 0)
            {
                // Jos ei, tulostetaan virheilmoitus ja perutaan uuden mökin luonti.
                MessageBox.Show("Virhe! Järjestelmässä ei ole yhtään toimipistettä, lisää ensin toimipiste.");
                return;
            }
            frm_Services_Popup frm = new frm_Services_Popup();
            frm.Is_service_edited = false;
            frm.Show();
            // Valitaan oletuksena nykyinen toimipiste.
            string selected_office_name = cbo_Office_Select.Text.ToString();
            frm.cbo_Service_Office_Select.SelectedIndex = cbo_Order_Office_Select.FindString(selected_office_name);
            frm.FormClosed += new FormClosedEventHandler(Get_service_names_to_grid_on_close_event);
        }

        private void btn_Cottages_Add_Click(object sender, EventArgs e)
        {
            // Tarkistetaan ensin, onko järjestelmässä yhtään toimipistettä.
            if (cbo_Office_Select.Items.Count == 0)
            {
                // Jos ei, tulostetaan virheilmoitus ja perutaan uuden mökin luonti.
                MessageBox.Show("Virhe! Järjestelmässä ei ole yhtään toimipistettä, lisää ensin toimipiste.");
                return;
            }
            frm_Cottage_Popup frm = new frm_Cottage_Popup();
            frm.Is_Cottage_edited = false;
            frm.Show();
            // Valitaan oletuksena nykyinen toimipiste.
            string selected_office_name = cbo_Office_Select.Text.ToString();
            frm.cbo_Cottage_Office_Select.SelectedIndex = cbo_Order_Office_Select.FindString(selected_office_name);
            frm.FormClosed += new FormClosedEventHandler(Get_cottage_names_to_grid_on_close_event);
        }

        private void btn_Office_Add_Click(object sender, EventArgs e)
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
            Properties.Settings.Default["default_office"] = cbo_Common_Settings_Default_Office.Text.ToString();
            Properties.Settings.Default.Save();
            // Asetetaan toimipistevalintakenttien arvot vastaamaan oletustoimipistettä.
            string default_office = Properties.Settings.Default["default_office"].ToString();
            cbo_Order_Office_Select.SelectedIndex = cbo_Order_Office_Select.FindStringExact(default_office);
            cbo_Office_Select.SelectedIndex = cbo_Office_Select.FindStringExact(default_office);
            cbo_History_Office_Select.SelectedIndex = cbo_History_Office_Select.FindStringExact(default_office);
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


        private void btn_Customer_Delete_Click(object sender, EventArgs e)
        {
            // Hakee nykyisen nimen ja poistaa tiedon tietokannasta sekä päivittää asiakaslistat.
            // Aloitetaan tarkistamalla, että valinta ei ole tyhjä.
            if (dgv_Customers_All.SelectedRows.Count > 0)
            {
                string asiakas_id = "";
                // Haetaan valitun asiakkaan ID datagridviewistä.
                foreach (DataGridViewRow row in dgv_Order_Customers_All.SelectedRows)
                {
                    asiakas_id = row.Cells[0].Value.ToString();
                }
                // Yritetään poistaa asiakasta tietokannasta
                try
                {
                    SqlCommand database_query = new SqlCommand("DELETE FROM Asiakas WHERE asiakas_id = @asiakas_id");
                    database_query.Connection = database_connection;
                    // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
                    database_connection.Open();
                    database_query.Parameters.AddWithValue("@asiakas_id", asiakas_id);
                    // Suoritetaan kysely, suljetaan tietokantayhteys ja päivitetään kentät.
                    database_query.ExecuteNonQuery();
                    database_connection.Close();
                    Get_customer_names_to_grid();
                    // Loki taulun päivitys
                    string lisatieto_loki = "Poistettiin asiakas nro: " + asiakas_id;
                    SqlCommand database_query_loki = new SqlCommand("INSERT INTO [Loki] ([paivittaja], [lisatieto]) " +
                        "VALUES(@paivittaja, @lisatieto_loki)");
                    database_query_loki.Connection = database_connection;
                    database_connection.Open();
                    database_query_loki.Parameters.AddWithValue("@paivittaja", Properties.Settings.Default["user_name"].ToString());
                    database_query_loki.Parameters.AddWithValue("@lisatieto_loki", lisatieto_loki);
                    database_query_loki.ExecuteNonQuery();
                    database_connection.Close();
                }
                // Yritys epäonnistuu tietokannan viite-eheyden rikkoutumiseen.
                catch (SqlException)
                {
                    // Suljetaan "try" lohkossa avattu tietokantayhteys ja alustetaan tietojen lukija.
                    database_connection.Close();
                    SqlDataReader myReader = null;
                    // Luodaan lista asiakkaan varausnumeroita varten.
                    List<int> customer_orders = new List<int>();
                    SqlCommand database_query_get_customer_reservations = new SqlCommand("SELECT varaus_id FROM Varaus WHERE asiakas_id = @asiakas_id");
                    database_query_get_customer_reservations.Connection = database_connection;
                    database_connection.Open();
                    // Haetaan asiakas_id:n perusteella tietokannasta varaukset ja lisätään ne listaan.
                    database_query_get_customer_reservations.Parameters.AddWithValue("@asiakas_id", asiakas_id);
                    database_query_get_customer_reservations.ExecuteNonQuery();
                    myReader = database_query_get_customer_reservations.ExecuteReader();
                    while (myReader.Read())
                    {
                        customer_orders.Add(Convert.ToInt32((myReader["varaus_id"])));
                    }
                    // Suljetaan yhteys ja tulostetaan virheilmoitus.
                    database_connection.Close();
                    var all_customer_orders = string.Join(",  ", customer_orders);
                    MessageBox.Show("Virhe! Asiakas on yhdistetty seuraaviin varausnumeroihin:\n\n" +
                        all_customer_orders + "\n\nJos haluat poistaa tämän asiakkaan, on sinun ensin " +
                        "poistettava\nkaikki tämän asiakkaan tekemät varaukset varaushistoriasta.");
                }
            }
        }

        private void txt_Services_Search_TextChanged(object sender, EventArgs e)
        {
            Filter_management_services_by_office_and_text();
        }

        private void btn_Office_Edit_Click(object sender, EventArgs e)
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
            database_connection.Close();
            // Luodaan yhteys formin sulkemiseen ja päivitetään toimipistelistat sulkemisen yhteydessä.
            frm.FormClosed += new FormClosedEventHandler(Get_office_names_to_combo_on_close_event);
        }

        private void btn_Customer_Edit_Click(object sender, EventArgs e)
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

        private void btn_Services_Edit_Click(object sender, EventArgs e)
        {
            frm_Services_Popup frm = new frm_Services_Popup();
            frm.Is_service_edited = true;
            // Alustetaan tietojen lukija
            SqlDataReader myReader = null;
            // Avataan asiakkaan tietojen muokkaus formi
            frm.Show();
            // Haetaan valitun DataGridView kentän ID.
            if (dgv_Services_All.SelectedRows.Count > 0)
            {
                int selectedrowindex = dgv_Services_All.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_Services_All.Rows[selectedrowindex];
                frm.Service_id = Convert.ToString(selectedRow.Cells["palvelu_id"].Value);
                SqlCommand database_query = new SqlCommand("SELECT * FROM Palvelu WHERE palvelu_id = @palvelu_id");
                database_query.Connection = database_connection;
                // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
                database_connection.Open();
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
                database_connection.Close();
                SqlCommand database_query_get_toimipiste_id = new SqlCommand("SELECT * FROM Toimipiste WHERE toimipiste_id = @toimipiste_id");
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
        }

        private void btn_Cottages_Edit_Click(object sender, EventArgs e)
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
                database_query.Connection = database_connection;
                // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
                database_connection.Open();
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
                database_connection.Close();
                SqlCommand database_query_get_toimipiste_id = new SqlCommand("SELECT * FROM Toimipiste WHERE toimipiste_id = @toimipiste_id");
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
            Filter_order_services_by_office_and_text();
        }

        private void txt_Order_Cottages_Search_TextChanged(object sender, EventArgs e)
        {
            Filter_order_cottages_by_office_and_text();
        }

        private void txt_Cottages_Search_TextChanged(object sender, EventArgs e)
        {
            Filter_management_cottages_by_office_and_text();
        }

        private void dtp_Order_Start_Date_ValueChanged(object sender, EventArgs e)
        {
            if(dtp_Order_Start_Date.Value < DateTime.Today)
            {
                dtp_Order_Start_Date.Value = DateTime.Today;
                MessageBox.Show("Virhe! Et voi valita varauksen alkamispäiväksi kulunutta päivää.");
            }
            Get_start_date_to_order_summary();
            // Tarkistetaan onko alkamispäivä päättymispäivän jälkeen.
            if(dtp_Order_Start_Date.Value > dtp_Order_End_Date.Value)
            {
                // Jos kyllä, muutetaan päättymispäiväksi alkamispäivä + 1 päivä.
                dtp_Order_End_Date.Value = dtp_Order_Start_Date.Value.AddDays(1);
            }
        }

        private void dtp_Order_End_Date_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_Order_End_Date.Value < DateTime.Today)
            {
                dtp_Order_End_Date.Value = DateTime.Today;
                MessageBox.Show("Virhe! Et voi valita varauksen päättymispäiväksi mennyttä päivää.");
            }
            Get_end_date_to_order_summary();
            // Tarkistetaan onko  päättymispäivä alkamispäivän jälkeen.
            if (dtp_Order_Start_Date.Value > dtp_Order_End_Date.Value)
            {
                // Jos ei, muutetaan alkamispäiväksi päättymispäivä  - 1 päivä.
                dtp_Order_Start_Date.Value  = dtp_Order_End_Date.Value.AddDays(-1);
            }
        }

        string Reservation_toimipiste_id = "";
        string office_name = "";
        private void cbo_Order_Office_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            office_name = cbo_Order_Office_Select.Text.ToString();
            Combo_box_item item = new Combo_box_item();
            Reservation_toimipiste_id = (cbo_Order_Office_Select.SelectedItem as Combo_box_item).Value.ToString();
            lbl_Order_Summary_Office.Text = "Toimipiste: " + office_name;
            // Filtteröidään mökit ja palvelut toimipisteen + hakukentän mukaan.
            Filter_order_cottages_by_office_and_text();
            Filter_order_services_by_office_and_text();
        }


        private void cbo_Order_Office_Select_DropDownClosed(object sender, EventArgs e)
        {
            // Tarkistetaan onko varaukseen lisätty jo mökkejä tai palveluita.
            if (lsv_Order_Summary_Cottages.Items.Count == 0 && lsv_Order_Summary_Services.Items.Count == 0)
            {
                // Jos ei, jatketaan normaalisti toimipisteen muuttamista.
            }
            else
            {
                // Asetetaan toimipisteen valinnan comboboxiin edellinen valittu toimipiste.
                // Tämä toteutuu edellisen toimipisteen nimen perusteella.
                cbo_Order_Office_Select.SelectedIndex = cbo_Order_Office_Select.FindString(office_name);
                // Tulostetaan virheilmoitus
                MessageBox.Show("Virhe! Tilaukseen on lisätty jo mökkejä tai palveluita nykyisestä toimipisteestä.\n\n"
                + "Jos haluat vaihtaa toimipistettä, poista ensin\nvarauksesta kaikki lisätyt mökit ja palvelut.");
            }
        }


        string Reservation_asiakas_id = "";
        private void btn_Order_Customers_Add_Click(object sender, EventArgs e)
        {
            if (dgv_Order_Customers_All.SelectedRows.Count > 0)
            {
                // Siirretään asiakkaan nimi varausksen yhteenvetoon.
                string customer_name = dgv_Order_Customers_All.CurrentCell.Value.ToString();
                lbl_Order_Summary_Customer.Text = ("Asiakas: " + customer_name);
                // Valmistellaan asiakkaan id valmiiksi "varaus" tauluun vientiä varten.
                foreach (DataGridViewRow row in dgv_Order_Customers_All.SelectedRows)
                {
                    Reservation_asiakas_id = row.Cells[0].Value.ToString();
                }
            }
        }
        // Muuttujasta Main_window juuressa, että menee laskutukseen
        string Reservation_Cottage_id = "";
        private void Btn_Order_Cottage_Add_Click(object sender, EventArgs e)
        {
            // Haetaan majoittujien lukumäärä
            string selected_quantity = txt_Order_Cottage_Persons_Quantity.Text.ToString();
            // Tarkistetaan, onko lukumäärä kelvollinen.
            int selected_quantity_int;
            bool is_quantity_valid = int.TryParse(selected_quantity, out selected_quantity_int);
            // Jos lkm on virheellinen, tulostetaan virheilmoitus ja keskeytetään metodin suoritus(return).
            if(is_quantity_valid == false)
            {
                MessageBox.Show("Virhe! Syöte: \"" + selected_quantity + "\" ei ole kelvollinen numero!");
                return;
            }

            if (dgv_Order_Cottages_All.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in dgv_Order_Cottages_All.SelectedRows)
                {
                    Reservation_Cottage_id = row.Cells[0].Value.ToString();
                }

                int selectedrowindex = dgv_Order_Cottages_All.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_Order_Cottages_All.Rows[selectedrowindex];
                string selected_cottage_name = dgv_Order_Cottages_All.CurrentCell.Value.ToString();
                string[] rowas = { selected_cottage_name + " [" + selected_quantity + "]" };
                var cottage_details = new ListViewItem(rowas);
                cottage_details.Tag = Reservation_Cottage_id;
                // Tarkistetaan onko varattu mökki jo varauksessa mökin id:n perusteella.
                List<int> cottage_ids_in_order = new List<int>();
                foreach (ListViewItem cottages_already_added in lsv_Order_Summary_Cottages.Items)
                {
                    // Lisätään kaikki lsitassa olevat mökit tarkistuslistaan.
                    cottage_ids_in_order.Add(Convert.ToInt32(cottages_already_added.Tag));
                }
                if (cottage_ids_in_order.Contains(Convert.ToInt32(Reservation_Cottage_id)))
                {
                    MessageBox.Show("Virhe, mökki \"" + selected_cottage_name + "\"on jo lisätty varaukseen!\n\nJos haluat " +
                        "muuttaa majoittujien määrää, poista mökki\nensin varauksesta ja lisää se sitten uudestaan.");
                }
                else
                {
                    // Jos mökkiä ei vielä ole listassa, lisätään se listaan.
                    lsv_Order_Summary_Cottages.Items.Add(cottage_details);
                }
            }
        }

        private void btn_Order_Service_add_Click(object sender, EventArgs e)
        {
            // Haetaan lukumäärä
            string selected_quantity = txt_Order_Services_Quantity.Text.ToString(); ;
            // Tarkistetaan, onko lukumäärä kelvollinen.
            int selected_quantity_int;
            bool is_quantity_valid = int.TryParse(selected_quantity, out selected_quantity_int);
            // Jos lkm on virheellinen, tulostetaan virheilmoitus ja keskeytetään metodin suoritus(return).
            if (is_quantity_valid == false)
            {
                MessageBox.Show("Virhe! Syöte: \"" + selected_quantity + "\" ei ole kelvollinen numero!");
                return;
            }
            string Reservation_service_id = "";
            if (dgv_Services_All.SelectedRows.Count > 0)
            {
                int selectedrowindex = dgv_Order_Services_All.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_Order_Services_All.Rows[selectedrowindex];
                Reservation_service_id = Convert.ToString(selectedRow.Cells["palvelu_id"].Value);
                string selected_service = dgv_Order_Services_All.CurrentCell.Value.ToString();
                string[] rowas = { selected_service + " [" + selected_quantity + "]" };
                var listViewItem = new ListViewItem(rowas);
                listViewItem.Tag = Reservation_service_id;
                // Tarkistetaan onko varattu palvelu jo varauksessa palvelun id:n perusteella.
                List<int> service_ids_in_order = new List<int>();
                foreach (ListViewItem services_already_added in lsv_Order_Summary_Services.Items)
                {
                    // Lisätään kaikki lsitassa olevat palvelut tarkistuslistaan.
                    service_ids_in_order.Add(Convert.ToInt32(services_already_added.Tag));
                }
                if (service_ids_in_order.Contains(Convert.ToInt32(Reservation_service_id)))
                {
                    MessageBox.Show("Virhe, palvelu \"" + selected_service + "\"on jo lisätty varaukseen!\n\nJos haluat muuttaa palveluiden " +
                        "määrää, poista palvelu\nensin varauksesta ja lisää se sitten uudestaan.");
                }
                else
                {
                    // Jos palvelua ei vielä ole listassa, lisätään se listaan.
                    lsv_Order_Summary_Services.Items.Add(listViewItem);
                }
            }
        }

        private void txt_Settings_User_Name_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default["user_name"] = txt_Settings_User_Name.Text.ToString();
            Properties.Settings.Default.Save();
        }

        private void btn_Order_Summary_Next_Page_Click(object sender, EventArgs e)
        {
            // Alustetaan tietojen lukija
            SqlDataReader myReader = null;
            // Määritellään tietokantayhteys.
            frm_Main_Window main_window = new frm_Main_Window();
            SqlConnection database_connection = main_window.database_connection;
            // Varaus taulun päivitys
            DateTime varattu_pvm = DateTime.Now;
            DateTime varattu_alkupvm = dtp_Order_Start_Date.Value;
            DateTime varattu_loppupvm = dtp_Order_End_Date.Value;
            string lisatieto = txt_Order_Additional_Details.Text;
            // Määritellään tietokantakyselyt asiakkaiden lisäämiseksi ja muokkaamiseksi.
            SqlCommand database_query_varaus = new SqlCommand("INSERT INTO [Varaus] ([asiakas_id], [toimipiste_id], [varattu_pvm], " +
                "[varattu_alkupvm], [varattu_loppupvm], [lisatieto]) " +
                " VALUES(@asiakas_id, @toimipiste_id, @varattu_pvm,  " +
                "@varattu_alkupvm, @varattu_loppupvm, @lisatieto)");
            database_query_varaus.Connection = main_window.database_connection;
            database_connection.Open();
            database_query_varaus.Parameters.AddWithValue("@asiakas_id", Reservation_asiakas_id);
            database_query_varaus.Parameters.AddWithValue("@toimipiste_id", Reservation_toimipiste_id);
            database_query_varaus.Parameters.AddWithValue("@varattu_pvm", varattu_pvm);
            database_query_varaus.Parameters.AddWithValue("@varattu_alkupvm", varattu_alkupvm);
            database_query_varaus.Parameters.AddWithValue("@varattu_loppupvm", varattu_loppupvm);
            database_query_varaus.Parameters.AddWithValue("@lisatieto", lisatieto);
            database_query_varaus.ExecuteNonQuery();
            // Valitaan tietokannasta luodun varauksen id aikaleiman perusteella.
            SqlCommand database_query = new SqlCommand("SELECT * FROM Varaus WHERE varattu_pvm = @varattu_pvm");
            database_query.Connection = database_connection;
            database_query.Parameters.AddWithValue("@varattu_pvm", varattu_pvm);
            database_query.ExecuteNonQuery();
            myReader = database_query.ExecuteReader();
            string varaus_id = "";
            while (myReader.Read())
            {
                varaus_id = (myReader["varaus_id"].ToString());
            }
            database_connection.Close();
            // Varauksen_majoitus taulun päivitys
            // Toistetaan silmukkaa kunnes kaikki palvelut on lisätty varaukseen.
            foreach (ListViewItem cottage_rows in lsv_Order_Summary_Cottages.Items)
            {
                // Haetaan palvelun_id listan riviin liitetystä "Tag" arvosta.
                string majoitus_id = cottage_rows.Tag.ToString();
                // Regex filtteröi kappalemäärän seuraavasta muodosta: 
                // ListViewItem: {Rodeo [11]}
                var find_quantity = new Regex("[ ][[](\\d{1,10})[]][}]");
                Match match = find_quantity.Match(cottage_rows.ToString());
                string majoittujien_maara = match.Groups[1].Value;
                SqlCommand database_query_Varauksen_majoitus = new SqlCommand("INSERT INTO [Varauksen_majoitus] ([varaus_id], [majoitus_id], " +
                    "[majoittujien_maara]) VALUES(@varaus_id, @majoitus_id, @majoittujien_maara)");
                database_query_Varauksen_majoitus.Connection = main_window.database_connection;
                database_connection.Open();
                database_query_Varauksen_majoitus.Parameters.AddWithValue("@varaus_id", varaus_id);
                database_query_Varauksen_majoitus.Parameters.AddWithValue("@majoitus_id", majoitus_id);
                database_query_Varauksen_majoitus.Parameters.AddWithValue("@majoittujien_maara", majoittujien_maara);
                database_query_Varauksen_majoitus.ExecuteNonQuery();
                database_connection.Close();
            }
            // Varauksen_palvelut taulun päivitys
            // Toistetaan silmukkaa kunnes kaikki palvelut on lisätty varaukseen.
            foreach (ListViewItem itemRow in lsv_Order_Summary_Services.Items)
            {
                // Haetaan palvelun_id listan riviin liitetystä "Tag" arvosta.
                string palvelu_id = itemRow.Tag.ToString();
                // Regex filtteröi kappalemäärän seuraavasta muodosta: 
                // ListViewItem: {Rodeo [11]}
                var find_quantity = new Regex("[ ][[](\\d{1,10})[]][}]");
                Match match = find_quantity.Match(itemRow.ToString());
                string lkm = match.Groups[1].Value;
                SqlCommand database_query_Varauksen_palvelut = new SqlCommand("INSERT INTO [Varauksen_palvelut] ([varaus_id], [palvelu_id], [lkm]) " +
                    "VALUES(@varaus_id, @palvelu_id, @lkm)");
                database_query_Varauksen_palvelut.Connection = main_window.database_connection;
                database_connection.Open();
                database_query_Varauksen_palvelut.Parameters.AddWithValue("@varaus_id", varaus_id);
                database_query_Varauksen_palvelut.Parameters.AddWithValue("@palvelu_id", palvelu_id);
                database_query_Varauksen_palvelut.Parameters.AddWithValue("@lkm", lkm);
                database_query_Varauksen_palvelut.ExecuteNonQuery();
                database_connection.Close();
                // Loki taulun päivitys
                string paivittaja = Properties.Settings.Default["user_name"].ToString();
                string lisatieto_loki = "Luotiin varaus numero: " + varaus_id;
                SqlCommand database_query_loki = new SqlCommand("INSERT INTO [Loki] ([paivittaja], [lisatieto]) " +
                    "VALUES(@paivittaja, @lisatieto_loki)");
                database_query_loki.Connection = main_window.database_connection;
                database_connection.Open();
                database_query_loki.Parameters.AddWithValue("@paivittaja", paivittaja);
                database_query_loki.Parameters.AddWithValue("@lisatieto_loki", lisatieto_loki);
                database_query_loki.ExecuteNonQuery();
                database_connection.Close();
                // Päivitetään varaushistoria
                Get_order_history_to_grid();
            }
            // Tehhään lasku
            frm_Invoicing Invoice = new frm_Invoicing();
            SqlCommand database_query_Customer_invoicing = new SqlCommand("SELECT etunimi, sukunimi, email, lahiosoite, postinro, postitoimipaikka, asuinmaa FROM Asiakas WHERE asiakas_id = @asiakas_id");
            database_query_Customer_invoicing.Connection = main_window.database_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            database_connection.Open();
            database_query_Customer_invoicing.Parameters.AddWithValue("@asiakas_id", Reservation_asiakas_id);
            // Suoritetaan kysely
            database_query_Customer_invoicing.ExecuteNonQuery();
            // Alustetaan tietojen lukija
            myReader = database_query_Customer_invoicing.ExecuteReader();
            while (myReader.Read())
            {
                Invoice.customer_firstname = (myReader["etunimi"].ToString());
                Invoice.customer_secondname = (myReader["sukunimi"].ToString());
                Invoice.customer_email = (myReader["email"].ToString());
                Invoice.customer_address = (myReader["lahiosoite"].ToString());
                Invoice.customer_postal_code = (myReader["postinro"].ToString());
                Invoice.customer_post_office = (myReader["postitoimipaikka"].ToString());
                Invoice.customer_country = (myReader["asuinmaa"].ToString());
            }
            database_connection.Close();
            string[] arr_cottage = new string[6];
            SqlCommand database_query_Cottage_invoicing = new SqlCommand("SELECT nimi, hinta FROM Majoitus WHERE majoitus_id = @majoitus_id");
            database_query_Cottage_invoicing.Connection = database_connection;
            database_connection.Open();
            database_query_Cottage_invoicing.Parameters.AddWithValue("@majoitus_id", Reservation_Cottage_id);
            // Suoritetaan kysely
            database_query_Cottage_invoicing.ExecuteNonQuery();
            // Alustetaan tietojen lukija
            myReader = null;
            myReader = database_query_Cottage_invoicing.ExecuteReader();
            while (myReader.Read())
            {
                arr_cottage[0] = (myReader["nimi"].ToString());
                arr_cottage[3] = (myReader["hinta"].ToString());
            }
            database_connection.Close();
            SqlCommand database_query_Reservation_invoicing = new SqlCommand("SELECT varattu_alkupvm, varattu_loppupvm FROM Varaus WHERE varaus_id = @varaus_id");
            database_query_Reservation_invoicing.Connection = database_connection;
            database_connection.Open();
            database_query_Reservation_invoicing.Parameters.AddWithValue("@varaus_id", varaus_id);
            // Suoritetaan kysely
            database_query_Reservation_invoicing.ExecuteNonQuery();
            // Alustetaan tietojen lukija
            myReader = null;
            myReader = database_query_Reservation_invoicing.ExecuteReader();
            DateTime Start = new DateTime(2000, 01, 01);
            DateTime End = new DateTime(2001, 01, 01);
            while (myReader.Read())
            {
                DateTime.TryParse(myReader["varattu_alkupvm"].ToString(), out Start);
                DateTime.TryParse(myReader["varattu_loppupvm"].ToString(), out End);
            }
            database_connection.Close();
            Start = Start.Date;
            End = End.Date;
            arr_cottage[1] = Start.ToString("dd.MM.yyyy");
            arr_cottage[2] = End.ToString("dd.MM.yyyy");
            // Montako päivää ollaan matkalla
            double days = (End - Start).TotalDays + 1;
            arr_cottage[4] = days.ToString();
            // Päivähinta * päivät = hinta
            double first = double.Parse(arr_cottage[3]);
            int second = int.Parse(arr_cottage[4]);
            arr_cottage[5] =  (first * second).ToString(".00");
            if (days == 1)
            {
                arr_cottage[4] += " päivä";
            }
            else
            {
                arr_cottage[4] += " päivää";
            }
            ListViewItem itm_cottage;
            itm_cottage = new ListViewItem(arr_cottage);
            Invoice.lst_Invoicing.Items.Add(itm_cottage);
            foreach (ListViewItem itemRow in lsv_Order_Summary_Services.Items)
            {
                string[] arr_service = new string[6];
                string service_id = itemRow.Tag.ToString();
                SqlCommand database_query_Palveluiden_laskutus = new SqlCommand("SELECT * FROM Palvelu WHERE palvelu_id = @palvelu_id");
                database_query_Palveluiden_laskutus.Connection = database_connection;
                database_connection.Open();
                database_query_Palveluiden_laskutus.Parameters.AddWithValue("@palvelu_id", service_id);
                // Suoritetaan kysely
                database_query_Palveluiden_laskutus.ExecuteNonQuery();
                // Alustetaan tietojen lukija
                myReader = null;
                myReader = database_query_Palveluiden_laskutus.ExecuteReader();
                while (myReader.Read())
                {
                    arr_service[0] = (myReader["nimi"].ToString());
                    arr_service[3] = (myReader["hinta"].ToString());
                }
                database_connection.Close();
                var find_quantity = new Regex("[ ][[](\\d{1,10})[]][}]");
                Match match = find_quantity.Match(itemRow.ToString());
                string lkm = match.Groups[1].Value;
                arr_service[4] = lkm;
                // Tehhään lukumäärästä ja hinnasta intti ja sitte kertolasku niistä
                double one = double.Parse(arr_service[3]);
                double two = double.Parse(arr_service[4]);
                double sum = one * two;
                arr_service[5] = sum.ToString(".00");
                ListViewItem itm_service;
                itm_service = new ListViewItem(arr_service);
                Invoice.lst_Invoicing.Items.Add(itm_service);
            }
            double total = 0;
            foreach (ListViewItem item in Invoice.lst_Invoicing.Items)
            {
                total += double.Parse(item.SubItems[5].Text);
            }
            ListViewItem total_no_alv = new ListViewItem();
            total_no_alv.SubItems[0].Text = "Arvolisäveroton hinta yhteensä";
            double no_alv = total / 1.24;
            total_no_alv.SubItems.Add(no_alv.ToString(".00"));
            ListViewItem alv = new ListViewItem();
            alv.SubItems[0].Text = "Arvolisävero yhteensä";
            alv.SubItems.Add((total - no_alv).ToString(".00"));
            Invoice.lst_Invoicing_2nd_Row_Alv.Items.Add(total_no_alv);
            Invoice.lst_Invoicing_2nd_Row_Alv.Items.Add(alv);
            ListViewItem total_row = new ListViewItem();
            total_row.SubItems[0].Text = varaus_id;
            total_row.SubItems[0].Font =  new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            total_row.SubItems.Add("Lasku yhteensä euroa");
            total_row.SubItems.Add(total.ToString(".00"));
            Invoice.lst_Invoicing_Details_Summary.Items.Add(total_row);
            Invoice.reference_number = varaus_id;
            Invoice.total = total.ToString(".00");
            Invoice.Show();
        }

        private void btn_Order_Summary_Delete_From_List_Click(object sender, EventArgs e)
        {
            // Poistaa valitun varauksen yhteenvedon mökin tai palvelun. Jos ei valintaa, ei poistoja.
            foreach (ListViewItem cottage in lsv_Order_Summary_Cottages.SelectedItems)
            {
                lsv_Order_Summary_Cottages.Items.Remove(cottage);
                Reservation_Cottage_id = null;
            }
            foreach (ListViewItem service in lsv_Order_Summary_Services.SelectedItems)
            {
                lsv_Order_Summary_Services.Items.Remove(service);
            }
        }

        private void txt_History_Order_Search_TextChanged(object sender, EventArgs e)
        {
            Filter_history_orders();
        }

        private void btn_Services_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Services_All.SelectedRows.Count > 0)
            {
                // Haetaan valitun DataGridView kentän ID.
                int selectedrowindex = dgv_Services_All.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_Services_All.Rows[selectedrowindex];
                string palvelu_id = Convert.ToString(selectedRow.Cells["palvelu_id"].Value);
                // Tarkistetaan, onko valittu mökki liitetty mihinkään varaukseen
                SqlDataReader myReader = null;
                // Luodaan lista asiakkaan varausnumeroita varten.
                List<int> service_orders = new List<int>();
                SqlCommand database_query_get_service_reservations = new SqlCommand("SELECT varaus_id FROM Varauksen_palvelut WHERE palvelu_id = @palvelu_id");
                database_query_get_service_reservations.Connection = database_connection;
                database_connection.Open();
                // Haetaan id:n perusteella tietokannasta varaukset ja lisätään ne listaan.
                database_query_get_service_reservations.Parameters.AddWithValue("@palvelu_id", palvelu_id);
                database_query_get_service_reservations.ExecuteNonQuery();
                myReader = database_query_get_service_reservations.ExecuteReader();
                while (myReader.Read())
                {
                    service_orders.Add(Convert.ToInt32((myReader["varaus_id"])));
                }
                // Suljetaan yhteys ja tulostetaan virheilmoitus.
                database_connection.Close();
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
                    database_query.Connection = database_connection;
                    // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
                    database_connection.Open();
                    database_query.Parameters.AddWithValue("@palvelu_id", palvelu_id);
                    // Suoritetaan kysely, suljetaan tietokantayhteys ja päivitetään kentät.
                    database_query.ExecuteNonQuery();
                    database_connection.Close();
                    Get_service_names_to_grid();
                    // Filtteröidän myös varaus välilehden lista
                    Filter_management_services_by_office_and_text();
                    // Loki taulun päivitys
                    string lisatieto_loki = "Poistettiin palvelu nro: " + palvelu_id;
                    SqlCommand database_query_loki = new SqlCommand("INSERT INTO [Loki] ([paivittaja], [lisatieto]) " +
                        "VALUES(@paivittaja, @lisatieto_loki)");
                    database_query_loki.Connection = database_connection;
                    database_connection.Open();
                    database_query_loki.Parameters.AddWithValue("@paivittaja", Properties.Settings.Default["user_name"].ToString());
                    database_query_loki.Parameters.AddWithValue("@lisatieto_loki", lisatieto_loki);
                    database_query_loki.ExecuteNonQuery();
                    database_connection.Close();
                }
            }
        }

        private void btn_Cottages_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Cottages_All.SelectedRows.Count > 0)
            {
                // Haetaan valitun DataGridView kentän ID.
                int selectedrowindex = dgv_Cottages_All.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_Cottages_All.Rows[selectedrowindex];
                string majoitus_id = Convert.ToString(selectedRow.Cells["majoitus_id"].Value);
                // Tarkistetaan, onko valittu mökki liitetty mihinkään varaukseen
                SqlDataReader myReader = null;
                List<int> service_cottages = new List<int>();
                SqlCommand database_query_get_cottage_reservations = new SqlCommand("SELECT varaus_id FROM Varauksen_majoitus WHERE majoitus_id = @majoitus_id");
                database_query_get_cottage_reservations.Connection = database_connection;
                database_connection.Open();
                // Haetaan id:n perusteella tietokannasta varaukset ja lisätään ne listaan.
                database_query_get_cottage_reservations.Parameters.AddWithValue("@majoitus_id", majoitus_id);
                database_query_get_cottage_reservations.ExecuteNonQuery();
                myReader = database_query_get_cottage_reservations.ExecuteReader();
                while (myReader.Read())
                {
                    service_cottages.Add(Convert.ToInt32((myReader["varaus_id"])));
                }
                // Suljetaan yhteys ja tulostetaan virheilmoitus.
                database_connection.Close();
                // Jos  palvelu löytyy jostakin varauksesta, tulostetaan palveluun yhdistetyt varaukset virheilmoituksessa.
                if (service_cottages.Count > 0)
                {
                    var all_service_cottages = string.Join(",  ", service_cottages);
                    MessageBox.Show("Virhe! Mökki on yhdistetty seuraaviin varausnumeroihin:\n\n" +
                        all_service_cottages + "\n\nJos haluat poistaa tämän mökin, on sinun ensin " +
                        "poistettava\nkaikki tämän mökin sisältävät varaukset varaushistoriasta.");
                }
                else
                {
                    // Tietokantakysely
                    SqlCommand database_query = new SqlCommand("DELETE FROM Majoitus WHERE majoitus_id = @majoitus_id");
                    database_query.Connection = database_connection;
                    // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
                    database_connection.Open();
                    database_query.Parameters.AddWithValue("@majoitus_id", majoitus_id);
                    // Suoritetaan kysely, suljetaan tietokantayhteys ja päivitetään kentät.
                    database_query.ExecuteNonQuery();
                    database_connection.Close();
                    Get_cottage_names_to_grid();
                    Filter_management_cottages_by_office_and_text();
                    // Loki taulun päivitys
                    string lisatieto_loki = "Poistettiin mökki nro: " + majoitus_id;
                    SqlCommand database_query_loki = new SqlCommand("INSERT INTO [Loki] ([paivittaja], [lisatieto]) " +
                        "VALUES(@paivittaja, @lisatieto_loki)");
                    database_query_loki.Connection = database_connection;
                    database_connection.Open();
                    database_query_loki.Parameters.AddWithValue("@paivittaja", Properties.Settings.Default["user_name"].ToString());
                    database_query_loki.Parameters.AddWithValue("@lisatieto_loki", lisatieto_loki);
                    database_query_loki.ExecuteNonQuery();
                    database_connection.Close();
                }
            }
        }

        private void tab_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hide_datagridview_id_fields_and_reset_search();
        }

        string Management_toimipiste_id;
        private void cbo_Office_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            Combo_box_item item = new Combo_box_item();
            Management_toimipiste_id = (cbo_Office_Select.SelectedItem as Combo_box_item).Value.ToString();
            // Filtteröidään mökit ja palvelut toimipisteen + hakukentän mukaan.
            Filter_management_cottages_by_office_and_text();
            Filter_management_services_by_office_and_text();
        }

        private void dgv_History_Orders_All_SelectionChanged(object sender, EventArgs e)
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
                database_query_order_basic_details.Connection = database_connection;
                database_connection.Open();
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
                database_connection.Close();
                // Toimipisteen nimen haku
                SqlCommand database_query_order_office_name = new SqlCommand("SELECT nimi FROM Toimipiste WHERE toimipiste_id = @toimipiste_id ");
                database_query_order_office_name.Connection = database_connection;
                database_connection.Open();
                database_query_order_office_name.Parameters.AddWithValue("@toimipiste_id", toimipiste_id);
                database_query_order_office_name.ExecuteNonQuery();
                myReader = database_query_order_office_name.ExecuteReader();
                while (myReader.Read())
                {
                    lbl_History_Selected_Order_Office.Text = "Toimipiste: " + (myReader["nimi"].ToString());
                }
                database_connection.Close();
                // Asiakkaan nimen haku
                SqlCommand database_query_order_customer_name = new SqlCommand("SELECT kokonimi FROM Asiakas WHERE asiakas_id = @asiakas_id ");
                database_query_order_customer_name.Connection = database_connection;
                database_connection.Open();
                database_query_order_customer_name.Parameters.AddWithValue("@asiakas_id", asiakas_id);
                database_query_order_customer_name.ExecuteNonQuery();
                myReader = database_query_order_customer_name.ExecuteReader();
                while (myReader.Read())
                {
                    lbl_History_Selected_Order_Customer.Text = "Asiakas: " + (myReader["kokonimi"].ToString());
                }
                database_connection.Close();
                // Majoitustietojen haku
                var cottage_ids_and_quantities = new Dictionary<int, int>();
                string majoitus_nimi = "";
                SqlCommand database_query_order_cottage_details = new SqlCommand("SELECT * FROM Varauksen_majoitus WHERE varaus_id = @varaus_id");
                database_query_order_cottage_details.Connection = database_connection;
                database_connection.Open();
                database_query_order_cottage_details.Parameters.AddWithValue("@varaus_id", varaus_id);
                database_query_order_cottage_details.ExecuteNonQuery();
                myReader = database_query_order_cottage_details.ExecuteReader();
                while (myReader.Read())
                {
                    cottage_ids_and_quantities.Add(Convert.ToInt32((myReader["majoitus_id"])), Convert.ToInt32((myReader["majoittujien_maara"])));
                }
                database_connection.Close();
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
                    database_query_order_cottage_text_details.Connection = database_connection;
                    database_connection.Open();
                    // Haetaan majoitus_id:n perusteella majoituksen nimi.
                    database_query_order_cottage_text_details.Parameters.AddWithValue("@majoitus_id", cottage_id);
                    database_query_order_cottage_text_details.ExecuteNonQuery();
                    myReader = database_query_order_cottage_text_details.ExecuteReader();
                    while (myReader.Read())
                    {
                        majoitus_nimi = (myReader["nimi"]).ToString();

                    }
                    // Suljetaan yhteys ja lisätään varauksen mökki listview näkymään.
                    database_connection.Close();
                    lsv_History_Order_Cottages.Items.Add(majoitus_nimi + " [" + persons + "]");
                }

                // Palveluiden haku
                var service_ids_and_quantities = new Dictionary<int, int>();
                string palvelun_nimi = "";
                SqlCommand database_query_order_service_details = new SqlCommand("SELECT * FROM Varauksen_palvelut WHERE varaus_id = @varaus_id");
                database_query_order_service_details.Connection = database_connection;
                database_connection.Open();
                database_query_order_service_details.Parameters.AddWithValue("@varaus_id", varaus_id);
                database_query_order_service_details.ExecuteNonQuery();
                myReader = database_query_order_service_details.ExecuteReader();
                while (myReader.Read())
                {
                    service_ids_and_quantities.Add(Convert.ToInt32((myReader["palvelu_id"])), Convert.ToInt32((myReader["lkm"])));
                }
                database_connection.Close();
                // Lisätään varauksen palvelut varaushistorian yhteenvetoon
                List<int> order_services = new List<int>(service_ids_and_quantities.Keys);
                // Käydään kaikki taulun arvot läpi.
                foreach (int service_id in order_services)
                {
                    // Mökissä majoittuvien määrä
                    int quantity = service_ids_and_quantities[service_id];
                    // Tietokantakomento on määriteltävä uudestaan jokaisessa silmukassa, muuten @majoitus_id ei ole uniikki ja johtaa virheeseen.
                    SqlCommand database_query_order_service_text_details = new SqlCommand("SELECT Nimi FROM Palvelu WHERE palvelu_id = @palvelu_id");
                    database_query_order_service_text_details.Connection = database_connection;
                    database_connection.Open();
                    // Haetaan majoitus_id:n perusteella majoituksen nimi.
                    database_query_order_service_text_details.Parameters.AddWithValue("@palvelu_id", service_id);
                    database_query_order_service_text_details.ExecuteNonQuery();
                    myReader = database_query_order_service_text_details.ExecuteReader();
                    while (myReader.Read())
                    {
                        palvelun_nimi = (myReader["nimi"]).ToString();

                    }
                    // Suljetaan yhteys ja lisätään varauksen mökki listview näkymään.
                    database_connection.Close();
                    lsv_History_Order_Services.Items.Add(palvelun_nimi + " [" + quantity + "]");
                }
            }
        }

        private void btn_History_Limit_To_Office_Click(object sender, EventArgs e)
        {
            lbl_History_Order_Filter_Office.Text = "Toimipiste: " + cbo_History_Office_Select.Text.ToString();
            history_toimipiste_id = (cbo_History_Office_Select.SelectedItem as Combo_box_item).Value.ToString();
            Filter_history_orders();
        }

        private void btn_History_Limit_To_Customer_Click(object sender, EventArgs e)
        {
            // Asetetaan asiakkaan nimi rajoittimiin.
            string customer_name = dgv_Order_Customers_All.CurrentCell.Value.ToString();
            lbl_History_Order_Filter_Customer.Text = ("Asiakas: " + customer_name);
            foreach (DataGridViewRow row in dgv_History_Customers_All.SelectedRows)
            {
                history_asiakas_id = row.Cells[0].Value.ToString();
            }
            Filter_history_orders();
        }

        private void btn_History_Order_Filter_Reset_Click(object sender, EventArgs e)
        {
            history_asiakas_id = "";
            history_toimipiste_id = "";
            lbl_History_Order_Filter_Customer.Text = ("Asiakas: -");
            lbl_History_Order_Filter_Office.Text = ("Toimipiste: -");
            txt_History_Order_Search.Text = "";
            dtp_History_Orders_Filter_Date_End.Value = DateTime.Today;
            Filter_history_orders();
        }

        private void dtp_History_Orders_Filter_Date_End_ValueChanged(object sender, EventArgs e)
        {
            // Lisätään päivään kellonajaksi 23:59:59, näin kaikki valitun päivän varaukset näytetään listassa.
            dtp_History_Orders_Filter_Date_End.Value = dtp_History_Orders_Filter_Date_End.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            Filter_history_orders();
        }

        private void btn_History_Order_History_Del_Click(object sender, EventArgs e)
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
                database_query_order_cottage_details.Connection = database_connection;
                database_connection.Open();
                database_query_order_cottage_details.Parameters.AddWithValue("@varaus_id", varaus_id_to_delete);
                database_query_order_cottage_details.ExecuteNonQuery();
                database_connection.Close();
                // Varauksen_palvelut poisto
                SqlCommand database_query_order_service_details = new SqlCommand("DELETE FROM Varauksen_palvelut WHERE varaus_id = @varaus_id");
                database_query_order_service_details.Connection = database_connection;
                database_connection.Open();
                database_query_order_service_details.Parameters.AddWithValue("@varaus_id", varaus_id_to_delete);
                database_query_order_service_details.ExecuteNonQuery();
                database_connection.Close();
                // Varaus poisto
                SqlCommand database_query_order_basic_details = new SqlCommand("DELETE FROM Varaus WHERE varaus_id = @varaus_id ");
                database_query_order_basic_details.Connection = database_connection;
                database_connection.Open();
                database_query_order_basic_details.Parameters.AddWithValue("@varaus_id", varaus_id_to_delete);
                database_query_order_basic_details.ExecuteNonQuery();
                database_connection.Close();
            }
            // Päivitetään historia ja resetoidaan kentät.
            lbl_History_Order_Start.Text = "Alkamispäivä";
            lbl_History_Order_End.Text = "Päättymispäivä:";
            lbl_History_Selected_Order_Office.Text = "Toimipiste:";
            lbl_History_Selected_Order_Customer.Text = "Asiakas:";
            txt_History_Order_Additional_Details.Clear();
            Get_order_history_to_grid();

        }

        private void btn_log_update_grid_Click(object sender, EventArgs e)
        {
            Get_log_events_to_grid();
        }

        private void btn_Office_Delete_Click(object sender, EventArgs e)
        {
            // Tarkistetaan ensin, onko järjestelmässä yhtään toimipistettä.
            if (cbo_Office_Select.Items.Count == 0)
            {
                // Jos ei, tulostetaan virheilmoitus ja perutaan uuden mökin luonti.
                MessageBox.Show("Virhe! Järjestelmässä ei ole yhtään toimipistettä, lisää ensin toimipiste.");
                return;
            }
            DialogResult Confirm_delete = MessageBox.Show("Haluatko varmasti poistaa toimipisteen: \"" + cbo_Office_Select.Text.ToString() + 
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
            string default_office = Properties.Settings.Default["default_office"].ToString();
            // Yritetään poistaa toimipistettä tietokannasta
            try
            {
                SqlCommand database_query = new SqlCommand("DELETE FROM Toimipiste WHERE toimipiste_id = @toimipiste_id");
                database_query.Connection = database_connection;
                database_connection.Open();
                database_query.Parameters.AddWithValue("@toimipiste_id", toimipiste_id);
                database_query.ExecuteNonQuery();
                database_connection.Close();
                Get_office_names_to_combo();
                // Loki taulun päivitys
                string lisatieto_loki = "Poistettiin toimipiste nro: " + toimipiste_id;
                SqlCommand database_query_loki = new SqlCommand("INSERT INTO [Loki] ([paivittaja], [lisatieto]) " +
                    "VALUES(@paivittaja, @lisatieto_loki)");
                database_query_loki.Connection = database_connection;
                database_connection.Open();
                database_query_loki.Parameters.AddWithValue("@paivittaja", Properties.Settings.Default["user_name"].ToString());
                database_query_loki.Parameters.AddWithValue("@lisatieto_loki", lisatieto_loki);
                database_query_loki.ExecuteNonQuery();
                database_connection.Close();
                Get_office_names_to_combo();
            }
            // Yritys epäonnistuu tietokannan viite-eheyden rikkoutumiseen.
            catch (SqlException)
            {
                // Suljetaan "try" lohkossa avattu tietokantayhteys ja alustetaan tietojen lukija.
                database_connection.Close();
                SqlDataReader myReader = null;
                // Luodaan lista asiakkaan varausnumeroita varten.
                List<int> office_orders = new List<int>();
                SqlCommand database_query_get_office_orders = new SqlCommand("SELECT varaus_id FROM Varaus WHERE toimipiste_id = @toimipiste_id");
                database_query_get_office_orders.Connection = database_connection;
                database_connection.Open();
                // Haetaan asiakas_id:n perusteella tietokannasta varaukset ja lisätään ne listaan.
                database_query_get_office_orders.Parameters.AddWithValue("@toimipiste_id", toimipiste_id);
                database_query_get_office_orders.ExecuteNonQuery();
                myReader = database_query_get_office_orders.ExecuteReader();
                while (myReader.Read())
                {
                    office_orders.Add(Convert.ToInt32((myReader["varaus_id"])));
                }
                // Suljetaan yhteys ja tulostetaan virheilmoitus.
                database_connection.Close();
                var all_office_orders = string.Join(",  ", office_orders);
                MessageBox.Show("Virhe! Toimipiste on yhdistetty seuraaviin varausnumeroihin:\n\n" +
                    all_office_orders + "\n\nJos haluat poistaa tämän toimipisteen, on sinun ensin " +
                    "poistettava\nkaikki tähän toimipisteeseen liitetyt varaukset varaushistoriasta.");
            }
        }
    }
}
