﻿using Resturent_Managment_System.Business_Logic_Layer;
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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginService RegistrationService = new LoginService();
            int result = RegistrationService.AddNewUser(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
            if (result > 0)
            {
                MessageBox.Show("New User added successfully !!");

                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Error in adding.");
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
