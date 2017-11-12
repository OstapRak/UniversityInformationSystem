using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityProjectVovk.ClassesForms
{
    public partial class BaseForm : Form
    {
        public string connectionString;
        public TreeNode node;
        public bool isEdit;
        public BaseForm()
        {
            InitializeComponent();
            isEdit = false;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
        public virtual void delete()
        {

        }
    }
}
