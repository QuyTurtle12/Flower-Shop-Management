namespace GUI.Orders_GUI
{
    partial class MyOrders
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
            label1 = new Label();
            lbPhoneNumber = new Label();
            lbEmail = new Label();
            lbClientID = new Label();
            dgvOrder = new DataGridView();
            txtOrderId = new DataGridViewLinkColumn();
            txtTotalPrice = new DataGridViewTextBoxColumn();
            txtPaymentMethod = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            txtAddress = new DataGridViewTextBoxColumn();
            txtStatus = new DataGridViewTextBoxColumn();
            txtOrderDate = new DataGridViewTextBoxColumn();
            txtShippedDate = new DataGridViewTextBoxColumn();
            lbOrdersHistory = new Label();
            txtClient = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            txtClientID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 53);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Client";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(43, 91);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(86, 15);
            lbPhoneNumber.TabIndex = 1;
            lbPhoneNumber.Text = "Phone number";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(43, 131);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbClientID
            // 
            lbClientID.AutoSize = true;
            lbClientID.Location = new Point(43, 173);
            lbClientID.Name = "lbClientID";
            lbClientID.Size = new Size(52, 15);
            lbClientID.TabIndex = 3;
            lbClientID.Text = "Client ID";
            // 
            // dgvOrder
            // 
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { txtOrderId, txtTotalPrice, txtPaymentMethod, PhoneNumber, txtAddress, txtStatus, txtOrderDate, txtShippedDate });
            dgvOrder.Location = new Point(29, 243);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.Size = new Size(643, 150);
            dgvOrder.TabIndex = 4;
            dgvOrder.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtOrderId
            // 
            txtOrderId.HeaderText = "Order";
            txtOrderId.MinimumWidth = 8;
            txtOrderId.Name = "txtOrderId";
            txtOrderId.ReadOnly = true;
            txtOrderId.Width = 43;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.HeaderText = "Total Price";
            txtTotalPrice.MinimumWidth = 8;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Resizable = DataGridViewTriState.True;
            txtTotalPrice.SortMode = DataGridViewColumnSortMode.NotSortable;
            txtTotalPrice.Width = 67;
            // 
            // txtPaymentMethod
            // 
            txtPaymentMethod.HeaderText = "Payment Method";
            txtPaymentMethod.MinimumWidth = 8;
            txtPaymentMethod.Name = "txtPaymentMethod";
            txtPaymentMethod.ReadOnly = true;
            txtPaymentMethod.Resizable = DataGridViewTriState.True;
            txtPaymentMethod.SortMode = DataGridViewColumnSortMode.NotSortable;
            txtPaymentMethod.Width = 105;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.MinimumWidth = 8;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Width = 113;
            // 
            // txtAddress
            // 
            txtAddress.HeaderText = "Address";
            txtAddress.MinimumWidth = 8;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Width = 74;
            // 
            // txtStatus
            // 
            txtStatus.HeaderText = "Status";
            txtStatus.MinimumWidth = 8;
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Resizable = DataGridViewTriState.True;
            txtStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            txtStatus.Width = 45;
            // 
            // txtOrderDate
            // 
            txtOrderDate.HeaderText = "Ordered Date";
            txtOrderDate.MinimumWidth = 8;
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.ReadOnly = true;
            txtOrderDate.Width = 102;
            // 
            // txtShippedDate
            // 
            txtShippedDate.HeaderText = "Shipped Date";
            txtShippedDate.MinimumWidth = 8;
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.ReadOnly = true;
            txtShippedDate.Width = 102;
            // 
            // lbOrdersHistory
            // 
            lbOrdersHistory.AutoSize = true;
            lbOrdersHistory.Location = new Point(43, 19);
            lbOrdersHistory.Name = "lbOrdersHistory";
            lbOrdersHistory.Size = new Size(83, 15);
            lbOrdersHistory.TabIndex = 5;
            lbOrdersHistory.Text = "Orders History";
            // 
            // txtClient
            // 
            txtClient.Location = new Point(137, 50);
            txtClient.Name = "txtClient";
            txtClient.ReadOnly = true;
            txtClient.Size = new Size(125, 23);
            txtClient.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(137, 88);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(125, 23);
            txtPhoneNumber.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(137, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(125, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtClientID
            // 
            txtClientID.Location = new Point(137, 170);
            txtClientID.Name = "txtClientID";
            txtClientID.ReadOnly = true;
            txtClientID.Size = new Size(125, 23);
            txtClientID.TabIndex = 9;
            // 
            // MyOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 450);
            Controls.Add(txtClientID);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtClient);
            Controls.Add(lbOrdersHistory);
            Controls.Add(dgvOrder);
            Controls.Add(lbClientID);
            Controls.Add(lbEmail);
            Controls.Add(lbPhoneNumber);
            Controls.Add(label1);
            Name = "MyOrders";
            Text = "MyOrders";
            Load += MyOrders_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbPhoneNumber;
        private Label lbEmail;
        private Label lbClientID;
        private DataGridView dgvOrder;
        private Label lbOrdersHistory;
        private TextBox txtClient;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private TextBox txtClientID;
        private DataGridViewLinkColumn txtOrderId;
        private DataGridViewTextBoxColumn txtTotalPrice;
        private DataGridViewTextBoxColumn txtPaymentMethod;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn txtAddress;
        private DataGridViewTextBoxColumn txtStatus;
        private DataGridViewTextBoxColumn txtOrderDate;
        private DataGridViewTextBoxColumn txtShippedDate;
    }
}