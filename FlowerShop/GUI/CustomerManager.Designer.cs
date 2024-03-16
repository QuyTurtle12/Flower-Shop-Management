namespace GUI
{
    partial class CustomerManager
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
            groupBox1 = new GroupBox();
            rdbtnOther = new RadioButton();
            rdbtnFemale = new RadioButton();
            rdbtnMale = new RadioButton();
            gbFilter = new GroupBox();
            rdbtnDeactive = new RadioButton();
            rdbtnActive = new RadioButton();
            btnClear = new Button();
            btnSearch = new Button();
            btnDeactive = new Button();
            btnActive = new Button();
            dgvCustomer = new DataGridView();
            txtID = new DataGridViewTextBoxColumn();
            txtFullName = new DataGridViewTextBoxColumn();
            txtEmail = new DataGridViewTextBoxColumn();
            txtPhoneNumber = new DataGridViewTextBoxColumn();
            txtGender = new DataGridViewTextBoxColumn();
            txtStatus = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            groupBox1.SuspendLayout();
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbtnOther);
            groupBox1.Controls.Add(rdbtnFemale);
            groupBox1.Controls.Add(rdbtnMale);
            groupBox1.Location = new Point(140, 48);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(152, 69);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender Filter";
            // 
            // rdbtnOther
            // 
            rdbtnOther.AutoSize = true;
            rdbtnOther.Location = new Point(81, 49);
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
            rdbtnFemale.Location = new Point(81, 26);
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
            rdbtnMale.Location = new Point(81, -2);
            rdbtnMale.Margin = new Padding(2);
            rdbtnMale.Name = "rdbtnMale";
            rdbtnMale.Size = new Size(51, 19);
            rdbtnMale.TabIndex = 5;
            rdbtnMale.TabStop = true;
            rdbtnMale.Text = "Male";
            rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(rdbtnDeactive);
            gbFilter.Controls.Add(rdbtnActive);
            gbFilter.Location = new Point(296, 48);
            gbFilter.Margin = new Padding(2);
            gbFilter.Name = "gbFilter";
            gbFilter.Padding = new Padding(2);
            gbFilter.Size = new Size(152, 55);
            gbFilter.TabIndex = 17;
            gbFilter.TabStop = false;
            gbFilter.Text = "Status Filter";
            // 
            // rdbtnDeactive
            // 
            rdbtnDeactive.AutoSize = true;
            rdbtnDeactive.Location = new Point(82, 26);
            rdbtnDeactive.Margin = new Padding(2);
            rdbtnDeactive.Name = "rdbtnDeactive";
            rdbtnDeactive.Size = new Size(70, 19);
            rdbtnDeactive.TabIndex = 6;
            rdbtnDeactive.TabStop = true;
            rdbtnDeactive.Text = "Deactive";
            rdbtnDeactive.UseVisualStyleBackColor = true;
            // 
            // rdbtnActive
            // 
            rdbtnActive.AutoSize = true;
            rdbtnActive.Location = new Point(82, -1);
            rdbtnActive.Margin = new Padding(2);
            rdbtnActive.Name = "rdbtnActive";
            rdbtnActive.Size = new Size(58, 19);
            rdbtnActive.TabIndex = 5;
            rdbtnActive.TabStop = true;
            rdbtnActive.Text = "Active";
            rdbtnActive.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(480, 92);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(74, 22);
            btnClear.TabIndex = 16;
            btnClear.Text = "Reset";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(480, 59);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(74, 22);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDeactive
            // 
            btnDeactive.Location = new Point(575, 242);
            btnDeactive.Margin = new Padding(2);
            btnDeactive.Name = "btnDeactive";
            btnDeactive.Size = new Size(74, 22);
            btnDeactive.TabIndex = 14;
            btnDeactive.Text = "Deactive";
            btnDeactive.UseVisualStyleBackColor = true;
            btnDeactive.Click += btnDeactive_Click;
            // 
            // btnActive
            // 
            btnActive.Location = new Point(575, 198);
            btnActive.Margin = new Padding(2);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(74, 22);
            btnActive.TabIndex = 13;
            btnActive.Text = "Active";
            btnActive.UseVisualStyleBackColor = true;
            btnActive.Click += btnActive_Click;
            // 
            // dgvCustomer
            // 
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { txtID, txtFullName, txtEmail, txtPhoneNumber, txtGender, txtStatus });
            dgvCustomer.DataSource = userBindingSource;
            dgvCustomer.Location = new Point(30, 132);
            dgvCustomer.Margin = new Padding(2);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.ReadOnly = true;
            dgvCustomer.RowHeadersWidth = 62;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvCustomer.Size = new Size(523, 145);
            dgvCustomer.TabIndex = 11;
            dgvCustomer.CellDoubleClick += dgvCustomer_CellDoubleClick;
            // 
            // txtID
            // 
            txtID.DataPropertyName = "Id";
            txtID.HeaderText = "Id";
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Width = 42;
            // 
            // txtFullName
            // 
            txtFullName.DataPropertyName = "Fullname";
            txtFullName.HeaderText = "Full Name";
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Width = 86;
            // 
            // txtEmail
            // 
            txtEmail.DataPropertyName = "Email";
            txtEmail.HeaderText = "Email";
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Width = 61;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.DataPropertyName = "PhoneNumber";
            txtPhoneNumber.HeaderText = "Phone Number";
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Width = 113;
            // 
            // txtGender
            // 
            txtGender.DataPropertyName = "Gender";
            txtGender.HeaderText = "Gender";
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Width = 70;
            // 
            // txtStatus
            // 
            txtStatus.DataPropertyName = "Status";
            txtStatus.HeaderText = "Status";
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.Width = 64;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(BusinessObject.Models.User);
            // 
            // CustomerManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 330);
            Controls.Add(groupBox1);
            Controls.Add(gbFilter);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(btnDeactive);
            Controls.Add(btnActive);
            Controls.Add(dgvCustomer);
            Name = "CustomerManager";
            Text = "CustomerManager";
            Load += CustomerManager_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdbtnOther;
        private RadioButton rdbtnFemale;
        private RadioButton rdbtnMale;
        private GroupBox gbFilter;
        private RadioButton rdbtnDeactive;
        private RadioButton rdbtnActive;
        private Button btnClear;
        private Button btnSearch;
        private Button btnDeactive;
        private Button btnActive;
        private DataGridView dgvCustomer;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn txtID;
        private DataGridViewTextBoxColumn txtFullName;
        private DataGridViewTextBoxColumn txtEmail;
        private DataGridViewTextBoxColumn txtPhoneNumber;
        private DataGridViewTextBoxColumn txtGender;
        private DataGridViewTextBoxColumn txtStatus;
    }
}