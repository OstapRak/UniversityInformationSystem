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
    public partial class LinqForm : ObjectForm
    {
        public LinqForm()
        {
            InitializeComponent();
            listBox1.Items.Add("server1");
            listBox1.Items.Add("server2");
            listBox1.Items.Add("server3");
        }

        private void LinqForm_Load(object sender, EventArgs e)
        {
            
        }

        protected override void open()
        {
            base.open();
            string queryString = "SELECT Server FROM dbo.Linq where Id = '" + (node.Tag as NodeData).Object.Id + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string servername = reader[0].ToString();
                        foreach (var i in listBox1.Items)
                        {
                            if(i.ToString() == servername)
                            {
                                listBox1.SelectedItem = i;
                            }
                        }
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }

        //////private void ThingForm_Load(object sender, EventArgs e)
        //////{
        //////    if (isEdit == true)
        //////    {
        //////        open();
        //////    }
        //////}

        public override void delete()
        {
            base.delete();
            string queryString = "DELETE FROM dbo.Linq where Id = '" + (node.Tag as NodeData).Object.Id + "';";
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
            string queryString = "INSERT INTO dbo.Linq(Id, Server) "
                 + "VALUES('" + newid + "','" + listBox1.SelectedItem.ToString() + "')";

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
            save("Linq");
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
