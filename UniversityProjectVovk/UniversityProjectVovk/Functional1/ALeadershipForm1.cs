﻿using System;
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
    public partial class ALeadershipForm1 : AWorkerForm1
    {
        public ALeadershipForm1()
        {
            InitializeComponent();
        }

        public override int save()
        {
            int newid = base.save();
            string queryString1 = "INSERT INTO dbo.ALeadership(Id, Purpos) "
                + "VALUES('" + newid + "','" + textBox5.Text + "');";

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

        protected override void open()
        {
            int ownerId = (node.Tag as TObject).Id;
            string queryString = "SELECT StartTime, EndTime, Place, Sallary,Purpos FROM dbo.Assignment INNER JOIN dbo.AWorker ON dbo.Assignment.Id = dbo.AWorker.Id INNER JOIN dbo.ALeadership ON dbo.AWorker.Id = dbo.ALeadership.Id   where OwnerId = '" + (node.Tag as TObject).Id + "';";
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
                    dataGridView1.Columns.Add("Sallary", "Sallary");
                    dataGridView1.Columns.Add("Purpose", "Purpose");
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = reader[0].ToString();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = reader[1].ToString();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = reader[2].ToString();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[3].Value = reader[3].ToString();
                        dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[4].Value = reader[4].ToString();

                    }

                    //dataGridView1.DataSource = reader;
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void ALeadershipForm1_Load(object sender, EventArgs e)
        {
            open();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}