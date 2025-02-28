namespace Proyecto1
{
    partial class RecoverPassword
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
            emailMissingLbl = new Label();
            label2 = new Label();
            emailTB = new TextBox();
            SuspendLayout();
            // 
            // emailMissingLbl
            // 
            emailMissingLbl.AutoSize = true;
            emailMissingLbl.BackColor = Color.Transparent;
            emailMissingLbl.Font = new Font("Segoe UI", 7F);
            emailMissingLbl.ForeColor = Color.Red;
            emailMissingLbl.Location = new Point(73, 147);
            emailMissingLbl.Name = "emailMissingLbl";
            emailMissingLbl.Size = new Size(91, 12);
            emailMissingLbl.TabIndex = 12;
            emailMissingLbl.Text = "This field is required";
            emailMissingLbl.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 97);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 11;
            label2.Text = "Email:";
            // 
            // emailTB
            // 
            emailTB.Location = new Point(72, 124);
            emailTB.Name = "emailTB";
            emailTB.Size = new Size(197, 23);
            emailTB.TabIndex = 10;
            // 
            // RecoverPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 428);
            Controls.Add(emailMissingLbl);
            Controls.Add(label2);
            Controls.Add(emailTB);
            Name = "RecoverPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recover Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label emailMissingLbl;
        private Label label2;
        private TextBox emailTB;
    }
}