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
            label6 = new Label();
            emailTB = new TextBox();
            label7 = new Label();
            addressTB = new TextBox();
            label9 = new Label();
            signUpBtn = new MiniStore.CustomBtn();
            administratorCL = new CheckBox();
            calendarC = new MonthCalendar();
            monthCB = new ComboBox();
            yearCB = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            dayCB = new ComboBox();
            nameMissingLbl = new Label();
            emailMissingLbl = new Label();
            passwordMissingLbl = new Label();
            addressMissingLbl = new Label();
            dateMissingLbl = new Label();
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
            label3.Location = new Point(75, 354);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 7;
            label3.Text = "Month:";
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
            label7.Location = new Point(76, 293);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 15;
            label7.Text = "Address:";
            // 
            // addressTB
            // 
            addressTB.Location = new Point(76, 311);
            addressTB.Name = "addressTB";
            addressTB.Size = new Size(223, 23);
            addressTB.TabIndex = 14;
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
            signUpBtn.Location = new Point(116, 458);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(150, 40);
            signUpBtn.TabIndex = 19;
            signUpBtn.Text = "Sign Up";
            signUpBtn.TextColor = Color.White;
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // administratorCL
            // 
            administratorCL.AutoSize = true;
            administratorCL.Location = new Point(76, 420);
            administratorCL.Name = "administratorCL";
            administratorCL.Size = new Size(99, 19);
            administratorCL.TabIndex = 21;
            administratorCL.Text = "Administrator";
            administratorCL.UseVisualStyleBackColor = true;
            // 
            // calendarC
            // 
            calendarC.Location = new Point(75, 355);
            calendarC.Name = "calendarC";
            calendarC.ShowToday = false;
            calendarC.TabIndex = 24;
            calendarC.Visible = false;
            calendarC.DateSelected += calendarC_DateSelected;
            // 
            // monthCB
            // 
            monthCB.DropDownStyle = ComboBoxStyle.Simple;
            monthCB.FormattingEnabled = true;
            monthCB.Location = new Point(76, 372);
            monthCB.Name = "monthCB";
            monthCB.Size = new Size(52, 23);
            monthCB.TabIndex = 23;
            monthCB.MouseClick += monthCB_MouseClick;
            // 
            // yearCB
            // 
            yearCB.DropDownStyle = ComboBoxStyle.Simple;
            yearCB.FormattingEnabled = true;
            yearCB.Location = new Point(246, 372);
            yearCB.Name = "yearCB";
            yearCB.Size = new Size(52, 23);
            yearCB.TabIndex = 22;
            yearCB.MouseClick += yearCB_MouseClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 354);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 9;
            label5.Text = "Year:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 354);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 8;
            label4.Text = "Day:";
            // 
            // dayCB
            // 
            dayCB.DropDownStyle = ComboBoxStyle.Simple;
            dayCB.FormattingEnabled = true;
            dayCB.Location = new Point(160, 372);
            dayCB.Name = "dayCB";
            dayCB.Size = new Size(52, 23);
            dayCB.TabIndex = 20;
            dayCB.MouseClick += dayCB_MouseClick;
            // 
            // nameMissingLbl
            // 
            nameMissingLbl.AutoSize = true;
            nameMissingLbl.BackColor = Color.Transparent;
            nameMissingLbl.Font = new Font("Segoe UI", 7F);
            nameMissingLbl.ForeColor = Color.Red;
            nameMissingLbl.Location = new Point(75, 142);
            nameMissingLbl.Name = "nameMissingLbl";
            nameMissingLbl.Size = new Size(91, 12);
            nameMissingLbl.TabIndex = 25;
            nameMissingLbl.Text = "This field is required";
            nameMissingLbl.Visible = false;
            // 
            // emailMissingLbl
            // 
            emailMissingLbl.AutoSize = true;
            emailMissingLbl.BackColor = Color.Transparent;
            emailMissingLbl.Font = new Font("Segoe UI", 7F);
            emailMissingLbl.ForeColor = Color.Red;
            emailMissingLbl.Location = new Point(75, 205);
            emailMissingLbl.Name = "emailMissingLbl";
            emailMissingLbl.Size = new Size(91, 12);
            emailMissingLbl.TabIndex = 26;
            emailMissingLbl.Text = "This field is required";
            emailMissingLbl.Visible = false;
            // 
            // passwordMissingLbl
            // 
            passwordMissingLbl.AutoSize = true;
            passwordMissingLbl.BackColor = Color.Transparent;
            passwordMissingLbl.Font = new Font("Segoe UI", 7F);
            passwordMissingLbl.ForeColor = Color.Red;
            passwordMissingLbl.Location = new Point(75, 268);
            passwordMissingLbl.Name = "passwordMissingLbl";
            passwordMissingLbl.Size = new Size(91, 12);
            passwordMissingLbl.TabIndex = 27;
            passwordMissingLbl.Text = "This field is required";
            passwordMissingLbl.Visible = false;
            // 
            // addressMissingLbl
            // 
            addressMissingLbl.AutoSize = true;
            addressMissingLbl.BackColor = Color.Transparent;
            addressMissingLbl.Font = new Font("Segoe UI", 7F);
            addressMissingLbl.ForeColor = Color.Red;
            addressMissingLbl.Location = new Point(76, 334);
            addressMissingLbl.Name = "addressMissingLbl";
            addressMissingLbl.Size = new Size(91, 12);
            addressMissingLbl.TabIndex = 28;
            addressMissingLbl.Text = "This field is required";
            addressMissingLbl.Visible = false;
            // 
            // dateMissingLbl
            // 
            dateMissingLbl.AutoSize = true;
            dateMissingLbl.BackColor = Color.Transparent;
            dateMissingLbl.Font = new Font("Segoe UI", 7F);
            dateMissingLbl.ForeColor = Color.Red;
            dateMissingLbl.Location = new Point(145, 398);
            dateMissingLbl.Name = "dateMissingLbl";
            dateMissingLbl.Size = new Size(84, 12);
            dateMissingLbl.TabIndex = 29;
            dateMissingLbl.Text = "Must select a date";
            dateMissingLbl.Visible = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 519);
            Controls.Add(dateMissingLbl);
            Controls.Add(addressMissingLbl);
            Controls.Add(passwordMissingLbl);
            Controls.Add(emailMissingLbl);
            Controls.Add(nameMissingLbl);
            Controls.Add(calendarC);
            Controls.Add(monthCB);
            Controls.Add(yearCB);
            Controls.Add(administratorCL);
            Controls.Add(dayCB);
            Controls.Add(signUpBtn);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(addressTB);
            Controls.Add(label6);
            Controls.Add(emailTB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordTB);
            Controls.Add(label1);
            Controls.Add(nameTB);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTB;
        private Label label1;
        private Label label2;
        private TextBox passwordTB;
        private Label label3;
        private Label label6;
        private TextBox emailTB;
        private Label label7;
        private TextBox addressTB;
        private Label label9;
        private MiniStore.CustomBtn signUpBtn;
        private CheckBox administratorCL;
        private MonthCalendar calendarC;
        private ComboBox monthCB;
        private ComboBox yearCB;
        private Label label5;
        private Label label4;
        private ComboBox dayCB;
        private Label nameMissingLbl;
        private Label emailMissingLbl;
        private Label passwordMissingLbl;
        private Label addressMissingLbl;
        private Label dateMissingLbl;
    }
}