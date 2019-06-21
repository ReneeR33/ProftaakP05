using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FruitMachineDing.SQL
{
    class Portie
    {
        public List<string> GetPorties(string connectionString, string PersonName)
        {
            List<string> porties = new List<string>();
            string query = "SELECT id FROM Portie WHERE PersoonId =(SELECT Id FROM Persoon WHERE Naam = @PersonName)";

            using (SqlConnection conn = new SqlConnection(Convert.ToString(connectionString)))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PersonName", PersonName);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        string portion = reader.GetInt32(0).ToString();
                        porties.Add(portion);
                    }
                }
            }
            return porties;
        }

        public string GetDate(string connectionString, string portieID)
        {
            string query = "SELECT DateTime FROM Portie WHERE Id = @portieID";

            using (SqlConnection conn = new SqlConnection(Convert.ToString(connectionString)))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@portieID", portieID);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(0);
                        return date.ToString();
                    }
                    else
                    {
                        return "unknown";
                    }
                }
            }

        }
    }
}
