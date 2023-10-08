using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppADo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();

            connectionStringBuilder.DataSource = @"STHQ0128-13";
            connectionStringBuilder.InitialCatalog = "Mark";
            connectionStringBuilder.UserID = UserNameTextBox.Text;
            connectionStringBuilder.Password = PasswdTextBox.Text;
            connectionStringBuilder.IntegratedSecurity = false;

            using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show(connection.State.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("MyConnectionString", connectionStringBuilder.ConnectionString));
            ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection;


            if (EncryptionCheckBox.Checked)
            {
                if (!section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                }
            }
            else
            {
                if (section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.UnprotectSection();
                }
            }
            config.Save();

            MessageBox.Show($"Protected = {section.SectionInformation.IsProtected.ToString()}");


        }
    }
}
