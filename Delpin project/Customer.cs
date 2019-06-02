using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delpin_project
{
    public class Customer
    {
        public int Id { get; set; }
        public String fName { get; set; }
        public String lName { get; set; }
        public String userName { get; set; }
        public String passward { get; set; }
        public String email { get; set; }
        public String telef { get; set; }
        public String address { get; set; }
        public String driver_licence { get; set; }
        public DateTime reg_date { get; set; }
        public int branch_id { get; set; }
        public String cpr_numm { get; set; }
        public string cvr_numm { get; set; }
        public String CompName { get; set; }
        public String Customer_Full_Name
        {
            get
            {
                return $"{fName} {lName}";
            }
        }

        public String Company_Customer_Name
        {
            get
            {
                return $"{CompName}";
            }
        }
        
    }
}
