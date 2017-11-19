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
    public partial class Workers : PeopleForm
    {
        public Workers()
        {
            InitializeComponent();
        }
        protected override void open()
        {
 	         base.open();
             string queryString = "SELECT Sallary, Position FROM dbo.Worker where Id = '" + (node.Tag as NodeData).Object.Id + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        sallaryText.Text = reader[0].ToString();
                        positionText.Text = reader[1].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            if (isEdit == true)
            {
                open();
            }
        }

        public override void delete()
        {
            base.delete();
            string queryString = "DELETE FROM dbo.Worker where Id = '" + (node.Tag as NodeData).Object.Id + "';";
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
            int sallary = 0;
            try
            {
                sallary = int.Parse(sallaryText.Text);
            }
            catch { }
            string queryString = "INSERT INTO dbo.Worker(Id, Sallary, Position) "
                   + "VALUES('" + newid + "','" + sallary + "','" + positionText.Text + "')";

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
            save("Worker");
            this.Close();
        }
    }
}
