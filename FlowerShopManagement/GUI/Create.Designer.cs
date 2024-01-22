namespace GUI
{
    partial class Create
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAlreadyAcc = new Button();
            label1 = new Label();
            btnCreate = new Button();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            SuspendLayout();
            // 
            // lbCreate
            // 
            lbCreate.AutoSize = true;
            lbCreate.Location = new Point(165, 28);
            lbCreate.Name = "lbCreate";
            lbCreate.Size = new Size(103, 15);
            lbCreate.TabIndex = 0;
            lbCreate.Text = "Create an account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 89);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 89);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Surname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 146);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 3;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 146);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 4;
            label5.Text = "Phone Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 211);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 5;
            label6.Text = "Username";

            // 
            // btnAlreadyAcc
            // 
            btnAlreadyAcc.Location = new Point(141, 376);
            btnAlreadyAcc.Name = "btnAlreadyAcc";
            btnAlreadyAcc.Size = new Size(127, 23);
            btnAlreadyAcc.TabIndex = 6;
            btnAlreadyAcc.Text = "Already an account ?";
            btnAlreadyAcc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 266);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 7;
            label1.Text = "Password";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(165, 337);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(221, 266);
            label7.Name = "label7";
            label7.Size = new Size(125, 15);
            label7.TabIndex = 9;
            label7.Text = "Re-enter the password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(48, 164);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(142, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(221, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(142, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(221, 284);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(142, 23);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(48, 229);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(142, 23);
            textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(48, 284);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(142, 23);
            textBox7.TabIndex = 16;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 420);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(btnCreate);
            Controls.Add(label1);
            Controls.Add(btnAlreadyAcc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbCreate);
            Name = "Create";
            Text = "Create an account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCreate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnAlreadyAcc;
        private Label label1;
        private Button btnCreate;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}