namespace GUI
{
    partial class StaffInterface
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
            lbId = new Label();
            lbRole = new Label();
            lbFullName = new Label();
            lbGender = new Label();
            lbPhone = new Label();
            lbEmail = new Label();
            btnEdit = new Button();
            lbRoleData = new Label();
            lbIdData = new Label();
            lbFullNameData = new Label();
            lbEmailData = new Label();
            lbPhoneNumberData = new Label();
            lbGenderData = new Label();
            btnSave = new Button();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            cmbGender = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // lbId
            // 
            lbId.AutoSize = true;
            lbId.Location = new Point(54, 60);
            lbId.Name = "lbId";
            lbId.Size = new Size(30, 25);
            lbId.TabIndex = 0;
            lbId.Tag = "lbId";
            lbId.Text = "ID";
            lbId.Click += label1_Click;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new Point(54, 113);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(46, 25);
            lbRole.TabIndex = 1;
            lbRole.Tag = "lbRole";
            lbRole.Text = "Role";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Location = new Point(54, 165);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(91, 25);
            lbFullName.TabIndex = 2;
            lbFullName.Text = "Full Name";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(54, 333);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(69, 25);
            lbGender.TabIndex = 5;
            lbGender.Text = "Gender";
            lbGender.Click += label4_Click;
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(54, 281);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(132, 25);
            lbPhone.TabIndex = 4;
            lbPhone.Text = "Phone Number";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(54, 221);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(61, 25);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "E-mail";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(262, 440);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 34);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += button1_Click;
            // 
            // lbRoleData
            // 
            lbRoleData.AutoSize = true;
            lbRoleData.Location = new Point(262, 113);
            lbRoleData.Name = "lbRoleData";
            lbRoleData.Size = new Size(88, 25);
            lbRoleData.TabIndex = 7;
            lbRoleData.Tag = "lbRole";
            lbRoleData.Text = "Role Data";
            lbRoleData.Click += lbRoleData_Click;
            // 
            // lbIdData
            // 
            lbIdData.AutoSize = true;
            lbIdData.Location = new Point(262, 60);
            lbIdData.Name = "lbIdData";
            lbIdData.Size = new Size(72, 25);
            lbIdData.TabIndex = 8;
            lbIdData.Tag = "lbRole";
            lbIdData.Text = "ID Data";
            lbIdData.Click += label1_Click_1;
            // 
            // lbFullNameData
            // 
            lbFullNameData.AutoSize = true;
            lbFullNameData.Location = new Point(262, 165);
            lbFullNameData.Name = "lbFullNameData";
            lbFullNameData.Size = new Size(123, 25);
            lbFullNameData.TabIndex = 9;
            lbFullNameData.Tag = "lbRole";
            lbFullNameData.Text = "FullNameData";
            // 
            // lbEmailData
            // 
            lbEmailData.AutoSize = true;
            lbEmailData.Location = new Point(262, 221);
            lbEmailData.Name = "lbEmailData";
            lbEmailData.Size = new Size(96, 25);
            lbEmailData.TabIndex = 10;
            lbEmailData.Tag = "lbRole";
            lbEmailData.Text = "Email Data";
            // 
            // lbPhoneNumberData
            // 
            lbPhoneNumberData.AutoSize = true;
            lbPhoneNumberData.Location = new Point(262, 281);
            lbPhoneNumberData.Name = "lbPhoneNumberData";
            lbPhoneNumberData.Size = new Size(174, 25);
            lbPhoneNumberData.TabIndex = 11;
            lbPhoneNumberData.Tag = "lbRole";
            lbPhoneNumberData.Text = "Phone Number Data";
            // 
            // lbGenderData
            // 
            lbGenderData.AutoSize = true;
            lbGenderData.Location = new Point(262, 333);
            lbGenderData.Name = "lbGenderData";
            lbGenderData.Size = new Size(111, 25);
            lbGenderData.TabIndex = 12;
            lbGenderData.Tag = "lbRole";
            lbGenderData.Text = "Gender Data";
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(54, 440);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtFullName
            // 
            txtFullName.Enabled = false;
            txtFullName.Location = new Point(262, 162);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(190, 31);
            txtFullName.TabIndex = 14;
            txtFullName.Visible = false;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(262, 218);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(190, 31);
            txtEmail.TabIndex = 15;
            txtEmail.Visible = false;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Enabled = false;
            txtPhoneNumber.Location = new Point(262, 281);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(190, 31);
            txtPhoneNumber.TabIndex = 16;
            txtPhoneNumber.Visible = false;
            // 
            // cmbGender
            // 
            cmbGender.Enabled = false;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "-- Other --" });
            cmbGender.Location = new Point(262, 333);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(198, 33);
            cmbGender.TabIndex = 17;
            cmbGender.Visible = false;
            cmbGender.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // StaffInterface
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 556);
            Controls.Add(cmbGender);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(btnSave);
            Controls.Add(lbGenderData);
            Controls.Add(lbPhoneNumberData);
            Controls.Add(lbEmailData);
            Controls.Add(lbFullNameData);
            Controls.Add(lbIdData);
            Controls.Add(lbRoleData);
            Controls.Add(btnEdit);
            Controls.Add(lbGender);
            Controls.Add(lbPhone);
            Controls.Add(lbEmail);
            Controls.Add(lbFullName);
            Controls.Add(lbRole);
            Controls.Add(lbId);
            Name = "StaffInterface";
            Tag = "lbId";
            Text = "ID";
            Load += StaffInterface_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbId;
        private Label lbRole;
        private Label lbFullName;
        private Label lbGender;
        private Label lbPhone;
        private Label lbEmail;
        private Button btnEdit;
        private Label lbRoleData;
        private Label lbIdData;
        private Label lbFullNameData;
        private Label lbEmailData;
        private Label lbPhoneNumberData;
        private Label lbGenderData;
        private Button btnSave;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private ComboBox cmbGender;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}