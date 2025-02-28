namespace Proyecto1
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            logInBtn = new MiniStore.CustomBtn();
            logOutBtn = new MiniStore.CustomBtn();
            label1 = new Label();
            nameLbl = new Label();
            emailLbl = new Label();
            addressLbl = new Label();
            ageLbl = new Label();
            PrivilagesLbl = new Label();
            userPB = new PictureBox();
            emailLbl1 = new Label();
            addressLbl1 = new Label();
            ageLbl1 = new Label();
            colorsCB = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)userPB).BeginInit();
            SuspendLayout();
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.FromArgb(24, 33, 79);
            logInBtn.BackgroundColor = Color.FromArgb(24, 33, 79);
            logInBtn.BorderColor = Color.LavenderBlush;
            logInBtn.BorderRadius = 20;
            logInBtn.BorderSize = 0;
            logInBtn.FlatAppearance.BorderSize = 0;
            logInBtn.FlatStyle = FlatStyle.Flat;
            logInBtn.ForeColor = Color.White;
            logInBtn.Location = new Point(142, 380);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(150, 40);
            logInBtn.TabIndex = 0;
            logInBtn.Text = "Log In";
            logInBtn.TextColor = Color.White;
            logInBtn.UseVisualStyleBackColor = false;
            logInBtn.Click += logInBtn_Click;
            // 
            // logOutBtn
            // 
            logOutBtn.BackColor = Color.White;
            logOutBtn.BackgroundColor = Color.White;
            logOutBtn.BorderColor = Color.Maroon;
            logOutBtn.BorderRadius = 20;
            logOutBtn.BorderSize = 2;
            logOutBtn.FlatAppearance.BorderSize = 0;
            logOutBtn.FlatStyle = FlatStyle.Flat;
            logOutBtn.ForeColor = Color.Maroon;
            logOutBtn.Location = new Point(142, 380);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(150, 40);
            logOutBtn.TabIndex = 1;
            logOutBtn.Text = "Log Out";
            logOutBtn.TextColor = Color.Maroon;
            logOutBtn.UseVisualStyleBackColor = false;
            logOutBtn.Visible = false;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 110);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            nameLbl.ForeColor = Color.White;
            nameLbl.Location = new Point(82, 179);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(230, 25);
            nameLbl.TabIndex = 3;
            nameLbl.Text = "Nestor Daniel Luna Avila";
            nameLbl.Visible = false;
            nameLbl.Click += nameLbl_Click;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.ForeColor = Color.White;
            emailLbl.Location = new Point(149, 333);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(134, 15);
            emailLbl.TabIndex = 4;
            emailLbl.Text = "luan991019@gmail.com";
            emailLbl.Visible = false;
            // 
            // addressLbl
            // 
            addressLbl.AutoSize = true;
            addressLbl.ForeColor = Color.White;
            addressLbl.Location = new Point(149, 298);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new Size(184, 15);
            addressLbl.TabIndex = 5;
            addressLbl.Text = "Azul #18 Col. Rinconada la huerta";
            addressLbl.Visible = false;
            // 
            // ageLbl
            // 
            ageLbl.AutoSize = true;
            ageLbl.ForeColor = Color.White;
            ageLbl.Location = new Point(149, 263);
            ageLbl.Name = "ageLbl";
            ageLbl.Size = new Size(19, 15);
            ageLbl.TabIndex = 6;
            ageLbl.Text = "18";
            ageLbl.Visible = false;
            // 
            // PrivilagesLbl
            // 
            PrivilagesLbl.AutoSize = true;
            PrivilagesLbl.Font = new Font("Segoe UI Light", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrivilagesLbl.ForeColor = Color.White;
            PrivilagesLbl.Location = new Point(82, 221);
            PrivilagesLbl.Name = "PrivilagesLbl";
            PrivilagesLbl.Size = new Size(125, 25);
            PrivilagesLbl.TabIndex = 7;
            PrivilagesLbl.Text = "Administrador";
            PrivilagesLbl.Visible = false;
            // 
            // userPB
            // 
            userPB.Image = (Image)resources.GetObject("userPB.Image");
            userPB.Location = new Point(142, 32);
            userPB.Name = "userPB";
            userPB.Size = new Size(124, 123);
            userPB.SizeMode = PictureBoxSizeMode.Zoom;
            userPB.TabIndex = 8;
            userPB.TabStop = false;
            userPB.Visible = false;
            // 
            // emailLbl1
            // 
            emailLbl1.AutoSize = true;
            emailLbl1.ForeColor = Color.White;
            emailLbl1.Location = new Point(82, 333);
            emailLbl1.Name = "emailLbl1";
            emailLbl1.Size = new Size(39, 15);
            emailLbl1.TabIndex = 9;
            emailLbl1.Text = "Email:";
            emailLbl1.Visible = false;
            // 
            // addressLbl1
            // 
            addressLbl1.AutoSize = true;
            addressLbl1.ForeColor = Color.White;
            addressLbl1.Location = new Point(82, 298);
            addressLbl1.Name = "addressLbl1";
            addressLbl1.Size = new Size(52, 15);
            addressLbl1.TabIndex = 10;
            addressLbl1.Text = "Address:";
            addressLbl1.Visible = false;
            // 
            // ageLbl1
            // 
            ageLbl1.AutoSize = true;
            ageLbl1.ForeColor = Color.White;
            ageLbl1.Location = new Point(82, 263);
            ageLbl1.Name = "ageLbl1";
            ageLbl1.Size = new Size(31, 15);
            ageLbl1.TabIndex = 11;
            ageLbl1.Text = "Age:";
            ageLbl1.Visible = false;
            // 
            // colorsCB
            // 
            colorsCB.DropDownStyle = ComboBoxStyle.DropDownList;
            colorsCB.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colorsCB.FormattingEnabled = true;
            colorsCB.Items.AddRange(new object[] { "Red", "Green", "Pink", "Black" });
            colorsCB.Location = new Point(296, 32);
            colorsCB.Name = "colorsCB";
            colorsCB.Size = new Size(73, 23);
            colorsCB.TabIndex = 12;
            colorsCB.Visible = false;
            colorsCB.SelectedValueChanged += colorsCB_SelectedValueChanged;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 448);
            Controls.Add(colorsCB);
            Controls.Add(ageLbl1);
            Controls.Add(addressLbl1);
            Controls.Add(emailLbl1);
            Controls.Add(userPB);
            Controls.Add(PrivilagesLbl);
            Controls.Add(ageLbl);
            Controls.Add(addressLbl);
            Controls.Add(emailLbl);
            Controls.Add(nameLbl);
            Controls.Add(label1);
            Controls.Add(logOutBtn);
            Controls.Add(logInBtn);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            Load += LogIn_Load;
            ((System.ComponentModel.ISupportInitialize)userPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MiniStore.CustomBtn logInBtn;
        private MiniStore.CustomBtn logOutBtn;
        private Label label1;
        private Label nameLbl;
        private Label emailLbl;
        private Label addressLbl;
        private Label ageLbl;
        private Label PrivilagesLbl;
        private PictureBox userPB;
        private Label emailLbl1;
        private Label addressLbl1;
        private Label ageLbl1;
        private ComboBox colorsCB;
    }
}