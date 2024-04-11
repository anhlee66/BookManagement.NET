using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class DBHandler
    {
        private static SqlConnection con;
        private static string server = "server=AnhLee;database=managebook;Integreted Security=SSPI";
        public static bool open()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();
            }
            catch(Exception e)
            {
                Debug.Print(e.Message, e.StackTrace);
                return false;
            }
            return true;
        }
        public static bool close()
        {
            try
            {
                con.Close();
            }

            catch (Exception e)
            {
                Debug.Print(e.Message, e.StackTrace);
                return false;
            }
            return true;
        }
    }
}
