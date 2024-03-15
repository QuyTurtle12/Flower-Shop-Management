namespace GUI
{
    partial class UpdateFlower
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
            cmbSeason = new ComboBox();
            txtName = new TextBox();
            txtStock = new TextBox();
            txtColor = new TextBox();
            txtPrice = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbSeason
            // 
            cmbSeason.FormattingEnabled = true;
            cmbSeason.Items.AddRange(new object[] { "spring", "summer", "fall", "winter" });
            cmbSeason.Location = new Point(181, 258);
            cmbSeason.Name = "cmbSeason";
            cmbSeason.Size = new Size(121, 23);
            cmbSeason.TabIndex = 24;
            // 
            // txtName
            // 
            txtName.Location = new Point(181, 99);
            txtName.Name = "txtName";
            txtName.Size = new Size(315, 23);
            txtName.TabIndex = 23;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(181, 139);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(315, 23);
            txtStock.TabIndex = 22;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(181, 179);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(315, 23);
            txtColor.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(181, 219);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(315, 23);
            txtPrice.TabIndex = 20;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(122, 308);
            button1.Name = "button1";
            button1.Size = new Size(102, 30);
            button1.TabIndex = 19;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(70, 258);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 18;
            label6.Text = "Season";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(70, 218);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 17;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(70, 178);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 16;
            label4.Text = "Descripiton";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(70, 138);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 15;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(70, 98);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 14;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(43, 40);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 13;
            label1.Text = "Update Flower";
            // 
            // UpdateFlower
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 449);
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
            Name = "UpdateFlower";
            Text = "UpdateFlower";
            Load += UpdateFlower_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSeason;
        private TextBox txtName;
        private TextBox txtStock;
        private TextBox txtColor;
        private TextBox txtPrice;
        private Button button1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}