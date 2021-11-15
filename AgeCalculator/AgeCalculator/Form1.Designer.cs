
namespace AgeCalculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ikaDT = new System.Windows.Forms.DateTimePicker();
            this.vuodetLB = new System.Windows.Forms.Label();
            this.kuukaudetLB = new System.Windows.Forms.Label();
            this.paivatLB = new System.Windows.Forms.Label();
            this.tunnitLB = new System.Windows.Forms.Label();
            this.minuutitLB = new System.Windows.Forms.Label();
            this.sekunnitLB = new System.Windows.Forms.Label();
            this.PainikeBT = new System.Windows.Forms.Button();
            this.oletLB = new System.Windows.Forms.Label();
            this.vuosinaLB = new System.Windows.Forms.Label();
            this.kuukausinaLB = new System.Windows.Forms.Label();
            this.paivinaLB = new System.Windows.Forms.Label();
            this.tunteinaLB = new System.Windows.Forms.Label();
            this.minuutteinaLB = new System.Windows.Forms.Label();
            this.sekunteinaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ikaDT
            // 
            this.ikaDT.Location = new System.Drawing.Point(13, 13);
            this.ikaDT.Name = "ikaDT";
            this.ikaDT.Size = new System.Drawing.Size(293, 26);
            this.ikaDT.TabIndex = 0;
            // 
            // vuodetLB
            // 
            this.vuodetLB.AutoSize = true;
            this.vuodetLB.Location = new System.Drawing.Point(12, 129);
            this.vuodetLB.Name = "vuodetLB";
            this.vuodetLB.Size = new System.Drawing.Size(51, 20);
            this.vuodetLB.TabIndex = 1;
            this.vuodetLB.Text = "label1";
            this.vuodetLB.Visible = false;
            // 
            // kuukaudetLB
            // 
            this.kuukaudetLB.AutoSize = true;
            this.kuukaudetLB.Location = new System.Drawing.Point(12, 198);
            this.kuukaudetLB.Name = "kuukaudetLB";
            this.kuukaudetLB.Size = new System.Drawing.Size(51, 20);
            this.kuukaudetLB.TabIndex = 2;
            this.kuukaudetLB.Text = "label2";
            this.kuukaudetLB.Visible = false;
            // 
            // paivatLB
            // 
            this.paivatLB.AutoSize = true;
            this.paivatLB.Location = new System.Drawing.Point(12, 263);
            this.paivatLB.Name = "paivatLB";
            this.paivatLB.Size = new System.Drawing.Size(51, 20);
            this.paivatLB.TabIndex = 3;
            this.paivatLB.Text = "label3";
            this.paivatLB.Visible = false;
            // 
            // tunnitLB
            // 
            this.tunnitLB.AutoSize = true;
            this.tunnitLB.Location = new System.Drawing.Point(255, 129);
            this.tunnitLB.Name = "tunnitLB";
            this.tunnitLB.Size = new System.Drawing.Size(51, 20);
            this.tunnitLB.TabIndex = 4;
            this.tunnitLB.Text = "label4";
            this.tunnitLB.Visible = false;
            // 
            // minuutitLB
            // 
            this.minuutitLB.AutoSize = true;
            this.minuutitLB.Location = new System.Drawing.Point(254, 198);
            this.minuutitLB.Name = "minuutitLB";
            this.minuutitLB.Size = new System.Drawing.Size(51, 20);
            this.minuutitLB.TabIndex = 5;
            this.minuutitLB.Text = "label5";
            this.minuutitLB.Visible = false;
            // 
            // sekunnitLB
            // 
            this.sekunnitLB.AutoSize = true;
            this.sekunnitLB.Location = new System.Drawing.Point(253, 263);
            this.sekunnitLB.Name = "sekunnitLB";
            this.sekunnitLB.Size = new System.Drawing.Size(51, 20);
            this.sekunnitLB.TabIndex = 6;
            this.sekunnitLB.Text = "label6";
            this.sekunnitLB.Visible = false;
            // 
            // PainikeBT
            // 
            this.PainikeBT.Location = new System.Drawing.Point(372, 12);
            this.PainikeBT.Name = "PainikeBT";
            this.PainikeBT.Size = new System.Drawing.Size(95, 27);
            this.PainikeBT.TabIndex = 7;
            this.PainikeBT.Text = "Laske";
            this.PainikeBT.UseVisualStyleBackColor = true;
            this.PainikeBT.Click += new System.EventHandler(this.PainikeBT_Click);
            // 
            // oletLB
            // 
            this.oletLB.AutoSize = true;
            this.oletLB.Location = new System.Drawing.Point(95, 82);
            this.oletLB.Name = "oletLB";
            this.oletLB.Size = new System.Drawing.Size(88, 20);
            this.oletLB.TabIndex = 8;
            this.oletLB.Text = "Olet elänyt:";
            this.oletLB.Visible = false;
            // 
            // vuosinaLB
            // 
            this.vuosinaLB.AutoSize = true;
            this.vuosinaLB.Location = new System.Drawing.Point(70, 128);
            this.vuosinaLB.Name = "vuosinaLB";
            this.vuosinaLB.Size = new System.Drawing.Size(101, 20);
            this.vuosinaLB.TabIndex = 9;
            this.vuosinaLB.Text = "Täyttä vuotta";
            this.vuosinaLB.Visible = false;
            // 
            // kuukausinaLB
            // 
            this.kuukausinaLB.AutoSize = true;
            this.kuukausinaLB.Location = new System.Drawing.Point(69, 198);
            this.kuukausinaLB.Name = "kuukausinaLB";
            this.kuukausinaLB.Size = new System.Drawing.Size(128, 20);
            this.kuukausinaLB.TabIndex = 10;
            this.kuukausinaLB.Text = "Täyttä kuukautta";
            this.kuukausinaLB.Visible = false;
            this.kuukausinaLB.Click += new System.EventHandler(this.label2_Click);
            // 
            // paivinaLB
            // 
            this.paivinaLB.AutoSize = true;
            this.paivinaLB.Location = new System.Drawing.Point(70, 262);
            this.paivinaLB.Name = "paivinaLB";
            this.paivinaLB.Size = new System.Drawing.Size(103, 20);
            this.paivinaLB.TabIndex = 11;
            this.paivinaLB.Text = "Täyttä päivää";
            this.paivinaLB.Visible = false;
            // 
            // tunteinaLB
            // 
            this.tunteinaLB.AutoSize = true;
            this.tunteinaLB.Location = new System.Drawing.Point(393, 129);
            this.tunteinaLB.Name = "tunteinaLB";
            this.tunteinaLB.Size = new System.Drawing.Size(152, 20);
            this.tunteinaLB.TabIndex = 12;
            this.tunteinaLB.Text = "Täyttä tuntia (about)";
            this.tunteinaLB.Visible = false;
            // 
            // minuutteinaLB
            // 
            this.minuutteinaLB.AutoSize = true;
            this.minuutteinaLB.Location = new System.Drawing.Point(393, 198);
            this.minuutteinaLB.Name = "minuutteinaLB";
            this.minuutteinaLB.Size = new System.Drawing.Size(177, 20);
            this.minuutteinaLB.TabIndex = 13;
            this.minuutteinaLB.Text = "Täyttä minuuttia (about)";
            this.minuutteinaLB.Visible = false;
            // 
            // sekunteinaLB
            // 
            this.sekunteinaLB.AutoSize = true;
            this.sekunteinaLB.Location = new System.Drawing.Point(393, 262);
            this.sekunteinaLB.Name = "sekunteinaLB";
            this.sekunteinaLB.Size = new System.Drawing.Size(172, 20);
            this.sekunteinaLB.TabIndex = 14;
            this.sekunteinaLB.Text = "Täyttä sekuntia (about)";
            this.sekunteinaLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sekunteinaLB);
            this.Controls.Add(this.minuutteinaLB);
            this.Controls.Add(this.tunteinaLB);
            this.Controls.Add(this.paivinaLB);
            this.Controls.Add(this.kuukausinaLB);
            this.Controls.Add(this.vuosinaLB);
            this.Controls.Add(this.oletLB);
            this.Controls.Add(this.PainikeBT);
            this.Controls.Add(this.sekunnitLB);
            this.Controls.Add(this.minuutitLB);
            this.Controls.Add(this.tunnitLB);
            this.Controls.Add(this.paivatLB);
            this.Controls.Add(this.kuukaudetLB);
            this.Controls.Add(this.vuodetLB);
            this.Controls.Add(this.ikaDT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ikaDT;
        private System.Windows.Forms.Label vuodetLB;
        private System.Windows.Forms.Label kuukaudetLB;
        private System.Windows.Forms.Label paivatLB;
        private System.Windows.Forms.Label tunnitLB;
        private System.Windows.Forms.Label minuutitLB;
        private System.Windows.Forms.Label sekunnitLB;
        private System.Windows.Forms.Button PainikeBT;
        private System.Windows.Forms.Label oletLB;
        private System.Windows.Forms.Label vuosinaLB;
        private System.Windows.Forms.Label kuukausinaLB;
        private System.Windows.Forms.Label paivinaLB;
        private System.Windows.Forms.Label tunteinaLB;
        private System.Windows.Forms.Label minuutteinaLB;
        private System.Windows.Forms.Label sekunteinaLB;
    }
}

