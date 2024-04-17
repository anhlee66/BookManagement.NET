using BookManagement.Models;
using BookManagement.Views;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Controller
{
    internal class EmployeeController
    {
        public static Employee GetEmployee(int id)
        {
            Employee emplyee = new Employee();
            try
            {
                DBHandler.open();
                string query = string.Format("Select * from Employees where EmployeeId={0}", id);

                SqlCommand cmd = new SqlCommand(query, DBHandler.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    emplyee = new Employee(dt.Rows[0]);
                    
                }
            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
            }

            finally { DBHandler.close(); }
            return emplyee;
        }
    }
}
