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
            btnConnect = new Button();
            btnForgotPwd = new Button();
            btnCreateAccount = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(120, 21);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(37, 15);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Login";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Location = new Point(29, 88);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(60, 15);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username";
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
            // btnConnect
            // 
            btnConnect.Location = new Point(134, 190);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += this.button1_Click;
            // 
            // btnForgotPwd
            // 
            btnForgotPwd.Location = new Point(146, 254);
            btnForgotPwd.Name = "btnForgotPwd";
            btnForgotPwd.Size = new Size(122, 23);
            btnForgotPwd.TabIndex = 4;
            btnForgotPwd.Text = "Forget password ?";
            btnForgotPwd.UseVisualStyleBackColor = true;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(42, 254);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(98, 23);
            btnCreateAccount.TabIndex = 5;
            btnCreateAccount.Text = "Create account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(134, 85);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(131, 23);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(134, 132);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(131, 23);
            txtPassword.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 301);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnCreateAccount);
            Controls.Add(btnForgotPwd);
            Controls.Add(btnConnect);
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
        private Button btnConnect;
        private Button btnForgotPwd;
        private Button btnCreateAccount;
        private TextBox txtUsername;
        private TextBox txtPassword;
    }
}
