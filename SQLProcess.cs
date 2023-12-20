using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineUp
{
    internal class SQLProcess
    {
        static string connectionString = "Server=.;Database=LineUP;User Id=Cuni;Password=123456;";
        static SqlConnection connection;
        static SqlCommand command;
        static Dictionary<int, Tuple<string, double>> allPlayers = new Dictionary<int, Tuple<string, double>>();

        private static bool ConnectionOpen(string connectionString)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Connection Open Error");
                return false;
            }
        }

        public static Dictionary<int, Tuple<string, double>> GetPlayers(string query)
        {
            try
            {
                if (!ConnectionOpen(connectionString))
                    return null;
                allPlayers.Clear();
                SqlDataReader reader = null;
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                    allPlayers.Add(reader.GetInt32(0), Tuple.Create(reader.GetString(1), reader.GetDouble(2)));

                command.Dispose();
                command = null;
                reader.Close();
                reader = null;

                return allPlayers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "GetPlayers Error");
                return null;
            }
        }

        public static bool AddPlayer(string query)
        {
            try
            {
                if (!ConnectionOpen(connectionString))
                    return false;
                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ex.message: " + ex.Message + " stacktrace: " + ex.StackTrace, "Add Player Error");
                return false;
            }
        }

    }
}
