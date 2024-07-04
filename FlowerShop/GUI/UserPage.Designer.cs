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
            btnMyOrders = new Button();
            SuspendLayout();
            // 
            // lbUserID
            // 
            lbUserID.AutoSize = true;
            lbUserID.Location = new Point(54, 87);
            lbUserID.Margin = new Padding(4, 0, 4, 0);
            lbUserID.Name = "lbUserID";
            lbUserID.Size = new Size(70, 25);
            lbUserID.TabIndex = 0;
            lbUserID.Text = "User ID";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new Point(54, 222);
            lbRole.Margin = new Padding(4, 0, 4, 0);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(46, 25);
            lbRole.TabIndex = 1;
            lbRole.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 148);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 2;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(364, 152);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 3;
            label4.Text = "Last Name";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(364, 293);
            lbPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(129, 25);
            lbPhoneNumber.TabIndex = 4;
            lbPhoneNumber.Text = "Phone number";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(54, 363);
            lbGender.Margin = new Padding(4, 0, 4, 0);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(69, 25);
            lbGender.TabIndex = 5;
            lbGender.Text = "Gender";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 82);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 31);
            textBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(167, 217);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 33);
            comboBox1.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(167, 143);
            txtFirstName.Margin = new Padding(4, 5, 4, 5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(171, 31);
            txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(496, 143);
            txtLastName.Margin = new Padding(4, 5, 4, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(167, 31);
            txtLastName.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(496, 280);
            txtPhoneNumber.Margin = new Padding(4, 5, 4, 5);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(171, 31);
            txtPhoneNumber.TabIndex = 10;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male", "Other" });
            cbGender.Location = new Point(167, 358);
            cbGender.Margin = new Padding(4, 5, 4, 5);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(171, 33);
            cbGender.TabIndex = 11;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(54, 293);
            lbEmail.Margin = new Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(61, 25);
            lbEmail.TabIndex = 12;
            lbEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(167, 288);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(171, 31);
            txtEmail.TabIndex = 13;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(167, 468);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(107, 38);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnMyOrders
            // 
            btnMyOrders.Location = new Point(574, 20);
            btnMyOrders.Margin = new Padding(4, 5, 4, 5);
            btnMyOrders.Name = "btnMyOrders";
            btnMyOrders.Size = new Size(107, 38);
            btnMyOrders.TabIndex = 15;
            btnMyOrders.Text = "My orders";
            btnMyOrders.UseVisualStyleBackColor = true;
            btnMyOrders.Click += btnMyOrders_Click;
            // 
            // frmUserPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 545);
            Controls.Add(btnMyOrders);
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
            Margin = new Padding(4, 5, 4, 5);
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
        private Button btnMyOrders;
    }
}