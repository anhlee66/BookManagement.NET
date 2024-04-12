using BookManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Controller
{
    internal class AuthorController
    {
        public static List<Author> getAllAuthor()
        {
            List<Author> list = new List<Author>();
            String query = "SELECT * FROM Authors;";
            DBHandler.open();
            using(SqlCommand cmd = new SqlCommand(query, DBHandler.con))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        Author author = new Author(dr);
                        list.Add(author);
                    }
                }
            }
            DBHandler.close();
            return list;
        }
        public static DataTable getAllAuthorDatatable()
        {
            DataTable dt = new DataTable();
            String query = "SELECT * FROM Authors;";
            DBHandler.open();
            using (SqlCommand cmd = new SqlCommand(query, DBHandler.con))
            {
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(dt);
                
            }
            DBHandler.close();
            return dt;
        }
        public static DataTable getAuthorToCombobox()
        {
            DataTable dt = new DataTable();
            String query = "SELECT * FROM Authors;";
            DBHandler.open();
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
