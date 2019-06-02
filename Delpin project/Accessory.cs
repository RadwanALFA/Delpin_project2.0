using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delpin_project
{
    public class Accessory
    {
        public int  Id { get; set; }
        public String Model { get; set; }
        public int Price_per_day { get; set; }
        public String Info { get; set; }
        public String GetFullInfo
        {
           get
            {
                return $"Tilbeør ID {Id} Price pr. dag {Price_per_day} Kr.";
            }
        }
        public String GetNmae
        { get
            {
                return $"{Model}";
            }
        }
    }
}
