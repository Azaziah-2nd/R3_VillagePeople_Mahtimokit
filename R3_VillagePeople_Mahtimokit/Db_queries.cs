using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace R3_VillagePeople_Mahtimokit
{
    public class Db_queries
    {

        // Määritellään tietokantayhteyden muodostin.
        public SqlConnection database_connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                          AttachDbFilename=|DataDirectory|\VP_Database.mdf;
                          Integrated Security=True;
                          Connect Timeout=15;
                          User Instance=False");


        public void Update_log(string lisatieto_loki)
        {
            frm_Main_Window main_window = new frm_Main_Window();
            // Loki taulun päivitys
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
