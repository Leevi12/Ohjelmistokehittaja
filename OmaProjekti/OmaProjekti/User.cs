using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace OmaProjekti
{
    class User
    {
        Yhdista cnction = new Yhdista();

        public bool AddUser(String usr, String pwd)
        {
            MySqlCommand komento = new MySqlCommand();
            String adding = "INSERT INTO users " +
                "(username, password) " +
                "VALUES (@user, @pass); ";
            komento.CommandText = adding;
            komento.Connection = cnction.MakeConnection();
            komento.Parameters.Add("@user", MySqlDbType.VarChar).Value = usr;
            komento.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pwd;

            cnction.OpenConnection();
            if (komento.ExecuteNonQuery() == 1)
            {
                cnction.CloseConnection();
                return true;
            }
            else
            {
                cnction.CloseConnection();
                return false;
            }
        }
    }
}
