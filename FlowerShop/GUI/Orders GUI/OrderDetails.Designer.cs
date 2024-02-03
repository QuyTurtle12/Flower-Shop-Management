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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            flower_name = new DataGridViewTextBoxColumn();
            season = new DataGridViewTextBoxColumn();
            amount = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            total_price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            txtNumberOfItems.Size = new Size(38, 23);
            txtNumberOfItems.TabIndex = 1;
            //txtNumberOfItems.TextChanged += this.textBox1_TextChanged;
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new Point(150, 52);
            txtOrderNumber.Name = "txtOrderNumber";
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, flower_name, season, amount, unit_price, total_price });
            dataGridView1.Location = new Point(44, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(642, 150);
            dataGridView1.TabIndex = 5;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // flower_name
            // 
            flower_name.HeaderText = "Flower Name";
            flower_name.Name = "flower_name";
            // 
            // season
            // 
            season.HeaderText = "Season";
            season.Name = "season";
            // 
            // amount
            // 
            amount.HeaderText = "Amount";
            amount.Name = "amount";
            // 
            // unit_price
            // 
            unit_price.HeaderText = "Unit price";
            unit_price.Name = "unit_price";
            // 
            // total_price
            // 
            total_price.HeaderText = "Total Price";
            total_price.Name = "total_price";
            // 
            // OrderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 378);
            Controls.Add(dataGridView1);
            Controls.Add(btnClose);
            Controls.Add(label2);
            Controls.Add(txtOrderNumber);
            Controls.Add(txtNumberOfItems);
            Controls.Add(label1);
            Name = "OrderDetails";
            Text = "OrderDetails";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumberOfItems;
        private TextBox txtOrderNumber;
        private Label label2;
        private Button btnClose;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn flower_name;
        private DataGridViewTextBoxColumn season;
        private DataGridViewTextBoxColumn amount;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewTextBoxColumn total_price;
    }
}