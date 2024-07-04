namespace GUI
{
    partial class CreateStaff
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
            lblPasswordMismatch = new Label();
            cbGender = new ComboBox();
            lbGender = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtConfirmPassword = new TextBox();
            txtPhoneNumber = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lbConfirmPassword = new Label();
            label1 = new Label();
            lbUsername = new Label();
            lbPhoneNumber = new Label();
            lbEmail = new Label();
            lbLastName = new Label();
            lbFirstName = new Label();
            lbCreate = new Label();
            lbRole = new Label();
            btnRegister = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblPasswordMismatch
            // 
            lblPasswordMismatch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPasswordMismatch.AutoSize = true;
            lblPasswordMismatch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPasswordMismatch.ForeColor = Color.OrangeRed;
            lblPasswordMismatch.Location = new Point(50, 401);
            lblPasswordMismatch.Name = "lblPasswordMismatch";
            lblPasswordMismatch.Size = new Size(0, 21);
            lblPasswordMismatch.TabIndex = 38;
            lblPasswordMismatch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male", "Other" });
            cbGender.Location = new Point(226, 228);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(142, 23);
            cbGender.TabIndex = 37;
            cbGender.Text = "Choose";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(226, 210);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(45, 15);
            lbGender.TabIndex = 36;
            lbGender.Text = "Gender";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(53, 283);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(142, 23);
            txtPassword.TabIndex = 35;
            txtPassword.TextChanged += PasswordFields_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(53, 228);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(142, 23);
            txtUsername.TabIndex = 34;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(226, 283);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(142, 23);
            txtConfirmPassword.TabIndex = 33;
            txtConfirmPassword.TextChanged += PasswordFields_TextChanged;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(226, 163);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(142, 23);
            txtPhoneNumber.TabIndex = 32;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(53, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(142, 23);
            txtEmail.TabIndex = 31;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(226, 106);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(142, 23);
            txtLastName.TabIndex = 30;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(53, 106);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(142, 23);
            txtFirstName.TabIndex = 29;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.AutoSize = true;
            lbConfirmPassword.Location = new Point(226, 265);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.Size = new Size(104, 15);
            lbConfirmPassword.TabIndex = 28;
            lbConfirmPassword.Text = "Confirm password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 265);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 26;
            label1.Text = "Password (>= 8 characters)";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(53, 210);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(60, 15);
            lbUsername.TabIndex = 25;
            lbUsername.Text = "Username";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(226, 145);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(88, 15);
            lbPhoneNumber.TabIndex = 24;
            lbPhoneNumber.Text = "Phone Number";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(53, 145);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(41, 15);
            lbEmail.TabIndex = 23;
            lbEmail.Text = "E-mail";
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(226, 88);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(63, 15);
            lbLastName.TabIndex = 22;
            lbLastName.Text = "Last Name";
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(53, 88);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(64, 15);
            lbFirstName.TabIndex = 21;
            lbFirstName.Text = "First Name";
            // 
            // lbCreate
            // 
            lbCreate.AutoSize = true;
            lbCreate.Location = new Point(155, 24);
            lbCreate.Name = "lbCreate";
            lbCreate.Size = new Size(116, 15);
            lbCreate.TabIndex = 20;
            lbCreate.Text = "Create Staff Account";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new Point(53, 323);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(30, 15);
            lbRole.TabIndex = 39;
            lbRole.Text = "Role";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(226, 341);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 27;
            btnRegister.Text = "Create";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 341);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 40;
            textBox1.Text = "Staff";
            // 
            // CreateStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 461);
            Controls.Add(textBox1);
            Controls.Add(lbRole);
            Controls.Add(lblPasswordMismatch);
            Controls.Add(cbGender);
            Controls.Add(lbGender);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lbConfirmPassword);
            Controls.Add(btnRegister);
            Controls.Add(label1);
            Controls.Add(lbUsername);
            Controls.Add(lbPhoneNumber);
            Controls.Add(lbEmail);
            Controls.Add(lbLastName);
            Controls.Add(lbFirstName);
            Controls.Add(lbCreate);
            Name = "CreateStaff";
            Text = "CreateStaff";
            Load += CreateStaff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPasswordMismatch;
        private ComboBox cbGender;
        private Label lbGender;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtConfirmPassword;
        private TextBox txtPhoneNumber;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lbConfirmPassword;
        private Label label1;
        private Label lbUsername;
        private Label lbPhoneNumber;
        private Label lbEmail;
        private Label lbLastName;
        private Label lbFirstName;
        private Label lbCreate;
        private Label lbRole;
        private Button btnRegister;
        private TextBox textBox1;
    }
}