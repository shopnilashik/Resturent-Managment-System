using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent_Managment_System.Data_Access_Layer.Entities
{
    class Food
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public double FoodPrice { get; set; }
        public int CategoryId { get; set; }
    }
}
