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
    public partial class frm_Office_Popup : Form
    {
        public frm_Office_Popup()
        {
            InitializeComponent();
        }

        private void Office_popup_Load(object sender, EventArgs e)
        {

        }

        private void btn_Office_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Is_office_edited;
        public string Office_id;
        private void btn_Office_Save_Click(object sender, EventArgs e)
        {
            // Muunnetaan textbox kenttien arvot tekstimuotoon ja asetetaan ne muuttujiin.
            string nimi = txt_Office_Name.Text;
            string lahiosoite = txt_Office_Adress.Text;
            string postinro = txt_Office_Postal_Code.Text;
            string postitoimipaikka = txt_Office_City.Text;
            string email = txt_Office_Email.Text;
            string puhelinnro = txt_Office_Phone.Text;
            // Tietojen tarkistus
            Common_methods common_methods = new Common_methods();
            if (string.IsNullOrWhiteSpace(nimi))
            {
                MessageBox.Show("Virhe! Nimi ei voi olla tyhjä!");
                return;
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
            if (common_methods.Is_post_office_valid(postitoimipaikka) == false)
            {
                return;
            }
            // Sähköpostin ja puhelinnumeroiden tarkistus (voivat olla tyhjiä)
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
            // Määritellään tietokantayhteys.
            frm_Main_Window main_window = new frm_Main_Window();
            SqlConnection database_connection = main_window.database_connection;
            // Määritellään tietokantakyselyt asiakkaiden lisäämiseksi ja muokkaamiseksi.
            SqlCommand database_query_new = new SqlCommand("INSERT INTO [Toimipiste] ([nimi], [lahiosoite], [postinro], [postitoimipaikka], " +
                "[email], [puhelinnro]) VALUES (@nimi, @lahiosoite, @postinro, @postitoimipaikka, @email, @puhelinnro)");
            SqlCommand database_query_update = new SqlCommand("UPDATE Toimipiste SET nimi = @nimi, lahiosoite=@lahiosoite, postinro=@postinro, " +
                "postitoimipaikka=@postitoimipaikka, email=@email, puhelinnro=@puhelinnro WHERE toimipiste_id = @toimipiste_id");
            string lisatieto_loki = "";
            // Jos muokataan asiakasta.
            if (this.Is_office_edited == true)
            {
                // Käytetään asiakkaan muokkauksen yhteyttä.
                database_query_update.Connection = main_window.database_connection;
                database_connection.Open();
                database_query_update.Parameters.AddWithValue("@toimipiste_id", Office_id);
                database_query_update.Parameters.AddWithValue("@nimi", nimi);
                database_query_update.Parameters.AddWithValue("@lahiosoite", lahiosoite);
                database_query_update.Parameters.AddWithValue("@postinro", postinro);
                database_query_update.Parameters.AddWithValue("@postitoimipaikka", postitoimipaikka);
                database_query_update.Parameters.AddWithValue("@email", email);
                database_query_update.Parameters.AddWithValue("@puhelinnro", puhelinnro);
                database_query_update.ExecuteNonQuery();
                database_connection.Close();
                // Loki taulun päivitys
                lisatieto_loki = "Muokattiin toimipistettä " + nimi + "toimipisteeseen nro.: " + Office_id;

            }
            // Jos luodaan uusi asiakas.
            else
            {
                // Käytetään uuden asiakkaan luonnin yhteyttä.
                database_query_new.Connection = main_window.database_connection;
                database_connection.Open();
                database_query_new.Parameters.AddWithValue("@nimi", nimi);
                database_query_new.Parameters.AddWithValue("@lahiosoite", lahiosoite);
                database_query_new.Parameters.AddWithValue("@postinro", postinro);
                database_query_new.Parameters.AddWithValue("@postitoimipaikka", postitoimipaikka);
                database_query_new.Parameters.AddWithValue("@email", email);
                database_query_new.Parameters.AddWithValue("@puhelinnro", puhelinnro);
                database_query_new.ExecuteNonQuery();
                database_connection.Close();
                // Loki taulun päivitys
                lisatieto_loki = "Luotiin toimipiste: " + nimi;
            }

            // Loki taulun päivitys
            common_methods.Update_log(lisatieto_loki);
            // Suljetaan formi.
            this.Close();
        }
    }
}
