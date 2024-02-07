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
            dgvCart = new DataGridView();
            txtFlowerId = new DataGridViewTextBoxColumn();
            txtFlowerName = new DataGridViewLinkColumn();
            txtPrice = new DataGridViewTextBoxColumn();
            amount = new DataGridViewComboBoxColumn();
            btnPurchase = new Button();
            btnRemove = new Button();
            lbPrice = new Label();
            txtShopName = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // txtCart
            // 
            txtCart.AutoSize = true;
            txtCart.Font = new Font("Segoe UI", 13F);
            txtCart.Location = new Point(73, 152);
            txtCart.Margin = new Padding(4, 0, 4, 0);
            txtCart.Name = "txtCart";
            txtCart.Size = new Size(62, 36);
            txtCart.TabIndex = 0;
            txtCart.Text = "Cart";
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { txtFlowerId, txtFlowerName, txtPrice, amount });
            dgvCart.Location = new Point(73, 263);
            dgvCart.Margin = new Padding(4, 5, 4, 5);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 62;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(490, 250);
            dgvCart.TabIndex = 1;
            dgvCart.CellContentClick += dataGridView1_CellContentClick;
            dgvCart.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // txtFlowerId
            // 
            txtFlowerId.HeaderText = "Flower ID";
            txtFlowerId.MinimumWidth = 8;
            txtFlowerId.Name = "txtFlowerId";
            txtFlowerId.ReadOnly = true;
            txtFlowerId.Width = 150;
            // 
            // txtFlowerName
            // 
            txtFlowerName.HeaderText = "Flower Name";
            txtFlowerName.MinimumWidth = 8;
            txtFlowerName.Name = "txtFlowerName";
            txtFlowerName.ReadOnly = true;
            txtFlowerName.Resizable = DataGridViewTriState.True;
            txtFlowerName.SortMode = DataGridViewColumnSortMode.Automatic;
            txtFlowerName.Width = 150;
            // 
            // txtPrice
            // 
            txtPrice.HeaderText = "Price";
            txtPrice.MinimumWidth = 8;
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Width = 150;
            // 
            // amount
            // 
            amount.HeaderText = "Amount";
            amount.MinimumWidth = 8;
            amount.Name = "amount";
            amount.Resizable = DataGridViewTriState.True;
            amount.Width = 150;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(877, 627);
            btnPurchase.Margin = new Padding(4, 5, 4, 5);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(107, 38);
            btnPurchase.TabIndex = 2;
            btnPurchase.Text = "Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(589, 263);
            btnRemove.Margin = new Padding(4, 5, 4, 5);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(107, 38);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 13F);
            lbPrice.Location = new Point(877, 530);
            lbPrice.Margin = new Padding(4, 0, 4, 0);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(84, 36);
            lbPrice.TabIndex = 4;
            lbPrice.Text = "0.00 $";
            // 
            // txtShopName
            // 
            txtShopName.AutoSize = true;
            txtShopName.Font = new Font("Segoe UI", 13F);
            txtShopName.Location = new Point(73, 63);
            txtShopName.Margin = new Padding(4, 0, 4, 0);
            txtShopName.Name = "txtShopName";
            txtShopName.Size = new Size(149, 36);
            txtShopName.TabIndex = 5;
            txtShopName.Text = "Shop Name";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(txtShopName);
            Controls.Add(lbPrice);
            Controls.Add(btnRemove);
            Controls.Add(btnPurchase);
            Controls.Add(dgvCart);
            Controls.Add(txtCart);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Cart";
            Text = "Cart";
            Load += Cart_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtCart;
        private DataGridView dgvCart;
        private Button btnPurchase;
        private Button btnRemove;
        private Label lbPrice;
        private Label txtShopName;
        private DataGridViewTextBoxColumn txtFlowerId;
        private DataGridViewLinkColumn txtFlowerName;
        private DataGridViewTextBoxColumn txtPrice;
        private DataGridViewComboBoxColumn amount;
    }
}