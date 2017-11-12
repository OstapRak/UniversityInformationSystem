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
using UniversityProjectVovk.ClassesForms;

namespace UniversityProjectVovk.Functional
{
   
    public partial class GroupOfPeopleForm : Form
    {
        public string connectionString;
        public TreeNode node = new TreeNode();
        public GroupOfPeopleForm()
        {
            InitializeComponent();
        }
        public class People
        {
            public string id;
            public string name;
            public string class1;
        }

        private void GroupOfPeopleForm_Load(object sender, EventArgs e)
        {
            int ownerId = (node.Tag as TObject).Id;
            //string queryString = "SELECT StartTime, EndTime, Place FROM dbo.Assignment where OwnerId = '" + (node.Tag as TObject).Id + "';";
            string queryString =
                    "SELECT Id, Name, Class, Major from dbo.TObject "
                        + "WHERE Major = '" + (node.Tag as TObject).Id + "'";
            List<People> peoples = new List<People>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    // dataGridView1 = new DataGridView();
                    //dataGridView1.Rows.Clear();
                    //dataGridView1.Columns.Clear();
                    //dataGridView1.Columns.Add("StartTime", "StartTime");
                    //dataGridView1.Columns.Add("EndTime", "EndTime");
                    //dataGridView1.Columns.Add("Place", "Place");
                    peoples = new List<People>();
                    while (reader.Read())
                    {
                        People p = new People();
                        p.id = reader[0].ToString();
                        p.name = reader[1].ToString();
                        p.class1 = reader[2].ToString();
                        if(Form1.getForm(p.class1)is PeopleForm)
                        {
                            peoples.Add(p);
                        }
                        //dataGridView1.Rows.Add();
                        //dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = reader[0].ToString();
                        //dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = reader[1].ToString();
                        //dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = reader[2].ToString();

                    }

                    //dataGridView1.DataSource = reader;
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
                //dataGridView1 = new DataGridView();
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();
                dataGridView1.Columns.Add("Name", "Name");
                dataGridView1.Columns.Add("StartTime", "StartTime");
                dataGridView1.Columns.Add("EndTime", "EndTime");
                dataGridView1.Columns.Add("Place", "Place");
                foreach (var iter in peoples)
                {
                    queryString = "SELECT StartTime, EndTime, Place FROM dbo.Assignment where OwnerId = '" + iter.id + "';";
                    using (SqlConnection connection1 = new SqlConnection(connectionString))
                    {
                        SqlCommand command1 = new SqlCommand(queryString, connection1);
                        try
                        {
                            connection1.Open();
                            SqlDataReader reader = command1.ExecuteReader();
                            
                            peoples = new List<People>();
                            while (reader.Read())
                            {

                                dataGridView1.Rows.Add();
                                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = iter.name;
                                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = reader[0].ToString();
                                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = reader[1].ToString();
                                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[3].Value = reader[2].ToString();

                            }

                            //dataGridView1.DataSource = reader;
                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
                
            }
        }
    }
}
