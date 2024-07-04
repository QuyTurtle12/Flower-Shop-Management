namespace GUI
{
    partial class RecoverAccount
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
            lbReset = new Label();
            lbMail = new Label();
            btnSend = new Button();
            txtMail = new TextBox();
            btnGoBack = new Button();
            SuspendLayout();
            // 
            // lbReset
            // 
            lbReset.AutoSize = true;
            lbReset.Location = new Point(24, 35);
            lbReset.Name = "lbReset";
            lbReset.Size = new Size(35, 15);
            lbReset.TabIndex = 0;
            lbReset.Text = "Reset";
            // 
            // lbMail
            // 
            lbMail.AutoSize = true;
            lbMail.Location = new Point(24, 88);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(41, 15);
            lbMail.TabIndex = 1;
            lbMail.Text = "E-mail";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(89, 141);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send mail";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(89, 85);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(193, 23);
            txtMail.TabIndex = 4;
            // 
            // btnGoBack
            // 
            btnGoBack.Location = new Point(89, 182);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(145, 23);
            btnGoBack.TabIndex = 5;
            btnGoBack.Text = "Go back to login page";
            btnGoBack.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 233);
            Controls.Add(btnGoBack);
            Controls.Add(txtMail);
            Controls.Add(btnSend);
            Controls.Add(lbMail);
            Controls.Add(lbReset);
            Name = "Reset";
            Text = "Reset Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbReset;
        private Label lbMail;
        private Button btnSend;
        private TextBox txtMail;
        private Button btnGoBack;
    }
}