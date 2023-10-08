using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Configuration;

namespace Async
{
    public partial class Form1 : Form
    {
        static List<Student> students = new List<Student>();
        static string conStr = "Data Source = STHQ0116-14; Initial Catalog = Students; Integrated Security = False; User ID = admin; Password = admin";

        public Form1()
        {
            InitializeComponent();

            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Students", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Student student = new Student();
                    student.Id = Convert.ToInt32(reader["Id"]);
                    student.Name = reader["Name"].ToString();
                    student.Surname = reader["Surname"].ToString();
                    student.Age = Convert.ToInt32(reader["Age"]);
                    students.Add(student);
                }
                reader.Close();

                for (int i = 0; i < students.Count; i++)
                {
                    StudentsListBox.Items.Add($"{students[i].Name} {students[i].Surname}");
                }
            }

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            for (int i = 1; i < config.ConnectionStrings.ConnectionStrings.Count; i++)
            {
                ConnectionStrsListBox.Items.Add(config.ConnectionStrings.ConnectionStrings[i].Name);
            }

        }

        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (i == StudentsListBox.SelectedIndex)
                {
                    DataOfStudentLbl.Text = students[i].PrintStudent(students[i]);

                    break;
                }
            }
        }

        async private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (StudentsListBox.SelectedIndex == -1)
                MessageBox.Show("Choose Student in list!!!");
            else
            {
                string sqlDel = $"DELETE FROM Students WHERE (Id = {students[StudentsListBox.SelectedIndex].Id})";
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    SqlCommand cmd = new SqlCommand(sqlDel, connection);
                    await connection.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }

                MessageBox.Show("Deleted SuccesFully");
            }
        }

        async private void RefreshBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Students", connection);

                await connection.OpenAsync();
                SqlDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    students.Clear();
                    while (await reader.ReadAsync())
                    {
                        Student student = new Student();
                        student.Id = Convert.ToInt32(reader["Id"]);
                        student.Name = reader["Name"].ToString();
                        student.Surname = reader["Surname"].ToString();
                        student.Age = Convert.ToInt32(reader["Age"]);
                        students.Add(student);
                    }

                    StudentsListBox.Items.Clear();
                    for (int i = 0; i < students.Count; i++)
                    {
                        StudentsListBox.Items.Add($"{students[i].Name} {students[i].Surname}");
                    }
                }


                reader.Close();

                MessageBox.Show("Refreshed");
            }
        }

        async private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(SurnameTextBox.Text))
                MessageBox.Show("Fill in the fields!!!");
            else
            {
                using (SqlConnection connection = new SqlConnection(conStr))
                {
                    await connection.OpenAsync();

                    SqlCommand cmd = new SqlCommand($"INSERT INTO Students VALUES('{NameTextBox.Text}','{SurnameTextBox.Text}', {Convert.ToInt32(AgeTextBox.Text)})", connection);

                    await cmd.ExecuteNonQueryAsync();

                    MessageBox.Show("Added Succesfully");
                }
            }
        }

        private void AddConnectionBtn_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings(ConnectionTextBox.Text, conStr));
            ConfigurationManager.RefreshSection("connectionStrings");
            config.Save();

            ConnectionStrsListBox.Items.Add(ConnectionTextBox.Text);

            MessageBox.Show("Added SuccesFully");
        }
    }
}