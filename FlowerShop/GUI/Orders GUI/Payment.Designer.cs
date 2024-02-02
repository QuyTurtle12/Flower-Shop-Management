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
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            lbStreet = new Label();
            lbDistrict = new Label();
            lbCountry = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            lbFullName = new Label();
            lbPhoneNumber = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            rbtnApplePay = new RadioButton();
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
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(253, 172);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Zalo Pay";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(168, 172);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(79, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Bank Card";
            radioButton3.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(42, 308);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 371);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(208, 371);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(135, 23);
            textBox3.TabIndex = 9;
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
            // textBox4
            // 
            textBox4.Location = new Point(134, 36);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(144, 23);
            textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(134, 75);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(144, 23);
            textBox5.TabIndex = 13;
            // 
            // rbtnApplePay
            // 
            rbtnApplePay.AutoSize = true;
            rbtnApplePay.Location = new Point(329, 172);
            rbtnApplePay.Name = "rbtnApplePay";
            rbtnApplePay.Size = new Size(78, 19);
            rbtnApplePay.TabIndex = 14;
            rbtnApplePay.TabStop = true;
            rbtnApplePay.Text = "Apple Pay";
            rbtnApplePay.UseVisualStyleBackColor = true;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbtnApplePay);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(lbPhoneNumber);
            Controls.Add(lbFullName);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbCountry);
            Controls.Add(lbDistrict);
            Controls.Add(lbStreet);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
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
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label lbStreet;
        private Label lbDistrict;
        private Label lbCountry;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lbFullName;
        private Label lbPhoneNumber;
        private TextBox textBox4;
        private TextBox textBox5;
        private RadioButton rbtnApplePay;
    }
}