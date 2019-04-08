using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FruitMachineDing
{
    class Persoon
    {
        List<string> personen = new List<string>();
        public string GiveName(string connectionString, int id)
        {
            string query = "SELECT naam FROM Persoon WHERE FingerId = @FingerId";

            using (SqlConnection conn = new SqlConnection(Convert.ToString(connectionString)))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FingerId", id);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                    else
                    {
                        return "unknown";
                    }
                }
            }
        }
        public List<string> GivePersonNames(string connectionString)
        {
            string query = "SELECT Naam FROM Persoon " +
                "ORDER BY Naam";
            using (SqlConnection conn = new SqlConnection(Convert.ToString(connectionString)))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        personen.Add(reader.GetString(0));
                    }
                }
            }
            return personen;
        }
        public int GiveAge(string connectionString, string naam)
        {
            string query = "SELECT age FROM Persoon WHERE naam = '" + naam + "'";

            using (SqlConnection conn = new SqlConnection(Convert.ToString(connectionString)))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                    else
                    {
                        return -0;
                    }
                }
            }
        }
        
    }
}
