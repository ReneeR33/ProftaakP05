using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FruitMachineDing
{
    class Fruit
    {
        public string GiveDescription(string connectionString, string naam)
        {
            string query = "SELECT descriptie FROM Fruit WHERE Name = @FruitName";

            using (SqlConnection conn = new SqlConnection(Convert.ToString(connectionString)))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FruitName", naam);
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

        public List<string> GetVitamins(string connectionString, string fruit)
        {
            List<string> vitamins = new List<string>();
            string query = "SELECT a.Vitamine FROM Vitamines a " +
                "INNER JOIN FruitVitamines b ON a.Id = b.VitaminesId " +
                "WHERE b.FruitId = " +
                    "(SELECT Id FROM Fruit WHERE Name = @FruitName)";

            using (SqlConnection conn = new SqlConnection(Convert.ToString(connectionString)))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@FruitName", fruit);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        vitamins.Add(reader.GetString(0));
                    }

                }
            }
            return vitamins;
        }
    }
}
