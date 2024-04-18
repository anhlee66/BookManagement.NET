using BookManagement.Models;
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
    internal class AccountController
    {
        public static AccountComputer GetAccount (string login)
        {
            AccountComputer account = new AccountComputer() ;

            try
            {
                DBHandler.open();
                string query = string.Format("Select * from ComputerAccounts where AccountName='{0}'", login);
                SqlCommand cmd = new SqlCommand(query, DBHandler.con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    account = new AccountComputer(dt.Rows[0]);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return account;
        }
    }
}
