using BookManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookManagement.Controller
{
    internal class BookController
    {
        
        public static List<Book> getAllBook()
        {
            List<Book> list = new List<Book>();
            DBHandler.open();
            String query = "SELECT * FROM Books";
            using (SqlCommand cmd = new SqlCommand(query, DBHandler.con))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(dt);
                if (dt.Rows.Count >0)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        Book book = new Book(dr);
                        list.Add(book);
                    }
                }
            }
            DBHandler.close();

            return list;
        }
        public static DataTable getAllBookToTable()
        {
            DataTable dt = new DataTable();
            DBHandler.open();
            String query = "SELECT * FROM Books";
            using (SqlCommand cmd = new SqlCommand(query, DBHandler.con))
            {
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(dt);
                
            }
            DBHandler.close();

            return dt;
        }
        public static Book getBookById(int id)
        {
            Book book = new Book();
            DataTable dt = new DataTable();
            DBHandler.open();

            String query = "SELECT * FROM Books WHERE BookId=@id";
            SqlCommand cmd = new SqlCommand(query,DBHandler.con);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataAdapter dp = new SqlDataAdapter(cmd);
            dp.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                book = new Book(dt.Rows[0]);
            }
            DBHandler.close();

            return book;
        }

        public static List<Book> getListBookByName(string name)
        {
            List<Book> list = new List<Book>();
            DBHandler.open();
            String[] filterName = name.Trim().Split(' ');
            StringBuilder str = new StringBuilder();
            str.Append("SELECT * FROM Books WHERE Name ");
            int count = 0;
            foreach(string s in filterName)
            {
                count++;
                str.Append(string.Format(" LIKE '%{0}%' ", s));
                if (count < filterName.Length)
                {
                    str.Append(" OR Name");
                }
                else
                {
                    str.Append(';');
                }
            }
            MessageBox.Show(str.ToString());
            using (SqlCommand cmd = new SqlCommand(str.ToString(),DBHandler.con))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    foreach(DataRow dr in  dt.Rows)
                    {
                        Book book = new Book(dr);
                        list.Add(book);
                    }
                }
            }
            DBHandler.close();

            return list;
        }
    }
}
