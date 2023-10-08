using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Dataa;
using System.Data.Entity;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string conStr = @"Data Source = MARKTOP; Initial Catalog = CodeFirst; Integrated Security = True";
        CodeContext codeContext;

        public Form1()
        {
            InitializeComponent();

            codeContext = new CodeContext(conStr);

            codeContext.Cars.Load();
            dataGridView1.DataSource = codeContext.Cars.Local.ToBindingList();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            codeContext.SaveChanges();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            Car temp_car = new Car
            {
                Name = NameTextBox.Text,
                Description = DescriptionTextBox.Text,
                PublishingDate = PublishingDatePicker.Value
            };

            codeContext.Cars.Add(temp_car);
            codeContext.SaveChanges();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            codeContext.Cars.Remove(dataGridView1.CurrentRow.DataBoundItem as Car);
            codeContext.SaveChanges();
        }
    }
}