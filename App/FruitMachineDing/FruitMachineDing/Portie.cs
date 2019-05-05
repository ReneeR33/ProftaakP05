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
        //List<string> portie = new List<string>();

        /// <summary>
        /// This method returns a (Alphabetically sorted) list of fruit names.
        /// </summary>
        /// <param name="connectionString">SQL Connection String</param>
        /// <returns>List of strings</returns>
        //public List<string> GiveFruit(string connectionString)
        //{
        //    List<string> fruit = new List<string>();
        //    string query = "SELECT Name FROM Fruit " +
        //        "ORDER BY Name";

        //    using (SqlConnection conn = new SqlConnection(Convert.ToString(connectionString)))
        //    using (SqlCommand cmd = new SqlCommand(query, conn))
        //    {
        //        conn.Open();
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                fruit.Add(reader.GetString(0));
        //            }
        //        }
        //    }
        //    return fruit;
        //}

        /// <summary>
        /// This method returns a sorted list of Vitamines connected to the fruit name you give along.
        /// </summary>
        /// <param name="connectionString">SQL Connection String</param>
        /// <param name="fruit">Name of fruit</param>
        /// <returns>List of strings</returns>
        //public List<string> GiveVitamins(string connectionString, string fruit)
        //{
        //    List<string> vitamins = new List<string>();
        //    string query = "SELECT a.Vitamine FROM Vitamines a " +
        //        "INNER JOIN FruitVitamines b ON a.Id = b.VitaminesId " +
        //        "WHERE b.FruitId = " +
        //            "(SELECT Id FROM Fruit WHERE Name = @FruitName)" +
        //        "ORDER BY a.Vitamine";

        //    using (SqlConnection conn = new SqlConnection(Convert.ToString(connectionString)))
        //    using (SqlCommand cmd = new SqlCommand(query, conn))
        //    {
        //        cmd.Parameters.AddWithValue("@FruitName", fruit);
        //        conn.Open();
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                vitamins.Add(reader.GetString(0));
        //            }
        //        }
        //    }
        //    return vitamins;
        //}

        /// <summary>
        /// This method adds fruit to a list.
        /// </summary>
        /// <param name="Fruit">Name of the fruit</param>
        /// <returns>List of strings</returns>
        //public List<string> AddToList(string Fruit)
        //{
        //    portie.Add(Fruit);
        //    return portie;
        //}

        /// <summary>
        /// This method removes a certain fruit from a list of fruits.
        /// </summary>
        /// <param name="_fruit">Name of fruit to be removed</param>
        /// <returns>List of strings</returns>
        //public List<string> RemoveFromList(string _fruit)
        //{
        //    if (portie.Contains(_fruit))
        //    {
        //        portie.RemoveAt(portie.IndexOf(_fruit));
        //    }
        //    return portie;
        //}
    }
}
