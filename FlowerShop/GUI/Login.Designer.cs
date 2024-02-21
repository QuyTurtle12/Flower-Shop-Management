namespace GUI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbLogin = new Label();
            lbUsername = new Label();
            lbPassword = new Label();
            btnLogin = new Button();
            btnRecoverAccount = new Button();
            btnRegister = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lbLogin.Location = new Point(109, 27);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(124, 25);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "LOGIN PAGE";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(29, 88);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(100, 15);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username / Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(29, 132);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(190, 223);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(92, 41);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRecoverAccount
            // 
            btnRecoverAccount.Location = new Point(212, 161);
            btnRecoverAccount.Name = "btnRecoverAccount";
            btnRecoverAccount.Size = new Size(122, 22);
            btnRecoverAccount.TabIndex = 4;
            btnRecoverAccount.Text = "Forget password ?";
            btnRecoverAccount.UseVisualStyleBackColor = true;
            btnRecoverAccount.Click += btnRecoverAccount_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(29, 223);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(107, 41);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Create account";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(137, 85);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(197, 23);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(137, 132);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(197, 23);
            txtPassword.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 340);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnRegister);
            Controls.Add(btnRecoverAccount);
            Controls.Add(btnLogin);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(lbLogin);
            Name = "Login";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogin;
        private Label lbUsername;
        private Label lbPassword;
        private Button btnLogin;
        private Button btnRecoverAccount;
        private Button btnRegister;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}
