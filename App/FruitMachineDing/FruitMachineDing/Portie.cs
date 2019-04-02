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
        

        public List<string> GiveFruit(string connectionString)
        {
            string query = "SELECT Name FROM Fruit";

            using (SqlConnection conn = new SqlConnection(Convert.ToString(connectionString)))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    fruit.Add(reader.GetString(0));
                }

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
