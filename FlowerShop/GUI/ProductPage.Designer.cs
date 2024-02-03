namespace GUI
{
    partial class ProductPage
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
            lbFlowerName = new Label();
            lbPrice = new Label();
            lbStock = new Label();
            lbSeason = new Label();
            lbDescription = new Label();
            txtFlowerName = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            cbSeason = new ComboBox();
            rtxtDescription = new RichTextBox();
            pbFlower = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbFlower).BeginInit();
            SuspendLayout();
            // 
            // lbFlowerName
            // 
            lbFlowerName.AutoSize = true;
            lbFlowerName.Location = new Point(59, 38);
            lbFlowerName.Name = "lbFlowerName";
            lbFlowerName.Size = new Size(77, 15);
            lbFlowerName.TabIndex = 0;
            lbFlowerName.Text = "Flower Name";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(59, 91);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 1;
            lbPrice.Text = "Price";
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new Point(59, 139);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(36, 15);
            lbStock.TabIndex = 2;
            lbStock.Text = "Stock";
            // 
            // lbSeason
            // 
            lbSeason.AutoSize = true;
            lbSeason.Location = new Point(59, 186);
            lbSeason.Name = "lbSeason";
            lbSeason.Size = new Size(44, 15);
            lbSeason.TabIndex = 3;
            lbSeason.Text = "Season";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(59, 237);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(67, 15);
            lbDescription.TabIndex = 4;
            lbDescription.Text = "Description";
            // 
            // txtFlowerName
            // 
            txtFlowerName.Location = new Point(147, 35);
            txtFlowerName.Name = "txtFlowerName";
            txtFlowerName.Size = new Size(121, 23);
            txtFlowerName.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(147, 88);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(121, 23);
            txtPrice.TabIndex = 6;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(147, 136);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(121, 23);
            txtStock.TabIndex = 7;
            // 
            // cbSeason
            // 
            cbSeason.FormattingEnabled = true;
            cbSeason.Items.AddRange(new object[] { "Spring", "Summer", "Autumn", "Winter" });
            cbSeason.Location = new Point(147, 183);
            cbSeason.Name = "cbSeason";
            cbSeason.Size = new Size(121, 23);
            cbSeason.TabIndex = 8;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(147, 234);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(258, 144);
            rtxtDescription.TabIndex = 10;
            rtxtDescription.Text = "";
            // 
            // pbFlower
            // 
            pbFlower.Image = Properties.Resources.defaultFlowerImage;
            pbFlower.Location = new Point(470, 66);
            pbFlower.Name = "pbFlower";
            pbFlower.Size = new Size(166, 170);
            pbFlower.TabIndex = 11;
            pbFlower.TabStop = false;
            pbFlower.Click += pictureBox1_Click;
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pbFlower);
            Controls.Add(rtxtDescription);
            Controls.Add(cbSeason);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtFlowerName);
            Controls.Add(lbDescription);
            Controls.Add(lbSeason);
            Controls.Add(lbStock);
            Controls.Add(lbPrice);
            Controls.Add(lbFlowerName);
            Name = "ProductPage";
            Text = "Product Page";
            ((System.ComponentModel.ISupportInitialize)pbFlower).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFlowerName;
        private Label lbPrice;
        private Label lbStock;
        private Label lbSeason;
        private Label lbDescription;
        private TextBox txtFlowerName;
        private TextBox txtPrice;
        private TextBox txtStock;
        private ComboBox cbSeason;
        private RichTextBox rtxtDescription;
        private PictureBox pbFlower;
    }
}