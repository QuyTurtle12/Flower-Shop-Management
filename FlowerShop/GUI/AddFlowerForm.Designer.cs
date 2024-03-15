namespace GUI
{
    partial class AddFlowerForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            txtPrice = new TextBox();
            txtColor = new TextBox();
            txtStock = new TextBox();
            txtName = new TextBox();
            cmbSeason = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 0;
            label1.Text = "Add Flower";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(50, 80);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(50, 120);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(50, 160);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 3;
            label4.Text = "Descripiton";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(50, 200);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 4;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(50, 240);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 5;
            label6.Text = "Season";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(102, 290);
            button1.Name = "button1";
            button1.Size = new Size(102, 30);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAdd_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(161, 201);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(315, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(161, 161);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(315, 23);
            txtColor.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(161, 121);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(315, 23);
            txtStock.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(161, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(315, 23);
            txtName.TabIndex = 11;
            // 
            // cmbSeason
            // 
            cmbSeason.FormattingEnabled = true;
            cmbSeason.Items.AddRange(new object[] { "spring", "summer", "fall", "winter" });
            cmbSeason.Location = new Point(161, 240);
            cmbSeason.Name = "cmbSeason";
            cmbSeason.Size = new Size(121, 23);
            cmbSeason.TabIndex = 12;
            // 
            // AddFlowerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 384);
            Controls.Add(cmbSeason);
            Controls.Add(txtName);
            Controls.Add(txtStock);
            Controls.Add(txtColor);
            Controls.Add(txtPrice);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddFlowerForm";
            Text = "AddFlowerForm";
            Load += AddFlowerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox txtPrice;
        private TextBox txtColor;
        private TextBox txtStock;
        private TextBox txtName;
        private ComboBox cmbSeason;
    }
}