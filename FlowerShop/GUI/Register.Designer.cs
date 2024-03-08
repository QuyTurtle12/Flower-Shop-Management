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
            lbCreate.Location = new Point(236, 47);
            lbCreate.Margin = new Padding(4, 0, 4, 0);
            lbCreate.Name = "lbCreate";
            lbCreate.Size = new Size(153, 25);
            lbCreate.TabIndex = 0;
            lbCreate.Text = "Create an account";
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(69, 148);
            lbFirstName.Margin = new Padding(4, 0, 4, 0);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(97, 25);
            lbFirstName.TabIndex = 1;
            lbFirstName.Text = "First Name";
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(316, 148);
            lbLastName.Margin = new Padding(4, 0, 4, 0);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(95, 25);
            lbLastName.TabIndex = 2;
            lbLastName.Text = "Last Name";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(69, 243);
            lbEmail.Margin = new Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(61, 25);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "E-mail";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(316, 243);
            lbPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(132, 25);
            lbPhoneNumber.TabIndex = 4;
            lbPhoneNumber.Text = "Phone Number";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(69, 352);
            lbUsername.Margin = new Padding(4, 0, 4, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(91, 25);
            lbUsername.TabIndex = 5;
            lbUsername.Text = "Username";
            // 
            // btnAlreadyAcc
            // 
            btnAlreadyAcc.Location = new Point(199, 645);
            btnAlreadyAcc.Margin = new Padding(4, 5, 4, 5);
            btnAlreadyAcc.Name = "btnAlreadyAcc";
            btnAlreadyAcc.Size = new Size(181, 38);
            btnAlreadyAcc.TabIndex = 6;
            btnAlreadyAcc.Text = "Already an account ?";
            btnAlreadyAcc.UseVisualStyleBackColor = true;
            btnAlreadyAcc.Click += btnAlreadyAcc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 443);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 25);
            label1.TabIndex = 7;
            label1.Text = "Password (>= 8 characters)";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(236, 597);
            btnRegister.Margin = new Padding(4, 5, 4, 5);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(107, 38);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Create";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lbConfirmPassword
            // 
            lbConfirmPassword.AutoSize = true;
            lbConfirmPassword.Location = new Point(316, 443);
            lbConfirmPassword.Margin = new Padding(4, 0, 4, 0);
            lbConfirmPassword.Name = "lbConfirmPassword";
            lbConfirmPassword.Size = new Size(158, 25);
            lbConfirmPassword.TabIndex = 9;
            lbConfirmPassword.Text = "Confirm password";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(69, 178);
            txtFirstName.Margin = new Padding(4, 5, 4, 5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(201, 31);
            txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(316, 178);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(201, 31);
            txtLastName.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(69, 273);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(201, 31);
            txtEmail.TabIndex = 12;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(316, 273);
            txtPhoneNumber.Margin = new Padding(4, 5, 4, 5);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(201, 31);
            txtPhoneNumber.TabIndex = 13;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(316, 473);
            txtConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(201, 31);
            txtConfirmPassword.TabIndex = 14;
            txtConfirmPassword.TextChanged += PasswordFields_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(69, 382);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(201, 31);
            txtUsername.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(69, 473);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(201, 31);
            txtPassword.TabIndex = 16;
            txtPassword.TextChanged += PasswordFields_TextChanged;
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(316, 352);
            lbGender.Margin = new Padding(4, 0, 4, 0);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(69, 25);
            lbGender.TabIndex = 17;
            lbGender.Text = "Gender";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male", "Other" });
            cbGender.Location = new Point(316, 382);
            cbGender.Margin = new Padding(4, 5, 4, 5);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(201, 33);
            cbGender.TabIndex = 18;
            cbGender.Text = "Choose";
            // 
            // lblPasswordMismatch
            // 
            lblPasswordMismatch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPasswordMismatch.AutoSize = true;
            lblPasswordMismatch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPasswordMismatch.ForeColor = Color.OrangeRed;
            lblPasswordMismatch.Location = new Point(73, 540);
            lblPasswordMismatch.Margin = new Padding(4, 0, 4, 0);
            lblPasswordMismatch.Name = "lblPasswordMismatch";
            lblPasswordMismatch.Size = new Size(0, 32);
            lblPasswordMismatch.TabIndex = 19;
            lblPasswordMismatch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 700);
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
            Margin = new Padding(4, 5, 4, 5);
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