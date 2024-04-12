using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class DataProvider
    {
        public static SqlDataAdapter dp = new SqlDataAdapter();
        public  DataTable executeQuery(string query)
        {
            DataTable dt = new DataTable();
            DBHandler.open();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, DBHandler.con))
                {
                    dp.SelectCommand = cmd;
                    dp.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }

            return dt;
        }
        public int executeScaler(string query)
        {
            int data = -1;
            DBHandler.open();
            using (SqlCommand cmd = new SqlCommand(query, DBHandler.con)) {
                data = Convert.ToInt32(cmd.ExecuteScalar());
                if(data != -1)
                {
                    return data;
                }
            }

            return data;
        }

        public int executeNonQuery(string query)
        {
            int data = -1;
            DBHandler.open();
            using(SqlCommand cmd = new SqlCommand(query,DBHandler.con))
            {
                try
                {
                    data = cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    Debug.Print(ex.Message);
                }
            }
            return data;
        }
    }
}
