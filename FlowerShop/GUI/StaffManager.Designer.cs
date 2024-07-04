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
            components = new System.ComponentModel.Container();
            dgvStaff = new DataGridView();
            userBindingSource = new BindingSource(components);
            btnCreate = new Button();
            btnActive = new Button();
            btnDeactive = new Button();
            rdbtnActive = new RadioButton();
            rdbtnDeactive = new RadioButton();
            btnSearch = new Button();
            btnClear = new Button();
            gbFilter = new GroupBox();
            groupBox1 = new GroupBox();
            rdbtnOther = new RadioButton();
            rdbtnFemale = new RadioButton();
            rdbtnMale = new RadioButton();
            txtID = new DataGridViewTextBoxColumn();
            txtFullName = new DataGridViewTextBoxColumn();
            txtEmail = new DataGridViewTextBoxColumn();
            txtPhoneNumber = new DataGridViewTextBoxColumn();
            txtGender = new DataGridViewTextBoxColumn();
            txtStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            gbFilter.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStaff
            // 
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Columns.AddRange(new DataGridViewColumn[] { txtID, txtFullName, txtEmail, txtPhoneNumber, txtGender, txtStatus });
            dgvStaff.DataSource = userBindingSource;
            dgvStaff.Location = new Point(39, 95);
            dgvStaff.Margin = new Padding(2);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.RowHeadersWidth = 62;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvStaff.Size = new Size(523, 145);
            dgvStaff.TabIndex = 1;
            dgvStaff.CellContentClick += dgvStaff_CellContentClick;
            dgvStaff.CellDoubleClick += dgvStaff_CellDoubleClick;
            dgvStaff.CellFormatting += dgvStaff_CellFormatting;
            dgvStaff.DataBindingComplete += dgvStaff_DataBindingComplete;
            dgvStaff.RowHeaderMouseDoubleClick += dgvStaff_RowHeaderMouseDoubleClick;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(BusinessObject.Models.User);
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(584, 106);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(74, 22);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnActive
            // 
            btnActive.Location = new Point(584, 161);
            btnActive.Margin = new Padding(2);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(74, 22);
            btnActive.TabIndex = 3;
            btnActive.Text = "Active";
            btnActive.UseVisualStyleBackColor = true;
            btnActive.Click += btnActive_Click;
            // 
            // btnDeactive
            // 
            btnDeactive.Location = new Point(584, 205);
            btnDeactive.Margin = new Padding(2);
            btnDeactive.Name = "btnDeactive";
            btnDeactive.Size = new Size(74, 22);
            btnDeactive.TabIndex = 4;
            btnDeactive.Text = "Deactive";
            btnDeactive.UseVisualStyleBackColor = true;
            btnDeactive.Click += btnDeactive_Click;
            // 
            // rdbtnActive
            // 
            rdbtnActive.AutoSize = true;
            rdbtnActive.Location = new Point(83, 0);
            rdbtnActive.Margin = new Padding(2);
            rdbtnActive.Name = "rdbtnActive";
            rdbtnActive.Size = new Size(58, 19);
            rdbtnActive.TabIndex = 5;
            rdbtnActive.TabStop = true;
            rdbtnActive.Text = "Active";
            rdbtnActive.UseVisualStyleBackColor = true;
            // 
            // rdbtnDeactive
            // 
            rdbtnDeactive.AutoSize = true;
            rdbtnDeactive.Location = new Point(83, 27);
            rdbtnDeactive.Margin = new Padding(2);
            rdbtnDeactive.Name = "rdbtnDeactive";
            rdbtnDeactive.Size = new Size(70, 19);
            rdbtnDeactive.TabIndex = 6;
            rdbtnDeactive.TabStop = true;
            rdbtnDeactive.Text = "Deactive";
            rdbtnDeactive.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(489, 22);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(74, 22);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(489, 55);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(74, 22);
            btnClear.TabIndex = 8;
            btnClear.Text = "Reset";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(rdbtnDeactive);
            gbFilter.Controls.Add(rdbtnActive);
            gbFilter.Location = new Point(305, 11);
            gbFilter.Margin = new Padding(2);
            gbFilter.Name = "gbFilter";
            gbFilter.Padding = new Padding(2);
            gbFilter.Size = new Size(152, 55);
            gbFilter.TabIndex = 9;
            gbFilter.TabStop = false;
            gbFilter.Text = "Status Filter";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbtnOther);
            groupBox1.Controls.Add(rdbtnFemale);
            groupBox1.Controls.Add(rdbtnMale);
            groupBox1.Location = new Point(149, 11);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(152, 69);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender Filter";
            // 
            // rdbtnOther
            // 
            rdbtnOther.AutoSize = true;
            rdbtnOther.Location = new Point(82, 50);
            rdbtnOther.Margin = new Padding(2);
            rdbtnOther.Name = "rdbtnOther";
            rdbtnOther.Size = new Size(55, 19);
            rdbtnOther.TabIndex = 7;
            rdbtnOther.TabStop = true;
            rdbtnOther.Text = "Other";
            rdbtnOther.UseVisualStyleBackColor = true;
            // 
            // rdbtnFemale
            // 
            rdbtnFemale.AutoSize = true;
            rdbtnFemale.Location = new Point(82, 27);
            rdbtnFemale.Margin = new Padding(2);
            rdbtnFemale.Name = "rdbtnFemale";
            rdbtnFemale.Size = new Size(63, 19);
            rdbtnFemale.TabIndex = 6;
            rdbtnFemale.TabStop = true;
            rdbtnFemale.Text = "Female";
            rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            rdbtnMale.AutoSize = true;
            rdbtnMale.Location = new Point(82, -1);
            rdbtnMale.Margin = new Padding(2);
            rdbtnMale.Name = "rdbtnMale";
            rdbtnMale.Size = new Size(51, 19);
            rdbtnMale.TabIndex = 5;
            rdbtnMale.TabStop = true;
            rdbtnMale.Text = "Male";
            rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            txtID.DataPropertyName = "Id";
            txtID.HeaderText = "Id";
            txtID.MinimumWidth = 8;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Width = 42;
            // 
            // txtFullName
            // 
            txtFullName.DataPropertyName = "Fullname";
            txtFullName.HeaderText = "Full Name";
            txtFullName.MinimumWidth = 8;
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Width = 86;
            // 
            // txtEmail
            // 
            txtEmail.DataPropertyName = "Email";
            txtEmail.HeaderText = "Email";
            txtEmail.MinimumWidth = 8;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Width = 61;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.DataPropertyName = "PhoneNumber";
            txtPhoneNumber.HeaderText = "Phone Number";
            txtPhoneNumber.MinimumWidth = 8;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Width = 113;
            // 
            // txtGender
            // 
            txtGender.DataPropertyName = "Gender";
            txtGender.HeaderText = "Gender";
            txtGender.MinimumWidth = 8;
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Width = 70;
            // 
            // txtStatus
            // 
            txtStatus.DataPropertyName = "Status";
            txtStatus.HeaderText = "Status";
            txtStatus.MinimumWidth = 8;
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Width = 64;
            // 
            // StaffManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 270);
            Controls.Add(groupBox1);
            Controls.Add(gbFilter);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(btnDeactive);
            Controls.Add(btnActive);
            Controls.Add(btnCreate);
            Controls.Add(dgvStaff);
            Margin = new Padding(2);
            Name = "StaffManager";
            Text = "Staff Manager";
            Load += StaffManager_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private BindingSource userBindingSource;
        private GroupBox groupBox1;
        private RadioButton rdbtnFemale;
        private RadioButton rdbtnMale;
        private RadioButton rdbtnOther;
        private DataGridViewTextBoxColumn txtID;
        private DataGridViewTextBoxColumn txtFullName;
        private DataGridViewTextBoxColumn txtEmail;
        private DataGridViewTextBoxColumn txtPhoneNumber;
        private DataGridViewTextBoxColumn txtGender;
        private DataGridViewTextBoxColumn txtStatus;
    }
}