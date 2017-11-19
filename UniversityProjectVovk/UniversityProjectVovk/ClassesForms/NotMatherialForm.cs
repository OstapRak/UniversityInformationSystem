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
    public partial class NotMatherialForm : ThingForm
    {
        public NotMatherialForm()
        {
            InitializeComponent();
        }
        protected override void open()
        {
 	         base.open();
             string queryString = "SELECT Description FROM dbo.NotMatherialThing where Id = '" + (node.Tag as NodeData).Object.Id + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DescriptionText.Text = reader[0].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void NotMatherialForm_Load(object sender, EventArgs e)
        {
            if (isEdit == true)
            {
                open();
            }
        }

        public override void delete()
        {
            base.delete();
            string queryString = "DELETE FROM dbo.GroupOfPeople where Id = '" + (node.Tag as NodeData).Object.Id + "';";
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
            string queryString = "INSERT INTO dbo.NotMatherialThing(Id, Description) "
                 + "VALUES('" + newid + "','" + DescriptionText.Text + "')";

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

        private void DescriptionText_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void button1_Click(object sender, EventArgs e)
        {
            save("NotMatherialThing");
            this.Close();
        }
    }
}
