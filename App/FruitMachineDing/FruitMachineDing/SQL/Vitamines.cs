﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FruitMachineDing.SQL
{
    class Vitamines
    {
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
        public List<string> GetVitamins(string connectionString, string fruit)
        {
            List<string> vitamins = new List<string>();
            string query = "SELECT a.Vitamine FROM Vitamines a " +
                "INNER JOIN FruitVitamines b ON a.Id = b.VitaminesId " +
                "WHERE b.FruitId = " +
                    "(SELECT Id FROM Fruit WHERE Name = @FruitName)" +
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
    }
}