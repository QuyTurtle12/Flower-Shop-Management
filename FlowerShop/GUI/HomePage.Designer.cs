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
            cbbSort = new ComboBox();
            dataGridView1 = new DataGridView();
            lbFilters = new Label();
            btnCart = new Button();
            btnAdd = new Button();
            lbAnnouncement = new Label();
            btnViewOrder = new Button();
            lbSeason = new Label();
            cbbSeason = new ComboBox();
            lbSort = new Label();
            btnSearch = new Button();
            btnClear = new Button();
            btnViewInfo = new Button();
            btnUpdate = new Button();
            AddFlower = new Button();
            btnDelete = new Button();
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
            // cbbSort
            // 
            cbbSort.FormattingEnabled = true;
            cbbSort.Items.AddRange(new object[] { "Alphabet", "Ascending price", "Descending price" });
            cbbSort.Location = new Point(251, 125);
            cbbSort.Margin = new Padding(4, 5, 4, 5);
            cbbSort.Name = "cbbSort";
            cbbSort.Size = new Size(171, 33);
            cbbSort.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            lbFilters.Location = new Point(91, 125);
            lbFilters.Margin = new Padding(4, 0, 4, 0);
            lbFilters.Name = "lbFilters";
            lbFilters.Size = new Size(58, 25);
            lbFilters.TabIndex = 6;
            lbFilters.Text = "Filters";
            // 
            // btnCart
            // 
            btnCart.Location = new Point(856, 267);
            btnCart.Margin = new Padding(4, 5, 4, 5);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(124, 48);
            btnCart.TabIndex = 9;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += button3_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(856, 353);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 52);
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
            // btnViewOrder
            // 
            btnViewOrder.Location = new Point(823, 175);
            btnViewOrder.Name = "btnViewOrder";
            btnViewOrder.Size = new Size(186, 38);
            btnViewOrder.TabIndex = 12;
            btnViewOrder.Text = "View My Order";
            btnViewOrder.UseVisualStyleBackColor = true;
            btnViewOrder.Click += btnViewOrder_Click;
            // 
            // lbSeason
            // 
            lbSeason.AutoSize = true;
            lbSeason.Location = new Point(180, 188);
            lbSeason.Margin = new Padding(4, 0, 4, 0);
            lbSeason.Name = "lbSeason";
            lbSeason.Size = new Size(69, 25);
            lbSeason.TabIndex = 14;
            lbSeason.Text = "Season";
            // 
            // cbbSeason
            // 
            cbbSeason.FormattingEnabled = true;
            cbbSeason.Items.AddRange(new object[] { "Spring", "Summer", "Autumn", "Winter" });
            cbbSeason.Location = new Point(250, 188);
            cbbSeason.Margin = new Padding(4, 5, 4, 5);
            cbbSeason.Name = "cbbSeason";
            cbbSeason.Size = new Size(173, 33);
            cbbSeason.TabIndex = 15;
            // 
            // lbSort
            // 
            lbSort.AutoSize = true;
            lbSort.Location = new Point(180, 125);
            lbSort.Margin = new Padding(4, 0, 4, 0);
            lbSort.Name = "lbSort";
            lbSort.Size = new Size(45, 25);
            lbSort.TabIndex = 16;
            lbSort.Text = "Sort";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(461, 118);
            btnSearch.Margin = new Padding(4, 5, 4, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(133, 47);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(461, 188);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(133, 47);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnViewInfo
            // 
            btnViewInfo.Location = new Point(823, 115);
            btnViewInfo.Margin = new Padding(4, 5, 4, 5);
            btnViewInfo.Name = "btnViewInfo";
            btnViewInfo.Size = new Size(186, 38);
            btnViewInfo.TabIndex = 19;
            btnViewInfo.Text = "View My Info";
            btnViewInfo.UseVisualStyleBackColor = true;
            btnViewInfo.Click += btnViewInfo_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(250, 606);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 38);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update Flower";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // AddFlower
            // 
            AddFlower.Enabled = false;
            AddFlower.Location = new Point(91, 606);
            AddFlower.Margin = new Padding(4, 5, 4, 5);
            AddFlower.Name = "AddFlower";
            AddFlower.Size = new Size(134, 38);
            AddFlower.TabIndex = 20;
            AddFlower.Text = "Create Flower";
            AddFlower.UseVisualStyleBackColor = true;
            AddFlower.Click += AddFlower_Click;
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(413, 606);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 38);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete Flower";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 658);
            Controls.Add(btnViewInfo);
            Controls.Add(btnViewOrder);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(AddFlower);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(lbSort);
            Controls.Add(cbbSeason);
            Controls.Add(lbSeason);
            Controls.Add(lbAnnouncement);
            Controls.Add(btnAdd);
            Controls.Add(btnCart);
            Controls.Add(lbFilters);
            Controls.Add(dataGridView1);
            Controls.Add(cbbSort);
            Controls.Add(txtShopName);
            Margin = new Padding(4, 5, 4, 5);
            Name = "HomePage";
            Text = "Home Page";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtShopName;
        private ComboBox cbbSort;
        private DataGridView dataGridView1;
        private Label lbFilters;
        private Button btnCart;
        private Button btnAdd;
        private Label lbAnnouncement;
        private Button btnViewOrder;
        private Label lbSeason;
        private ComboBox cbbSeason;
        private Label lbSort;
        private Button btnSearch;
        private Button btnClear;
        private Button btnViewInfo;
        private Button btnUpdate;
        private Button AddFlower;
        private Button btnDelete;
    }
}