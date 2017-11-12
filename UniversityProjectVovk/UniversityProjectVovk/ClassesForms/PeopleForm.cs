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
    public partial class PeopleForm : ObjectForm
    {
        public PeopleForm()
        {
            InitializeComponent();
            label1.Visible = false;
            textBox1.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected virtual int save(string OClass)
        {
            if (isEdit == true)
            {
                delete();
            }
            //int id = (node.Tag as TObject).Id;
            int newid = -1;
            int id = -1;
            if (isEdit)
            {
                newid = (node.Tag as TObject).Id;
                id = (int)(node.Tag as TObject).Major;
                delete();
            }
            else
            {
                id = (node.Tag as TObject).Id;
                string queryString1 = "SELECT MAX(Id) FROM dbo.TObject";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString1, connection);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            newid = int.Parse(reader[0].ToString());
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                    }
                }
                newid++;
            }
            string queryString = "INSERT INTO dbo.TObject(Id, Name, Class, Major) "
                + "VALUES('" + newid + "','" + firstNameText.Text + " " + secondNameText.Text + "','" + OClass + "','" + id + "')";

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
            queryString = "INSERT INTO dbo.People(Id, FirstName, SecondName) "
                    + "VALUES('" + newid + "','" + firstNameText.Text + "','" + secondNameText.Text + "')";

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

        protected virtual void button1_Click(object sender, EventArgs e)
        {
            save("People");
            this.Close();
        }

        public override void delete()
        {
            base.delete();
            string queryString = "DELETE FROM dbo.People where Id = '" + (node.Tag as TObject).Id + "';";
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

        protected override void open()
        {
 	         base.open();
             string queryString = "SELECT FirstName, SecondName FROM dbo.People where Id = '" + (node.Tag as TObject).Id + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        firstNameText.Text = reader[0].ToString();
                        secondNameText.Text = reader[1].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }



        private void PeopleForm_Load(object sender, EventArgs e)
        {
            if (isEdit == true)
            {
                open();
            }
        }
    }
}
