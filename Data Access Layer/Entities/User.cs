﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent_Managment_System.Data_Access_Layer.Entities
{
    class User
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int userType { get; set; }
    }
}