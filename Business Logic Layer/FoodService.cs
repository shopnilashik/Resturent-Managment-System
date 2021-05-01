using Resturent_Managment_System.Data_Access_Layer;
using Resturent_Managment_System.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent_Managment_System.Business_Logic_Layer
{
    class FoodService
    {
        FoodDataAccess foodDataAccess;
        public FoodService()
        {
            this.foodDataAccess = new FoodDataAccess();
        }
        public List<Food> GetAllFoods()
        {
            return this.foodDataAccess.GetFoods();
        }
        public Food GetFood(int id)
        {
            return this.foodDataAccess.GetFood(id);
        }
        public int AddNewFood(string foodName, double foodprice, string categoryName)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int categoryId = categoryDataAccess.GetCategoryId(categoryName);

            Food food = new Food()
            {
                FoodName = foodName,
                FoodPrice = foodprice,
                CategoryId = categoryId
            };
            this.foodDataAccess = new FoodDataAccess();
            return this.foodDataAccess.AddFood(food);
        }
        public int UpdateExistingFood(int foodId, string foodName, double foodprice, string categoryName)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int categoryId = categoryDataAccess.GetCategoryId(categoryName);
            Food food = new Food()
            {
                FoodId = foodId,
                FoodName = foodName,
                FoodPrice = foodprice,
                CategoryId = categoryId
            };
            this.foodDataAccess = new FoodDataAccess();
            return this.foodDataAccess.UpdateFood(food);
        }
        public int DeleteFood(int id)
        {
            return this.foodDataAccess.DeleteFood(id);
        }
        public List<Food> GetAllFoodsByCategory(string categoryName)
        {
            CategoryDataAccess categoryDataAccess = new CategoryDataAccess();
            int categoryId = categoryDataAccess.GetCategoryId(categoryName);
            this.foodDataAccess = new FoodDataAccess();
            return this.foodDataAccess.GetFoodsByCategoryId(categoryId);
        }
    }
}
