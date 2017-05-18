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
    public partial class frm_Customer_Popup : Form
    {
        public frm_Customer_Popup(frm_Main_Window frm)
        {
            InitializeComponent();
        }

        private void btn_Customer_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Apumuuttujat asiakastietojen muokkaukseen, arvot pääikkunasta.
        public string Asiakas_id;
        public bool is_customer_edited;
        public void btn_Customer_Save_Click(object sender, EventArgs e)
        {
            // Muunnetaan textbox kenttien arvot tekstimuotoon ja asetetaan ne muuttujiin.
            string etunimi = txt_Customer_First_Name.Text;
            string sukunimi = txt_Customer_Surname.Text;
            string kokonimi = etunimi + " " + sukunimi;
            string email = txt_Customer_Email.Text;
            string puhelinnro = txt_Customer_Phone_Number.Text;
            string lahiosoite = txt_Customer_Adress.Text;
            string postinro = txt_Customere_Postal_Code.Text;
            string postitoimipaikka = txt_Customer_City.Text;
            string asuinmaa = txt_Customer_Country.Text;
            // Määritellään tietokantayhteys.
            frm_Main_Window main_window = new frm_Main_Window();
            SqlConnection database_connection = main_window.database_connection;
            // Määritellään tietokantakyselyt asiakkaiden lisäämiseksi ja muokkaamiseksi.
            SqlCommand database_query_new = new SqlCommand("INSERT INTO [Asiakas] ([etunimi], [sukunimi], [kokonimi], [lahiosoite], " +
                "[postitoimipaikka], [postinro], [asuinmaa], [email], [puhelinnro]) VALUES (@etunimi, @sukunimi, @kokonimi, @lahiosoite, " +
                "@postitoimipaikka, @postinro, @asuinmaa, @email, @puhelinnro)");
            SqlCommand database_query_update = new SqlCommand("UPDATE Asiakas SET etunimi=@etunimi, sukunimi=@sukunimi, kokonimi=@kokonimi, " +
                "lahiosoite=@lahiosoite, postitoimipaikka=@postitoimipaikka, postinro=@postinro, asuinmaa=@asuinmaa, email=@email, " +
                "puhelinnro=@puhelinnro WHERE asiakas_id = @asiakas_id");
            string paivittaja = Properties.Settings.Default["user_name"].ToString();
            // Jos muokataan asiakasta.
            if (this.is_customer_edited == true)
            {
                // Käytetään asiakkaan muokkauksen yhteyttä.
                database_query_update.Connection = main_window.database_connection;
                database_connection.Open();
                database_query_update.Parameters.AddWithValue("@asiakas_id", Asiakas_id);
                database_query_update.Parameters.AddWithValue("@etunimi", etunimi);
                database_query_update.Parameters.AddWithValue("@sukunimi", sukunimi);
                database_query_update.Parameters.AddWithValue("@kokonimi", kokonimi);
                database_query_update.Parameters.AddWithValue("@lahiosoite", lahiosoite);
                database_query_update.Parameters.AddWithValue("@postitoimipaikka", postitoimipaikka);
                database_query_update.Parameters.AddWithValue("@postinro", postinro);
                database_query_update.Parameters.AddWithValue("@asuinmaa", asuinmaa);
                database_query_update.Parameters.AddWithValue("@email", email);
                database_query_update.Parameters.AddWithValue("@puhelinnro", puhelinnro);
                database_query_update.ExecuteNonQuery();
                database_connection.Close();
                // Loki taulun päivitys
                string lisatieto_loki = "Muokattiin asiakasta: " + kokonimi + " (asiakas nro.: " + Asiakas_id +")";
                SqlCommand database_query_loki = new SqlCommand("INSERT INTO [Loki] ([paivittaja], [lisatieto]) " +
                    "VALUES(@paivittaja, @lisatieto_loki)");
                database_query_loki.Connection = main_window.database_connection;
                database_connection.Open();
                database_query_loki.Parameters.AddWithValue("@paivittaja", paivittaja);
                database_query_loki.Parameters.AddWithValue("@lisatieto_loki", lisatieto_loki);
                database_query_loki.ExecuteNonQuery();
                database_connection.Close();
            }
            // Jos luodaan uusi asiakas.
            else
            {
                // Käytetään uuden asiakkaan luonnin yhteyttä.
                database_query_new.Connection = main_window.database_connection;
                database_connection.Open();
                database_query_new.Parameters.AddWithValue("@etunimi", etunimi);
                database_query_new.Parameters.AddWithValue("@sukunimi", sukunimi);
                database_query_new.Parameters.AddWithValue("@kokonimi", kokonimi);
                database_query_new.Parameters.AddWithValue("@lahiosoite", lahiosoite);
                database_query_new.Parameters.AddWithValue("@postitoimipaikka", postitoimipaikka);
                database_query_new.Parameters.AddWithValue("@postinro", postinro);
                database_query_new.Parameters.AddWithValue("@asuinmaa", asuinmaa);
                database_query_new.Parameters.AddWithValue("@email", email);
                database_query_new.Parameters.AddWithValue("@puhelinnro", puhelinnro);
                database_query_new.ExecuteNonQuery();
                database_connection.Close();
                // Loki taulun päivitys
                string lisatieto_loki = "Luotiin asiakas: " + kokonimi;
                SqlCommand database_query_loki = new SqlCommand("INSERT INTO [Loki] ([paivittaja], [lisatieto]) " +
                    "VALUES(@paivittaja, @lisatieto_loki)");
                database_query_loki.Connection = main_window.database_connection;
                database_connection.Open();
                database_query_loki.Parameters.AddWithValue("@paivittaja", paivittaja);
                database_query_loki.Parameters.AddWithValue("@lisatieto_loki", lisatieto_loki);
                database_query_loki.ExecuteNonQuery();
                database_connection.Close();
            }
            // Suljetaan formi.
            this.Close();
        }
    }
}
