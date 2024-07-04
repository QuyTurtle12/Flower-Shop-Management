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
            txtDescription = new TextBox();
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
            cmbSeason.Items.AddRange(new object[] { "Spring", "Summer", "Fall", "Winter" });
            cmbSeason.Location = new Point(275, 424);
            cmbSeason.Margin = new Padding(4, 5, 4, 5);
            cmbSeason.Name = "cmbSeason";
            cmbSeason.Size = new Size(171, 33);
            cmbSeason.TabIndex = 36;
            // 
            // txtName
            // 
            txtName.Location = new Point(275, 159);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(448, 31);
            txtName.TabIndex = 35;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(275, 226);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(448, 31);
            txtStock.TabIndex = 34;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(275, 292);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(448, 31);
            txtDescription.TabIndex = 33;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(275, 359);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(448, 31);
            txtPrice.TabIndex = 32;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(190, 507);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(146, 50);
            button1.TabIndex = 31;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(116, 424);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 30);
            label6.TabIndex = 30;
            label6.Text = "Season";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(116, 357);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 30);
            label5.TabIndex = 29;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(116, 291);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 30);
            label4.TabIndex = 28;
            label4.Text = "Descripiton";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(116, 224);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 30);
            label3.TabIndex = 27;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(116, 157);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 26;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(77, 61);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 41);
            label1.TabIndex = 25;
            label1.Text = "Update Flower";
            // 
            // UpdateFlower
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 598);
            Controls.Add(cmbSeason);
            Controls.Add(txtName);
            Controls.Add(txtStock);
            Controls.Add(txtDescription);
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
        private TextBox txtDescription;
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