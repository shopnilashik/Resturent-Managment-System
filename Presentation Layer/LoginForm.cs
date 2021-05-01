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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();
            int result = loginService.LoginValidation(usernameTextBox.Text, passwordTextBox.Text);
            if (result == 1)
            {
                Registration dashboard = new Registration();
                this.Hide();
                dashboard.Show();
            }
            
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration dashboard = new Registration();
            this.Hide();
            dashboard.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manage_Category manage = new Manage_Category();
            this.Hide();
            manage.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageFood manage = new ManageFood();
            this.Hide();
            manage.Show();
        }
    }
}
