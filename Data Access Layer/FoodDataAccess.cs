using Resturent_Managment_System.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent_Managment_System.Data_Access_Layer
{
    class FoodDataAccess: DataAccess
    {
        public List<Food> GetFoods()
        {
            string sql = "SELECT * FROM Food_Item";
            SqlDataReader reader = this.GetData(sql);
            List<Food> foods = new List<Food>();
            while (reader.Read())
            {
                Food food = new Food();
                food.FoodId = Convert.ToInt32(reader["FoodId"]);
                food.FoodName = reader["FoodName"].ToString();
                food.FoodPrice = Convert.ToDouble(reader["FoodPrice"]);
                food.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                foods.Add(food);
            }
            return foods;
        }
        public Food GetFood(int id)
        {
            string sql = "SELECT * FROM Food_Item WHERE FoodId=" + id;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                Food food = new Food();
                food.FoodId = Convert.ToInt32(reader["FoodId"]);
                food.FoodName = reader["FoodName"].ToString();
                food.FoodPrice = Convert.ToDouble(reader["FoodPrice"]);
                food.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                return food;
            }
            return null;
        }
        public int AddFood(Food food)
        {
            string sql = "INSERT INTO Food_Item(FoodName,FoodPrice,CategoryId) VALUES('" + food.FoodName + "'," + food.FoodPrice + "," + food.CategoryId + ")";
            return this.ExecuteQuery(sql);
        }
        public int UpdateFood(Food food)
        {
            string sql = "UPDATE Food_Item SET FoodName='" + food.FoodName + "',FoodPrice=" + food.FoodPrice + ",CategoryId=" + food.CategoryId + " WHERE FoodId=" + food.FoodId;
            return this.ExecuteQuery(sql);
        }
        public int DeleteFood(int id)
        {
            string sql = "DELETE FROM Food_Item WHERE FoodId=" + id;
            return this.ExecuteQuery(sql);
        }
        public List<Food> GetFoodsByCategoryId(int categoryId)
        {
            string sql = "SELECT * FROM Food_Item WHERE FoodId=" + categoryId;
            SqlDataReader reader = this.GetData(sql);
            List<Food> foods = new List<Food>();
            while (reader.Read())
            {
                Food food = new Food();
                food.FoodId = Convert.ToInt32(reader["FoodId"]);
                food.FoodName = reader["FoodName"].ToString();
                food.FoodPrice = Convert.ToDouble(reader["FoodPrice"]);
                food.CategoryId = Convert.ToInt32(reader["CategoryId"]);
                foods.Add(food);
            }
            return foods;
        }
        
    }
}
