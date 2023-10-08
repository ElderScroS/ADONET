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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnectionStringBuilder stringBuilder;

        public Form1()
        {
            InitializeComponent();
            stringBuilder = new SqlConnectionStringBuilder();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stringBuilder.DataSource = "MARKTOP";
            stringBuilder.InitialCatalog = "Students";
            stringBuilder.IntegratedSecurity = true;

            using (SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Students; SELECT * FROM Marks;", connection);

                DataSet dataSet = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd.CommandText, stringBuilder.ConnectionString);

                adapter.Fill(dataSet);

                ForeignKeyConstraint FK = new ForeignKeyConstraint("FOREIGN KEY", dataSet.Tables[0].Columns["ID"], dataSet.Tables[1].Columns["Student_ID"]);
                dataSet.Tables["Table1"].Constraints.Add(FK);

                StudentDataGridView.DataSource = dataSet.Tables[0];
                MarksDataGridView.DataSource = dataSet.Tables[1];
            }
        }
    }
}
