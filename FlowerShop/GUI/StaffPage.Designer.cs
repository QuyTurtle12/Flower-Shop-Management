namespace GUI
{
    partial class StaffPage
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
            btnUpdate = new Button();
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtPhoneNumber = new TextBox();
            txtFullName = new TextBox();
            txtUserId = new TextBox();
            lbGender = new Label();
            lbPhoneNumber = new Label();
            label3 = new Label();
            lbRole = new Label();
            lbUserID = new Label();
            txtRole = new TextBox();
            txtGender = new TextBox();
            btnEmailChange = new Button();
            btnPhoneChange = new Button();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(120, 326);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 29;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(133, 177);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(121, 23);
            txtEmail.TabIndex = 28;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(41, 180);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(41, 15);
            lbEmail.TabIndex = 27;
            lbEmail.Text = "E-mail";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(133, 260);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(121, 23);
            txtPhoneNumber.TabIndex = 25;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(133, 90);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(121, 23);
            txtFullName.TabIndex = 23;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(133, 53);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(121, 23);
            txtUserId.TabIndex = 21;
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(41, 222);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(45, 15);
            lbGender.TabIndex = 20;
            lbGender.Text = "Gender";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(41, 260);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(86, 15);
            lbPhoneNumber.TabIndex = 19;
            lbPhoneNumber.Text = "Phone number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 93);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 17;
            label3.Text = "Full Name";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new Point(41, 137);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(30, 15);
            lbRole.TabIndex = 16;
            lbRole.Text = "Role";
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Location = new Point(41, 56);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new Size(44, 15);
            lbUserID.TabIndex = 15;
            lbUserID.Text = "User ID";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(133, 137);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(121, 23);
            txtRole.TabIndex = 30;
            // 
            // txtGender
            // 
            txtGender.Location = new Point(133, 222);
            txtGender.Name = "txtGender";
            txtGender.ReadOnly = true;
            txtGender.Size = new Size(121, 23);
            txtGender.TabIndex = 31;
            // 
            // btnEmailChange
            // 
            btnEmailChange.Location = new Point(269, 177);
            btnEmailChange.Name = "btnEmailChange";
            btnEmailChange.Size = new Size(103, 25);
            btnEmailChange.TabIndex = 32;
            btnEmailChange.Text = "Change Email";
            btnEmailChange.UseVisualStyleBackColor = true;
            btnEmailChange.Click += btnEmailChange_Click;
            // 
            // btnPhoneChange
            // 
            btnPhoneChange.Location = new Point(269, 260);
            btnPhoneChange.Name = "btnPhoneChange";
            btnPhoneChange.Size = new Size(103, 25);
            btnPhoneChange.TabIndex = 33;
            btnPhoneChange.Text = "Change Phone";
            btnPhoneChange.UseVisualStyleBackColor = true;
            btnPhoneChange.Click += button1_Click;
            // 
            // StaffPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 361);
            Controls.Add(btnPhoneChange);
            Controls.Add(btnEmailChange);
            Controls.Add(txtGender);
            Controls.Add(txtRole);
            Controls.Add(btnUpdate);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtFullName);
            Controls.Add(txtUserId);
            Controls.Add(lbGender);
            Controls.Add(lbPhoneNumber);
            Controls.Add(label3);
            Controls.Add(lbRole);
            Controls.Add(lbUserID);
            Name = "StaffPage";
            Text = "Staff Info";
            Load += StaffPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtFullName;
        private TextBox txtUserId;
        private Label lbGender;
        private Label lbPhoneNumber;
        private Label label3;
        private Label lbRole;
        private Label lbUserID;
        private TextBox txtRole;
        private TextBox txtGender;
        private Button btnEmailChange;
        private Button btnPhoneChange;
    }
}