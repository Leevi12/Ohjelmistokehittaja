
namespace HarjoitusCRUD
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
            this.idLB = new System.Windows.Forms.Label();
            this.bookLB = new System.Windows.Forms.Label();
            this.authorLB = new System.Windows.Forms.Label();
            this.nocLB = new System.Windows.Forms.Label();
            this.bid = new System.Windows.Forms.TextBox();
            this.bookTB = new System.Windows.Forms.TextBox();
            this.AuthorTB = new System.Windows.Forms.TextBox();
            this.nocTB = new System.Windows.Forms.TextBox();
            this.clearBT = new System.Windows.Forms.Button();
            this.saveBT = new System.Windows.Forms.Button();
            this.updateBT = new System.Windows.Forms.Button();
            this.deleteBT = new System.Windows.Forms.Button();
            this.bookDG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bookDG)).BeginInit();
            this.SuspendLayout();
            // 
            // idLB
            // 
            this.idLB.AutoSize = true;
            this.idLB.Location = new System.Drawing.Point(13, 13);
            this.idLB.Name = "idLB";
            this.idLB.Size = new System.Drawing.Size(30, 20);
            this.idLB.TabIndex = 0;
            this.idLB.Text = "ID:";
            // 
            // bookLB
            // 
            this.bookLB.AutoSize = true;
            this.bookLB.Location = new System.Drawing.Point(13, 49);
            this.bookLB.Name = "bookLB";
            this.bookLB.Size = new System.Drawing.Size(50, 20);
            this.bookLB.TabIndex = 1;
            this.bookLB.Text = "Book:";
            // 
            // authorLB
            // 
            this.authorLB.AutoSize = true;
            this.authorLB.Location = new System.Drawing.Point(274, 12);
            this.authorLB.Name = "authorLB";
            this.authorLB.Size = new System.Drawing.Size(61, 20);
            this.authorLB.TabIndex = 2;
            this.authorLB.Text = "Author:";
            // 
            // nocLB
            // 
            this.nocLB.AutoSize = true;
            this.nocLB.Location = new System.Drawing.Point(274, 49);
            this.nocLB.Name = "nocLB";
            this.nocLB.Size = new System.Drawing.Size(137, 20);
            this.nocLB.TabIndex = 3;
            this.nocLB.Text = "Number of copies:";
            // 
            // bid
            // 
            this.bid.Enabled = false;
            this.bid.Location = new System.Drawing.Point(86, 6);
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(182, 26);
            this.bid.TabIndex = 4;
            // 
            // bookTB
            // 
            this.bookTB.Location = new System.Drawing.Point(86, 42);
            this.bookTB.Name = "bookTB";
            this.bookTB.Size = new System.Drawing.Size(182, 26);
            this.bookTB.TabIndex = 5;
            // 
            // AuthorTB
            // 
            this.AuthorTB.Location = new System.Drawing.Point(406, 6);
            this.AuthorTB.Name = "AuthorTB";
            this.AuthorTB.Size = new System.Drawing.Size(183, 26);
            this.AuthorTB.TabIndex = 6;
            // 
            // nocTB
            // 
            this.nocTB.Location = new System.Drawing.Point(406, 49);
            this.nocTB.Name = "nocTB";
            this.nocTB.Size = new System.Drawing.Size(183, 26);
            this.nocTB.TabIndex = 7;
            // 
            // clearBT
            // 
            this.clearBT.Location = new System.Drawing.Point(17, 85);
            this.clearBT.Name = "clearBT";
            this.clearBT.Size = new System.Drawing.Size(93, 44);
            this.clearBT.TabIndex = 8;
            this.clearBT.Text = "Clear";
            this.clearBT.UseVisualStyleBackColor = true;
            // 
            // saveBT
            // 
            this.saveBT.Location = new System.Drawing.Point(173, 85);
            this.saveBT.Name = "saveBT";
            this.saveBT.Size = new System.Drawing.Size(95, 44);
            this.saveBT.TabIndex = 9;
            this.saveBT.Text = "Save";
            this.saveBT.UseVisualStyleBackColor = true;
            // 
            // updateBT
            // 
            this.updateBT.Location = new System.Drawing.Point(342, 85);
            this.updateBT.Name = "updateBT";
            this.updateBT.Size = new System.Drawing.Size(90, 44);
            this.updateBT.TabIndex = 10;
            this.updateBT.Text = "Update";
            this.updateBT.UseVisualStyleBackColor = true;
            // 
            // deleteBT
            // 
            this.deleteBT.Location = new System.Drawing.Point(500, 85);
            this.deleteBT.Name = "deleteBT";
            this.deleteBT.Size = new System.Drawing.Size(89, 44);
            this.deleteBT.TabIndex = 11;
            this.deleteBT.Text = "Delete";
            this.deleteBT.UseVisualStyleBackColor = true;
            // 
            // bookDG
            // 
            this.bookDG.BackgroundColor = System.Drawing.Color.BlanchedAlmond;
            this.bookDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDG.Location = new System.Drawing.Point(12, 145);
            this.bookDG.Name = "bookDG";
            this.bookDG.RowHeadersWidth = 62;
            this.bookDG.RowTemplate.Height = 28;
            this.bookDG.Size = new System.Drawing.Size(577, 243);
            this.bookDG.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookDG);
            this.Controls.Add(this.deleteBT);
            this.Controls.Add(this.updateBT);
            this.Controls.Add(this.saveBT);
            this.Controls.Add(this.clearBT);
            this.Controls.Add(this.nocTB);
            this.Controls.Add(this.AuthorTB);
            this.Controls.Add(this.bookTB);
            this.Controls.Add(this.bid);
            this.Controls.Add(this.nocLB);
            this.Controls.Add(this.authorLB);
            this.Controls.Add(this.bookLB);
            this.Controls.Add(this.idLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLB;
        private System.Windows.Forms.Label bookLB;
        private System.Windows.Forms.Label authorLB;
        private System.Windows.Forms.Label nocLB;
        private System.Windows.Forms.TextBox bid;
        private System.Windows.Forms.TextBox bookTB;
        private System.Windows.Forms.TextBox AuthorTB;
        private System.Windows.Forms.TextBox nocTB;
        private System.Windows.Forms.Button clearBT;
        private System.Windows.Forms.Button saveBT;
        private System.Windows.Forms.Button updateBT;
        private System.Windows.Forms.Button deleteBT;
        private System.Windows.Forms.DataGridView bookDG;
    }
}

