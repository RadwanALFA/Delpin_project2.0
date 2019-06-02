using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delpin_project
{
    public class Product
    {
        public int Id
        {
            get
            {
                return Id;
            }
        }
        public String Name { get; set; }
        public int PricePerDay { get; set; }
        public char driver_licence { get; set; }
        public int catagory_id { get; set; }
        public int branch_id { get; set; }
        public String GetFullInfo
        {
            get
            {
                return $"{Name} leje pr. dag {PricePerDay}Kr. branch id {branch_id}";
            }
        }
        public String GetName
        {
            get
            {
                return $"{Name}";
            }
        }
    }
}
