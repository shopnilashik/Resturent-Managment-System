using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturent_Managment_System.Data_Access_Layer
{
    class DataAccess
    {
        protected SqlConnection connection;
        protected SqlCommand command;

        public DataAccess()
        {
            try
            {

                this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ResturentManagementDb"].ConnectionString);
                this.connection.Open();
            }
            catch (Exception exp)
            {

                MessageBox.Show("Exection error");
            }
        
   
        }

        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteReader();
        }
        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteNonQuery();
        }
    }
}
