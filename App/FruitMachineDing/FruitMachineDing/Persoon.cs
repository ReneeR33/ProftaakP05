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

        /// <summary>
        /// This method gets the name from the database connected to the Fingerprint Id given along with it.
        /// </summary>
        /// <param name="connectionString">SQL Connection String</param>
        /// <param name="id">Fingerprint Id</param>
        /// <returns>String</returns>
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

        /// <summary>
        /// This method returns a list of the names of all persons saved in the databse.
        /// </summary>
        /// <param name="connectionString">SQL Connection String</param>
        /// <returns>List of strings</returns>
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

        /// <summary>
        /// This method returns the age of the personName given as a parameter.
        /// </summary>
        /// <param name="connectionString">SQL Connection String</param>
        /// <param name="naam">Name of a person</param>
        /// <returns>Int</returns>
        public int GiveAge(string connectionString, string naam)
        {
            string query = "SELECT age FROM Persoon WHERE naam = @PersonName";

            using (SqlConnection conn = new SqlConnection(Convert.ToString(connectionString)))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PersonName", naam);
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
