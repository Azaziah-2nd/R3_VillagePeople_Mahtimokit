using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace R3_VillagePeople_Mahtimokit
{
    public class Combo_box_item
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }

    public class Common_methods
    {

        public void Update_log(string lisatieto_loki)
        {
            frm_Main_Window main_window = new frm_Main_Window();
            // Loki taulun päivitys
            SqlCommand database_query_loki = new SqlCommand("INSERT INTO [Loki] ([paivittaja], [lisatieto]) " +
                "VALUES(@paivittaja, @lisatieto_loki)");
            database_query_loki.Connection = main_window.database_connection;
            main_window.database_connection.Open();
            database_query_loki.Parameters.AddWithValue("@paivittaja", Properties.Settings.Default["user_name"].ToString());
            database_query_loki.Parameters.AddWithValue("@lisatieto_loki", lisatieto_loki);
            database_query_loki.ExecuteNonQuery();
            main_window.database_connection.Close();
        }

        public bool Is_email_valid(string email)
        {
            try
            {
                MailAddress email_to_verify = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Virhe! Annettu sähköpostiosoite on virheellinen!");
                return false;
            }
        }
        public bool Is_phone_valid(string phone_number)
        {
            {
                bool return_value = false;
                // Tarkistaa, että syöte koostuu:
                // numeroista, "," "-" ja välilyönneistä.
                // Mahdollistaa puh syötteet eroteltuina väleillä yms.
                var verify_phone = new Regex("^[\\d,\\s\\-]+$");
                Match find_match = verify_phone.Match(phone_number);
                if (find_match.Success)
                {
                    return_value = true;
                }
                else
                {
                    MessageBox.Show("Virhe! Annettu puhelinnumero on virheellinen!\n\nSallitut merkit: " +
                        "numerot, pilkut ja väliviivat.");
                    return_value = false;
                }
                return return_value;
            }
        }

        public bool Is_adress_valid(string adress)
        {
            {
                bool return_value = false;
                // Tarkistaa, että syöteessä on sekä kirjaimia, että numeroita.
                var verify_adress_contains_text = new Regex("[a-zA-Z]");
                var verify_adress_contains_numbers = new Regex("[a-zA-Z]");
                Match find_text = verify_adress_contains_text.Match(adress);
                Match find_numbers = verify_adress_contains_numbers.Match(adress);
                // Oletetaan myös, että osoitteen on oltava vähintään 5 merkkiä pitkä.
                if (find_text.Success && find_numbers.Success && adress.Length > 5)
                {
                    return_value = true;
                }
                else
                {
                    MessageBox.Show("Virhe! Annettu osoite on virheellinen!\n\nOsoitteen täytyy sisältää " +
                        "kirjaimia, vähintään 1 numero\n ja sen on oltava vähintään 5 merkkiä pitkä.");
                    return_value = false;
                }
                return return_value;
            }
        }
        public bool Is_zip_code_valid(string zip_code)
        {
            {
                bool return_value = false;
                // Tarkistaa, että syöte koostuu pelkistä numeroista.
                var find_numbers = new Regex("\\d");
                Match check_numbers = find_numbers.Match(zip_code);
                // Tarkistetaan myös, että postinumero on 4-5 merkkiä pitkä
                // HUOM! Joissakin maissa postinumerot ovat 6 merkkiä pitkiä tai sisältävät muuta kuin numeroit
                // Tehtävässä käytetty tietokanta hyväksyy vain max 5 merkkisiä syötteitä, eli maa + postinumeron rajoite
                // ajattelu on rajallista.
                if (check_numbers.Success && zip_code.Length > 3)
                {
                    return_value = true;
                }
                else
                {
                    MessageBox.Show("Virhe! Annettu postinumero on virheellinen!");
                    return_value = false;
                }
                return return_value;
            }
        }
        public bool Is_post_office_valid(string post_office)
        {
            {
                bool return_value = false;
                // Tarkistaa, että syöte koostuu pelkistä kirjaimista.
                var check_post_office = new Regex("^[a-zA-Z]+$");
                Match find_office = check_post_office.Match(post_office);
                // Tarkistetaan myös, että postitoimipaikan nimi on vähintään 2 merkkiä pitkä.
                if (find_office.Success && post_office.Length > 1)
                {
                    return_value = true;
                }
                else
                {
                    MessageBox.Show("Virhe! Annettu postitoimipaikka on virheellinen!\n\n" +
                        "Postitoimipaikan nimen täytyy koostua pelkistä kirjaimista\n" +
                        "ja sen on oltava vähintään 2 merkkiä pitkä.");
                    return_value = false;
                }
                return return_value;
            }
        }
    }
}
