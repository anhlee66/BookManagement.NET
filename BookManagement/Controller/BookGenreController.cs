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
    internal class BookGenreController
    {
        public static DataTable getBookGenreToFilter()
        {
            DataTable dt = new DataTable();
            DBHandler.open();
            string query = "SELECT * FROM BookGenres";
            using(SqlCommand cmd = new SqlCommand(query, DBHandler.con))
            {
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(dt);

            }
            DBHandler.close();
            return dt;
        }

        public static BookGenre getBookGenreById(int id)
        {
            BookGenre genre = new BookGenre();
            DataTable dt = new DataTable();
            DBHandler.open();
            string query = "SELECT * FROM BookGenres WHERE BookGenreId=" + id.ToString();
            using (SqlCommand cmd = new SqlCommand(query, DBHandler.con))
            {
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    genre = new BookGenre(dt.Rows[0]);
                }
            }
            DBHandler.close();
            return genre;
        }
        public static DataTable getAllBookGenre()
        {
            DataTable dt = new DataTable();
            DBHandler.open();
            string query = "SELECT * FROM BookGenres;";
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
