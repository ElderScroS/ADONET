namespace WindowsForms3
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
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.DataOfStudentLbl = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditAgeBtn = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.ShowStudentByAgeBtn = new System.Windows.Forms.Button();
            this.NameLbl = new System.Windows.Forms.Label();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.AllLbl = new System.Windows.Forms.Label();
            this.AgeStdLbl = new System.Windows.Forms.Label();
            this.AgeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.BackColor = System.Drawing.Color.Teal;
            this.StudentsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsListBox.ForeColor = System.Drawing.SystemColors.Info;
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.ItemHeight = 18;
            this.StudentsListBox.Location = new System.Drawing.Point(848, 70);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(319, 382);
            this.StudentsListBox.TabIndex = 0;
            this.StudentsListBox.SelectedIndexChanged += new System.EventHandler(this.StudentsListBox_SelectedIndexChanged);
            // 
            // DataOfStudentLbl
            // 
            this.DataOfStudentLbl.AutoSize = true;
            this.DataOfStudentLbl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataOfStudentLbl.ForeColor = System.Drawing.Color.Fuchsia;
            this.DataOfStudentLbl.Location = new System.Drawing.Point(12, 24);
            this.DataOfStudentLbl.Name = "DataOfStudentLbl";
            this.DataOfStudentLbl.Size = new System.Drawing.Size(271, 26);
            this.DataOfStudentLbl.TabIndex = 1;
            this.DataOfStudentLbl.Text = "The Data will be show here";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Navy;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeleteBtn.Location = new System.Drawing.Point(49, 533);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(202, 80);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete By Name Surname";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditAgeBtn
            // 
            this.EditAgeBtn.BackColor = System.Drawing.Color.Navy;
            this.EditAgeBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditAgeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EditAgeBtn.Location = new System.Drawing.Point(322, 533);
            this.EditAgeBtn.Name = "EditAgeBtn";
            this.EditAgeBtn.Size = new System.Drawing.Size(202, 80);
            this.EditAgeBtn.TabIndex = 3;
            this.EditAgeBtn.Text = "Edit Age By Name Surname";
            this.EditAgeBtn.UseVisualStyleBackColor = false;
            this.EditAgeBtn.Click += new System.EventHandler(this.EditAgeBtn_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.NameTextBox.Location = new System.Drawing.Point(498, 70);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(208, 29);
            this.NameTextBox.TabIndex = 4;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.SurnameTextBox.Location = new System.Drawing.Point(498, 146);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(208, 29);
            this.SurnameTextBox.TabIndex = 5;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.AgeTextBox.Location = new System.Drawing.Point(498, 222);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(208, 29);
            this.AgeTextBox.TabIndex = 6;
            // 
            // ShowStudentByAgeBtn
            // 
            this.ShowStudentByAgeBtn.BackColor = System.Drawing.Color.Navy;
            this.ShowStudentByAgeBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowStudentByAgeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ShowStudentByAgeBtn.Location = new System.Drawing.Point(553, 533);
            this.ShowStudentByAgeBtn.Name = "ShowStudentByAgeBtn";
            this.ShowStudentByAgeBtn.Size = new System.Drawing.Size(202, 80);
            this.ShowStudentByAgeBtn.TabIndex = 7;
            this.ShowStudentByAgeBtn.Text = "Show studs by age and above";
            this.ShowStudentByAgeBtn.UseVisualStyleBackColor = false;
            this.ShowStudentByAgeBtn.Click += new System.EventHandler(this.ShowStudentByAgeBtn_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.SystemColors.Info;
            this.NameLbl.Location = new System.Drawing.Point(383, 70);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(88, 29);
            this.NameLbl.TabIndex = 8;
            this.NameLbl.Text = "Name:";
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLbl.ForeColor = System.Drawing.SystemColors.Info;
            this.AgeLbl.Location = new System.Drawing.Point(406, 219);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(65, 29);
            this.AgeLbl.TabIndex = 9;
            this.AgeLbl.Text = "Age:";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLbl.ForeColor = System.Drawing.SystemColors.Info;
            this.SurnameLbl.Location = new System.Drawing.Point(366, 146);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(126, 29);
            this.SurnameLbl.TabIndex = 10;
            this.SurnameLbl.Text = "Surname:";
            // 
            // AllLbl
            // 
            this.AllLbl.AutoSize = true;
            this.AllLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllLbl.ForeColor = System.Drawing.SystemColors.Info;
            this.AllLbl.Location = new System.Drawing.Point(843, 38);
            this.AllLbl.Name = "AllLbl";
            this.AllLbl.Size = new System.Drawing.Size(157, 29);
            this.AllLbl.TabIndex = 11;
            this.AllLbl.Text = "All students";
            // 
            // AgeStdLbl
            // 
            this.AgeStdLbl.AutoSize = true;
            this.AgeStdLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeStdLbl.ForeColor = System.Drawing.SystemColors.Info;
            this.AgeStdLbl.Location = new System.Drawing.Point(843, 455);
            this.AgeStdLbl.Name = "AgeStdLbl";
            this.AgeStdLbl.Size = new System.Drawing.Size(222, 29);
            this.AgeStdLbl.TabIndex = 12;
            this.AgeStdLbl.Text = "By age and above";
            // 
            // AgeListBox
            // 
            this.AgeListBox.BackColor = System.Drawing.Color.Teal;
            this.AgeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeListBox.ForeColor = System.Drawing.SystemColors.Info;
            this.AgeListBox.FormattingEnabled = true;
            this.AgeListBox.ItemHeight = 18;
            this.AgeListBox.Location = new System.Drawing.Point(848, 501);
            this.AgeListBox.Name = "AgeListBox";
            this.AgeListBox.Size = new System.Drawing.Size(319, 148);
            this.AgeListBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1198, 695);
            this.Controls.Add(this.AgeListBox);
            this.Controls.Add(this.AgeStdLbl);
            this.Controls.Add(this.AllLbl);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.AgeLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.ShowStudentByAgeBtn);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.EditAgeBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.DataOfStudentLbl);
            this.Controls.Add(this.StudentsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox StudentsListBox;
        private System.Windows.Forms.Label DataOfStudentLbl;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditAgeBtn;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Button ShowStudentByAgeBtn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label AllLbl;
        private System.Windows.Forms.Label AgeStdLbl;
        private System.Windows.Forms.ListBox AgeListBox;
    }
}

