namespace GUI.Orders_GUI
{
    partial class Payment
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
            lbPaymentMethod = new Label();
            rbtnCash = new RadioButton();
            rbtnZaloPay = new RadioButton();
            rbtnBankCard = new RadioButton();
            lbStreet = new Label();
            lbDistrict = new Label();
            lbCountry = new Label();
            txtStreet = new TextBox();
            txtDistrict = new TextBox();
            txtCountry = new TextBox();
            lbFullName = new Label();
            lbPhoneNumber = new Label();
            txtFullName = new TextBox();
            txtPhoneNumber = new TextBox();
            rbtnApplePay = new RadioButton();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // lbPaymentMethod
            // 
            lbPaymentMethod.AutoSize = true;
            lbPaymentMethod.Location = new Point(42, 139);
            lbPaymentMethod.Name = "lbPaymentMethod";
            lbPaymentMethod.Size = new Size(99, 15);
            lbPaymentMethod.TabIndex = 0;
            lbPaymentMethod.Text = "Payment method";
            // 
            // rbtnCash
            // 
            rbtnCash.AutoSize = true;
            rbtnCash.Location = new Point(42, 172);
            rbtnCash.Name = "rbtnCash";
            rbtnCash.Size = new Size(120, 19);
            rbtnCash.TabIndex = 1;
            rbtnCash.TabStop = true;
            rbtnCash.Text = "Cash (on delivery)";
            rbtnCash.UseVisualStyleBackColor = true;
            // 
            // rbtnZaloPay
            // 
            rbtnZaloPay.AutoSize = true;
            rbtnZaloPay.Enabled = false;
            rbtnZaloPay.Location = new Point(253, 172);
            rbtnZaloPay.Name = "rbtnZaloPay";
            rbtnZaloPay.Size = new Size(70, 19);
            rbtnZaloPay.TabIndex = 2;
            rbtnZaloPay.TabStop = true;
            rbtnZaloPay.Text = "Zalo Pay";
            rbtnZaloPay.UseVisualStyleBackColor = true;
            // 
            // rbtnBankCard
            // 
            rbtnBankCard.AutoSize = true;
            rbtnBankCard.Enabled = false;
            rbtnBankCard.Location = new Point(168, 172);
            rbtnBankCard.Name = "rbtnBankCard";
            rbtnBankCard.Size = new Size(79, 19);
            rbtnBankCard.TabIndex = 3;
            rbtnBankCard.TabStop = true;
            rbtnBankCard.Text = "Bank Card";
            rbtnBankCard.UseVisualStyleBackColor = true;
            // 
            // lbStreet
            // 
            lbStreet.AutoSize = true;
            lbStreet.Location = new Point(42, 290);
            lbStreet.Name = "lbStreet";
            lbStreet.Size = new Size(37, 15);
            lbStreet.TabIndex = 4;
            lbStreet.Text = "Street";
            lbStreet.Click += label2_Click;
            // 
            // lbDistrict
            // 
            lbDistrict.AutoSize = true;
            lbDistrict.Location = new Point(42, 353);
            lbDistrict.Name = "lbDistrict";
            lbDistrict.Size = new Size(44, 15);
            lbDistrict.TabIndex = 5;
            lbDistrict.Text = "District";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(208, 353);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 6;
            lbCountry.Text = "Country";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(42, 308);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(301, 23);
            txtStreet.TabIndex = 7;
            // 
            // txtDistrict
            // 
            txtDistrict.Location = new Point(42, 371);
            txtDistrict.Name = "txtDistrict";
            txtDistrict.Size = new Size(149, 23);
            txtDistrict.TabIndex = 8;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(208, 371);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(135, 23);
            txtCountry.TabIndex = 9;
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Location = new Point(42, 39);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(59, 15);
            lbFullName.TabIndex = 10;
            lbFullName.Text = "Full name";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(42, 78);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(86, 15);
            lbPhoneNumber.TabIndex = 11;
            lbPhoneNumber.Text = "Phone number";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(134, 36);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(144, 23);
            txtFullName.TabIndex = 12;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(134, 75);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(144, 23);
            txtPhoneNumber.TabIndex = 13;
            txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
            // 
            // rbtnApplePay
            // 
            rbtnApplePay.AutoSize = true;
            rbtnApplePay.Enabled = false;
            rbtnApplePay.Location = new Point(329, 172);
            rbtnApplePay.Name = "rbtnApplePay";
            rbtnApplePay.Size = new Size(78, 19);
            rbtnApplePay.TabIndex = 14;
            rbtnApplePay.TabStop = true;
            rbtnApplePay.Text = "Apple Pay";
            rbtnApplePay.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(468, 334);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirm);
            Controls.Add(rbtnApplePay);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtFullName);
            Controls.Add(lbPhoneNumber);
            Controls.Add(lbFullName);
            Controls.Add(txtCountry);
            Controls.Add(txtDistrict);
            Controls.Add(txtStreet);
            Controls.Add(lbCountry);
            Controls.Add(lbDistrict);
            Controls.Add(lbStreet);
            Controls.Add(rbtnBankCard);
            Controls.Add(rbtnZaloPay);
            Controls.Add(rbtnCash);
            Controls.Add(lbPaymentMethod);
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbPaymentMethod;
        private RadioButton rbtnCash;
        private RadioButton rbtnZaloPay;
        private RadioButton rbtnBankCard;
        private Label lbStreet;
        private Label lbDistrict;
        private Label lbCountry;
        private TextBox txtStreet;
        private TextBox txtDistrict;
        private TextBox txtCountry;
        private Label lbFullName;
        private Label lbPhoneNumber;
        private TextBox txtFullName;
        private TextBox txtPhoneNumber;
        private RadioButton rbtnApplePay;
        private Button btnConfirm;
    }
}