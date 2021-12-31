using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace OmaProjekti
{
    public class Yhdista
    {
        public string Connect()
        {
            return "datasource=localhost; port=3306; username=root; password=; database=game_voting; SSL mode = None";
        }
        private MySqlConnection cnction = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=game_voting; SSL mode = None");

        public MySqlConnection MakeConnection()
        {
            return cnction;
        }
        public void OpenConnection()
        {
            if (cnction.State == ConnectionState.Closed)
            {
                cnction.Open();
            }
        }
        public void CloseConnection()
        {
            if (cnction.State == ConnectionState.Open)
            {
                cnction.Close();
            }
        }
    }
}
