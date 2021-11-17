using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HarjoitusCRUD
{
    class BOOK
    {
        Yhdista yhteys = new Yhdista();

        public bool addBook(String bk, String auth, int noc)
        {
            MySqlCommand komento = new MySqlCommand();
            String adding = "INSERT INTO library " +
                "(Book, Author, Number_of_copies) " +
                "VALUES (@bok, @aut, @cop); ";
            komento.CommandText = adding;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@bok", MySqlDbType.VarChar).Value = bk;
            komento.Parameters.Add("@aut", MySqlDbType.VarChar).Value = auth;
            komento.Parameters.Add("@cop", MySqlDbType.UInt32).Value = noc;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
        public DataTable getBooks()
        {
            MySqlCommand komento = new MySqlCommand("SELECT bid, Book, Author, Number_of_copies From library", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool editBook(int bid, String bk, String auth, int noc)
        {
            MySqlCommand komento = new MySqlCommand();
            String updating = "UPDATE library SET Book = @bok, " +
                "Author = @aut, Number_of_copies = @cop WHERE bid = @bid";
            komento.CommandText = updating;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@bok", MySqlDbType.VarChar).Value = bk;
            komento.Parameters.Add("@aut", MySqlDbType.VarChar).Value = auth;
            komento.Parameters.Add("@cop", MySqlDbType.UInt32).Value = noc;
            komento.Parameters.Add("@bid", MySqlDbType.UInt32).Value = bid;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
        public bool deleteBook(String username)
        {
            MySqlCommand komento = new MySqlCommand();
            String deleting = "DELETE FROM library WHERE bid = @usr";
            komento.CommandText = deleting;
            komento.Connection = yhteys.otaYhteys();
            komento.Parameters.Add("@usr", MySqlDbType.UInt32).Value = username;

            yhteys.avaaYhteys();
            if (komento.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }
    }
}
