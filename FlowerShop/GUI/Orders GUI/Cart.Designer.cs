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
            btnUpdate = new Button();
            lbTotalPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
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
            // dgvCart
            // 
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { txtFlowerId, txtFlowerName, txtPrice, amount });
            dgvCart.Location = new Point(50, 158);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 62;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(343, 241);
            dgvCart.TabIndex = 1;
            dgvCart.CellContentClick += dataGridView1_CellContentClick;
            dgvCart.CellValueChanged += dgvCart_CellValueChanged;
            dgvCart.DataBindingComplete += dataGridView1_DataBindingComplete;
            // 
            // txtFlowerId
            // 
            txtFlowerId.HeaderText = "Flower ID";
            txtFlowerId.MinimumWidth = 8;
            txtFlowerId.Name = "txtFlowerId";
            txtFlowerId.ReadOnly = true;
            txtFlowerId.Visible = false;
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
            txtFlowerName.Width = 102;
            // 
            // txtPrice
            // 
            txtPrice.HeaderText = "Price";
            txtPrice.MinimumWidth = 8;
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.Width = 58;
            // 
            // amount
            // 
            amount.HeaderText = "Amount";
            amount.MinimumWidth = 8;
            amount.Name = "amount";
            amount.Resizable = DataGridViewTriState.True;
            amount.Width = 57;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(527, 376);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(75, 23);
            btnPurchase.TabIndex = 2;
            btnPurchase.Text = "Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(412, 158);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(75, 23);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 13F);
            lbPrice.Location = new Point(541, 339);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(61, 25);
            lbPrice.TabIndex = 4;
            lbPrice.Text = "0.00 $";
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
            // btnUpdate
            // 
            btnUpdate.Location = new Point(412, 199);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Font = new Font("Segoe UI", 13F);
            lbTotalPrice.Location = new Point(541, 303);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(49, 25);
            lbTotalPrice.TabIndex = 7;
            lbTotalPrice.Text = "Total";
            // 
            // Cart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 456);
            Controls.Add(lbTotalPrice);
            Controls.Add(btnUpdate);
            Controls.Add(txtShopName);
            Controls.Add(lbPrice);
            Controls.Add(btnRemove);
            Controls.Add(btnPurchase);
            Controls.Add(dgvCart);
            Controls.Add(txtCart);
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
        private Button btnUpdate;
        private DataGridViewTextBoxColumn txtFlowerId;
        private DataGridViewLinkColumn txtFlowerName;
        private DataGridViewTextBoxColumn txtPrice;
        private DataGridViewComboBoxColumn amount;
        private Label lbTotalPrice;
    }
}