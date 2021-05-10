namespace Store
{
    partial class Store
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
            this.StoreManagerView = new System.Windows.Forms.TabControl();
            this.KassaView = new System.Windows.Forms.TabPage();
            this.exitButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.removeCart = new System.Windows.Forms.Button();
            this.addToCart = new System.Windows.Forms.Button();
            this.customerCart = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showStorageView = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LagerView = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textMediaType = new System.Windows.Forms.TextBox();
            this.quantityButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.textProduct = new System.Windows.Forms.TextBox();
            this.textArtNr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreManagerView.SuspendLayout();
            this.KassaView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStorageView)).BeginInit();
            this.LagerView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // StoreManagerView
            // 
            this.StoreManagerView.Controls.Add(this.KassaView);
            this.StoreManagerView.Controls.Add(this.LagerView);
            this.StoreManagerView.Location = new System.Drawing.Point(0, 2);
            this.StoreManagerView.Name = "StoreManagerView";
            this.StoreManagerView.SelectedIndex = 0;
            this.StoreManagerView.Size = new System.Drawing.Size(798, 445);
            this.StoreManagerView.TabIndex = 0;
            // 
            // KassaView
            // 
            this.KassaView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.KassaView.Controls.Add(this.exitButton);
            this.KassaView.Controls.Add(this.buyButton);
            this.KassaView.Controls.Add(this.removeCart);
            this.KassaView.Controls.Add(this.addToCart);
            this.KassaView.Controls.Add(this.customerCart);
            this.KassaView.Controls.Add(this.showStorageView);
            this.KassaView.Location = new System.Drawing.Point(4, 22);
            this.KassaView.Name = "KassaView";
            this.KassaView.Padding = new System.Windows.Forms.Padding(3);
            this.KassaView.Size = new System.Drawing.Size(790, 419);
            this.KassaView.TabIndex = 0;
            this.KassaView.Text = "Kassa";
            this.KassaView.Click += new System.EventHandler(this.Kassa_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(718, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(66, 39);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buyButton.Location = new System.Drawing.Point(636, 7);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 39);
            this.buyButton.TabIndex = 5;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // removeCart
            // 
            this.removeCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCart.Location = new System.Drawing.Point(553, 7);
            this.removeCart.Name = "removeCart";
            this.removeCart.Size = new System.Drawing.Size(76, 39);
            this.removeCart.TabIndex = 4;
            this.removeCart.Text = "Remove from cart";
            this.removeCart.UseVisualStyleBackColor = true;
            this.removeCart.Click += new System.EventHandler(this.removeCart_Click);
            // 
            // addToCart
            // 
            this.addToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCart.Location = new System.Drawing.Point(471, 7);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(75, 39);
            this.addToCart.TabIndex = 3;
            this.addToCart.Text = "Add to cart";
            this.addToCart.UseVisualStyleBackColor = true;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // customerCart
            // 
            this.customerCart.AllowUserToAddRows = false;
            this.customerCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.customerCart.Location = new System.Drawing.Point(471, 52);
            this.customerCart.Name = "customerCart";
            this.customerCart.ReadOnly = true;
            this.customerCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerCart.Size = new System.Drawing.Size(313, 309);
            this.customerCart.TabIndex = 2;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Artnr";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 50;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Product";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 75;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Price";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 75;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Quantity";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 75;
            // 
            // showStorageView
            // 
            this.showStorageView.AllowUserToAddRows = false;
            this.showStorageView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showStorageView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.showStorageView.Location = new System.Drawing.Point(8, 6);
            this.showStorageView.Name = "showStorageView";
            this.showStorageView.ReadOnly = true;
            this.showStorageView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showStorageView.Size = new System.Drawing.Size(456, 407);
            this.showStorageView.TabIndex = 1;
            this.showStorageView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.FillWeight = 75F;
            this.Column6.HeaderText = "Artnr";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Product";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Price";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 75;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Quantity";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 50;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Media type";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // LagerView
            // 
            this.LagerView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LagerView.Controls.Add(this.label5);
            this.LagerView.Controls.Add(this.textMediaType);
            this.LagerView.Controls.Add(this.quantityButton);
            this.LagerView.Controls.Add(this.removeButton);
            this.LagerView.Controls.Add(this.addButton);
            this.LagerView.Controls.Add(this.textQuantity);
            this.LagerView.Controls.Add(this.textPrice);
            this.LagerView.Controls.Add(this.textProduct);
            this.LagerView.Controls.Add(this.textArtNr);
            this.LagerView.Controls.Add(this.label4);
            this.LagerView.Controls.Add(this.label3);
            this.LagerView.Controls.Add(this.label2);
            this.LagerView.Controls.Add(this.label1);
            this.LagerView.Controls.Add(this.dataGridView1);
            this.LagerView.Location = new System.Drawing.Point(4, 22);
            this.LagerView.Name = "LagerView";
            this.LagerView.Padding = new System.Windows.Forms.Padding(3);
            this.LagerView.Size = new System.Drawing.Size(790, 419);
            this.LagerView.TabIndex = 1;
            this.LagerView.Text = "Lager";
            this.LagerView.Click += new System.EventHandler(this.Lager_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(552, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Media type:";
            // 
            // textMediaType
            // 
            this.textMediaType.Location = new System.Drawing.Point(660, 115);
            this.textMediaType.Name = "textMediaType";
            this.textMediaType.Size = new System.Drawing.Size(100, 20);
            this.textMediaType.TabIndex = 9;
            // 
            // quantityButton
            // 
            this.quantityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityButton.Location = new System.Drawing.Point(558, 255);
            this.quantityButton.Name = "quantityButton";
            this.quantityButton.Size = new System.Drawing.Size(88, 41);
            this.quantityButton.TabIndex = 12;
            this.quantityButton.Text = "Add quantity";
            this.quantityButton.UseVisualStyleBackColor = true;
            this.quantityButton.Click += new System.EventHandler(this.quantityButton_Click_1);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(558, 208);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(88, 41);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Remove product";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(557, 160);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(89, 42);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add new product";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(660, 87);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(100, 20);
            this.textQuantity.TabIndex = 8;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(660, 59);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(100, 20);
            this.textPrice.TabIndex = 7;
            // 
            // textProduct
            // 
            this.textProduct.Location = new System.Drawing.Point(660, 34);
            this.textProduct.Name = "textProduct";
            this.textProduct.Size = new System.Drawing.Size(100, 20);
            this.textProduct.TabIndex = 6;
            // 
            // textArtNr
            // 
            this.textArtNr.Location = new System.Drawing.Point(660, 8);
            this.textArtNr.Name = "textArtNr";
            this.textArtNr.Size = new System.Drawing.Size(100, 20);
            this.textArtNr.TabIndex = 5;
            this.textArtNr.TextChanged += new System.EventHandler(this.textArtNr_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(553, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "ArtNr:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(540, 407);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ArtNr";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Product";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Media type";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StoreManagerView);
            this.Name = "Store";
            this.Text = "Storemanager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StoreManagerView.ResumeLayout(false);
            this.KassaView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showStorageView)).EndInit();
            this.LagerView.ResumeLayout(false);
            this.LagerView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl StoreManagerView;
        private System.Windows.Forms.TabPage KassaView;
        private System.Windows.Forms.TabPage LagerView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridView showStorageView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox textQuantity;
        public System.Windows.Forms.TextBox textPrice;
        public System.Windows.Forms.TextBox textProduct;
        public System.Windows.Forms.TextBox textArtNr;
        public System.Windows.Forms.Button quantityButton;
        public System.Windows.Forms.Button removeButton;
        public System.Windows.Forms.Button addButton;
        public System.Windows.Forms.TextBox textMediaType;
        private System.Windows.Forms.DataGridView customerCart;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button removeCart;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
    }
}

