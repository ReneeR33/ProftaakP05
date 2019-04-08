using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace FruitMachineDing
{
    class Portie
    {
        List<string> portie = new List<string>();


        public List<string> GiveFruit(string connectionString)
        {
            List<string> fruit = new List<string>();
            string query = "SELECT Name FROM Fruit";

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

        public List<string> GiveVitamins(string connectionString, string fruit)
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

        public List<string> AddToList(string Fruit)
        {
            portie.Add(Fruit);
            return portie;
        }

        public List<string> RemoveFromList(string _fruit)
        {
            if (portie.Contains(_fruit))
            {
                portie.RemoveAt(portie.IndexOf(_fruit));
            }
            return portie;
        }
    }
}
