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
            lbFlowerName.Location = new Point(84, 63);
            lbFlowerName.Margin = new Padding(4, 0, 4, 0);
            lbFlowerName.Name = "lbFlowerName";
            lbFlowerName.Size = new Size(116, 25);
            lbFlowerName.TabIndex = 0;
            lbFlowerName.Text = "Flower Name";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(84, 152);
            lbPrice.Margin = new Padding(4, 0, 4, 0);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(49, 25);
            lbPrice.TabIndex = 1;
            lbPrice.Text = "Price";
            // 
            // lbStock
            // 
            lbStock.AutoSize = true;
            lbStock.Location = new Point(84, 232);
            lbStock.Margin = new Padding(4, 0, 4, 0);
            lbStock.Name = "lbStock";
            lbStock.Size = new Size(55, 25);
            lbStock.TabIndex = 2;
            lbStock.Text = "Stock";
            // 
            // lbSeason
            // 
            lbSeason.AutoSize = true;
            lbSeason.Location = new Point(84, 310);
            lbSeason.Margin = new Padding(4, 0, 4, 0);
            lbSeason.Name = "lbSeason";
            lbSeason.Size = new Size(69, 25);
            lbSeason.TabIndex = 3;
            lbSeason.Text = "Season";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Location = new Point(84, 395);
            lbDescription.Margin = new Padding(4, 0, 4, 0);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(102, 25);
            lbDescription.TabIndex = 4;
            lbDescription.Text = "Description";
            // 
            // txtFlowerName
            // 
            txtFlowerName.Location = new Point(210, 58);
            txtFlowerName.Margin = new Padding(4, 5, 4, 5);
            txtFlowerName.Name = "txtFlowerName";
            txtFlowerName.Size = new Size(171, 31);
            txtFlowerName.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(210, 147);
            txtPrice.Margin = new Padding(4, 5, 4, 5);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(171, 31);
            txtPrice.TabIndex = 6;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(210, 227);
            txtStock.Margin = new Padding(4, 5, 4, 5);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(171, 31);
            txtStock.TabIndex = 7;
            // 
            // cbSeason
            // 
            cbSeason.FormattingEnabled = true;
            cbSeason.Items.AddRange(new object[] { "Spring", "Summer", "Autumn", "Winter" });
            cbSeason.Location = new Point(210, 305);
            cbSeason.Margin = new Padding(4, 5, 4, 5);
            cbSeason.Name = "cbSeason";
            cbSeason.Size = new Size(171, 33);
            cbSeason.TabIndex = 8;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(210, 390);
            rtxtDescription.Margin = new Padding(4, 5, 4, 5);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(367, 237);
            rtxtDescription.TabIndex = 10;
            rtxtDescription.Text = "";
            // 
            // pbFlower
            // 
            pbFlower.Image = Properties.Resources.defaultFlowerImage;
            pbFlower.Location = new Point(671, 110);
            pbFlower.Margin = new Padding(4, 5, 4, 5);
            pbFlower.Name = "pbFlower";
            pbFlower.Size = new Size(237, 283);
            pbFlower.TabIndex = 11;
            pbFlower.TabStop = false;
            pbFlower.Click += pictureBox1_Click;
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "ProductPage";
            Text = "Product Page";
            Load += ProductPage_Load;
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