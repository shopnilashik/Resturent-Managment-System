using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent_Managment_System.Data_Access_Layer.Entities
{
    class Order
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public double CustomerNumber { get; set; }
        public string OrderdCategory { get; set; }
        public string OrderdFood { get; set; }
        public string Price { get; set; }
        public string DeliveryType { get; set; }
        
    }
}
