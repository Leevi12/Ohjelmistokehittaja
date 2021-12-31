using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmaProjekti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            MgsBT.BackColor = Color.Red;
            GowBT.BackColor = Color.Red;
            DsBT.BackColor = Color.Red;
            ShowBT.BackColor = Color.Green;


        }

        COUNTER counter = new COUNTER();

        public static int Mgscount = 0;
        public static int Gowcount = 0;
        public static int Dscount = 0;

        private void MgsBT_Click(object sender, EventArgs e)
        {
            Mgscount = Int32.Parse(MgsLB.Text);
            Mgscount++;
            MgsLB.Text = Mgscount.ToString();
            MgsBT.Enabled = false;
            GowBT.Enabled = false;
            DsBT.Enabled = false;
            //a3Boolean addToMgsCount = counter.AddMgscount(Mgscount);
            MessageBox.Show("Thank you for voting!", "Successful vote", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void GowBT_Click(object sender, EventArgs e)
        {
            Gowcount = Int32.Parse(GowLB.Text);
            Gowcount++;
            GowLB.Text = Gowcount.ToString();
            MgsBT.Enabled = false;
            GowBT.Enabled = false;
            DsBT.Enabled = false;
            MessageBox.Show("Thank you for voting!", "Successful vote", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DsBT_Click(object sender, EventArgs e)
        {
            Dscount = Int32.Parse(DsLB.Text);
            Dscount++;
            DsLB.Text = Dscount.ToString();
            MgsBT.Enabled = false;
            GowBT.Enabled = false;
            DsBT.Enabled = false;
            MessageBox.Show("Thank you for voting!", "Successful vote", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowBT_Click(object sender, EventArgs e)
        {
            DsLB.Visible = true;
            MgsLB.Visible = true;
            GowLB.Visible = true;
        }
    }
}
