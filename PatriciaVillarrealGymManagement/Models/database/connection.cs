using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace PatriciaVillarrealGymManagement.Models.database
{
    internal class connection
    {
        static string server = System.Environment.GetEnvironmentVariable("USER") ??"localhost";
        static string user_id = System.Environment.GetEnvironmentVariable("USER")??"root";
        static string password = System.Environment.GetEnvironmentVariable("USER")??"admin";
        static string db_name = System.Environment.GetEnvironmentVariable("USER")?? "PV_GYM_MANAGEMENT_DB";
        static string port = System.Environment.GetEnvironmentVariable("USER")??"3306";

        static string query = $"server={server};user id={user_id};password={password};database={db_name};port={port};";



        public MySqlConnection StartConnection()
        {
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn.ConnectionString = query;
                conn.Open();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.ToString());
            }


            return conn;
        }
        public void EndConnection()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.Close();
        }
    }
}
