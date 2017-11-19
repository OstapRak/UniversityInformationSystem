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
using System.Reflection;
//using UniversityProjectVovk.assignmentForms;
using UniversityProjectVovk.Functional1;

namespace UniversityProjectVovk
{

   public partial class Form1 : Form
    {
        private string StartConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=L:\UniversityInformationSystem\UniversityProjectVovk\UniversityProjectVovk\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        //private string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='E:\projects 2016-2017\UniversityProjectVovk\UniversityProjectVovk\Database1.mdf';Integrated Security=True";
        public TreeNode selectNode;
        private string add = "Add";
        private string update = "Update";
        private string delete = "Delete";
        private List<string> classes;
        public Form1()
        {
            InitializeComponent();
            InitializeTree();
            classes = new List<string>();
            classes.Add("Object");
            classes.Add("Linq");
            classes.Add("People");
            classes.Add("Connect to university people");
            classes.Add("Worker");
            classes.Add("Leadeship");
            classes.Add("Teacher");
            classes.Add("Staff");
            classes.Add("Student");
            classes.Add("Entrant");
            classes.Add("Thing");
            classes.Add("CultureThing");
            classes.Add("MatherialThing");
            classes.Add("Building");
            classes.Add("Room");
            classes.Add("PersonalThing");
            classes.Add("Literature");
            classes.Add("Electronic");
            classes.Add("NotMatherialThing");
            classes.Add("GroupOfPeople");
            classes.Add("Faculty");
            classes.Add("Group");
            classes.Add("ManageOfPeople");
            classes.Add("Mark");
            classes.Add("Award");
            //classes.Add("Event");
            //classes.Add("ControlKnowledge");
            classes.Add("Subject");
        }

       // private string connectionstring = "Data Source=(LocalDB)\v11.0;AttachDbFilename=\"E:\projects 2016-2017\UniversityProjectVovk\UniversityProjectVovk\Database1.mdf\";Integrated Security=True";

        public void AddChild(TreeNode core, List<string> objects)
        {
        //    for (int i = 0; i < objects.Count; ++i)
        //    {
                TreeNode node = new TreeNode("gf");
                node.ContextMenuStrip = new ContextMenuStrip();
                //node.ContextMenuStrip.Name = node.Textf;
                node.ContextMenuStrip.Items.Add(add);
                node.ContextMenuStrip.Items.Add(update);
                
                node.ContextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
                
            core.Nodes.Add(node);
        //        // AddChild(core.Nodes[core.Nodes.Count-1], objects);
        //    }

        }


        //private static ConstructorInfo getParameterlessFormConstructorInfo(string typeName, string formSuffix)
        //{
        //    string formTypeName = string.Format("{0}{1}{2}", FORMS_PREFIX, typeName, formSuffix);
        //    Type formType = Assembly.GetExecutingAssembly().GetType("ObjectModelsTask__University." + typeName + "ViewForm");
        //    ConstructorInfo formCtor = formType.GetConstructor(Type.EmptyTypes);
        //    return formCtor;
        //}
        #region get
        public APeopleForm1 getAForm (string name)
       {
           APeopleForm1 f = null;// = new ObjectForm();
            switch (name)
            {
                case "People":
                    f = new APeopleForm1();
                    break;
                case "Student":
                    f = new APeopleForm1();
                    break;
                case "Entrat":
                    f = new APeopleForm1();
                    break;
                case "ConnectToUniversityPeople":
                    f = new AConnectPeopleForm1();
                    break;
                case "Worker":
                    f = new AWorkerForm1();
                    break;
                case "Staff":
                    f = new AWorkerForm1();
                    break;
                case "Leadership":
                    f = new ALeadershipForm1();
                    break;
                case "Teacher":
                    f = new ATeacherForm1();
                    break;                
            }
           return f;
       }

       public static BaseForm getForm(string name)
       {
           BaseForm f = new ObjectForm();
           switch (name)
           {
               case "Object":
                   f = new ObjectForm();
                   break;
                case "Linq":
                    f = new LinqForm();
                    break;
                case "People":
                   f = new PeopleForm();
                   break;
               case "ConnectToUniversityPeople":
                   f = new ConnectToUniversityPeopleForm();
                   break;
               case "Worker":
                   f = new Workers();
                   break;
               case "Leadership":
                   f = new LeadershipForm();
                   break;
               case "Teacher":
                   f = new TeacherForm();
                   break;
               case "Staff":
                   f = new StaffForm();
                   break;
               case "Student":
                   f = new StudentForm();
                   break;
               case "Entrant":
                   f = new EntrantForm();
                   break;
               case "Thing":
                   f = new ThingForm();
                   break;
               case "CultureThing":
                   f = new CultureThingForm();
                   break;
               case "MatherialThing":
                   f = new MatherialThingForm();
                   break;
               case "Building":
                   f = new BuildingForm();
                   break;
               case "Room":
                   f = new RoomForm();
                   break;
               case "PersonalThing":
                   f = new RersonalThingForm();
                   break;
               case "Literature":
                   f = new LiteratureForm();
                   break;
               case "Electronic":
                   f = new ElectronicForm();
                   break;
               case "NotMatherialThing":
                   f = new NotMatherialForm();
                   break;
               case "GroupOfPeople":
                   f = new GroupOfPeopleForm();
                   break;
               case "Faculty":
                   f = new FacultyForm();
                   break;
               case "Group":
                   f = new GroupForm();
                   break;
               case "ManageOfPeople":
                   f = new ManageOfPeopleForm();
                   break;
               case "Mark":
                   f = new MarkForm();
                   break;
               case "Award":
                   f = new AwardForm();
                   break;
               //case "Event":
               //    f = new EventForm();
               //    break;
               //case "ControlKnowledge":
               //    f = new ControlKnowledgeForm();
               //    break;
               case "Subject":
                   f = new SubjectForm();
                   break;
           }
           return f;
       }
        #endregion
       public void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            
            if(classes.Contains(item.Text))
            {
                BaseForm f = getForm(item.Text);

                f.connectionString = (selectNode.Tag as NodeData).ConnectionString;
                f.node = selectNode;
                f.Show();
            }
          // // if(item.Text == showChildClasses)
          //  {
          //      //isData = false;
          //     // string queryString =
          //     //"SELECT Id from dbo.Class "
          //     //    + "WHERE Name = '" + selectNode.Text + "'";
          //     // int id = -1;
          //     // using (SqlConnection connection = new SqlConnection(connectionString))
          //     // {
          //     //     SqlCommand command = new SqlCommand(queryString, connection);
          //     //     try
          //     //     {
          //     //         connection.Open();
          //     //         SqlDataReader reader = command.ExecuteReader();
          //     //         while (reader.Read())
          //     //         {
          //     //             id = int.Parse(reader[0].ToString());                            
          //     //         }
          //     //         reader.Close();
          //     //     }
          //     //     catch (Exception ex)
          //     //     {
          //     //     }
          //     // }
          //     // if(id>=0)
          //     // {
          //     //     queryString =
          //     //        "SELECT Name from dbo.TObject "
          //     //            + "WHERE Major = '"+ id + "'";

          //     //     using (SqlConnection connection = new SqlConnection(connectionString))
          //     //     {
          //     //         SqlCommand command = new SqlCommand(queryString, connection);
          //     //         try
          //     //         {
          //     //             connection.Open();
          //     //             SqlDataReader reader = command.ExecuteReader();
          //     //             while (reader.Read())
          //     //             {
          //     //                 TreeNode node = new TreeNode(reader[0].ToString());
          //     //                 node.ContextMenuStrip = new ContextMenuStrip();
          //     //                 node.ContextMenuStrip.Items.Add(add);
          //     //                 node.ContextMenuStrip.Items.Add(update);
          //     //                 node.ContextMenuStrip.Items.Add(delete);
          //     //                 node.ContextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
          //     //                 selectNode.Nodes.Add(node);
          //     //             }
          //     //             selectNode.Expand();
          //     //             reader.Close();
          //     //         }
          //     //         catch (Exception ex)
          //     //         {
          //     //         }
          //     //     }
          // //     }
          //  }
          ////  else if (item.Text == showData)
          //  {
          //      // your code here
          //  }
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }
        private void InitializeTree()
        {
            (contextMenuStrip1.Items[0] as ToolStripMenuItem).DropDownItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
            string queryString =
               "SELECT Id, Name, Class, Major from dbo.TObject "
                   + "WHERE Major IS NULL";

            using (SqlConnection connection = new SqlConnection(StartConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TObject t = new TObject();
                        t.Id = int.Parse(reader[0].ToString());
                        t.Name = reader[1].ToString();
                        t.Class = reader[2].ToString();
                        try
                        {
                            t.Major = int.Parse(reader[3].ToString());
                        }
                        catch { }
                        TreeNode node = new TreeNode(t.Name.ToString());
                        NodeData nodeData = new NodeData(StartConnectionString, t);
                        node.Tag = nodeData;
                        node.ContextMenuStrip = contextMenuStrip1;
                        //node.ContextMenuStrip.Items.Add(add);
                        ////foreach(var it in classes)
                        ////{
                        ////    node.ContextMenuStrip.Items[0]
                        ////}
                        //node.ContextMenuStrip.Items.Add(update);
                        //node.ContextMenuStrip.Items.Add(delete);
                        node.ContextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
                        treeView1.Nodes.Add(node);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                }
            }

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                TreeNode Node = e.Node;
                treeView1.PathSeparator = ".";
                if (Node.Nodes.Count != 0)
                {
                    Node.Nodes.Clear();
                }
                else
                {
                    ///using (var db = new Database1Entities1())
                    {
                        //int id = db.TObjects.Where(o => o.Name == Node.Text).FirstOrDefault().Id;
                        //List<TObject> goodObjects = db.TObjects.Where(o => o.Major == id).ToList();
                       // AddChild(Node, goodObjects);
                    }
                    Node.Expand();
                }
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                TreeNode node = e.Node;
               // node.ContextMenuStrip = contextMenuStrip1;
                node.ContextMenuStrip.Show();
                selectNode = node;
                //node.ContextMenuStrip.Items.up
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            selectNode = e.Node;
           
            int id = ((selectNode.Tag as NodeData).Object).Id;
            string connectionString = (selectNode.Tag as NodeData).ConnectionString;

            if (id >= 0)
            {
                string queryString =
                    "SELECT Id, Name, Class, Major from dbo.TObject "
                        + "WHERE Major = '" + id + "'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            TObject t = new TObject();
                            t.Id = int.Parse(reader[0].ToString());
                            t.Name = reader[1].ToString();
                            t.Class = reader[2].ToString();
                            t.Major = int.Parse(reader[3].ToString());
                            TreeNode node = new TreeNode(reader[1].ToString());
                            NodeData nodeData = new NodeData(connectionString, t);
                            node.Tag = nodeData;
                            node.ContextMenuStrip = contextMenuStrip1;
                            //node.ContextMenuStrip.Items.Add(add);
                            //node.ContextMenuStrip.Items.Add(update);
                            //node.ContextMenuStrip.Items.Add(delete);
                            node.ContextMenuStrip.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
                            //(node.ContextMenuStrip.Items[0] as ToolStripMenuItem).DropDownItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
                            selectNode.Nodes.Add(node);
                        }
                        selectNode.Expand();
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseForm f = getForm((selectNode.Tag as NodeData).Object.Class);
            string connectionString =(selectNode.Tag as NodeData).ConnectionString;
            f.isEdit = true;
            f.node = selectNode;
            f.connectionString = connectionString;
            f.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseForm f = getForm((selectNode.Tag as NodeData).Object.Class);
            string connectionString = (selectNode.Tag as NodeData).ConnectionString;
            f.isEdit = true;
            f.node = selectNode;
            f.connectionString = connectionString;
            f.delete();
            TreeNode p = selectNode.Parent;
            p.Nodes.Remove(selectNode);

            
        }

        private void assignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APeopleForm1 f = getAForm((selectNode.Tag as NodeData).Object.Class); //= new ATeacherForm1();
            string connectionString = (selectNode.Tag as NodeData).ConnectionString;
            if (f != null)
            {
                f.node = selectNode;
                f.connectionString = connectionString;
                f.Show();
            }
            else
            {
                if( (selectNode.Tag as NodeData).Object.Class == "GroupOfPeople")
                {
                    UniversityProjectVovk.Functional.GroupOfPeopleForm f1 = new UniversityProjectVovk.Functional.GroupOfPeopleForm();
                    f1.node = selectNode;
                    f1.connectionString = connectionString;
                    f1.Show();
                }
                if ((selectNode.Tag as NodeData).Object.Class == "Faculty")
                {
                    UniversityProjectVovk.Functional.GroupOfPeopleForm f1 = new UniversityProjectVovk.Functional.FacultyForm();
                    f1.node = selectNode;
                    f1.connectionString = connectionString;
                    f1.Show();
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
