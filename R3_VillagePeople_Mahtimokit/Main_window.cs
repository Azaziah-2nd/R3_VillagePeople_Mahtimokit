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
 
        Db_queries database = new Db_queries();
        /// <summary>
        /// 1. Yleinen ja käynnistys
        /// 2. Sekalaiset metodit
        /// 3. Uusi varaus välilehti
        /// 4. Tietojen hallinta välilehti
        /// 5. Varaushistoria välilehti
        /// 6. Asetukset ja loki välilehti
        /// </summary>
        //
        // 1. Yleinen ja käynnistys
        //
        // Määritellään tietokantayhteyden muodostin.

        public frm_Main_Window()
        {
            InitializeComponent();
            

        }



        private void Main_window_Load(object sender, EventArgs e)
        {
            Load_settings_and_dates();
            // Haetaan tiedot tietokannasta eri kenttiin.
            // Toimipisteiden haku täytyy suorittaa ensin, muuten mökkien ja palveluiden lisäys varaukseen ei toimi ennen
            // kuin listasta valitaan manuaalisesti jokin kohde. (null error, liittyy filtteröintiin)
            database.Get_office_names_to_combo();
            database.Get_customer_names_to_grid();
            database.Get_service_names_to_grid();
            database.Get_cottage_names_to_grid();
            database.Get_order_history_to_grid();
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
                dtp_History_Orders_Filter_Date_End.Value = DateTime.Today;
            }
            // Varaus välilehden päivät.
            dtp_Order_Start_Date.Value = DateTime.Today;
            dtp_Order_End_Date.Value = DateTime.Today.AddDays(1);
            // Isketään arvot laskutusasetuksiin
            txt_Options_Penalty_Interest.Text = Properties.Settings.Default["default_penalty_interest"].ToString().Trim('%');
            txt_Options_Remark_Time.Text = Properties.Settings.Default["default_remark_time"].ToString().Trim(' ', 'p', 'v');
            txt_Options_Infobox_1.Text = Properties.Settings.Default["default_infobox_1"].ToString();
            txt_Options_Infobox_2.Text = Properties.Settings.Default["default_infobox_2"].ToString();
            txt_Options_Infobox_3.Text = Properties.Settings.Default["default_infobox_3"].ToString();
            txt_Options_Infobox_4.Text = Properties.Settings.Default["default_infobox_4"].ToString();
            txt_Options_Infobox_5.Text = Properties.Settings.Default["default_infobox_5"].ToString();
            txt_Options_IBAN.Text = Properties.Settings.Default["default_IBAN"].ToString();
            txt_Options_BIC.Text = Properties.Settings.Default["default_BIC"].ToString();
            txt_Options_Receiver.Text = Properties.Settings.Default["default_receiver"].ToString();
        }
        // Tietojen päivitys formien sulkemisen yhteydessä.
        public void Get_customer_names_to_grid_on_close_event(object sender, FormClosedEventArgs e)
        {
            database.Get_customer_names_to_grid();
            Hide_datagridview_id_fields_and_reset_search();
        }

        public void Get_office_names_to_combo_on_close_event(object sender, FormClosedEventArgs e)
        {
            database.Get_office_names_to_combo();
            Hide_datagridview_id_fields_and_reset_search();
        }
        public void Get_service_names_to_grid_on_close_event(object sender, FormClosedEventArgs e)
        {
            database.Get_service_names_to_grid();
            Hide_datagridview_id_fields_and_reset_search();
        }
        public void Get_cottage_names_to_grid_on_close_event(object sender, FormClosedEventArgs e)
        {
            database.Get_cottage_names_to_grid();
            Hide_datagridview_id_fields_and_reset_search();
        }
        //
        // 2. Sekalaiset metodit.
        //
        public void Hide_datagridview_id_fields_and_reset_search()
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
                dgv_Order_Services_All.Columns[1].Visible = false;
                dgv_Order_Services_All.Columns[3].Visible = false;
                dgv_Order_Cottages_All.Columns[0].Visible = false;
                dgv_Order_Cottages_All.Columns[1].Visible = false;
                dgv_Order_Cottages_All.Columns[3].Visible = false;
                Filter_order_cottages_by_dates_office_and_text();
                Filter_order_services_by_office_and_text();
            }
            else if (tab_index == 1)
            {
                dgv_Customers_All.Columns[0].Visible = false;
                dgv_Services_All.Columns[0].Visible = false;
                dgv_Services_All.Columns[1].Visible = false;
                dgv_Services_All.Columns[3].Visible = false;
                dgv_Cottages_All.Columns[0].Visible = false;
                dgv_Cottages_All.Columns[1].Visible = false;
                dgv_Cottages_All.Columns[3].Visible = false;
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

        private void tab_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hide_datagridview_id_fields_and_reset_search();
        }
        //
        // 3. Uusi varaus välilehti
        //
        private void Get_Cottage_Max_Quantity()
        {
            foreach (DataGridViewRow row in dgv_Order_Cottages_All.SelectedRows)
            {
                try
                {
                    //  Cell 3 = Max majoittujat.
                    int cottage_max_quantity = Convert.ToInt32(row.Cells[3].Value.ToString());
                    lbl_Order_Cottage_Max_Persons.Text = "Max hlö: " + cottage_max_quantity;
                }
                catch (NullReferenceException)
                {
                    // Tämä voi joskus johtaa null erroriin, mikäli metodi kutsutaan ennen kuin data ehtii lataantua.
                }
            }
        }

        private void Get_Service_Max_Quantity()
        {
            foreach (DataGridViewRow row in dgv_Order_Services_All.SelectedRows)
            {
                try
                {
                    //  Cell 3 = Max majoittujat.
                    int service_max_quantity = Convert.ToInt32(row.Cells[3].Value.ToString());
                    lbl_Order_Services_Max_Quantity.Text = "Max kpl: " + service_max_quantity;
                }
                catch (NullReferenceException)
                {
                    // Tämä voi joskus johtaa null erroriin, mikäli metodi kutsutaan ennen kuin data ehtii lataantua.
                }
            }
        }

        // Päivämäärien tarkistus ja lisäys varaukseen.
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
            if (dtp_Order_Start_Date.Value < DateTime.Today)
            {
                dtp_Order_Start_Date.Value = DateTime.Today;
                MessageBox.Show("Virhe! Et voi valita varauksen alkamispäiväksi mennyttä päivää.");
            }
            // Tarkistetaan onko alkamispäivä päättymispäivän jälkeen.
            if (dtp_Order_Start_Date.Value > dtp_Order_End_Date.Value)
            {
                // Jos kyllä, muutetaan päättymispäiväksi alkamispäivä + 1 päivä.
                dtp_Order_End_Date.Value = dtp_Order_Start_Date.Value.AddDays(1);
            }
            Get_start_date_to_order_summary();
            // Päivitetään myös mökkien näkyvyys, siten että vain vapaat mökit näytetään.
            Filter_order_cottages_by_dates_office_and_text();
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
                dtp_Order_Start_Date.Value = dtp_Order_End_Date.Value.AddDays(-1);
            }
            // Päivitetään myös mökkien näkyvyys, siten että vain vapaat mökit näytetään.
            Filter_order_cottages_by_dates_office_and_text();
        }


        private void Filter_order_cottages_by_dates_office_and_text()
        {
            // Tarkistetaan mökkien saatavuus päivien perusteella.
            database.Get_order_cottages_within_dates();
            // Filtteröidään mökit toimipisteen + hakukentän mukaan.
            BindingSource cottage_list = new BindingSource();
            cottage_list.DataSource = dgv_Order_Cottages_All.DataSource;
            string filer_cottages = "";
            string cottages_within_orders = database.Cottages_within_orders;
            if (cottages_within_orders != "")
            {
                // Jos mökkejä on yhdistetty varauksiin valitulla aikavälillä.
                filer_cottages = string.Format("CONVERT(majoitus_id, 'System.String') NOT IN ({0}) AND CONVERT(toimipiste_id, 'System.String') LIKE '%{1}%' AND nimi LIKE '%{2}%'",
                                      cottages_within_orders, Reservation_toimipiste_id, txt_Order_Cottages_Search.Text);
            }
            else
            {
                // Jos ei ole yhdistetty varauksiin valitulla aikavälillä.
                filer_cottages = string.Format("CONVERT(toimipiste_id, 'System.String') LIKE '%{0}%' AND nimi LIKE '%{1}%'",
                                      Reservation_toimipiste_id, txt_Order_Cottages_Search.Text);
            }
            cottage_list.Filter = filer_cottages;
            Get_Cottage_Max_Quantity();
            Get_Service_Max_Quantity();

        }

        public void Filter_order_services_by_office_and_text()
        {
            // Filtteröidään palvelut toimipisteen + hakukentän mukaan.
            BindingSource service_list = new BindingSource();
            service_list.DataSource = dgv_Order_Services_All.DataSource;
            string filter_services = string.Format("CONVERT(toimipiste_id, 'System.String') LIKE '%{0}%' AND nimi LIKE '%{1}%'",
            Reservation_toimipiste_id, txt_Order_Services_Search.Text);
            service_list.Filter = filter_services;
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


        private void dgv_Order_Cottages_All_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Get_Cottage_Max_Quantity();
        }
        private void dgv_Order_Services_All_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Get_Service_Max_Quantity();
        }


        public string Reservation_toimipiste_id = "";
        string office_name = "";
        private void cbo_Order_Office_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            office_name = cbo_Order_Office_Select.Text.ToString();
            Combo_box_item item = new Combo_box_item();
            Reservation_toimipiste_id = (cbo_Order_Office_Select.SelectedItem as Combo_box_item).Value.ToString();
            lbl_Order_Summary_Office.Text = "Toimipiste: " + office_name;
            // Filtteröidään mökit ja palvelut toimipisteen + hakukentän mukaan.
            Filter_order_cottages_by_dates_office_and_text();
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

        public string Reservation_asiakas_id = "";
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
            if (is_quantity_valid == false || selected_quantity_int < 1)
            {
                MessageBox.Show("Virhe! Syöte: \"" + selected_quantity + "\" ei ole kelvollinen numero!");
                return;
            }
            int cottage_max_quantity = 0;
            if (dgv_Order_Cottages_All.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in dgv_Order_Cottages_All.SelectedRows)
                {
                    // Cell 0 = id, Cell 3 = Max majoittujat.
                    Reservation_Cottage_id = row.Cells[0].Value.ToString();
                    cottage_max_quantity = Convert.ToInt32(row.Cells[3].Value.ToString());
                }
                int selectedrowindex = dgv_Order_Cottages_All.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_Order_Cottages_All.Rows[selectedrowindex];
                string selected_cottage_name = dgv_Order_Cottages_All.CurrentCell.Value.ToString();
                if (selected_quantity_int > cottage_max_quantity)
                {
                    MessageBox.Show("Virhe! Mökissä \"" + selected_cottage_name + "\" voi majoittua enintään " + cottage_max_quantity + " henkilöä.");
                    return;
                }
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

        private void txt_Order_Services_Search_TextChanged(object sender, EventArgs e)
        {
            Filter_order_services_by_office_and_text();
        }

        private void txt_Order_Cottages_Search_TextChanged(object sender, EventArgs e)
        {
            Filter_order_cottages_by_dates_office_and_text();
        }

        private void btn_Order_Service_add_Click(object sender, EventArgs e)
        {
            // Haetaan lukumäärä
            string selected_quantity = txt_Order_Services_Quantity.Text.ToString();
            // Tarkistetaan, onko lukumäärä kelvollinen.
            int selected_quantity_int;
            bool is_quantity_valid = int.TryParse(selected_quantity, out selected_quantity_int);
            // Jos lkm on virheellinen, tulostetaan virheilmoitus ja keskeytetään metodin suoritus(return).
            if (is_quantity_valid == false || selected_quantity_int < 1)
            {
                MessageBox.Show("Virhe! Syöte: \"" + selected_quantity + "\" ei ole kelvollinen numero!");
                return;
            }
            string Reservation_service_id = "";
            int service_max_quantity = 0;
            if (dgv_Services_All.SelectedRows.Count > 0)
            {
                int selectedrowindex = dgv_Order_Services_All.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_Order_Services_All.Rows[selectedrowindex];
                Reservation_service_id = Convert.ToString(selectedRow.Cells["palvelu_id"].Value);
                service_max_quantity = Convert.ToInt32(selectedRow.Cells["max_osallistujat"].Value.ToString());
                string selected_service = dgv_Order_Services_All.CurrentCell.Value.ToString();

                if (selected_quantity_int > service_max_quantity)
                {
                    MessageBox.Show("Virhe! Palveluun \"" + selected_service + "\" voi osallistua enintään " + service_max_quantity + " henkilöä.");
                    return;
                }
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

        private void btn_Order_Summary_Next_Page_Click(object sender, EventArgs e)
        {
            if (lsv_Order_Summary_Cottages.Items.Count == 0 || lbl_Order_Summary_Customer.Text == "Asiakas:" || lbl_Order_Summary_Office.Text == "Toimipiste:")
            {
                MessageBox.Show("Virhe! Tilauksessa on oltava vähintään 1 mökki, asiakas ja toimipiste.");
                return;
            }
            // Alustetaan tietojen lukija
            SqlDataReader myReader = null;
            // Määritellään tietokantayhteys.
            frm_Main_Window main_window = new frm_Main_Window();
            SqlConnection database_connection = database.db_connection;
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
            database_query_varaus.Connection = database.db_connection;
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
                database_query_Varauksen_majoitus.Connection = database.db_connection;
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
                database_query_Varauksen_palvelut.Connection = database.db_connection;
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
                database_query_loki.Connection = database.db_connection;
                database_connection.Open();
                database_query_loki.Parameters.AddWithValue("@paivittaja", paivittaja);
                database_query_loki.Parameters.AddWithValue("@lisatieto_loki", lisatieto_loki);
                database_query_loki.ExecuteNonQuery();
                database_connection.Close();
                // Päivitetään varaushistoria
                database.Get_order_history_to_grid();
            }
            // Tehhään lasku
            frm_Invoicing Invoice = new frm_Invoicing();
            SqlCommand database_query_Customer_invoicing = new SqlCommand("SELECT etunimi, sukunimi, email, lahiosoite, postinro, postitoimipaikka, asuinmaa FROM Asiakas WHERE asiakas_id = @asiakas_id");
            database_query_Customer_invoicing.Connection = database.db_connection;
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

            foreach (ListViewItem itemRow in lsv_Order_Summary_Cottages.Items)
            {
                string[] arr_cottage = new string[6];
                SqlCommand database_query_Cottage_invoicing = new SqlCommand("SELECT nimi, hinta FROM Majoitus WHERE majoitus_id = @majoitus_id");
                database_query_Cottage_invoicing.Connection = database_connection;
                database_connection.Open();
                database_query_Cottage_invoicing.Parameters.AddWithValue("@majoitus_id", itemRow.Tag);
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
                arr_cottage[5] = (first * second).ToString(".00");
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
            }
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
            total_row.SubItems[0].Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
            total_row.SubItems.Add("Lasku yhteensä euroa");
            total_row.SubItems.Add(total.ToString(".00"));
            Invoice.lsv_Invoicing_Details_Summary.Items.Add(total_row);
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
        //
        // 4. Tietojen hallinta välilehti
        //
        public void Filter_management_services_by_office_and_text()
        {
            // Filtteröidään palvelut toimipisteen + hakukentän mukaan.
            BindingSource service_list = new BindingSource();
            service_list.DataSource = dgv_Services_All.DataSource;
            string filter_services = string.Format("CONVERT(toimipiste_id, 'System.String') LIKE '%{0}%' AND nimi LIKE '%{1}%'",
            Management_toimipiste_id, txt_Services_Search.Text);
            service_list.Filter = filter_services;
        }

        public void Filter_management_cottages_by_office_and_text()
        {
            // Filtteröidään palvelut toimipisteen + hakukentän mukaan.
            BindingSource service_list = new BindingSource();
            service_list.DataSource = dgv_Cottages_All.DataSource;
            string filter_services = string.Format("CONVERT(toimipiste_id, 'System.String') LIKE '%{0}%' AND nimi LIKE '%{1}%'",
            Management_toimipiste_id, txt_Cottages_Search.Text);
            service_list.Filter = filter_services;
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
                database.Delete_customer();
            }
        }

        private void txt_Services_Search_TextChanged(object sender, EventArgs e)
        {
            Filter_management_services_by_office_and_text();
        }

        private void btn_Office_Edit_Click(object sender, EventArgs e)
        {
            database.Edit_office();
        }

        private void btn_Office_Delete_Click(object sender, EventArgs e)
        {
            database.Delete_office();
        }

        private void btn_Customer_Edit_Click(object sender, EventArgs e)
        {
            database.Edit_customer();
        }

        private void btn_Services_Edit_Click(object sender, EventArgs e)
        {
            frm_Services_Popup frm = new frm_Services_Popup();
            frm.Is_service_edited = true;
            // Alustetaan tietojen lukija
            // Avataan asiakkaan tietojen muokkaus formi
            // Haetaan valitun DataGridView kentän ID.
            if (dgv_Services_All.SelectedRows.Count > 0)
            {
                frm.Show();
                database.Edit_service();
                frm.FormClosed += new FormClosedEventHandler(Get_service_names_to_grid_on_close_event);
            }

        }

        private void btn_Cottages_Edit_Click(object sender, EventArgs e)
        {
            database.Edit_cottage();
        }

        private void txt_Cottages_Search_TextChanged(object sender, EventArgs e)
        {
            Filter_management_cottages_by_office_and_text();
        }

        private void txt_History_Order_Search_TextChanged(object sender, EventArgs e)
        {
            Filter_history_orders();
        }

        private void btn_Services_Delete_Click(object sender, EventArgs e)
        {
            database.Delete_service();
        }

        private void btn_Cottages_Delete_Click(object sender, EventArgs e)
        {
            database.Delete_cottage();
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
        //
        // 5. Varaushistoria välilehti
        //
        string history_asiakas_id = "";
        string history_toimipiste_id = "";
        private void Filter_history_orders()
        {
            database.Get_history_orders_within_dates();
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
                filer_order_history = string.Format("CONVERT(varaus_id, 'System.String') IN ({0}) AND CONVERT(asiakas_id, 'System.String') LIKE '%{1}%' "
                    + "AND CONVERT(toimipiste_id, 'System.String') LIKE '%{2}%'"
                    + " AND CONVERT(varaus_id, 'System.String') LIKE '%{3}%'",
                     database.Orders_within_dates, history_asiakas_id, history_toimipiste_id, txt_History_Order_Search.Text);
            }
            // Jos ainoastaan asiakasfiltteröinti on asetettu.
            else if (history_asiakas_id != "")
            {
                filer_order_history = string.Format("CONVERT(varaus_id, 'System.String') IN ({0}) AND CONVERT(asiakas_id, 'System.String') LIKE '%{1}%' "
                    + "AND CONVERT(varaus_id, 'System.String') LIKE '%{2}%'",
                    database.Orders_within_dates, history_asiakas_id, txt_History_Order_Search.Text);
            }
            // Jos ainoastaan  toimipiste filtteröinti on asetettu.
            else if (history_toimipiste_id != "")
            {
                filer_order_history = string.Format("CONVERT(varaus_id, 'System.String') IN ({0}) AND CONVERT(toimipiste_id, 'System.String') LIKE '%{1}%' "
                    + "AND CONVERT(varaus_id, 'System.String') LIKE '%{2}%'",
                     database.Orders_within_dates, history_toimipiste_id, txt_History_Order_Search.Text);
            }
            // Jos kumpikaan ei ole asetettu, tapahtuu filtteröinti pelkän hakukentän mukaan.
            else
            {
                filer_order_history = string.Format("CONVERT(varaus_id, 'System.String') IN ({0}) AND CONVERT "
                    + "(varaus_id, 'System.String') LIKE '%{1}%'",
                        database.Orders_within_dates, txt_History_Order_Search.Text);
            }
            // Toteutetaan filtteröinti.
            try
            {
                order_history_list.Filter = filer_order_history;
            }
            catch(SyntaxErrorException)
            {
                // Valitulla aikavälillä ei löytynyt yhtään varausta > string arvo "" > syntaxerror.
                // Asetetaan varaus id:n fillteriksi = -1, näin voimme tyhjentää listan hakutuloksista.
                string hide_all_rows = "-1";
                filer_order_history = string.Format("CONVERT (varaus_id, 'System.String') LIKE '%{0}%'",
                    hide_all_rows);
                order_history_list.Filter = filer_order_history;
            }
        }

        private void dtp_History_Orders_Filter_Date_End_ValueChanged_1(object sender, EventArgs e)
        {
            // Tarkistetaan onko  päättymispäivä alkamispäivän jälkeen.
            if (dtp_History_Orders_Filter_Date_Start.Value > dtp_History_Orders_Filter_Date_End.Value)
            {
                // Jos ei, muutetaan alkamispäiväksi päättymispäivä  - 1 päivä.
                dtp_History_Orders_Filter_Date_Start.Value = dtp_History_Orders_Filter_Date_End.Value.AddDays(-1);
            }
            // Lisätään päättymisaikaan 23:59:59, näin samana päivänä luodut varaukser mäytetään.
            dtp_History_Orders_Filter_Date_End.Value = dtp_History_Orders_Filter_Date_End.Value.Date.AddHours(23).AddMinutes(59).AddSeconds(59);
            Filter_history_orders();
        }

        private void dtp_History_Orders_Filter_Date_Start_ValueChanged(object sender, EventArgs e)
        {
            // Tarkistetaan onko alkamispäivä päättymispäivän jälkeen.
            if (dtp_History_Orders_Filter_Date_Start.Value > dtp_History_Orders_Filter_Date_End.Value)
            {
                // Jos kyllä, muutetaan päättymispäiväksi alkamispäivä + 1 päivä.
                dtp_History_Orders_Filter_Date_End.Value = dtp_History_Orders_Filter_Date_Start.Value.AddDays(1);
            }
            Filter_history_orders();
        }

        private void dgv_History_Orders_All_SelectionChanged(object sender, EventArgs e)
        {
            database.Get_order_details();
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
            database.Delete_order();
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

        //
        // 6. Asetukset ja loki välilehti
        //
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

        private void btn_Options_Save_Invoicing_Click(object sender, EventArgs e)
        {
            Common_methods common_methods = new Common_methods();
            string penalty_intrest = txt_Options_Penalty_Interest.Text.ToString();
            string remark_time = txt_Options_Remark_Time.Text.ToString();
            // Tietojen tarkistus
            decimal parsed_decimal;
            bool is_penalty_valid = decimal.TryParse(penalty_intrest, out parsed_decimal);
            // Jos syöte on virheellinen, tulostetaan virheilmoitus ja keskeytetään metodin suoritus(return).
            if (is_penalty_valid == false)
            {
                MessageBox.Show("Virhe! Syöte: \"" + penalty_intrest + "\" ei ole kelvollinen numero!");
                return;
            }
            int parsed_int;
            bool is_remark_valid = int.TryParse(remark_time, out parsed_int);
            if (is_remark_valid == false)
            {
                MessageBox.Show("Virhe! Syöte: \"" + remark_time + "\" ei ole kelvollinen numero!");
                return;
            }
            Properties.Settings.Default["default_penalty_interest"] = txt_Options_Penalty_Interest.Text.ToString() + "%";
            Properties.Settings.Default["default_remark_time"] = txt_Options_Remark_Time.Text.ToString() + " pv";
            Properties.Settings.Default["default_infobox_1"] = txt_Options_Infobox_1.Text.ToString();
            Properties.Settings.Default["default_infobox_2"] = txt_Options_Infobox_2.Text.ToString();
            Properties.Settings.Default["default_infobox_3"] = txt_Options_Infobox_3.Text.ToString();
            Properties.Settings.Default["default_infobox_4"] = txt_Options_Infobox_4.Text.ToString();
            Properties.Settings.Default["default_infobox_5"] = txt_Options_Infobox_5.Text.ToString();
            Properties.Settings.Default["default_IBAN"] = txt_Options_IBAN.Text.ToString();
            Properties.Settings.Default["default_BIC"] = txt_Options_BIC.Text.ToString();
            Properties.Settings.Default["default_receiver"] = txt_Options_Receiver.Text.ToString();
            Properties.Settings.Default.Save();
            txt_Options_Penalty_Interest.Text = Properties.Settings.Default["default_penalty_interest"].ToString().Trim('%');
            txt_Options_Remark_Time.Text = Properties.Settings.Default["default_remark_time"].ToString().Trim(' ', 'p', 'v');
            txt_Options_Infobox_1.Text = Properties.Settings.Default["default_infobox_1"].ToString();
            txt_Options_Infobox_2.Text = Properties.Settings.Default["default_infobox_2"].ToString();
            txt_Options_Infobox_3.Text = Properties.Settings.Default["default_infobox_3"].ToString();
            txt_Options_Infobox_4.Text = Properties.Settings.Default["default_infobox_4"].ToString();
            txt_Options_Infobox_5.Text = Properties.Settings.Default["default_infobox_5"].ToString();
            txt_Options_IBAN.Text = Properties.Settings.Default["default_IBAN"].ToString();
            txt_Options_BIC.Text = Properties.Settings.Default["default_BIC"].ToString();
            txt_Options_Receiver.Text = Properties.Settings.Default["default_receiver"].ToString();
        }

        private void txt_Settings_User_Name_TextChanged(object sender, EventArgs e)
        {
            // Haetaan käyttäjänimi asetuksiin.
            string user_name = txt_Settings_User_Name.Text.ToString();
            if(string.IsNullOrWhiteSpace(user_name))
            {
                // Jos nimi on tyhjä asetetaan nimeksi "Määrittelemätön".
                user_name = "Määrittelemätön";
            }
            Properties.Settings.Default["user_name"] = user_name;
            Properties.Settings.Default.Save();
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

        private void btn_log_update_grid_Click(object sender, EventArgs e)
        {
            database.Get_log_events_to_grid();
        }
    }
}
