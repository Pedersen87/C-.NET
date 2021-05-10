namespace LottoProgram
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.LottoRow1 = new System.Windows.Forms.TextBox();
            this.LottoRow2 = new System.Windows.Forms.TextBox();
            this.LottoRow3 = new System.Windows.Forms.TextBox();
            this.LottoRow4 = new System.Windows.Forms.TextBox();
            this.LottoRow5 = new System.Windows.Forms.TextBox();
            this.LottoRow6 = new System.Windows.Forms.TextBox();
            this.LottoRow7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.draws = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.amount1 = new System.Windows.Forms.TextBox();
            this.amount2 = new System.Windows.Forms.TextBox();
            this.amount3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Din Lottorad: ";
            // 
            // LottoRow1
            // 
            this.LottoRow1.Location = new System.Drawing.Point(103, 6);
            this.LottoRow1.Name = "LottoRow1";
            this.LottoRow1.Size = new System.Drawing.Size(60, 20);
            this.LottoRow1.TabIndex = 1;
            this.LottoRow1.TextChanged += new System.EventHandler(this.LottoRow1_TextChanged);
            // 
            // LottoRow2
            // 
            this.LottoRow2.Location = new System.Drawing.Point(169, 6);
            this.LottoRow2.Name = "LottoRow2";
            this.LottoRow2.Size = new System.Drawing.Size(60, 20);
            this.LottoRow2.TabIndex = 2;
            this.LottoRow2.TextChanged += new System.EventHandler(this.LottoRow2_TextChanged);
            // 
            // LottoRow3
            // 
            this.LottoRow3.Location = new System.Drawing.Point(235, 6);
            this.LottoRow3.Name = "LottoRow3";
            this.LottoRow3.Size = new System.Drawing.Size(60, 20);
            this.LottoRow3.TabIndex = 3;
            this.LottoRow3.TextChanged += new System.EventHandler(this.LottoRow3_TextChanged);
            // 
            // LottoRow4
            // 
            this.LottoRow4.Location = new System.Drawing.Point(301, 6);
            this.LottoRow4.Name = "LottoRow4";
            this.LottoRow4.Size = new System.Drawing.Size(60, 20);
            this.LottoRow4.TabIndex = 4;
            this.LottoRow4.TextChanged += new System.EventHandler(this.LottoRow4_TextChanged);
            // 
            // LottoRow5
            // 
            this.LottoRow5.Location = new System.Drawing.Point(367, 6);
            this.LottoRow5.Name = "LottoRow5";
            this.LottoRow5.Size = new System.Drawing.Size(60, 20);
            this.LottoRow5.TabIndex = 5;
            this.LottoRow5.TextChanged += new System.EventHandler(this.LottoRow5_TextChanged);
            // 
            // LottoRow6
            // 
            this.LottoRow6.Location = new System.Drawing.Point(433, 6);
            this.LottoRow6.Name = "LottoRow6";
            this.LottoRow6.Size = new System.Drawing.Size(60, 20);
            this.LottoRow6.TabIndex = 6;
            this.LottoRow6.TextChanged += new System.EventHandler(this.LottoRow6_TextChanged);
            // 
            // LottoRow7
            // 
            this.LottoRow7.Location = new System.Drawing.Point(499, 6);
            this.LottoRow7.Name = "LottoRow7";
            this.LottoRow7.Size = new System.Drawing.Size(60, 20);
            this.LottoRow7.TabIndex = 7;
            this.LottoRow7.TextChanged += new System.EventHandler(this.LottoRow7_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Antal dragningar:  ";
            // 
            // draws
            // 
            this.draws.Location = new System.Drawing.Point(255, 46);
            this.draws.Name = "draws";
            this.draws.Size = new System.Drawing.Size(87, 20);
            this.draws.TabIndex = 9;
            this.draws.TextChanged += new System.EventHandler(this.draws_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(348, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Starta Lotto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(142, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "5 rätt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(245, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "6 rätt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "7 rätt:";
            // 
            // amount1
            // 
            this.amount1.Location = new System.Drawing.Point(189, 87);
            this.amount1.Name = "amount1";
            this.amount1.Size = new System.Drawing.Size(50, 20);
            this.amount1.TabIndex = 14;
            // 
            // amount2
            // 
            this.amount2.Location = new System.Drawing.Point(292, 87);
            this.amount2.Name = "amount2";
            this.amount2.Size = new System.Drawing.Size(50, 20);
            this.amount2.TabIndex = 15;
            // 
            // amount3
            // 
            this.amount3.Location = new System.Drawing.Point(395, 87);
            this.amount3.Name = "amount3";
            this.amount3.Size = new System.Drawing.Size(50, 20);
            this.amount3.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 112);
            this.Controls.Add(this.amount3);
            this.Controls.Add(this.amount2);
            this.Controls.Add(this.amount1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.draws);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LottoRow7);
            this.Controls.Add(this.LottoRow6);
            this.Controls.Add(this.LottoRow5);
            this.Controls.Add(this.LottoRow4);
            this.Controls.Add(this.LottoRow3);
            this.Controls.Add(this.LottoRow2);
            this.Controls.Add(this.LottoRow1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Lotto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TextBox LottoRow1;
        private System.Windows.Forms.TextBox LottoRow2;
        private System.Windows.Forms.TextBox LottoRow3;
        private System.Windows.Forms.TextBox LottoRow4;
        private System.Windows.Forms.TextBox LottoRow5;
        private System.Windows.Forms.TextBox LottoRow6;
        private System.Windows.Forms.TextBox LottoRow7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox draws;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amount1;
        private System.Windows.Forms.TextBox amount2;
        private System.Windows.Forms.TextBox amount3;
    }
}

