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
    public partial class StudentForm : PeopleForm
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        protected override void open()
        {
 	         base.open();
             string queryString = "SELECT IsPay, YearOfEntry FROM dbo.Student where Id = '" + (node.Tag as TObject).Id + "';";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        bool t = false;
                        if (int.Parse(reader[0].ToString()) == 1)
                        {
                            t = true;
                        }
                        IsPay.Checked = t;
                        YearText.Text = reader[1].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            if (isEdit == true)
            {
                open();
            }
        }

        public override void delete()
        {
            base.delete();
            string queryString = "DELETE FROM dbo.Student where Id = '" + (node.Tag as TObject).Id + "';";
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
              int year = 0;
            try
            {
                year = int.Parse(YearText.Text);
            }
            catch { }
            int b = 0;
            if (IsPay.Checked == true) b = 1;
            string queryString = "INSERT INTO dbo.Student(Id, IsPay, YearOfEntry) "
                   + "VALUES('" + newid + "','" + b + "','" + year + "')";

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
            save("Student");
            this.Close();
        }
    }
}
