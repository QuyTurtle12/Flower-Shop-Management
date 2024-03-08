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
            lbPaymentMethod.Location = new Point(60, 232);
            lbPaymentMethod.Margin = new Padding(4, 0, 4, 0);
            lbPaymentMethod.Name = "lbPaymentMethod";
            lbPaymentMethod.Size = new Size(148, 25);
            lbPaymentMethod.TabIndex = 0;
            lbPaymentMethod.Text = "Payment method";
            // 
            // rbtnCash
            // 
            rbtnCash.AutoSize = true;
            rbtnCash.Location = new Point(60, 287);
            rbtnCash.Margin = new Padding(4, 5, 4, 5);
            rbtnCash.Name = "rbtnCash";
            rbtnCash.Size = new Size(177, 29);
            rbtnCash.TabIndex = 1;
            rbtnCash.TabStop = true;
            rbtnCash.Text = "Cash (on delivery)";
            rbtnCash.UseVisualStyleBackColor = true;
            // 
            // rbtnZaloPay
            // 
            rbtnZaloPay.AutoSize = true;
            rbtnZaloPay.Enabled = false;
            rbtnZaloPay.Location = new Point(361, 287);
            rbtnZaloPay.Margin = new Padding(4, 5, 4, 5);
            rbtnZaloPay.Name = "rbtnZaloPay";
            rbtnZaloPay.Size = new Size(103, 29);
            rbtnZaloPay.TabIndex = 2;
            rbtnZaloPay.TabStop = true;
            rbtnZaloPay.Text = "Zalo Pay";
            rbtnZaloPay.UseVisualStyleBackColor = true;
            // 
            // rbtnBankCard
            // 
            rbtnBankCard.AutoSize = true;
            rbtnBankCard.Enabled = false;
            rbtnBankCard.Location = new Point(240, 287);
            rbtnBankCard.Margin = new Padding(4, 5, 4, 5);
            rbtnBankCard.Name = "rbtnBankCard";
            rbtnBankCard.Size = new Size(117, 29);
            rbtnBankCard.TabIndex = 3;
            rbtnBankCard.TabStop = true;
            rbtnBankCard.Text = "Bank Card";
            rbtnBankCard.UseVisualStyleBackColor = true;
            // 
            // lbStreet
            // 
            lbStreet.AutoSize = true;
            lbStreet.Location = new Point(60, 483);
            lbStreet.Margin = new Padding(4, 0, 4, 0);
            lbStreet.Name = "lbStreet";
            lbStreet.Size = new Size(57, 25);
            lbStreet.TabIndex = 4;
            lbStreet.Text = "Street";
            lbStreet.Click += label2_Click;
            // 
            // lbDistrict
            // 
            lbDistrict.AutoSize = true;
            lbDistrict.Location = new Point(60, 588);
            lbDistrict.Margin = new Padding(4, 0, 4, 0);
            lbDistrict.Name = "lbDistrict";
            lbDistrict.Size = new Size(67, 25);
            lbDistrict.TabIndex = 5;
            lbDistrict.Text = "District";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(297, 588);
            lbCountry.Margin = new Padding(4, 0, 4, 0);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(75, 25);
            lbCountry.TabIndex = 6;
            lbCountry.Text = "Country";
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(60, 513);
            txtStreet.Margin = new Padding(4, 5, 4, 5);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(428, 31);
            txtStreet.TabIndex = 7;
            // 
            // txtDistrict
            // 
            txtDistrict.Location = new Point(60, 618);
            txtDistrict.Margin = new Padding(4, 5, 4, 5);
            txtDistrict.Name = "txtDistrict";
            txtDistrict.Size = new Size(211, 31);
            txtDistrict.TabIndex = 8;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(297, 618);
            txtCountry.Margin = new Padding(4, 5, 4, 5);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(191, 31);
            txtCountry.TabIndex = 9;
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Location = new Point(60, 65);
            lbFullName.Margin = new Padding(4, 0, 4, 0);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(88, 25);
            lbFullName.TabIndex = 10;
            lbFullName.Text = "Full name";
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.AutoSize = true;
            lbPhoneNumber.Location = new Point(60, 130);
            lbPhoneNumber.Margin = new Padding(4, 0, 4, 0);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(129, 25);
            lbPhoneNumber.TabIndex = 11;
            lbPhoneNumber.Text = "Phone number";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(191, 60);
            txtFullName.Margin = new Padding(4, 5, 4, 5);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(204, 31);
            txtFullName.TabIndex = 12;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(191, 125);
            txtPhoneNumber.Margin = new Padding(4, 5, 4, 5);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(204, 31);
            txtPhoneNumber.TabIndex = 13;
            // 
            // rbtnApplePay
            // 
            rbtnApplePay.AutoSize = true;
            rbtnApplePay.Enabled = false;
            rbtnApplePay.Location = new Point(470, 287);
            rbtnApplePay.Margin = new Padding(4, 5, 4, 5);
            rbtnApplePay.Name = "rbtnApplePay";
            rbtnApplePay.Size = new Size(116, 29);
            rbtnApplePay.TabIndex = 14;
            rbtnApplePay.TabStop = true;
            rbtnApplePay.Text = "Apple Pay";
            rbtnApplePay.UseVisualStyleBackColor = true;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(669, 557);
            btnConfirm.Margin = new Padding(4, 5, 4, 5);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(107, 38);
            btnConfirm.TabIndex = 15;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
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
            Margin = new Padding(4, 5, 4, 5);
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