namespace MediaIntegrator
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
            this.fButton = new System.Windows.Forms.Button();
            this.tButton = new System.Windows.Forms.Button();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fButton
            // 
            this.fButton.Location = new System.Drawing.Point(13, 13);
            this.fButton.Name = "fButton";
            this.fButton.Size = new System.Drawing.Size(75, 23);
            this.fButton.TabIndex = 0;
            this.fButton.Text = "Från";
            this.fButton.UseVisualStyleBackColor = true;
            this.fButton.Click += new System.EventHandler(this.fButton_Click);
            // 
            // tButton
            // 
            this.tButton.Location = new System.Drawing.Point(13, 43);
            this.tButton.Name = "tButton";
            this.tButton.Size = new System.Drawing.Size(75, 23);
            this.tButton.TabIndex = 1;
            this.tButton.Text = "Till";
            this.tButton.UseVisualStyleBackColor = true;
            this.tButton.Click += new System.EventHandler(this.tButton_Click);
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(95, 13);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(251, 20);
            this.textBoxF.TabIndex = 2;
            // 
            // textBoxT
            // 
            this.textBoxT.Location = new System.Drawing.Point(95, 43);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(251, 20);
            this.textBoxT.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 84);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.tButton);
            this.Controls.Add(this.fButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fButton;
        private System.Windows.Forms.Button tButton;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.TextBox textBoxT;
    }
}

