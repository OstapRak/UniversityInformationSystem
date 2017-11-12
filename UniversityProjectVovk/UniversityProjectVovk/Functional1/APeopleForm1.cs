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
    public partial class APeopleForm1 : Form
    {
        public TreeNode node;
        public string connectionString;
        public APeopleForm1()
        {
            InitializeComponent();
        }

        protected virtual void open()
        {
            int ownerId = (node.Tag as TObject).Id;
            string queryString = "SELECT StartTime, EndTime, Place FROM dbo.Assignment where OwnerId = '" + (node.Tag as TObject).Id + "';";
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
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = reader[0].ToString();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = reader[1].ToString();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = reader[2].ToString();

                    }

                    //dataGridView1.DataSource = reader;
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void APeopleForm1_Load(object sender, EventArgs e)
        {
            int ownerId = (node.Tag as TObject).Id;
            string queryString = "SELECT StartTime, EndTime, Place FROM dbo.Assignment where OwnerId = '" + (node.Tag as TObject).Id + "';";
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
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = reader[0].ToString();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = reader[1].ToString();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = reader[2].ToString();

                    }

                    //dataGridView1.DataSource = reader;
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }

        public virtual int save()
        {
            int ownerId = (node.Tag as TObject).Id;
            string queryString = "SELECT MAX(Id) FROM dbo.Assignment";
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
                        newid = int.Parse(reader[0].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }
            newid++;

            string queryString1 = "INSERT INTO dbo.Assignment(Id, StartTime, EndTime, Place, OwnerId) "
                + "VALUES('" + newid + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + ownerId + "');";

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

        private void button1_Click(object sender, EventArgs e)
        {
            save();
            open();
        }
    }
}
