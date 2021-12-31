
namespace OmaProjekti
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
            this.label1 = new System.Windows.Forms.Label();
            this.MgsBT = new System.Windows.Forms.Button();
            this.GowBT = new System.Windows.Forms.Button();
            this.DsBT = new System.Windows.Forms.Button();
            this.MgsLB = new System.Windows.Forms.Label();
            this.GowLB = new System.Windows.Forms.Label();
            this.DsLB = new System.Windows.Forms.Label();
            this.ShowBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which of these game series is the best?";
            // 
            // MgsBT
            // 
            this.MgsBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MgsBT.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.MgsBT.Location = new System.Drawing.Point(36, 182);
            this.MgsBT.Name = "MgsBT";
            this.MgsBT.Size = new System.Drawing.Size(175, 91);
            this.MgsBT.TabIndex = 1;
            this.MgsBT.Text = "Metal Gear Solid";
            this.MgsBT.UseVisualStyleBackColor = true;
            this.MgsBT.Click += new System.EventHandler(this.MgsBT_Click);
            // 
            // GowBT
            // 
            this.GowBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GowBT.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.GowBT.Location = new System.Drawing.Point(303, 182);
            this.GowBT.Name = "GowBT";
            this.GowBT.Size = new System.Drawing.Size(175, 91);
            this.GowBT.TabIndex = 2;
            this.GowBT.Text = "God of War";
            this.GowBT.UseVisualStyleBackColor = true;
            this.GowBT.Click += new System.EventHandler(this.GowBT_Click);
            // 
            // DsBT
            // 
            this.DsBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DsBT.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DsBT.Location = new System.Drawing.Point(579, 182);
            this.DsBT.Name = "DsBT";
            this.DsBT.Size = new System.Drawing.Size(175, 91);
            this.DsBT.TabIndex = 3;
            this.DsBT.Text = "Dark Souls";
            this.DsBT.UseVisualStyleBackColor = true;
            this.DsBT.Click += new System.EventHandler(this.DsBT_Click);
            // 
            // MgsLB
            // 
            this.MgsLB.AutoSize = true;
            this.MgsLB.Location = new System.Drawing.Point(117, 317);
            this.MgsLB.Name = "MgsLB";
            this.MgsLB.Size = new System.Drawing.Size(18, 20);
            this.MgsLB.TabIndex = 4;
            this.MgsLB.Text = "0";
            this.MgsLB.Visible = false;
            // 
            // GowLB
            // 
            this.GowLB.AutoSize = true;
            this.GowLB.Location = new System.Drawing.Point(377, 317);
            this.GowLB.Name = "GowLB";
            this.GowLB.Size = new System.Drawing.Size(18, 20);
            this.GowLB.TabIndex = 5;
            this.GowLB.Text = "0";
            this.GowLB.Visible = false;
            // 
            // DsLB
            // 
            this.DsLB.AutoSize = true;
            this.DsLB.Location = new System.Drawing.Point(639, 317);
            this.DsLB.Name = "DsLB";
            this.DsLB.Size = new System.Drawing.Size(18, 20);
            this.DsLB.TabIndex = 6;
            this.DsLB.Text = "0";
            this.DsLB.Visible = false;
            // 
            // ShowBT
            // 
            this.ShowBT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowBT.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.ShowBT.Location = new System.Drawing.Point(303, 369);
            this.ShowBT.Name = "ShowBT";
            this.ShowBT.Size = new System.Drawing.Size(175, 91);
            this.ShowBT.TabIndex = 7;
            this.ShowBT.Text = "Show votes";
            this.ShowBT.UseVisualStyleBackColor = true;
            this.ShowBT.Click += new System.EventHandler(this.ShowBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.ShowBT);
            this.Controls.Add(this.DsLB);
            this.Controls.Add(this.GowLB);
            this.Controls.Add(this.MgsLB);
            this.Controls.Add(this.DsBT);
            this.Controls.Add(this.GowBT);
            this.Controls.Add(this.MgsBT);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Game survey";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MgsBT;
        private System.Windows.Forms.Button GowBT;
        private System.Windows.Forms.Button DsBT;
        private System.Windows.Forms.Label MgsLB;
        private System.Windows.Forms.Label GowLB;
        private System.Windows.Forms.Label DsLB;
        private System.Windows.Forms.Button ShowBT;
    }
}

