namespace GUI
{
    partial class frmCustomerInfo
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
            lblFullName = new Label();
            lblEmail = new Label();
            lblOldPassword = new Label();
            lblPhoneNumber = new Label();
            lblConfirmNewPassword = new Label();
            lblNewPassword = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtOldPassword = new TextBox();
            txtPhoneNumber = new TextBox();
            txtConfirmNewPassword = new TextBox();
            txtNewPassword = new TextBox();
            btnSaveChanges = new Button();
            btnUpdatePassword = new Button();
            cbGender = new ComboBox();
            lblGender = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblRole = new Label();
            cbRole = new ComboBox();
            btnShowHide = new Button();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(81, 71);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(64, 15);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(106, 107);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email:";
            // 
            // lblOldPassword
            // 
            lblOldPassword.AutoSize = true;
            lblOldPassword.Location = new Point(83, 452);
            lblOldPassword.Name = "lblOldPassword";
            lblOldPassword.Size = new Size(82, 15);
            lblOldPassword.TabIndex = 3;
            lblOldPassword.Text = "Old Password:";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(54, 143);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(91, 15);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.Location = new Point(31, 524);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new Size(134, 15);
            lblConfirmNewPassword.TabIndex = 5;
            lblConfirmNewPassword.Text = "Confirm New Password:";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new Point(78, 488);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(87, 15);
            lblNewPassword.TabIndex = 4;
            lblNewPassword.Text = "New Password:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(175, 69);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 23);
            txtFullName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(175, 104);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(175, 446);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(200, 23);
            txtOldPassword.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(175, 139);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 23);
            txtPhoneNumber.TabIndex = 9;
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(175, 516);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.PasswordChar = '*';
            txtConfirmNewPassword.Size = new Size(200, 23);
            txtConfirmNewPassword.TabIndex = 12;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(175, 481);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new Size(200, 23);
            txtNewPassword.TabIndex = 11;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Location = new Point(213, 266);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(134, 23);
            btnSaveChanges.TabIndex = 13;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnUpdatePassword
            // 
            btnUpdatePassword.Location = new Point(213, 559);
            btnUpdatePassword.Name = "btnUpdatePassword";
            btnUpdatePassword.Size = new Size(134, 23);
            btnUpdatePassword.TabIndex = 14;
            btnUpdatePassword.Text = "Update Password";
            btnUpdatePassword.UseVisualStyleBackColor = true;
            btnUpdatePassword.Click += btnUpdatePassword_Click;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male", "Other" });
            cbGender.Location = new Point(175, 178);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(200, 23);
            cbGender.TabIndex = 15;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(97, 185);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(48, 15);
            lblGender.TabIndex = 16;
            lblGender.Text = "Gender:";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(82, 42);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 17;
            lblUsername.Text = "Username:";
            lblUsername.Click += label4_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(175, 40);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 20;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(112, 223);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(33, 15);
            lblRole.TabIndex = 22;
            lblRole.Text = "Role:";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Customer", "Admin", "Staff" });
            cbRole.Location = new Point(175, 216);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(200, 23);
            cbRole.TabIndex = 21;
            // 
            // btnShowHide
            // 
            btnShowHide.Location = new Point(175, 417);
            btnShowHide.Name = "btnShowHide";
            btnShowHide.Size = new Size(83, 23);
            btnShowHide.TabIndex = 23;
            btnShowHide.Text = "Show/Hide";
            btnShowHide.UseVisualStyleBackColor = true;
            btnShowHide.Click += btnShowHide_Click;
            // 
            // frmCustomerInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 622);
            Controls.Add(btnShowHide);
            Controls.Add(lblRole);
            Controls.Add(cbRole);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblGender);
            Controls.Add(cbGender);
            Controls.Add(btnUpdatePassword);
            Controls.Add(btnSaveChanges);
            Controls.Add(lblConfirmNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(lblOldPassword);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmail);
            Controls.Add(lblFullName);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(txtOldPassword);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Name = "frmCustomerInfo";
            Text = "s";
            Load += frmCustomerInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private Label lblEmail;
        private Label lblOldPassword;
        private Label lblPhoneNumber;
        private Label lblConfirmNewPassword;
        private Label lblNewPassword;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtOldPassword;
        private TextBox txtPhoneNumber;
        private TextBox txtConfirmNewPassword;
        private TextBox txtNewPassword;
        private Button btnSaveChanges;
        private Button btnUpdatePassword;
        private ComboBox cbGender;
        private Label lblGender;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblRole;
        private ComboBox cbRole;
        private Button btnShowHide;
    }
}