namespace GUI
{
    partial class HomePage
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
            txtShopName = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            lbFilters = new Label();
            btnCart = new Button();
            btnAdd = new Button();
            lbAnnouncement = new Label();
            flower_name = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            Image = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtShopName
            // 
            txtShopName.AutoSize = true;
            txtShopName.Font = new Font("Segoe UI", 13F);
            txtShopName.Location = new Point(91, 37);
            txtShopName.Margin = new Padding(4, 0, 4, 0);
            txtShopName.Name = "txtShopName";
            txtShopName.Size = new Size(149, 36);
            txtShopName.TabIndex = 0;
            txtShopName.Text = "Shop Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(724, 20);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 31);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(724, 83);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(130, 38);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(870, 83);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(130, 38);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Alphabet", "Ascending price", "Descending price" });
            comboBox1.Location = new Point(131, 125);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 33);
            comboBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { flower_name, unit_price, Image });
            dataGridView1.Location = new Point(91, 252);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(714, 335);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lbFilters
            // 
            lbFilters.AutoSize = true;
            lbFilters.BackColor = Color.Transparent;
            lbFilters.Location = new Point(34, 130);
            lbFilters.Margin = new Padding(4, 0, 4, 0);
            lbFilters.Name = "lbFilters";
            lbFilters.Size = new Size(58, 25);
            lbFilters.TabIndex = 6;
            lbFilters.Text = "Filters";
            // 
            // btnCart
            // 
            btnCart.Location = new Point(870, 285);
            btnCart.Margin = new Padding(4, 5, 4, 5);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(107, 38);
            btnCart.TabIndex = 9;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += button3_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(870, 362);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 38);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbAnnouncement
            // 
            lbAnnouncement.AutoSize = true;
            lbAnnouncement.Location = new Point(91, 222);
            lbAnnouncement.Name = "lbAnnouncement";
            lbAnnouncement.Size = new Size(0, 25);
            lbAnnouncement.TabIndex = 11;
            lbAnnouncement.Tag = "Announcer";
            // 
            // flower_name
            // 
            flower_name.HeaderText = "Flower Name";
            flower_name.MinimumWidth = 8;
            flower_name.Name = "flower_name";
            flower_name.ReadOnly = true;
            flower_name.Width = 150;
            // 
            // unit_price
            // 
            unit_price.HeaderText = "Unit Price";
            unit_price.MinimumWidth = 8;
            unit_price.Name = "unit_price";
            unit_price.ReadOnly = true;
            unit_price.Width = 150;
            // 
            // Image
            // 
            Image.HeaderText = "Image";
            Image.MinimumWidth = 8;
            Image.Name = "Image";
            Image.ReadOnly = true;
            Image.Width = 150;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 632);
            Controls.Add(lbAnnouncement);
            Controls.Add(btnAdd);
            Controls.Add(btnCart);
            Controls.Add(lbFilters);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(txtShopName);
            Margin = new Padding(4, 5, 4, 5);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtShopName;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Label lbFilters;
        private Button btnCart;
        private Button btnAdd;
        private Label lbAnnouncement;
        private DataGridViewTextBoxColumn flower_name;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewImageColumn Image;
    }
}