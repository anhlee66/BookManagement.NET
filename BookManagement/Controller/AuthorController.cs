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

        public static bool updateAuthor(Author author)
        {
            try
            {
                DBHandler.open();
                int id = Convert.ToInt32(author.authorId);
                string name = author.name;
                string contact = author.contact;
                string description = author.description;
                string query = string.Format("UPDATE Authors SET Name=N'{0}',Contact=N'{1}', Description=N'{2}' WHERE AuthorId={3}", name,contact, description, id);
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
        public static bool InsertAuthor(Author author)
        {
            try
            {
                DBHandler.open();
                int id = Convert.ToInt32(author.authorId);
                string name = author.name;
                string contact = author.contact;
                string description = author.description;
                string query = string.Format("INSERT INTO Authors VALUES(N'{0}','{1}',N'{2}')", name, contact, description);
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

        public static bool DeleteAuthor(int id)
        {
            try
            {
                DBHandler.open();
                string query = "DELETE Authors WHERE AuthorId=" + id.ToString();
                SqlCommand cmd = new SqlCommand(query, DBHandler.con);
                if (cmd.ExecuteNonQuery() <= 0)
                {
                    return false;

                }
            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
                return false;
            }
            return false;
        }
        public static bool isAuthorEmpty(int id)
        {
            try
            {
                DBHandler.open();
                string query = "SELECT COUNT(BookId) FROM Authorship WHERE AuthorId=" + id;
                SqlCommand cmd = new SqlCommand(query, DBHandler.con);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result == 0)
                    return true;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
            return false;
        }
    }
}
