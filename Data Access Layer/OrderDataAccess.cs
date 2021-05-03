using Resturent_Managment_System.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent_Managment_System.Data_Access_Layer
{
    class OrderDataAccess: DataAccess
    {
        public List<Order> GetOrders()
        {
            string sql = "SELECT * FROM Orders";
            SqlDataReader reader = this.GetData(sql);
            List<Order> orders = new List<Order>();
            while (reader.Read())
            {
                Order order = new Order();
                order.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                order.CustomerName = reader["CustomerName"].ToString();
                order.CustomerNumber = Convert.ToDouble(reader["CustomerNumber"]);
                order.OrderdCategory = Convert.ToString(reader["OrderdCategory"]);
                order.OrderdFood = Convert.ToString(reader["OrderdFood"]);
                order.Price = Convert.ToString(reader["Price"]);
                order.DeliveryType = Convert.ToString(reader["CategoryId"]);
                orders.Add(order);
            }
            return orders;
        }
        public Order GetOrder(int id)
        {
            string sql = "SELECT * FROM Orders WHERE OrderId=" + id;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                Order order = new Order();
                order.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                order.CustomerName = reader["CustomerName"].ToString();
                order.CustomerNumber = Convert.ToDouble(reader["CustomerNumber"]);
                order.OrderdCategory = Convert.ToString(reader["OrderdCategory"]);
                order.OrderdFood = Convert.ToString(reader["OrderdFood"]);
                order.Price = Convert.ToString(reader["Price"]);
                order.DeliveryType = Convert.ToString(reader["CategoryId"]);
                return order;
            }
            return null;
        }
        public int AddOrder(Order order)
        {
            string sql = "INSERT INTO Orders(CustomerName,CustomerNumber,OrderdCategory,OrderdFood,Price,DeliveryType) VALUES('" + order.CustomerName + "'," + order.CustomerNumber + "," + order.OrderdCategory + "," + order.OrderdFood + "," + order.Price + "," + order.DeliveryType + ")";
            return this.ExecuteQuery(sql);
        }
        public int DeleteOrder(int id)
        {
            string sql = "DELETE FROM Orders WHERE OrderId=" + id;
            return this.ExecuteQuery(sql);
        }
       
    }
}
