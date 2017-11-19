using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityProjectVovk
{
    public class NodeData
    {
        public string ConnectionString { get; set; }
        public TObject Object { get; set; }

        public NodeData(string connectionString, TObject obj)
        {
            ConnectionString = connectionString;
            Object = obj;
        }

    }
}
