namespace Async
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.ConnectionTextBox = new System.Windows.Forms.TextBox();
            this.ConnectionLbl = new System.Windows.Forms.Label();
            this.AddConnectionBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AgeListBox = new System.Windows.Forms.ListBox();
            this.AllLbl = new System.Windows.Forms.Label();
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataOfStudentLbl = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.AgeLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.ConnectionStrsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.MainPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.MainPage);
            this.MainTabControl.Controls.Add(this.tabPage2);
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Controls.Add(this.tabPage3);
            this.MainTabControl.Location = new System.Drawing.Point(-3, -1);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1089, 503);
            this.MainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainTabControl.TabIndex = 0;
            // 
            // MainPage
            // 
            this.MainPage.BackColor = System.Drawing.Color.DimGray;
            this.MainPage.Controls.Add(this.label1);
            this.MainPage.Controls.Add(this.ConnectionStrsListBox);
            this.MainPage.Controls.Add(this.ConnectionTextBox);
            this.MainPage.Controls.Add(this.ConnectionLbl);
            this.MainPage.Controls.Add(this.AddConnectionBtn);
            this.MainPage.Location = new System.Drawing.Point(4, 22);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(1081, 477);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Connection  Page";
            // 
            // ConnectionTextBox
            // 
            this.ConnectionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectionTextBox.Location = new System.Drawing.Point(402, 169);
            this.ConnectionTextBox.Name = "ConnectionTextBox";
            this.ConnectionTextBox.Size = new System.Drawing.Size(160, 35);
            this.ConnectionTextBox.TabIndex = 2;
            // 
            // ConnectionLbl
            // 
            this.ConnectionLbl.AutoSize = true;
            this.ConnectionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectionLbl.ForeColor = System.Drawing.Color.Aqua;
            this.ConnectionLbl.Location = new System.Drawing.Point(130, 169);
            this.ConnectionLbl.Name = "ConnectionLbl";
            this.ConnectionLbl.Size = new System.Drawing.Size(238, 25);
            this.ConnectionLbl.TabIndex = 1;
            this.ConnectionLbl.Text = "Add New Connection:";
            // 
            // AddConnectionBtn
            // 
            this.AddConnectionBtn.BackColor = System.Drawing.Color.Black;
            this.AddConnectionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddConnectionBtn.ForeColor = System.Drawing.Color.Yellow;
            this.AddConnectionBtn.Location = new System.Drawing.Point(304, 316);
            this.AddConnectionBtn.Name = "AddConnectionBtn";
            this.AddConnectionBtn.Size = new System.Drawing.Size(210, 56);
            this.AddConnectionBtn.TabIndex = 0;
            this.AddConnectionBtn.Text = "Add Connection";
            this.AddConnectionBtn.UseVisualStyleBackColor = false;
            this.AddConnectionBtn.Click += new System.EventHandler(this.AddConnectionBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.RefreshBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1081, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Refresh Page";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.AddStudentBtn);
            this.tabPage1.Controls.Add(this.SurnameLbl);
            this.tabPage1.Controls.Add(this.AgeLbl);
            this.tabPage1.Controls.Add(this.NameLbl);
            this.tabPage1.Controls.Add(this.AgeTextBox);
            this.tabPage1.Controls.Add(this.SurnameTextBox);
            this.tabPage1.Controls.Add(this.NameTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1081, 477);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Add Student";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.DeleteBtn);
            this.tabPage3.Controls.Add(this.DataOfStudentLbl);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.AgeListBox);
            this.tabPage3.Controls.Add(this.AllLbl);
            this.tabPage3.Controls.Add(this.StudentsListBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1081, 477);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Delete Student";
            // 
            // AgeListBox
            // 
            this.AgeListBox.BackColor = System.Drawing.Color.Teal;
            this.AgeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeListBox.ForeColor = System.Drawing.SystemColors.Info;
            this.AgeListBox.FormattingEnabled = true;
            this.AgeListBox.ItemHeight = 18;
            this.AgeListBox.Location = new System.Drawing.Point(281, 483);
            this.AgeListBox.Name = "AgeListBox";
            this.AgeListBox.Size = new System.Drawing.Size(319, 4);
            this.AgeListBox.TabIndex = 17;
            // 
            // AllLbl
            // 
            this.AllLbl.AutoSize = true;
            this.AllLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllLbl.ForeColor = System.Drawing.SystemColors.Info;
            this.AllLbl.Location = new System.Drawing.Point(89, 16);
            this.AllLbl.Name = "AllLbl";
            this.AllLbl.Size = new System.Drawing.Size(208, 29);
            this.AllLbl.TabIndex = 15;
            this.AllLbl.Text = "List Of Students";
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.BackColor = System.Drawing.Color.Teal;
            this.StudentsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsListBox.ForeColor = System.Drawing.SystemColors.Info;
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.ItemHeight = 18;
            this.StudentsListBox.Location = new System.Drawing.Point(29, 56);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(319, 148);
            this.StudentsListBox.TabIndex = 14;
            this.StudentsListBox.SelectedIndexChanged += new System.EventHandler(this.StudentsListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(422, -95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "All students";
            // 
            // DataOfStudentLbl
            // 
            this.DataOfStudentLbl.AutoSize = true;
            this.DataOfStudentLbl.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataOfStudentLbl.ForeColor = System.Drawing.Color.Indigo;
            this.DataOfStudentLbl.Location = new System.Drawing.Point(457, 56);
            this.DataOfStudentLbl.Name = "DataOfStudentLbl";
            this.DataOfStudentLbl.Size = new System.Drawing.Size(271, 26);
            this.DataOfStudentLbl.TabIndex = 20;
            this.DataOfStudentLbl.Text = "The Data will be show here";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Navy;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Yellow;
            this.DeleteBtn.Location = new System.Drawing.Point(447, 347);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(202, 80);
            this.DeleteBtn.TabIndex = 21;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLbl.ForeColor = System.Drawing.SystemColors.Info;
            this.SurnameLbl.Location = new System.Drawing.Point(362, 115);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(126, 29);
            this.SurnameLbl.TabIndex = 16;
            this.SurnameLbl.Text = "Surname:";
            // 
            // AgeLbl
            // 
            this.AgeLbl.AutoSize = true;
            this.AgeLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLbl.ForeColor = System.Drawing.SystemColors.Info;
            this.AgeLbl.Location = new System.Drawing.Point(402, 188);
            this.AgeLbl.Name = "AgeLbl";
            this.AgeLbl.Size = new System.Drawing.Size(65, 29);
            this.AgeLbl.TabIndex = 15;
            this.AgeLbl.Text = "Age:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.ForeColor = System.Drawing.SystemColors.Info;
            this.NameLbl.Location = new System.Drawing.Point(379, 39);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(88, 29);
            this.NameLbl.TabIndex = 14;
            this.NameLbl.Text = "Name:";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.AgeTextBox.Location = new System.Drawing.Point(494, 191);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(208, 29);
            this.AgeTextBox.TabIndex = 13;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.SurnameTextBox.Location = new System.Drawing.Point(494, 115);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(208, 29);
            this.SurnameTextBox.TabIndex = 12;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.ForeColor = System.Drawing.SystemColors.Info;
            this.NameTextBox.Location = new System.Drawing.Point(494, 39);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(208, 29);
            this.NameTextBox.TabIndex = 11;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.Black;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.Yellow;
            this.RefreshBtn.Location = new System.Drawing.Point(381, 169);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(290, 92);
            this.RefreshBtn.TabIndex = 0;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.BackColor = System.Drawing.Color.Black;
            this.AddStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStudentBtn.ForeColor = System.Drawing.Color.Yellow;
            this.AddStudentBtn.Location = new System.Drawing.Point(412, 300);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(290, 92);
            this.AddStudentBtn.TabIndex = 17;
            this.AddStudentBtn.Text = "Add Student";
            this.AddStudentBtn.UseVisualStyleBackColor = false;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // ConnectionStrsListBox
            // 
            this.ConnectionStrsListBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ConnectionStrsListBox.FormattingEnabled = true;
            this.ConnectionStrsListBox.Location = new System.Drawing.Point(719, 94);
            this.ConnectionStrsListBox.Name = "ConnectionStrsListBox";
            this.ConnectionStrsListBox.Size = new System.Drawing.Size(327, 251);
            this.ConnectionStrsListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(756, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "List Of Connection Strs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 496);
            this.Controls.Add(this.MainTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainTabControl.ResumeLayout(false);
            this.MainPage.ResumeLayout(false);
            this.MainPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button AddConnectionBtn;
        private System.Windows.Forms.TextBox ConnectionTextBox;
        private System.Windows.Forms.Label ConnectionLbl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox AgeListBox;
        private System.Windows.Forms.Label AllLbl;
        private System.Windows.Forms.ListBox StudentsListBox;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label DataOfStudentLbl;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label AgeLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.ListBox ConnectionStrsListBox;
        private System.Windows.Forms.Label label1;
    }
}

