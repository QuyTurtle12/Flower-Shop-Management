namespace GUI.Orders_GUI
{
    partial class OrderDetails
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
            txtNumberOfItems = new TextBox();
            txtOrderNumber = new TextBox();
            label2 = new Label();
            btnClose = new Button();
            dgvOrderDetail = new DataGridView();
            txtID = new DataGridViewTextBoxColumn();
            txtFlowerName = new DataGridViewTextBoxColumn();
            txtSeason = new DataGridViewTextBoxColumn();
            txtAmount = new DataGridViewTextBoxColumn();
            txtTotalPrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 97);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of items";
            // 
            // txtNumberOfItems
            // 
            txtNumberOfItems.Location = new Point(150, 94);
            txtNumberOfItems.Name = "txtNumberOfItems";
            txtNumberOfItems.ReadOnly = true;
            txtNumberOfItems.Size = new Size(38, 23);
            txtNumberOfItems.TabIndex = 1;
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new Point(150, 52);
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.ReadOnly = true;
            txtOrderNumber.Size = new Size(100, 23);
            txtOrderNumber.TabIndex = 2;
            txtOrderNumber.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 55);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 3;
            label2.Text = "Order number";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(44, 332);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Columns.AddRange(new DataGridViewColumn[] { txtID, txtFlowerName, txtSeason, txtAmount, txtTotalPrice });
            dgvOrderDetail.Location = new Point(44, 144);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.ReadOnly = true;
            dgvOrderDetail.RowHeadersWidth = 62;
            dgvOrderDetail.Size = new Size(467, 150);
            dgvOrderDetail.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.HeaderText = "ID";
            txtID.MinimumWidth = 8;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Width = 43;
            // 
            // txtFlowerName
            // 
            txtFlowerName.HeaderText = "Flower Name";
            txtFlowerName.MinimumWidth = 8;
            txtFlowerName.Name = "txtFlowerName";
            txtFlowerName.ReadOnly = true;
            txtFlowerName.Width = 102;
            // 
            // txtSeason
            // 
            txtSeason.HeaderText = "Season";
            txtSeason.MinimumWidth = 8;
            txtSeason.Name = "txtSeason";
            txtSeason.ReadOnly = true;
            txtSeason.Width = 69;
            // 
            // txtAmount
            // 
            txtAmount.HeaderText = "Amount";
            txtAmount.MinimumWidth = 8;
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Width = 76;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.HeaderText = "Total Price";
            txtTotalPrice.MinimumWidth = 8;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Width = 86;
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 378);
            Controls.Add(dgvOrderDetail);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(txtOrderNumber);
            Controls.Add(txtNumberOfItems);
            Controls.Add(label1);
            Name = "OrderDetails";
            Text = "OrderDetails";
            Load += OrderDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumberOfItems;
        private TextBox txtOrderNumber;
        private Label label2;
        private Button btnClose;
        private DataGridView dgvOrderDetail;
        private DataGridViewTextBoxColumn txtID;
        private DataGridViewTextBoxColumn txtFlowerName;
        private DataGridViewTextBoxColumn txtSeason;
        private DataGridViewTextBoxColumn txtAmount;
        private DataGridViewTextBoxColumn txtTotalPrice;
    }
}