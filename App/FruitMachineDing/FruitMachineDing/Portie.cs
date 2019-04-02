using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FruitMachineDing
{
    class Portie
    {

        List<string> portie = new List<string>();
        List<string> fruit = new List<string>();
        

        public List<string> GiveFruit(SqlConnection connectionString)
        {
            SqlCommand cmd = new SqlCommand("SELECT Name FROM Fruit;", connectionString);
            SqlConnection conn = new SqlConnection(Convert.ToString(connectionString));
            using (SqlDataReader reader = cmd.ExecuteReader())
            { 
                fruit.Clear();
                conn.Open();
                while (reader.Read())
                {
                    fruit.Add(reader.GetString(0));
                }
                conn.Close();
                return fruit;
            }
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
