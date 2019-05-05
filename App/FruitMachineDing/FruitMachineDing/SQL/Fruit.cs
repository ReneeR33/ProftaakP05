using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FruitMachineDing.SQL
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
        public List<string> GiveFruit(string connectionString)
        {
            List<string> fruit = new List<string>();
            string query = "SELECT Name FROM Fruit " +
                "ORDER BY Name";

            using (SqlConnection conn = new SqlConnection(Convert.ToString(connectionString)))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        fruit.Add(reader.GetString(0));
                    }
                }
            }
            return fruit;
        }
    }
}
