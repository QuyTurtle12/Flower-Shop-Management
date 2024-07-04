﻿namespace GUI
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
            cmbSeason.Items.AddRange(new object[] { "Spring", "Summer", "Fall", "Winter" });
            cmbSeason.Location = new Point(320, 439);
            cmbSeason.Margin = new Padding(4, 5, 4, 5);
            cmbSeason.Name = "cmbSeason";
            cmbSeason.Size = new Size(171, 33);
            cmbSeason.TabIndex = 24;
            cmbSeason.SelectedIndexChanged += cmbSeason_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(320, 174);
            txtName.Margin = new Padding(4, 5, 4, 5);
            txtName.Name = "txtName";
            txtName.Size = new Size(448, 31);
            txtName.TabIndex = 23;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(320, 241);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(448, 31);
            txtStock.TabIndex = 22;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(320, 307);
            txtColor.Margin = new Padding(4, 5, 4, 5);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(448, 31);
            txtColor.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(320, 374);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(448, 31);
            txtPrice.TabIndex = 20;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F);
            button1.Location = new Point(236, 522);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(146, 50);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(161, 439);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 30);
            label6.TabIndex = 18;
            label6.Text = "Season";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F);
            label5.Location = new Point(161, 372);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 30);
            label5.TabIndex = 17;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(161, 306);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 30);
            label4.TabIndex = 16;
            label4.Text = "Descripiton";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(161, 239);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 30);
            label3.TabIndex = 15;
            label3.Text = "Stock";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(161, 172);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 14;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(123, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 41);
            label1.TabIndex = 13;
            label1.Text = "Add Flower";
            // 
            // AddFlowerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 648);
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
            Load += AddFlowerForm_Load_1;
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