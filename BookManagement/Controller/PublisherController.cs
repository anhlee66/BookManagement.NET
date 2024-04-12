using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Controller
{
    internal class PublisherController
    {
        public static DataTable getPublisherToFilter()
        {
            DataTable dt = new DataTable();
            DBHandler.open();
            string query = "SELECT * FROM Publishers";
            using (SqlCommand cmd = new SqlCommand(query, DBHandler.con))
            {
                SqlDataAdapter dp= new SqlDataAdapter(cmd);
                dp.Fill(dt);
            }
            DBHandler.close();
            return dt;
        }
        public static DataTable getAllPublisherDataTable()
        {
            DataTable dt = new DataTable();
            DBHandler.open();
            string query = "SELECT * FROM Publishers";
            using (SqlCommand cmd = new SqlCommand(query, DBHandler.con))
            {
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(dt);
            }
            DBHandler.close();
            return dt;
        }

    }
}
