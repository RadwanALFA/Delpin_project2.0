using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delpin_project
{
    public class Catagory
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public int Main_id { get; set; }
        public String GetName
        {
            get
            {
                return $"{Name}";
            }
        }
    }
}
