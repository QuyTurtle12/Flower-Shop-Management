namespace GUI
{
    partial class StaffManager
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
            dgvStaff = new DataGridView();
            btnCreate = new Button();
            btnActive = new Button();
            btnDeactive = new Button();
            rdbtnActive = new RadioButton();
            rdbtnDeactive = new RadioButton();
            btnSearch = new Button();
            btnClear = new Button();
            gbFilter = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            gbFilter.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStaff
            // 
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(56, 158);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.RowHeadersWidth = 62;
            dgvStaff.Size = new Size(529, 241);
            dgvStaff.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(640, 188);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(105, 37);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnActive
            // 
            btnActive.Location = new Point(640, 268);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(105, 37);
            btnActive.TabIndex = 3;
            btnActive.Text = "Active";
            btnActive.UseVisualStyleBackColor = true;
            // 
            // btnDeactive
            // 
            btnDeactive.Location = new Point(640, 337);
            btnDeactive.Name = "btnDeactive";
            btnDeactive.Size = new Size(105, 37);
            btnDeactive.TabIndex = 4;
            btnDeactive.Text = "Deactive";
            btnDeactive.UseVisualStyleBackColor = true;
            // 
            // rdbtnActive
            // 
            rdbtnActive.AutoSize = true;
            rdbtnActive.Location = new Point(118, 0);
            rdbtnActive.Name = "rdbtnActive";
            rdbtnActive.Size = new Size(85, 29);
            rdbtnActive.TabIndex = 5;
            rdbtnActive.TabStop = true;
            rdbtnActive.Text = "Active";
            rdbtnActive.UseVisualStyleBackColor = true;
            // 
            // rdbtnDeactive
            // 
            rdbtnDeactive.AutoSize = true;
            rdbtnDeactive.Location = new Point(118, 45);
            rdbtnDeactive.Name = "rdbtnDeactive";
            rdbtnDeactive.Size = new Size(104, 29);
            rdbtnDeactive.TabIndex = 6;
            rdbtnDeactive.TabStop = true;
            rdbtnDeactive.Text = "Deactive";
            rdbtnDeactive.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(640, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(105, 37);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(640, 103);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(105, 37);
            btnClear.TabIndex = 8;
            btnClear.Text = "Reset";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(rdbtnDeactive);
            gbFilter.Controls.Add(rdbtnActive);
            gbFilter.Location = new Point(377, 37);
            gbFilter.Name = "gbFilter";
            gbFilter.Size = new Size(222, 91);
            gbFilter.TabIndex = 9;
            gbFilter.TabStop = false;
            gbFilter.Text = "Filter";
            // 
            // StaffManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbFilter);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(btnDeactive);
            Controls.Add(btnActive);
            Controls.Add(btnCreate);
            Controls.Add(dgvStaff);
            Name = "StaffManager";
            Text = "Staff Manager";
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvStaff;
        private Button btnCreate;
        private Button btnActive;
        private Button btnDeactive;
        private RadioButton rdbtnActive;
        private RadioButton rdbtnDeactive;
        private Button btnSearch;
        private Button btnClear;
        private GroupBox gbFilter;
    }
}