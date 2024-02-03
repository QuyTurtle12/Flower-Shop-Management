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
            flower_name = new DataGridViewTextBoxColumn();
            unit_price = new DataGridViewTextBoxColumn();
            Image = new DataGridViewImageColumn();
            lbFilters = new Label();
            btnCart = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtShopName
            // 
            txtShopName.AutoSize = true;
            txtShopName.Font = new Font("Segoe UI", 13F);
            txtShopName.Location = new Point(64, 22);
            txtShopName.Name = "txtShopName";
            txtShopName.Size = new Size(106, 25);
            txtShopName.TabIndex = 0;
            txtShopName.Text = "Shop Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(507, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(507, 50);
            button1.Name = "button1";
            button1.Size = new Size(91, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(609, 50);
            button2.Name = "button2";
            button2.Size = new Size(91, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Alphabet", "Ascending price", "Descending price" });
            comboBox1.Location = new Point(92, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { flower_name, unit_price, Image });
            dataGridView1.Location = new Point(64, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(500, 201);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // flower_name
            // 
            flower_name.HeaderText = "Flower Name";
            flower_name.Name = "flower_name";
            // 
            // unit_price
            // 
            unit_price.HeaderText = "Unit Price";
            unit_price.Name = "unit_price";
            // 
            // Image
            // 
            Image.HeaderText = "Image";
            Image.Name = "Image";
            // 
            // lbFilters
            // 
            lbFilters.AutoSize = true;
            lbFilters.BackColor = Color.Transparent;
            lbFilters.Location = new Point(24, 78);
            lbFilters.Name = "lbFilters";
            lbFilters.Size = new Size(38, 15);
            lbFilters.TabIndex = 6;
            lbFilters.Text = "Filters";
            // 
            // btnCart
            // 
            btnCart.Location = new Point(609, 171);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(75, 23);
            btnCart.TabIndex = 9;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += button3_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 379);
            Controls.Add(btnCart);
            Controls.Add(lbFilters);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(txtShopName);
            Name = "HomePage";
            Text = "HomePage";
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
        private DataGridViewTextBoxColumn flower_name;
        private DataGridViewTextBoxColumn unit_price;
        private DataGridViewImageColumn Image;
        private Label lbFilters;
        private Button btnCart;
    }
}