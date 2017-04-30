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
   
        private void btn_Customer_Save_Click(object sender, EventArgs e)
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
            SqlConnection database_connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                          AttachDbFilename=|DataDirectory|\VP_Database.mdf;
                          Integrated Security=True;
                          Connect Timeout=10;
                          User Instance=False");
            // Määritellään komento tietojen viemiseksi tietokantaan.
            SqlCommand database_query = new SqlCommand("INSERT INTO [Asiakas] ([etunimi], [sukunimi], [kokonimi], [lahiosoite], " +
                "[postitoimipaikka], [postinro], [asuinmaa], [email], [puhelinnro]) VALUES (@etunimi, @sukunimi, @kokonimi, @lahiosoite, " +
                "@postitoimipaikka, @postinro, @asuinmaa, @email, @puhelinnro)");
            database_query.Connection = database_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            database_connection.Open();
            database_query.Parameters.AddWithValue("@etunimi", etunimi);
            database_query.Parameters.AddWithValue("@sukunimi", sukunimi);
            database_query.Parameters.AddWithValue("@kokonimi", kokonimi);
            database_query.Parameters.AddWithValue("@lahiosoite", lahiosoite);
            database_query.Parameters.AddWithValue("@postitoimipaikka", postitoimipaikka);
            database_query.Parameters.AddWithValue("@postinro", postinro);
            database_query.Parameters.AddWithValue("@asuinmaa", asuinmaa);
            database_query.Parameters.AddWithValue("@email", email);
            database_query.Parameters.AddWithValue("@puhelinnro", puhelinnro);
            // Suoritetaan kysely, suljetaan tietokantayhteys ja suljetaan formi.
            database_query.ExecuteNonQuery();
            database_connection.Close();
            this.Close();
        }
    }
}
