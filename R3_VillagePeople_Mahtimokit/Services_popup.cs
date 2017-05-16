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
    public partial class frm_Services_Popup : Form
    {
        public frm_Services_Popup()
        {
            InitializeComponent();
        }

        private void Services_popup_Load(object sender, EventArgs e)
        {
            // Haetaan toimipisteen comboboxiin tiedot tietokannasta.
            frm_Main_Window main_window = new frm_Main_Window();
            SqlDataReader myReader = null;
            SqlCommand database_query_toimipiste = new SqlCommand("SELECT toimipiste_id, nimi FROM Toimipiste");
            database_query_toimipiste.Connection = main_window.database_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            main_window.database_connection.Open();
            myReader = database_query_toimipiste.ExecuteReader();
            while (myReader.Read())
            {
                Combo_box_item item = new Combo_box_item();
                item.Text = myReader[1].ToString();
                item.Value = myReader[0].ToString();
                cbo_Service_Office_Select.Items.Add(item);
            }
            main_window.database_connection.Close();
        }

        private void btn_Service_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Apumuuttujat asiakastietojen muokkaukseen, arvot pääikkunasta.
        public string Service_id;
        public bool Is_service_edited;
        private void btn_Service_Save_Click(object sender, EventArgs e)
        {
            frm_Main_Window main_window = new frm_Main_Window();
            // Muunnetaan textbox kenttien arvot tekstimuotoon ja asetetaan ne muuttujiin.
            string nimi = txt_Service_Name.Text;
            string kuvaus = txt_Service_Description.Text;
            string max_osallistujat = txt_Service_Max_Visitors.Text;
            string hinta = txt_Service_Price.Text;
            string alv = txt_Service_alv.Text;
            // Apumuuttujat
            string chosen_office = cbo_Service_Office_Select.Text.ToString();
            string toimipiste_id = "";
            SqlCommand database_query = new SqlCommand("SELECT * FROM Toimipiste WHERE nimi = @chosen_office");
            database_query.Connection = main_window.database_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            main_window.database_connection.Open();
            database_query.Parameters.AddWithValue("@chosen_office", chosen_office);
            // Suoritetaan kysely
            database_query.ExecuteNonQuery();
            // Alustetaan tietojen lukija
            SqlDataReader myReader = null;
            myReader = database_query.ExecuteReader();
            while (myReader.Read())
            {
                toimipiste_id = (myReader["toimipiste_id"].ToString());
            }
            main_window.database_connection.Close();
            // Määritellään tietokantayhteys.
            SqlConnection database_connection = main_window.database_connection;
            // Määritellään tietokantakyselyt asiakkaiden lisäämiseksi ja muokkaamiseksi.
            SqlCommand database_query_new = new SqlCommand("INSERT INTO [Palvelu] ([toimipiste_id], [nimi], [kuvaus], [max_osallistujat], " +
                "[hinta], [alv]) VALUES (@toimipiste_id, @nimi, @kuvaus, @max_osallistujat, @hinta, @alv)");

            SqlCommand database_query_update = new SqlCommand("UPDATE Palvelu SET toimipiste_id=@toimipiste_id, nimi=@nimi, kuvaus=@kuvaus, " +
                "max_osallistujat=@max_osallistujat, hinta=@hinta, alv=@alv WHERE palvelu_id = @palvelu_id");
            // Jos muokataan asiakasta.

            if (this.Is_service_edited == true)
            {
                // Käytetään asiakkaan muokkauksen yhteyttä.
                database_query_update.Connection = main_window.database_connection;
                database_connection.Open();
                database_query_update.Parameters.AddWithValue("@palvelu_id", this.Service_id);
                database_query_update.Parameters.AddWithValue("@toimipiste_id", toimipiste_id);
                database_query_update.Parameters.AddWithValue("@nimi", nimi);
                database_query_update.Parameters.AddWithValue("@kuvaus", kuvaus);
                database_query_update.Parameters.AddWithValue("@max_osallistujat", max_osallistujat);
                database_query_update.Parameters.AddWithValue("@hinta", hinta);
                database_query_update.Parameters.AddWithValue("@alv", alv);
                database_query_update.ExecuteNonQuery();
                database_connection.Close();
            }
            // Jos luodaan uusi asiakas.
            else
            {
                // Käytetään uuden asiakkaan luonnin yhteyttä.
                database_query_new.Connection = main_window.database_connection;
                database_connection.Open();
                database_query_new.Parameters.AddWithValue("@toimipiste_id", toimipiste_id);
                database_query_new.Parameters.AddWithValue("@nimi", nimi);
                database_query_new.Parameters.AddWithValue("@kuvaus", kuvaus);
                database_query_new.Parameters.AddWithValue("@max_osallistujat", max_osallistujat);
                database_query_new.Parameters.AddWithValue("@hinta", hinta);
                database_query_new.Parameters.AddWithValue("@alv", alv);
                database_query_new.ExecuteNonQuery();
                database_connection.Close();
            }
            // Suljetaan formi.
            this.Close();
        }
    }
}
