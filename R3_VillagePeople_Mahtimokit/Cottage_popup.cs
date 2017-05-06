﻿using System;
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
    public partial class frm_Cottage_Popup : Form
    {
        public frm_Cottage_Popup()
        {
            InitializeComponent();
        }

        private void btn_Cottage_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public string Cottage_id;
        public bool Is_Cottage_edited;
        private void btn_Cottage_Save_Click(object sender, EventArgs e)
        {
            frm_Main_Window main_window = new frm_Main_Window();
            // Muunnetaan textbox kenttien arvot tekstimuotoon ja asetetaan ne muuttujiin.
            string nimi = txt_Cottage_Name.Text;
            string kuvaus = txt_Cottage_Description.Text;
            string hinta = txt_Cottage_Price.Text;
            string max_henkilot = txt_Cottage_Max_Visitors.Text;
            string koko = txt_Cottage_Size.Text;
            string wlan = "0";
            bool is_wlan_checked = rbu_Cottage_Wlan_Yes.Checked;
            if (is_wlan_checked)
            {
                wlan = "1";
            }
            // Apumuuttujat
            string selected_office = cbo_Cottage_Office_Select.Text.ToString();
            string toimipiste_id = "";
            SqlCommand database_query = new SqlCommand("SELECT * FROM Toimipiste WHERE nimi = @selected_office");
            database_query.Connection = main_window.database_connection;
            // Avataan yhteys tietokantaan ja asetetaan tallennettavat arvot.
            main_window.database_connection.Open();
            database_query.Parameters.AddWithValue("@selected_office", selected_office);
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
            SqlCommand database_query_new = new SqlCommand("INSERT INTO [Majoitus] ([toimipiste_id], [nimi], [kuvaus], [hinta], " +
                "[max_henkilot], [koko], [wlan]) VALUES (@toimipiste_id, @nimi, @kuvaus, @hinta, @max_henkilot, @koko, @wlan)");

            SqlCommand database_query_update = new SqlCommand("UPDATE Majoitus SET toimipiste_id=@toimipiste_id, nimi=@nimi, kuvaus=@kuvaus, " +
                "hinta=@hinta, max_henkilot=@max_henkilot, koko=@koko, wlan=@wlan WHERE majoitus_id = @majoitus_id");
            // Jos muokataan asiakasta.

            if (this.Is_Cottage_edited == true)
            {
                // Käytetään asiakkaan muokkauksen yhteyttä.
                database_query_update.Connection = main_window.database_connection;
                database_connection.Open();
                database_query_update.Parameters.AddWithValue("@majoitus_id", this.Cottage_id);
                database_query_update.Parameters.AddWithValue("@toimipiste_id", toimipiste_id);
                database_query_update.Parameters.AddWithValue("@nimi", nimi);
                database_query_update.Parameters.AddWithValue("@kuvaus", kuvaus);
                database_query_update.Parameters.AddWithValue("@hinta", hinta);
                database_query_update.Parameters.AddWithValue("@max_henkilot", max_henkilot);
                database_query_update.Parameters.AddWithValue("@koko", koko);
                database_query_update.Parameters.AddWithValue("@wlan", wlan);
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
                database_query_new.Parameters.AddWithValue("@hinta", hinta);
                database_query_new.Parameters.AddWithValue("@max_henkilot", max_henkilot);
                database_query_new.Parameters.AddWithValue("@koko", koko);
                database_query_new.Parameters.AddWithValue("@wlan", wlan);
                database_query_new.ExecuteNonQuery();
                database_connection.Close();
            }
            // Suljetaan formi.
            this.Close();
        }

        private void frm_Cottage_Popup_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vP_DatabaseDataSet1.Toimipiste' table. You can move, or remove it, as needed.
            this.toimipisteTableAdapter.Fill(this.vP_DatabaseDataSet1.Toimipiste);

        }
    }
}
