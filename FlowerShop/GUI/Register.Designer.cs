namespace GUI
{
    partial class Register
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
            lbCreate = new Label();
            lbFirstName = new Label();
            lbLastName = new Label();
            lbEmail = new Label();
            lbPhoneNumber = new Label();
            lbUsername = new Label();
            btnAlreadyAcc = new Button();
            label1 = new Label();
            btnRegister = new Button();
            lbConfirmPassword = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtConfirmPassword = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lbGender = new Label();
            cbGender = new ComboBox();
            lblPasswordMismatch = new Label();
            SuspendLayout();
            // 
            // lbCreate
            // 
            lbCreate.AutoSize = true;
            lbCreate.Location = new Point(165, 28);
            lbCreate.Name = "lbCreate";
            lbCreate.Size = new Size(103, 15);
            lbCreate.TabIndex = 0;
            lbCreate.Text = "Create an account";
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(48, 89);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(64, 15);
            lbFirstName.TabIndex = 1;
            lbFirstName.Text = "First Name";
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(221, 89);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(63, 15);
            lbLastName.TabIndex = 2;
            lbLastName.Text = "Last Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(48, 146);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(41, 15);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "E-mail";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(221, 146);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(88, 15);
            lbPhoneNumber.TabIndex = 4;
            lbPhoneNumber.Text = "Phone Number";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(48, 211);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(60, 15);
            lbUsername.TabIndex = 5;
            lbUsername.Text = "Username";
            // 
            // btnAlreadyAcc
            // 
            btnAlreadyAcc.Location = new Point(139, 387);
            btnAlreadyAcc.Name = "btnAlreadyAcc";
            btnAlreadyAcc.Size = new Size(127, 23);
            btnAlreadyAcc.TabIndex = 6;
            btnAlreadyAcc.Text = "Already an account ?";
            btnAlreadyAcc.UseVisualStyleBackColor = true;
            btnAlreadyAcc.Click += btnAlreadyAcc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 266);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 7;
            label1.Text = "Password (>= 8 characters)";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(165, 358);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Create";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.AutoSize = true;
            lbConfirmPassword.Location = new Point(221, 266);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.Size = new Size(104, 15);
            lbConfirmPassword.TabIndex = 9;
            lbConfirmPassword.Text = "Confirm password";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(48, 107);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(142, 23);
            txtFirstName.TabIndex = 10;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(221, 107);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(142, 23);
            txtLastName.TabIndex = 11;
            txtLastName.TextChanged += txtLastName_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(48, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(142, 23);
            txtEmail.TabIndex = 12;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(221, 164);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(142, 23);
            txtPhoneNumber.TabIndex = 13;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(221, 284);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(142, 23);
            txtConfirmPassword.TabIndex = 14;
            txtConfirmPassword.TextChanged += PasswordFields_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(48, 229);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(142, 23);
            txtUsername.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(48, 284);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(142, 23);
            txtPassword.TabIndex = 16;
            txtPassword.TextChanged += PasswordFields_TextChanged;
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(221, 211);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(45, 15);
            lbGender.TabIndex = 17;
            lbGender.Text = "Gender";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male", "Other" });
            cbGender.Location = new Point(221, 229);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(142, 23);
            cbGender.TabIndex = 18;
            cbGender.Text = "Choose";
            // 
            // lblPasswordMismatch
            // 
            lblPasswordMismatch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPasswordMismatch.AutoSize = true;
            lblPasswordMismatch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPasswordMismatch.ForeColor = Color.OrangeRed;
            lblPasswordMismatch.Location = new Point(51, 324);
            lblPasswordMismatch.Name = "lblPasswordMismatch";
            lblPasswordMismatch.Size = new Size(0, 21);
            lblPasswordMismatch.TabIndex = 19;
            lblPasswordMismatch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 420);
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
            Controls.Add(btnAlreadyAcc);
            Controls.Add(lbUsername);
            Controls.Add(lbPhoneNumber);
            Controls.Add(lbEmail);
            Controls.Add(lbLastName);
            Controls.Add(lbFirstName);
            Controls.Add(lbCreate);
            Name = "Register";
            Text = "Create an account";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCreate;
        private Label lbFirstName;
        private Label lbLastName;
        private Label lbEmail;
        private Label lbPhoneNumber;
        private Label lbUsername;
        private Button btnAlreadyAcc;
        private Label label1;
        private Button btnRegister;
        private Label lbConfirmPassword;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtConfirmPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lbGender;
        private ComboBox cbGender;
        private Label lblPasswordMismatch;
    }
}