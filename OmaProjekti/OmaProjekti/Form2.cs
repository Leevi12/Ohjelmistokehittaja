using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OmaProjekti
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        User user = new User();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String usr = UsernameTB.Text;
            String pwd = PasswordTB.Text;

            if (UsernameTB.ToString().Trim().Equals("") || PasswordTB.ToString().Trim().Equals(""))
            {
                MessageBox.Show("Error, All fields must be filled", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Boolean addNewUser = user.AddUser(usr, pwd);
                if (addNewUser)
                {
                    MessageBox.Show("New user added", "Add new user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Could not add new user", "Adding failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

                private void button1_Click(object sender, EventArgs e)
        {
            Yhdista tietokantaan = new Yhdista();
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();
            String kysely = "SELECT username, password FROM users WHERE username = @user AND password = @pass";


            komento.CommandText = kysely;
            komento.Connection = tietokantaan.MakeConnection();

            komento.Parameters.Add("@user", MySqlDbType.VarChar).Value = UsernameTB.Text;
            komento.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordTB.Text;

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            if(taulu.Rows.Count > 0)
            {
                this.Hide();
                Form1 Game = new Form1();
                Game.Show();
                MessageBox.Show("Remember that you are not allowed to vote more than once!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("User not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
