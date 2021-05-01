using Resturent_Managment_System.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturent_Managment_System.Presentation_Layer
{
    public partial class ManageFood : Form
    {
        public ManageFood()
        {
            InitializeComponent();
            FoodService productService = new FoodService();
            productListDataGridView.DataSource = productService.GetAllFoods();
            CategoryService categoryService = new CategoryService();
            addProductCategoryComboBox.DataSource = categoryService.GetCategoryNames();
            CategoryService categoryService2 = new CategoryService();
            productByCategoryComboBox.DataSource = categoryService2.GetCategoryNames();
        }
        void UpdateListOfFoods()
        {
            FoodService foodService = new FoodService();
            productListDataGridView.DataSource = foodService.GetAllFoods();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            FoodService foodService = new FoodService();
            int result = foodService.AddNewFood(addProductNameTextBox.Text, Convert.ToDouble(addProductPriceTextBox.Text), addProductCategoryComboBox.Text);
            if (result > 0)
            {
                MessageBox.Show("New product added successfully !!");
                UpdateListOfFoods();
            }
            else
            {
                MessageBox.Show("Error in Adding.");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            
        }

        private void productsByCategoryGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FoodService productService = new FoodService();
            productsByCategoryGridView.DataSource = productService.GetAllFoodsByCategory(productByCategoryComboBox.Text);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void productListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
