namespace GUI
{
    partial class Cart
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
            txtCart = new Label();
            dataGridView1 = new DataGridView();
            btnPurchase = new Button();
            btnRemove = new Button();
            lbPrice = new Label();
            txtFlowerName = new DataGridViewLinkColumn();
            txtPrice = new DataGridViewTextBoxColumn();
            amount = new DataGridViewComboBoxColumn();
            txtShopName = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtCart
            // 
            txtCart.AutoSize = true;
            txtCart.Font = new Font("Segoe UI", 13F);
            txtCart.Location = new Point(51, 91);
            txtCart.Name = "txtCart";
            txtCart.Size = new Size(44, 25);
            txtCart.TabIndex = 0;
            txtCart.Text = "Cart";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { txtFlowerName, txtPrice, amount });
            dataGridView1.Location = new Point(51, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 150);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(614, 376);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(75, 23);
            btnPurchase.TabIndex = 2;
            btnPurchase.Text = "Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(412, 158);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 13F);
            lbPrice.Location = new Point(614, 318);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(61, 25);
            lbPrice.TabIndex = 4;
            lbPrice.Text = "0.00 $";
            // 
            // txtFlowerName
            // 
            txtFlowerName.HeaderText = "Flower Name";
            txtFlowerName.Name = "txtFlowerName";
            txtFlowerName.Resizable = DataGridViewTriState.True;
            txtFlowerName.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // txtPrice
            // 
            txtPrice.HeaderText = "Price";
            txtPrice.Name = "txtPrice";
            // 
            // amount
            // 
            amount.HeaderText = "Amount";
            amount.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            amount.Name = "amount";
            // 
            // txtShopName
            // 
            txtShopName.AutoSize = true;
            txtShopName.Font = new Font("Segoe UI", 13F);
            txtShopName.Location = new Point(51, 38);
            txtShopName.Name = "txtShopName";
            txtShopName.Size = new Size(106, 25);
            txtShopName.TabIndex = 5;
            txtShopName.Text = "Shop Name";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtShopName);
            Controls.Add(lbPrice);
            Controls.Add(btnRemove);
            Controls.Add(btnPurchase);
            Controls.Add(dataGridView1);
            Controls.Add(txtCart);
            Name = "Cart";
            Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCart;
        private DataGridView dataGridView1;
        private Button btnPurchase;
        private Button btnRemove;
        private DataGridViewLinkColumn txtFlowerName;
        private DataGridViewTextBoxColumn txtPrice;
        private DataGridViewComboBoxColumn amount;
        private Label lbPrice;
        private Label txtShopName;
    }
}