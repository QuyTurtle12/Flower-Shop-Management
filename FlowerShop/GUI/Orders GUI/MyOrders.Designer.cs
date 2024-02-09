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
            lbOrdersHistory = new Label();
            txtClient = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            txtClientID = new TextBox();
            txtOrderId = new DataGridViewLinkColumn();
            txtTotalPrice = new DataGridViewTextBoxColumn();
            txtPaymentMethod = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            txtAddress = new DataGridViewTextBoxColumn();
            txtStatus = new DataGridViewTextBoxColumn();
            txtOrderDate = new DataGridViewTextBoxColumn();
            txtShippedDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 88);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Client";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(61, 152);
            lbPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(129, 25);
            lbPhoneNumber.TabIndex = 1;
            lbPhoneNumber.Text = "Phone number";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(61, 218);
            lbEmail.Margin = new Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(54, 25);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // lbClientID
            // 
            lbClientID.AutoSize = true;
            lbClientID.Location = new Point(61, 288);
            lbClientID.Margin = new Padding(4, 0, 4, 0);
            lbClientID.Name = "lbClientID";
            lbClientID.Size = new Size(79, 25);
            lbClientID.TabIndex = 3;
            lbClientID.Text = "Client ID";
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Columns.AddRange(new DataGridViewColumn[] { txtOrderId, txtTotalPrice, txtPaymentMethod, PhoneNumber, txtAddress, txtStatus, txtOrderDate, txtShippedDate });
            dgvOrder.Location = new Point(41, 405);
            dgvOrder.Margin = new Padding(4, 5, 4, 5);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersWidth = 62;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.Size = new Size(919, 250);
            dgvOrder.TabIndex = 4;
            dgvOrder.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbOrdersHistory
            // 
            lbOrdersHistory.AutoSize = true;
            lbOrdersHistory.Location = new Point(61, 32);
            lbOrdersHistory.Margin = new Padding(4, 0, 4, 0);
            lbOrdersHistory.Name = "lbOrdersHistory";
            lbOrdersHistory.Size = new Size(128, 25);
            lbOrdersHistory.TabIndex = 5;
            lbOrdersHistory.Text = "Orders History";
            // 
            // txtClient
            // 
            txtClient.Location = new Point(196, 83);
            txtClient.Margin = new Padding(4, 5, 4, 5);
            txtClient.Name = "txtClient";
            txtClient.ReadOnly = true;
            txtClient.Size = new Size(177, 31);
            txtClient.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(196, 147);
            txtPhoneNumber.Margin = new Padding(4, 5, 4, 5);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(177, 31);
            txtPhoneNumber.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(196, 213);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(177, 31);
            txtEmail.TabIndex = 8;
            // 
            // txtClientID
            // 
            txtClientID.Location = new Point(196, 283);
            txtClientID.Margin = new Padding(4, 5, 4, 5);
            txtClientID.Name = "txtClientID";
            txtClientID.ReadOnly = true;
            txtClientID.Size = new Size(177, 31);
            txtClientID.TabIndex = 9;
            // 
            // txtOrderId
            // 
            txtOrderId.HeaderText = "Order";
            txtOrderId.MinimumWidth = 8;
            txtOrderId.Name = "txtOrderId";
            txtOrderId.ReadOnly = true;
            txtOrderId.Width = 150;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.HeaderText = "Total Price";
            txtTotalPrice.MinimumWidth = 8;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Resizable = DataGridViewTriState.True;
            txtTotalPrice.SortMode = DataGridViewColumnSortMode.NotSortable;
            txtTotalPrice.Width = 150;
            // 
            // txtPaymentMethod
            // 
            txtPaymentMethod.HeaderText = "Payment Method";
            txtPaymentMethod.MinimumWidth = 8;
            txtPaymentMethod.Name = "txtPaymentMethod";
            txtPaymentMethod.ReadOnly = true;
            txtPaymentMethod.Resizable = DataGridViewTriState.True;
            txtPaymentMethod.SortMode = DataGridViewColumnSortMode.NotSortable;
            txtPaymentMethod.Width = 150;
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Phone Number";
            PhoneNumber.MinimumWidth = 8;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Width = 150;
            // 
            // txtAddress
            // 
            txtAddress.HeaderText = "Address";
            txtAddress.MinimumWidth = 8;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Width = 150;
            // 
            // txtStatus
            // 
            txtStatus.HeaderText = "Status";
            txtStatus.MinimumWidth = 8;
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Resizable = DataGridViewTriState.True;
            txtStatus.SortMode = DataGridViewColumnSortMode.NotSortable;
            txtStatus.Width = 150;
            // 
            // txtOrderDate
            // 
            txtOrderDate.HeaderText = "Ordered Date";
            txtOrderDate.MinimumWidth = 8;
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.ReadOnly = true;
            txtOrderDate.Width = 150;
            // 
            // txtShippedDate
            // 
            txtShippedDate.HeaderText = "Shipped Date";
            txtShippedDate.MinimumWidth = 8;
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.ReadOnly = true;
            txtShippedDate.Width = 150;
            // 
            // MyOrders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 750);
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
            Margin = new Padding(4, 5, 4, 5);
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