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

namespace WindowsForms3
{
    public partial class Form1 : Form
    {
        static List<Student> students = new List<Student>();
        static string connectionSTR = "Data Source = STHQ0116-13; Initial Catalog = Students; Integrated Security = false; User ID = admin; Password = admin";

        public Form1()
        {
            InitializeComponent();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
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
                    student.Gender = reader["Gender"].ToString();
                    student.Age = Convert.ToInt32(reader["Age"]);
                    students.Add(student);
                }
                reader.Close();

                for (int i = 0; i < students.Count; i++)
                {
                    StudentsListBox.Items.Add($"{students[i].Name} {students[i].Surname}");
                }
            }
        }

        private void StudentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < students.Count; i++)
            {
                if (i == StudentsListBox.SelectedIndex)
                {
                    DataOfStudentLbl.Text = students[i].PrintStudent(students[i]);

                    NameTextBox.Text = students[i].Name;
                    SurnameTextBox.Text = students[i].Surname;
                    AgeTextBox.Text = students[i].Age.ToString();


                    break;
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" && SurnameTextBox.Text == "")
            {
                MessageBox.Show("Please enter the data");
            }
            else
            {
                bool f = true;
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Name == NameTextBox.Text && students[i].Surname == SurnameTextBox.Text)
                    {
                        students.Remove(students[i]);
                        f = false;
                        break;
                    }
                }

                if (f)
                    MessageBox.Show("Such Student Not Exist");
            }

            StudentsListBox.Items.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                StudentsListBox.Items.Add($"{students[i].Name} {students[i].Surname}");

                string sqlDel = $"DELETE FROM Students WHERE ([Name] = '{NameTextBox.Text}' AND [Surname] = '{SurnameTextBox.Text}')";
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlDel, connection);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void EditAgeBtn_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" && SurnameTextBox.Text == "" && AgeTextBox.Text == "")
            {
                MessageBox.Show("Please enter the data");
            }
            else
            {
                bool f = true;
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Name == NameTextBox.Text && students[i].Surname == SurnameTextBox.Text)
                    {
                        students[i].Age = Convert.ToInt32(AgeTextBox.Text);
                        f = false;
                    }
                }

                if (f)
                    MessageBox.Show("Such Student Not Exist");
            }

            StudentsListBox.Items.Clear();
            for (int i = 0; i < students.Count; i++)
            {
                StudentsListBox.Items.Add($"{students[i].Name} {students[i].Surname}");

                string sqlEdit = $"Update Students SET Age = '{int.Parse(AgeTextBox.Text)}' WHERE ([Name] = '{NameTextBox.Text}' AND [Surname] = '{SurnameTextBox.Text}')";
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlEdit, connection);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void ShowStudentByAgeBtn_Click(object sender, EventArgs e)
        {
            if (AgeTextBox.Text == "")
            {
                MessageBox.Show("Please enter the data");
            }
            else
            {
                AgeListBox.Items.Clear();
                for (int i = 0; i < students.Count; i++)
                {
                    if (int.Parse(AgeTextBox.Text) <= students[i].Age)
                    {
                        
                        AgeListBox.Items.Add(students[i].Name);
                    }
                }
            }
        }

        
    }
}
