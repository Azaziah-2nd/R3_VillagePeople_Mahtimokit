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
            string postinro = txt_Customer_Postal_Code.Text;
            string postitoimipaikka = txt_Customer_City.Text;
            string asuinmaa = txt_Customer_Country.Text;
            // Tietojen tarkastus
            Common_methods common_methods = new Common_methods();
            if (string.IsNullOrWhiteSpace(etunimi))
            {
                MessageBox.Show("Virhe! Etunimi ei voi olla tyhjä!");
                return;
            }
            if (string.IsNullOrWhiteSpace(sukunimi))
            {
                MessageBox.Show("Virhe! Sukunimi ei voi olla tyhjä!");
                return;
            }
            // Sähköpostin tarkistus.
            // Jos sähköposti ei ole tyhjä.
            if (email.Length > 0)
            {
                // Sähköpostin oikeellisuus tarkistetaan Verify_email metodilla.
                if (common_methods.Is_email_valid(email) == false)
                { 
                    return;
                }
            }
            // Puhelinnumeron tarkistus
            if (puhelinnro.Length > 0)
            {
                if (common_methods.Is_phone_valid(puhelinnro) == false)
                {
                    return;
                }
            }
            // Osoitteen tarkistus
            if (common_methods.Is_adress_valid(lahiosoite) == false)
            {
                return;
            }
            if (common_methods.Is_zip_code_valid(postinro) == false)
            {
                return;
            }
            // Postitoimipaikan tarkistus
            if (common_methods.Is_post_office_valid(postitoimipaikka) == false)
            {
                return;
            }
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
            // Jos muokataan asiakasta.
            string lisatieto_loki = "";
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
                lisatieto_loki = "Muokattiin asiakasta: " + kokonimi + " (asiakas nro.: " + Asiakas_id +")";
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
                lisatieto_loki = "Luotiin asiakas: " + kokonimi;
            }
            // Loki taulun päivitys
            common_methods.Update_log(lisatieto_loki);
            // Suljetaan formi.
            this.Close();
        }
    }
}
