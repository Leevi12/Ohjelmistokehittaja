using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PainikeBT_Click(object sender, EventArgs e)
        {
            int years = 0;
            int months = 0;
            int hours = 0;
            int minutes = 0;
            int seconds = 0;
            DateTime nyt = DateTime.Now;
            DateTime synttarit = ikaDT.Value;
            double erotus = Math.Round((nyt - synttarit).TotalDays);
            paivatLB.Text = erotus + "";
            paivatLB.Visible = true;
            paivinaLB.Visible = true;

            years = Convert.ToInt32(erotus) / 365;
            vuodetLB.Text = years + "";
            vuodetLB.Visible = true;
            vuosinaLB.Visible = true;

            months = Convert.ToInt32(erotus / 365.25 * 12);
            kuukaudetLB.Text = months + "";
            kuukaudetLB.Visible = true;
            kuukausinaLB.Visible = true;

            hours = Convert.ToInt32(erotus * 24);
            tunnitLB.Text = hours + "";
            tunnitLB.Visible = true;
            tunteinaLB.Visible = true;

            minutes = Convert.ToInt32(erotus * 24 * 60);
            minuutitLB.Text = minutes + "";
            minuutitLB.Visible = true;
            minuutteinaLB.Visible = true;

            seconds = Convert.ToInt32(erotus * 24 * 60 * 60);
            sekunnitLB.Text = seconds + "";
            sekunnitLB.Visible = true;
            sekunteinaLB.Visible = true;
            oletLB.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
