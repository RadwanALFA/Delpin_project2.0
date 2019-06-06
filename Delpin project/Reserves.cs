using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delpin_project
{
    public class Reserves
    {
        public int ID { get; set; }
        public int FROM_ID { get; set; }
        public int TO_ID { get; set; }
        public int product_id { get; set; }
        public DateTime DATE { get; set; }
    }
}
