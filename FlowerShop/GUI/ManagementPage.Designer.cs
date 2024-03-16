namespace GUI
{
    partial class ManagementPage
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
            btnManageOrder = new Button();
            btnDashboard = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnHomePage = new Button();
            btnStaffManager = new Button();
            label1 = new Label();
            label2 = new Label();
            btnCustomer = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnManageOrder
            // 
            btnManageOrder.Location = new Point(2, 2);
            btnManageOrder.Margin = new Padding(2);
            btnManageOrder.Name = "btnManageOrder";
            btnManageOrder.Size = new Size(244, 46);
            btnManageOrder.TabIndex = 23;
            btnManageOrder.Text = "Order Management";
            btnManageOrder.UseVisualStyleBackColor = true;
            btnManageOrder.Click += btnManageOrder_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(251, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(264, 44);
            btnDashboard.TabIndex = 21;
            btnDashboard.Text = "Flower Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.87645F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.12355F));
            tableLayoutPanel1.Controls.Add(btnManageOrder, 0, 0);
            tableLayoutPanel1.Controls.Add(btnDashboard, 1, 0);
            tableLayoutPanel1.Controls.Add(btnStaffManager, 1, 1);
            tableLayoutPanel1.Controls.Add(btnHomePage, 0, 1);
            tableLayoutPanel1.Controls.Add(btnCustomer, 0, 2);
            tableLayoutPanel1.Location = new Point(59, 67);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 227F));
            tableLayoutPanel1.Size = new Size(518, 328);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // btnHomePage
            // 
            btnHomePage.Location = new Point(2, 52);
            btnHomePage.Margin = new Padding(2);
            btnHomePage.Name = "btnHomePage";
            btnHomePage.Size = new Size(244, 47);
            btnHomePage.TabIndex = 25;
            btnHomePage.Text = "Home Page";
            btnHomePage.UseVisualStyleBackColor = true;
            btnHomePage.Click += btnHomePage_Click;
            // 
            // btnStaffManager
            // 
            btnStaffManager.Location = new Point(250, 52);
            btnStaffManager.Margin = new Padding(2);
            btnStaffManager.Name = "btnStaffManager";
            btnStaffManager.Size = new Size(266, 47);
            btnStaffManager.TabIndex = 24;
            btnStaffManager.Text = "Staff Manager";
            btnStaffManager.UseVisualStyleBackColor = true;
            btnStaffManager.Click += btnStaffManager_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(122, 39);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 25;
            label1.Text = "Staff/Admin";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(385, 39);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 26;
            label2.Text = "Admin Only";
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(2, 103);
            btnCustomer.Margin = new Padding(2);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(244, 57);
            btnCustomer.TabIndex = 26;
            btnCustomer.Text = "Customer Management";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // ManagementPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 462);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "ManagementPage";
            Text = "Management Page";
            Load += ManagementPage_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnManageOrder;
        private Button btnDashboard;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnStaffManager;
        private Label label1;
        private Label label2;
        private Button btnHomePage;
        private Button btnCustomer;
    }
}