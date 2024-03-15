namespace GUI
{
    partial class frmOrders
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
            ordersDataGridView = new DataGridView();
            statusFilterComboBox = new ComboBox();
            lblFilter = new Label();
            filterButton = new Button();
            updateStatusButton = new Button();
            updateStatusComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ordersDataGridView
            // 
            ordersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersDataGridView.Location = new Point(12, 103);
            ordersDataGridView.Name = "ordersDataGridView";
            ordersDataGridView.Size = new Size(1205, 470);
            ordersDataGridView.TabIndex = 0;
            ordersDataGridView.CellDoubleClick += ordersDataGridView_CellDoubleClick;
            ordersDataGridView.SelectionChanged += ordersDataGridView_SelectionChanged;
            // 
            // statusFilterComboBox
            // 
            statusFilterComboBox.FormattingEnabled = true;
            statusFilterComboBox.Items.AddRange(new object[] { "Unprocessed", "Canceled", "Processing", "Delivering", "Delivering Failed", "Finished", "All" });
            statusFilterComboBox.Location = new Point(159, 67);
            statusFilterComboBox.Name = "statusFilterComboBox";
            statusFilterComboBox.Size = new Size(240, 23);
            statusFilterComboBox.TabIndex = 1;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Location = new Point(97, 71);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(52, 15);
            lblFilter.TabIndex = 2;
            lblFilter.Text = "Filter By:";
            // 
            // filterButton
            // 
            filterButton.Location = new Point(12, 67);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(75, 23);
            filterButton.TabIndex = 3;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // updateStatusButton
            // 
            updateStatusButton.Location = new Point(1075, 63);
            updateStatusButton.Name = "updateStatusButton";
            updateStatusButton.Size = new Size(136, 23);
            updateStatusButton.TabIndex = 4;
            updateStatusButton.Text = "Update Status";
            updateStatusButton.UseVisualStyleBackColor = true;
            updateStatusButton.Click += updateStatusButton_Click;
            // 
            // updateStatusComboBox
            // 
            updateStatusComboBox.FormattingEnabled = true;
            updateStatusComboBox.Location = new Point(829, 63);
            updateStatusComboBox.Name = "updateStatusComboBox";
            updateStatusComboBox.Size = new Size(240, 23);
            updateStatusComboBox.TabIndex = 5;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 642);
            Controls.Add(updateStatusComboBox);
            Controls.Add(updateStatusButton);
            Controls.Add(filterButton);
            Controls.Add(lblFilter);
            Controls.Add(statusFilterComboBox);
            Controls.Add(ordersDataGridView);
            Name = "frmOrders";
            Text = "frmOrders";
            Load += frmOrders_Load;
            ((System.ComponentModel.ISupportInitialize)ordersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ordersDataGridView;
        private ComboBox statusFilterComboBox;
        private Label lblFilter;
        private Button filterButton;
        private Button updateStatusButton;
        private ComboBox updateStatusComboBox;
    }
}