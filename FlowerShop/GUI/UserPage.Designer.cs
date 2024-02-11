namespace GUI
{
    partial class frmUserPage
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
            lbUserID = new Label();
            lbRole = new Label();
            label3 = new Label();
            label4 = new Label();
            lbPhoneNumber = new Label();
            lbGender = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhoneNumber = new TextBox();
            cbGender = new ComboBox();
            lbEmail = new Label();
            txtEmail = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Location = new Point(38, 52);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new Size(44, 15);
            lbUserID.TabIndex = 0;
            lbUserID.Text = "User ID";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new Point(38, 133);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(30, 15);
            lbRole.TabIndex = 1;
            lbRole.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 89);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 91);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 3;
            label4.Text = "Last Name";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(255, 176);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(86, 15);
            lbPhoneNumber.TabIndex = 4;
            lbPhoneNumber.Text = "Phone number";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(38, 218);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(45, 15);
            lbGender.TabIndex = 5;
            lbGender.Text = "Gender";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(117, 130);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(117, 86);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(121, 23);
            txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(324, 86);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(118, 23);
            txtLastName.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(347, 168);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(121, 23);
            txtPhoneNumber.TabIndex = 10;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male", "Other" });
            cbGender.Location = new Point(117, 215);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 23);
            cbGender.TabIndex = 11;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(38, 176);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(41, 15);
            lbEmail.TabIndex = 12;
            lbEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(117, 173);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(121, 23);
            txtEmail.TabIndex = 13;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(117, 281);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;

            // 
            // frmUserPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 327);
            Controls.Add(btnUpdate);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(cbGender);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(lbGender);
            Controls.Add(lbPhoneNumber);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbRole);
            Controls.Add(lbUserID);
            Name = "frmUserPage";
            Text = "My account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUserID;
        private Label lbRole;
        private Label label3;
        private Label label4;
        private Label lbPhoneNumber;
        private Label lbGender;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhoneNumber;
        private ComboBox cbGender;
        private Label lbEmail;
        private TextBox txtEmail;
        private Button btnUpdate;
    }
}