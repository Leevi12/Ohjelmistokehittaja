using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace OmaProjekti
{
    class COUNTER
    {
        Yhdista cnction = new Yhdista();

        public bool AddMgsCount(int Mgs)
        {
            MySqlCommand komento = new MySqlCommand();
            String adding = "UPDATE votes" +
                "SET Mgscount += Mgscount" +
                "WHERE Name = mgsvotes; ";
            komento.CommandText = adding;
            komento.Connection = cnction.MakeConnection();
            komento.Parameters.Add("@user", MySqlDbType.Int32).Value = Mgs;

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
