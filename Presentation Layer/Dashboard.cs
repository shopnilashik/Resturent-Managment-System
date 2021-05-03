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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {

            LoginForm logout = new LoginForm();
            this.Hide();
            logout.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Category manage = new Manage_Category();
            this.Hide();
            manage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageFood manage = new ManageFood();
            this.Hide();
            manage.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
