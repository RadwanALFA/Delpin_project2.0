using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delpin_project
{
    public class Booking
    {
        public int ID { get; set; }
        public int CUSTOMER_ID { get; set; }
        public int PRODUCT_ID { get; set; }
        public DateTime START_DATE { get; set; }
        public DateTime END_DATE { get; set; }
        public char DELIVERY { get; set; }
        public char PICK_UP { get; set; }
        public String DELIVERY_ADDRESS { get; set; }
        public int ACCESSORY_ID { get; set; }
        public DateTime ACCESSORY_START_DATE { get; set; }
        public DateTime ACCESSORY_END_DATE { get; set; }

        public String GetFullInfo
        {
            get
            { 
                return $"Resource Id {PRODUCT_ID} Start Date {START_DATE.ToShortDateString()} End date {END_DATE.ToShortDateString()}";
            }
        }
    }
}
