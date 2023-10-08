namespace WindowsFormsAppADo2
{
    partial class Form1
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
            this.LogInBtn = new System.Windows.Forms.Button();
            this.EncryptionCheckBox = new System.Windows.Forms.CheckBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.PasswdLbl = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.PasswdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LogInBtn
            // 
            this.LogInBtn.BackColor = System.Drawing.Color.Navy;
            this.LogInBtn.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.LogInBtn.Location = new System.Drawing.Point(268, 168);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(123, 46);
            this.LogInBtn.TabIndex = 0;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = false;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // EncryptionCheckBox
            // 
            this.EncryptionCheckBox.AutoSize = true;
            this.EncryptionCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EncryptionCheckBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EncryptionCheckBox.Location = new System.Drawing.Point(486, 79);
            this.EncryptionCheckBox.Name = "EncryptionCheckBox";
            this.EncryptionCheckBox.Size = new System.Drawing.Size(82, 24);
            this.EncryptionCheckBox.TabIndex = 1;
            this.EncryptionCheckBox.Text = "Encrypt";
            this.EncryptionCheckBox.UseVisualStyleBackColor = true;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.ForeColor = System.Drawing.SystemColors.Info;
            this.UsernameLbl.Location = new System.Drawing.Point(174, 55);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(138, 29);
            this.UsernameLbl.TabIndex = 2;
            this.UsernameLbl.Text = "Username:";
            // 
            // PasswdLbl
            // 
            this.PasswdLbl.AutoSize = true;
            this.PasswdLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswdLbl.ForeColor = System.Drawing.SystemColors.Info;
            this.PasswdLbl.Location = new System.Drawing.Point(174, 105);
            this.PasswdLbl.Name = "PasswdLbl";
            this.PasswdLbl.Size = new System.Drawing.Size(130, 29);
            this.PasswdLbl.TabIndex = 3;
            this.PasswdLbl.Text = "Password:";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.UserNameTextBox.Location = new System.Drawing.Point(327, 55);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(115, 29);
            this.UserNameTextBox.TabIndex = 4;
            // 
            // PasswdTextBox
            // 
            this.PasswdTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PasswdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswdTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PasswdTextBox.Location = new System.Drawing.Point(327, 105);
            this.PasswdTextBox.Name = "PasswdTextBox";
            this.PasswdTextBox.Size = new System.Drawing.Size(115, 29);
            this.PasswdTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(652, 277);
            this.Controls.Add(this.PasswdTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.PasswdLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.EncryptionCheckBox);
            this.Controls.Add(this.LogInBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.CheckBox EncryptionCheckBox;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label PasswdLbl;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.TextBox PasswdTextBox;
    }
}

