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
    public partial class ObjectForm : BaseForm
    {        
        public ObjectForm()
        {
            InitializeComponent();
        }

        private void ObjectForm_Load(object sender, EventArgs e)
        {
            if(isEdit == true)
            {
                open();
            }
        }

        public override void delete()
        {
            string queryString = "DELETE FROM dbo.TObject where Id = '" + (node.Tag as NodeData).Object.Id + "';";
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

        protected virtual void open()
        {
            string queryString = "SELECT Name FROM dbo.TObject where Id = '" + (node.Tag as NodeData).Object.Id + "';";
            int newid = -1;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox1.Text = reader[0].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }

        protected virtual int save(string OClass)
        {
            if (isEdit == true)
            {
                delete();
            }
            int id;
            int newid;
            if (isEdit)
            {
                newid = (node.Tag as NodeData).Object.Id;
                id = (int)(node.Tag as NodeData).Object.Major;
                delete();
            }
            else
            {
                id = (node.Tag as NodeData).Object.Id;
                string queryString = "SELECT MAX(Id) FROM dbo.TObject";
                newid = -1;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
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
            string queryString1 = "INSERT INTO dbo.TObject(Id, Name, Class, Major) "
                + "VALUES('" + newid + "','" + textBox1.Text + "','" + OClass + "','" + id + "')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString1, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Close();
                }
                catch
                {
                }
            }
            return newid;
        }

        protected virtual void button1_Click(object sender, EventArgs e)
        {
            save("TObject");
            this.Close();
        }
    }
}
