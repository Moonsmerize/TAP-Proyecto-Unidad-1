﻿namespace Proyecto1
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
            logInBtn = new MiniStore.CustomBtn();
            SuspendLayout();
            // 
            // logInBtn
            // 
            logInBtn.BackColor = Color.FromArgb(24, 33, 79);
            logInBtn.BackgroundColor = Color.FromArgb(24, 33, 79);
            logInBtn.BorderColor = Color.LavenderBlush;
            logInBtn.BorderRadius = 15;
            logInBtn.BorderSize = 0;
            logInBtn.FlatAppearance.BorderSize = 0;
            logInBtn.FlatStyle = FlatStyle.Flat;
            logInBtn.ForeColor = Color.White;
            logInBtn.Location = new Point(155, 409);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(150, 40);
            logInBtn.TabIndex = 0;
            logInBtn.Text = "Log In";
            logInBtn.TextColor = Color.White;
            logInBtn.UseVisualStyleBackColor = false;
            logInBtn.Click += logInBtn_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 492);
            Controls.Add(logInBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            Load += LogIn_Load;
            ResumeLayout(false);
        }

        #endregion

        private MiniStore.CustomBtn logInBtn;
    }
}