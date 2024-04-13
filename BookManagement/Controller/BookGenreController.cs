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
        public static bool UpdateBookGenre(BookGenre genre)
        {
            try
            {
                DBHandler.open();
                int id = Convert.ToInt32(genre.genreId);
                string name = genre.name;
                string description = genre.description;
                string query = string.Format("UPDATE BookGenres SET Name=N'{0}', Description=N'{1}' WHERE BookGenreId={2}",  name, description,id);
                using(SqlCommand cmd = new SqlCommand(query, DBHandler.con)) { 
                    if(cmd.ExecuteNonQuery() <= 0)
                    {
                        return false;

                    }
                  
                }
            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message); 
                return false;
            }
            finally
            {
                DBHandler.close();
               
            }
            return true;

        }

        public static bool InsertBookGenre(BookGenre genre)
        {

            try
            {
                DBHandler.open();
                string name = genre.name;
                string description = genre.description;
                string query = string.Format("INSERT INTO BookGenres VALUES(N'{0}',N'{1}')", name, description);
                using (SqlCommand cmd = new SqlCommand(query, DBHandler.con))
                {
                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        return false;

                    }

                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                return false;
            }
            finally
            {
                DBHandler.close();

            }
            return true;
        }

        public static bool DeleteBookGenre(int id)
        {
            try
            {
                DBHandler.open();
               
                string query = string.Format("DELETE BookGenres WHERE BookGenreId={0}",id);
                using (SqlCommand cmd = new SqlCommand(query, DBHandler.con))
                {
                    if (cmd.ExecuteNonQuery() <= 0)
                    {
                        return false;

                    }

                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                return false;
            }
            finally
            {
                DBHandler.close();

            }
            return true;
        }
        public static bool isGenreEmpty(int id)
        {
            try
            {
                DBHandler.open();
                string query = "SELECT COUNT(BookId) FROM Books WHERE BookGenreId=" + id;
                SqlCommand cmd = new SqlCommand(query, DBHandler.con);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result == 0)
                    return true;
            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return false;
        }
    }
}
