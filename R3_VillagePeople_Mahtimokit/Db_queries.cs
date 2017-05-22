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
    public class Db_queries
    {
        SqlDataReader myReader = null;
        public void Update_log(string lisatieto_loki)
        {
            // Loki taulun päivitys
            frm_Main_Window main_window = new frm_Main_Window();
            SqlCommand database_query_loki = new SqlCommand("INSERT INTO [Loki] ([paivittaja], [lisatieto]) " +
                "VALUES(@paivittaja, @lisatieto_loki)");
            database_query_loki.Connection = main_window.database_connection;
            main_window.database_connection.Open();
            database_query_loki.Parameters.AddWithValue("@paivittaja", Properties.Settings.Default["user_name"].ToString());
            database_query_loki.Parameters.AddWithValue("@lisatieto_loki", lisatieto_loki);
            database_query_loki.ExecuteNonQuery();
            main_window.database_connection.Close();
        }

        public void Generate_invoice(string Varaus_id)
        {
            // Luodaan uusi lasku
            // Varaus ID saadaan joko uudesta varauksesta tai varaushistorian listasta.
            frm_Invoicing Invoice = new frm_Invoicing();
            frm_Main_Window main_window = new frm_Main_Window();
            // Varauksen keston haku
            DateTime Start = new DateTime();
            DateTime End = new DateTime();
            string reservation_asiakas_id = "";
            SqlCommand database_query_Reservation_invoicing = new SqlCommand("SELECT asiakas_id, varattu_alkupvm, varattu_loppupvm FROM Varaus WHERE varaus_id = @varaus_id");
            database_query_Reservation_invoicing.Connection = main_window.database_connection;
            main_window.database_connection.Open();
            database_query_Reservation_invoicing.Parameters.AddWithValue("@varaus_id", Varaus_id);
            database_query_Reservation_invoicing.ExecuteNonQuery();
            // Alustetaan tietojen lukija
            myReader = database_query_Reservation_invoicing.ExecuteReader();
            while (myReader.Read())
            {
                reservation_asiakas_id = (myReader["asiakas_id"].ToString());
                DateTime.TryParse(myReader["varattu_alkupvm"].ToString(), out Start);
                DateTime.TryParse(myReader["varattu_loppupvm"].ToString(), out End);
            }
            main_window.database_connection.Close();
            // Asiakkaan tietojen haku
            SqlCommand database_query_Customer_invoicing = new SqlCommand("SELECT kokonimi, email, lahiosoite, postinro, postitoimipaikka, asuinmaa FROM Asiakas WHERE asiakas_id = @asiakas_id");
            database_query_Customer_invoicing.Connection = main_window.database_connection;
            main_window.database_connection.Open();
            database_query_Customer_invoicing.Parameters.AddWithValue("@asiakas_id", reservation_asiakas_id);
            database_query_Customer_invoicing.ExecuteNonQuery();
            myReader = database_query_Customer_invoicing.ExecuteReader();
            while (myReader.Read())
            {
                Invoice.customer_name = (myReader["kokonimi"].ToString());
                Invoice.customer_email = (myReader["email"].ToString());
                Invoice.customer_address = (myReader["lahiosoite"].ToString());
                Invoice.customer_postal_code = (myReader["postinro"].ToString());
                Invoice.customer_post_office = (myReader["postitoimipaikka"].ToString());
                Invoice.customer_country = (myReader["asuinmaa"].ToString());
            }
            main_window.database_connection.Close();
            /* Haetaan mökin tiedot arr_cottageen.
            /* 0 = Nimi
            /* 1 = Aloituspäivä
            /* 2 = Päättymispäivä
            /* 3 = Hinta
            /* 4 = Päivien määrä
            /* 5 = Hinta x päivät
            */
            string[] arr_cottage = new string[6];
            var cottage_ids_and_quantities = new Dictionary<int, int>();
            SqlCommand database_query_order_cottage_details = new SqlCommand("SELECT * FROM Varauksen_majoitus WHERE varaus_id = @varaus_id");
            database_query_order_cottage_details.Connection = main_window.database_connection;
            main_window.database_connection.Open();
            database_query_order_cottage_details.Parameters.AddWithValue("@varaus_id", Varaus_id);
            database_query_order_cottage_details.ExecuteNonQuery();
            myReader = database_query_order_cottage_details.ExecuteReader();
            while (myReader.Read())
            {
                cottage_ids_and_quantities.Add(Convert.ToInt32((myReader["majoitus_id"])), Convert.ToInt32((myReader["majoittujien_maara"])));
            }
            main_window.database_connection.Close();
            // Lisätään varauksen mökit varaushistorian yhteenvetoon
            // Luodaan läpikäytävä lista cottage_ids_and_quantities taulusta.
            List<int> order_cottages = new List<int>(cottage_ids_and_quantities.Keys);
            // Käydään kaikki taulun arvot läpi.
            foreach (int cottage_id in order_cottages)
            {
                // Tietokantakomento on määriteltävä uudestaan jokaisessa silmukassa, muuten @majoitus_id ei ole uniikki ja johtaa virheeseen.
                SqlCommand database_query_order_cottage_text_details = new SqlCommand("SELECT Nimi, hinta FROM Majoitus WHERE majoitus_id = @majoitus_id");
                database_query_order_cottage_text_details.Connection = main_window.database_connection;
                main_window.database_connection.Open();
                // Haetaan majoitus_id:n perusteella majoituksen nimi.
                database_query_order_cottage_text_details.Parameters.AddWithValue("@majoitus_id", cottage_id);
                database_query_order_cottage_text_details.ExecuteNonQuery();
                myReader = database_query_order_cottage_text_details.ExecuteReader();
                while (myReader.Read())
                {
                    arr_cottage[0] = (myReader["nimi"]).ToString();
                    arr_cottage[3] = (myReader["hinta"]).ToString();
                }
                // Suljetaan yhteys ja lisätään varauksen mökki listview näkymään.
                main_window.database_connection.Close();
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
            // Palveluiden haku
            string[] arr_service = new string[6];
            var service_ids_and_quantities = new Dictionary<int, int>();
            SqlCommand database_query_order_service_details = new SqlCommand("SELECT * FROM Varauksen_palvelut WHERE varaus_id = @varaus_id");
            database_query_order_service_details.Connection = main_window.database_connection;
            main_window.database_connection.Open();
            database_query_order_service_details.Parameters.AddWithValue("@varaus_id", Varaus_id);
            database_query_order_service_details.ExecuteNonQuery();
            myReader = database_query_order_service_details.ExecuteReader();
            while (myReader.Read())
            {
                service_ids_and_quantities.Add(Convert.ToInt32((myReader["palvelu_id"])), Convert.ToInt32((myReader["lkm"])));
            }
            main_window.database_connection.Close();
            List<int> order_services = new List<int>(service_ids_and_quantities.Keys);
            // Lisätään varauksen palvelut varaushistorian yhteenvetoon
            foreach (int service_id in order_services)
                {
                    arr_service[4] = service_ids_and_quantities[service_id].ToString();
                    // Tietokantakomento on määriteltävä uudestaan jokaisessa silmukassa, muuten @majoitus_id ei ole uniikki ja johtaa virheeseen.
                    SqlCommand database_query_order_service_text_details = new SqlCommand("SELECT * FROM Palvelu WHERE palvelu_id = @palvelu_id");
                    database_query_order_service_text_details.Connection = main_window.database_connection;
                    main_window.database_connection.Open();
                    database_query_order_service_text_details.Parameters.AddWithValue("@palvelu_id", service_id);
                    database_query_order_service_text_details.ExecuteNonQuery();
                    myReader = database_query_order_service_text_details.ExecuteReader();
                    while (myReader.Read())
                    {
                        arr_service[0] = (myReader["nimi"].ToString());
                        arr_service[3] = (myReader["hinta"].ToString());
                    }
                    main_window.database_connection.Close();
                    double sum = double.Parse(arr_service[3]) * double.Parse(arr_service[4]);
                    arr_service[5] = sum.ToString(".00");
                    ListViewItem itm_service;
                    itm_service = new ListViewItem(arr_service);
                    Invoice.lst_Invoicing.Items.Add(itm_service);

                }
                // Viimeistellään laskun tiedot
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
                total_row.SubItems[0].Text = Varaus_id;
                total_row.SubItems[0].Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular);
                total_row.SubItems.Add("Lasku yhteensä euroa");
                total_row.SubItems.Add(total.ToString(".00"));
                Invoice.lsv_Invoicing_Details_Summary.Items.Add(total_row);
                Invoice.reference_number = Varaus_id;
                Invoice.total = total.ToString(".00");
                Invoice.Show();
            }
        }
}
