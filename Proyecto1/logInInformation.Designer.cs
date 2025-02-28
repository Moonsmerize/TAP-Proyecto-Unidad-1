namespace Proyecto1
{
    partial class logInInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logInInformation));
            label1 = new Label();
            emailTB = new TextBox();
            passwordTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            logInBtn = new MiniStore.CustomBtn();
            panel1 = new Panel();
            signUpBtn = new MiniStore.CustomBtn();
            fgtYourPasswordBtn = new Label();
            emailMissingLbl = new Label();
            emailMissingLbl1 = new Label();
            incorrectLbl = new Label();
            hidePassBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)hidePassBtn).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 9);
            label1.Name = "label1";
            label1.Size = new Size(224, 65);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // emailTB
            // 
            emailTB.Location = new Point(35, 145);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(197, 23);
            emailTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            passwordTB.Location = new Point(35, 229);
            passwordTB.Name = "passwordTB";
            passwordTB.PasswordChar = '*';
            passwordTB.Size = new Size(197, 23);
            passwordTB.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 118);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 202);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.FromArgb(24, 33, 79);
            logInBtn.BackgroundColor = Color.FromArgb(24, 33, 79);
            logInBtn.BorderColor = Color.PaleVioletRed;
            logInBtn.BorderRadius = 20;
            logInBtn.BorderSize = 0;
            logInBtn.FlatAppearance.BorderSize = 0;
            logInBtn.FlatStyle = FlatStyle.Flat;
            logInBtn.ForeColor = Color.White;
            logInBtn.Location = new Point(35, 309);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(150, 40);
            logInBtn.TabIndex = 5;
            logInBtn.Text = "Login";
            logInBtn.TextColor = Color.White;
            logInBtn.UseVisualStyleBackColor = false;
            logInBtn.Click += logInBtn_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.resolutions;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(380, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 375);
            panel1.TabIndex = 6;
            // 
            // signUpBtn
            // 
            signUpBtn.BackColor = Color.Transparent;
            signUpBtn.BackgroundColor = Color.Transparent;
            signUpBtn.BorderColor = Color.FromArgb(24, 33, 79);
            signUpBtn.BorderRadius = 20;
            signUpBtn.BorderSize = 1;
            signUpBtn.FlatAppearance.BorderSize = 0;
            signUpBtn.FlatStyle = FlatStyle.Flat;
            signUpBtn.ForeColor = Color.Black;
            signUpBtn.Location = new Point(191, 309);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(150, 40);
            signUpBtn.TabIndex = 7;
            signUpBtn.Text = "Sign Up";
            signUpBtn.TextColor = Color.Black;
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // fgtYourPasswordBtn
            // 
            fgtYourPasswordBtn.AutoSize = true;
            fgtYourPasswordBtn.ForeColor = Color.FromArgb(24, 33, 79);
            fgtYourPasswordBtn.Location = new Point(126, 291);
            fgtYourPasswordBtn.Name = "fgtYourPasswordBtn";
            fgtYourPasswordBtn.Size = new Size(127, 15);
            fgtYourPasswordBtn.TabIndex = 8;
            fgtYourPasswordBtn.Text = "Forgot your password?";
            fgtYourPasswordBtn.Click += fgtYourPasswordBtn_Click;
            fgtYourPasswordBtn.MouseEnter += frgPasswordOn;
            fgtYourPasswordBtn.MouseLeave += frgPasswordOff;
            // 
            // emailMissingLbl
            // 
            emailMissingLbl.AutoSize = true;
            emailMissingLbl.BackColor = Color.Transparent;
            emailMissingLbl.Font = new Font("Segoe UI", 7F);
            emailMissingLbl.ForeColor = Color.Red;
            emailMissingLbl.Location = new Point(36, 168);
            emailMissingLbl.Name = "emailMissingLbl";
            emailMissingLbl.Size = new Size(91, 12);
            emailMissingLbl.TabIndex = 9;
            emailMissingLbl.Text = "This field is required";
            emailMissingLbl.Visible = false;
            // 
            // emailMissingLbl1
            // 
            emailMissingLbl1.AutoSize = true;
            emailMissingLbl1.BackColor = Color.Transparent;
            emailMissingLbl1.Font = new Font("Segoe UI", 7F);
            emailMissingLbl1.ForeColor = Color.Red;
            emailMissingLbl1.Location = new Point(36, 252);
            emailMissingLbl1.Name = "emailMissingLbl1";
            emailMissingLbl1.Size = new Size(91, 12);
            emailMissingLbl1.TabIndex = 10;
            emailMissingLbl1.Text = "This field is required";
            emailMissingLbl1.Visible = false;
            // 
            // incorrectLbl
            // 
            incorrectLbl.AutoSize = true;
            incorrectLbl.BackColor = Color.Transparent;
            incorrectLbl.Font = new Font("Segoe UI", 10F);
            incorrectLbl.ForeColor = Color.Red;
            incorrectLbl.Location = new Point(35, 87);
            incorrectLbl.Name = "incorrectLbl";
            incorrectLbl.Size = new Size(177, 19);
            incorrectLbl.TabIndex = 11;
            incorrectLbl.Text = "Email or password incorrect";
            incorrectLbl.Visible = false;
            // 
            // hidePassBtn
            // 
            hidePassBtn.BackColor = Color.White;
            hidePassBtn.Image = (Image)resources.GetObject("hidePassBtn.Image");
            hidePassBtn.Location = new Point(209, 230);
            hidePassBtn.Name = "hidePassBtn";
            hidePassBtn.Size = new Size(22, 20);
            hidePassBtn.SizeMode = PictureBoxSizeMode.Zoom;
            hidePassBtn.TabIndex = 12;
            hidePassBtn.TabStop = false;
            hidePassBtn.Click += hidePassBtn_Click;
            hidePassBtn.MouseEnter += hidePassBtn_MouseEnter;
            hidePassBtn.MouseLeave += hidePassBtn_MouseLeave;
            // 
            // logInInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 375);
            Controls.Add(hidePassBtn);
            Controls.Add(incorrectLbl);
            Controls.Add(emailMissingLbl1);
            Controls.Add(emailMissingLbl);
            Controls.Add(fgtYourPasswordBtn);
            Controls.Add(signUpBtn);
            Controls.Add(panel1);
            Controls.Add(logInBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordTB);
            Controls.Add(emailTB);
            Controls.Add(label1);
            Name = "logInInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            Load += logInInformation_Load;
            ((System.ComponentModel.ISupportInitialize)hidePassBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox emailTB;
        private TextBox passwordTB;
        private Label label2;
        private Label label3;
        private MiniStore.CustomBtn logInBtn;
        private Panel panel1;
        private MiniStore.CustomBtn signUpBtn;
        private Label fgtYourPasswordBtn;
        private Label emailMissingLbl;
        private Label emailMissingLbl1;
        private Label incorrectLbl;
        private PictureBox hidePassBtn;
    }
}