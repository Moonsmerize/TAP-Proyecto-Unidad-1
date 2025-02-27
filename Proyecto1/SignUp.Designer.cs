namespace Proyecto1
{
    partial class SignUp
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
            nameTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            passwordTB = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            emailTB = new TextBox();
            label7 = new Label();
            addressTB = new TextBox();
            label8 = new Label();
            conPasswordTB = new TextBox();
            label9 = new Label();
            signUpBtn = new MiniStore.CustomBtn();
            comboBox1 = new ComboBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // nameTB
            // 
            nameTB.Location = new Point(76, 119);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(223, 23);
            nameTB.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 101);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 227);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(76, 245);
            passwordTB.Name = "passwordTB";
            passwordTB.Size = new Size(223, 23);
            passwordTB.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 422);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 7;
            label3.Text = "Month:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 422);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 8;
            label4.Text = "Day:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 422);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 9;
            label5.Text = "Year:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(247, 449);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(52, 23);
            textBox5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 164);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 13;
            label6.Text = "Email:";
            // 
            // emailTB
            // 
            emailTB.Location = new Point(76, 182);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(223, 23);
            emailTB.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(76, 361);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 15;
            label7.Text = "Address:";
            // 
            // addressTB
            // 
            addressTB.Location = new Point(76, 379);
            addressTB.Name = "addressTB";
            addressTB.Size = new Size(223, 23);
            addressTB.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(76, 296);
            label8.Name = "label8";
            label8.Size = new Size(107, 15);
            label8.TabIndex = 17;
            label8.Text = "Confirm Password:";
            // 
            // conPasswordTB
            // 
            conPasswordTB.Location = new Point(76, 314);
            conPasswordTB.Name = "conPasswordTB";
            conPasswordTB.Size = new Size(223, 23);
            conPasswordTB.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(116, 9);
            label9.Name = "label9";
            label9.Size = new Size(151, 50);
            label9.TabIndex = 18;
            label9.Text = "Sign Up";
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = Color.FromArgb(24, 33, 79);
            signUpBtn.BackgroundColor = Color.FromArgb(24, 33, 79);
            signUpBtn.BorderColor = Color.PaleVioletRed;
            signUpBtn.BorderRadius = 20;
            signUpBtn.BorderSize = 0;
            signUpBtn.FlatAppearance.BorderSize = 0;
            signUpBtn.FlatStyle = FlatStyle.Flat;
            signUpBtn.ForeColor = Color.White;
            signUpBtn.Location = new Point(102, 510);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(150, 40);
            signUpBtn.TabIndex = 19;
            signUpBtn.Text = "Sign Up";
            signUpBtn.TextColor = Color.White;
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBox1.Location = new Point(161, 449);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(52, 23);
            comboBox1.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(77, 449);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(52, 23);
            textBox3.TabIndex = 4;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 562);
            Controls.Add(comboBox1);
            Controls.Add(signUpBtn);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(conPasswordTB);
            Controls.Add(label7);
            Controls.Add(addressTB);
            Controls.Add(label6);
            Controls.Add(emailTB);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(passwordTB);
            Controls.Add(label1);
            Controls.Add(nameTB);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTB;
        private Label label1;
        private Label label2;
        private TextBox passwordTB;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox emailTB;
        private Label label7;
        private TextBox addressTB;
        private Label label8;
        private TextBox conPasswordTB;
        private Label label9;
        private MiniStore.CustomBtn signUpBtn;
        private ComboBox comboBox1;
        private TextBox textBox3;
    }
}