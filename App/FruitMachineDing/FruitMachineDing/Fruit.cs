using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                    "(SELECT Id FROM Fruit WHERE Name = @FruitName) " +
                "ORDER BY a.Vitamine";

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

        public string GetVitamineDesc(string connectionString, string vitamineNaam)
        {
            string query = "SELECT Descriptie FROM Vitamines WHERE Vitamine = @VitamineNaam";

            using (SqlConnection conn = new SqlConnection(Convert.ToString(connectionString)))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@VitamineNaam", vitamineNaam);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string incomming = reader.GetString(0);
                        return incomming.Replace("|", "\n");
                    }
                    else
                    {
                        return "unknown";
                    }
                }
            }
        }

        public List<string> TotalVitamine(string connectionString, ListBox.ObjectCollection items)
        {
            List<string> fruitSoorten = new List<string>();
            List<string> vitamineLijst = new List<string>();
            foreach (string x in items)
            {
                if (!fruitSoorten.Contains(x))
                {
                    fruitSoorten.Add(x);
                }
            }
            foreach (var x in fruitSoorten)
            {
                foreach (var y in GetVitamins(connectionString, x))
                {
                    if (!vitamineLijst.Contains(y))
                    {
                        vitamineLijst.Add(y);
                    }
                }
            }
            vitamineLijst.Sort();
            return vitamineLijst;
        }
    }
}