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
            dataGridView1 = new DataGridView();
            lbOrdersHistory = new Label();
            txtClient = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            txtClientID = new TextBox();
            ID = new DataGridViewTextBoxColumn();
            orders = new DataGridViewLinkColumn();
            total_price = new DataGridViewTextBoxColumn();
            payment_method = new DataGridViewComboBoxColumn();
            status = new DataGridViewComboBoxColumn();
            date = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, orders, total_price, payment_method, status, date });
            dataGridView1.Location = new Point(29, 243);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 150);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            txtClient.Size = new Size(125, 23);
            txtClient.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(137, 88);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(125, 23);
            txtPhoneNumber.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(137, 128);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtClientID
            // 
            txtClientID.Location = new Point(137, 170);
            txtClientID.Name = "txtClientID";
            txtClientID.Size = new Size(125, 23);
            txtClientID.TabIndex = 9;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // orders
            // 
            orders.HeaderText = "Orders";
            orders.Name = "orders";
            // 
            // total_price
            // 
            total_price.HeaderText = "Total Price";
            total_price.Name = "total_price";
            total_price.Resizable = DataGridViewTriState.True;
            total_price.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // payment_method
            // 
            payment_method.HeaderText = "Payment method";
            payment_method.Items.AddRange(new object[] { "Bank card", "Cash", "Zalo Pay" });
            payment_method.Name = "payment_method";
            payment_method.Resizable = DataGridViewTriState.True;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.Items.AddRange(new object[] { "Unprocessed", "Canceled", "Processing", "Delivering", "Finished" });
            status.Name = "status";
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.Name = "date";
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
            Controls.Add(dataGridView1);
            Controls.Add(lbClientID);
            Controls.Add(lbEmail);
            Controls.Add(lbPhoneNumber);
            Controls.Add(label1);
            Name = "MyOrders";
            Text = "MyOrders";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbPhoneNumber;
        private Label lbEmail;
        private Label lbClientID;
        private DataGridView dataGridView1;
        private Label lbOrdersHistory;
        private TextBox txtClient;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private TextBox txtClientID;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewLinkColumn orders;
        private DataGridViewTextBoxColumn total_price;
        private DataGridViewComboBoxColumn payment_method;
        private DataGridViewComboBoxColumn status;
        private DataGridViewTextBoxColumn date;
    }
}