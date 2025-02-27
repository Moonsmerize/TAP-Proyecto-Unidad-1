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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            customBtn1 = new MiniStore.CustomBtn();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 23);
            label1.Name = "label1";
            label1.Size = new Size(146, 65);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 186);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 295);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 23);
            textBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 159);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 268);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // customBtn1
            // 
            customBtn1.BackColor = Color.MediumSlateBlue;
            customBtn1.BackgroundColor = Color.MediumSlateBlue;
            customBtn1.BorderColor = Color.PaleVioletRed;
            customBtn1.BorderRadius = 0;
            customBtn1.BorderSize = 0;
            customBtn1.FlatAppearance.BorderSize = 0;
            customBtn1.FlatStyle = FlatStyle.Flat;
            customBtn1.ForeColor = Color.White;
            customBtn1.Location = new Point(157, 373);
            customBtn1.Name = "customBtn1";
            customBtn1.Size = new Size(150, 40);
            customBtn1.TabIndex = 5;
            customBtn1.Text = "Login";
            customBtn1.TextColor = Color.White;
            customBtn1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.loginImg;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(480, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(243, 494);
            panel1.TabIndex = 6;
            // 
            // logInInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 494);
            Controls.Add(panel1);
            Controls.Add(customBtn1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "logInInformation";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private MiniStore.CustomBtn customBtn1;
        private Panel panel1;
    }
}