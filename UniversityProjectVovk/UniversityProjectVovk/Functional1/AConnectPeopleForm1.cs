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

namespace UniversityProjectVovk.Functional1
{
    public partial class AConnectPeopleForm1 : APeopleForm1
    {
        public AConnectPeopleForm1()
        {
            InitializeComponent();
        }

        private void AConnectPeopleForm1_Load(object sender, EventArgs e)
        {
            int ownerId = (node.Tag as TObject).Id;
            string queryString = "SELECT StartTime, EndTime, Place, Purpos FROM dbo.Assignment INNER JOIN dbo.AConnect ON dbo.Assignment.Id = dbo.AConnect.Id  where OwnerId = '" + (node.Tag as TObject).Id + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    // dataGridView1 = new DataGridView();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.Columns.Add("StartTime", "StartTime");
                    dataGridView1.Columns.Add("EndTime", "EndTime");
                    dataGridView1.Columns.Add("Place", "Place");
                    dataGridView1.Columns.Add("Purpos", "Purpos");
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = reader[0].ToString();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = reader[1].ToString();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = reader[2].ToString();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[3].Value = reader[3].ToString();

                    }

                    //dataGridView1.DataSource = reader;
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }

        protected override void open()
        {
            int ownerId = (node.Tag as TObject).Id;
            string queryString = "SELECT StartTime, EndTime, Place, Purpos FROM dbo.Assignment INNER JOIN dbo.AConnect ON dbo.Assignment.Id = dbo.AConnect.Id  where OwnerId = '" + (node.Tag as TObject).Id + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    // dataGridView1 = new DataGridView();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.Columns.Add("StartTime", "StartTime");
                    dataGridView1.Columns.Add("EndTime", "EndTime");
                    dataGridView1.Columns.Add("Place", "Place");
                    dataGridView1.Columns.Add("Purpos", "Purpos");
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = reader[0].ToString();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = reader[1].ToString();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = reader[2].ToString();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[3].Value = reader[3].ToString();

                    }

                    //dataGridView1.DataSource = reader;
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // if ((node.Tag as TObject).Class == "ConnectToUniversityPeople")
            {
                save();
                AConnectPeopleForm1_Load(sender, e);
            }
        
        }

        public override int save()
        {
            int newid = base.save();
            string queryString1 = "INSERT INTO dbo.AConnect(Id, Purpos) "
                + "VALUES('" + newid + "','" + textBox4.Text + "');";

            using (SqlConnection connection = new System.Data.SqlClient.SqlConnection(connectionString))
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
