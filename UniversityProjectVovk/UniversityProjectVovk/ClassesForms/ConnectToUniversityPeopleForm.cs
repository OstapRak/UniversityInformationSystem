using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UniversityProjectVovk.ClassesForms
{
    public partial class ConnectToUniversityPeopleForm : PeopleForm
    {
        public ConnectToUniversityPeopleForm()
        {
            InitializeComponent();
        }

        protected override void open()
        {
            base.open();
            string queryString = "SELECT Description FROM dbo.ConnectToUniversityPeople where Id = '" + (node.Tag as NodeData).Object.Id + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        richTextBox1.Text = reader[0].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }


        private void ConnectToUniversityPeopleForm_Load(object sender, EventArgs e)
        {
            if (isEdit == true)
            {
                open();
            }
        }

        public override void delete()
        {
            base.delete();
            string queryString = "DELETE FROM dbo.ConnectToUniversityPeople where Id = '" + (node.Tag as NodeData).Object.Id + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }

        protected override int save(string OClass)
        {
            if (isEdit == true)
            {
                delete();
            }
            int newid = base.save(OClass);
            int id = (node.Tag as NodeData).Object.Id;
            string queryString = "INSERT INTO dbo.ConnectToUniversityPeople(Id, Description) "
                   + "VALUES('" + newid + "','" + richTextBox1.Text + "')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }
            return newid;
        }

        protected override void button1_Click(object sender, EventArgs e)
        {
            save("ConnectToUniversityPeople");
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
