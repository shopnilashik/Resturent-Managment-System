using Resturent_Managment_System.Data_Access_Layer;
using Resturent_Managment_System.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent_Managment_System.Business_Logic_Layer
{
    class OrderSevice
    {
        OrderDataAccess orderDataAccess;
        public OrderService()
        {
             this.orderDataAccess = new OrderDataAccess();
        }
        public List<Order> GetAllFoods()
        {
            return this.orderDataAccess.GetOrders();
        }
        public Order GetOrder(int id)
        {
            return this.orderDataAccess.GetOrder(id);
        }
        public int AddNewOrder(string customerName, int customerNumber, string orderdCategory,string orderdFood,int price,string DeliveryType,string categoryName)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int categoryId = categoryDataAccess.GetCategoryId(categoryName);

            Order order = new Order()
            {
                CustomerName = customerName,
                CustomerNumber = customerNumber,
                OrderdCategory = orderdCategory,
                OrderdFood = orderdFood,

            };
            this.orderDataAccess = new OrderDataAccess();
            return this.orderDataAccess.AddOrder(order);
        }

    }
}
