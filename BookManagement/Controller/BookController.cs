using BookManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace BookManagement.Controller
{
    internal class BookController
    {
        public static decimal getBookPrice(int id)
        {
            decimal price = 0;
            DBHandler.open();
            String query = "GetCurrentPrice";
               
            using (SqlCommand cmd = new SqlCommand(query, DBHandler.con))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);
                price = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            DBHandler.close();
            return price;

        }
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

        public static string getAuthorName(int id)
        {
            string author = string.Empty;
            bool firstRow = true;
            try
            {
                DBHandler.open();
                string query = "GetAuthorName";
                using (SqlCommand cmd = new SqlCommand(query,DBHandler.con)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader dr  = cmd.ExecuteReader();
                    if(dr.HasRows) {
                        {
                            while (dr.Read())
                            {
                                if (!firstRow)
                                {
                                    author += " - " + dr.GetString(0);
                                }
                                else
                                {
                                    author += dr.GetString(0);
                                    firstRow = false;
                                }
                            }
                        } }
                    
                }
                
            }
            finally
            {
                DBHandler.close();
            }
            return author;
        }

        public static List<int> getAuthorId(int id)
        {
            List<int> listId = new List<int> ();
            try
            {
                DBHandler.open();
                string query = "GetAuthorId";
                using (SqlCommand cmd = new SqlCommand(query, DBHandler.con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader dr = cmd.ExecuteReader();

                   
                    while (dr.Read())
                    {
                        listId.Add(dr.GetInt32(0));

                    }
                    
                   
                }

            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
            }
            finally
            {
                DBHandler.close();
            }
            return listId;
        }

        public static int[] GetStatictisBook(int author,int genre)
        {
            int[] data = new int[2];
            DBHandler.open();
            string query = "select count(distinct b.BookId),sum(quantity) from Books b " +
                "inner join Authorship au on b.BookId = au.BookId " +
                "inner join Authors a on a.AuthorId = au.AuthorId ";
            if (genre != -1 && author != -1)
            {
                query += string.Format("where BookGenreId={0} and a.AuthorId={1}", genre, author);
            }
            else if (genre != -1) query += "where BookGenreId=" + genre;
            else if (author != -1) query += "where a.AuthorId=" + author;
            SqlCommand cmd = new SqlCommand(query,DBHandler.con);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    data[0] = dr.GetInt32(0);
                    data[1] = dr.GetInt32(1);
                }
            }
            catch
            {
                data[0] = 0;
                data[1] = 0;
            }
            DBHandler.close();

            return data;
        }

        public static bool InsertBook(int genre, int author, int publisher, int quantity,
            decimal import, decimal price, string name,string summary,string state,string thumbnail)
        {
            try
            {
                DBHandler.open();

                string query = "SetBooks";
                SqlCommand cmd = new SqlCommand(query, DBHandler.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name",name);
                cmd.Parameters.AddWithValue("@Quantity",quantity);
                cmd.Parameters.AddWithValue("@ImportPrice",import);
                cmd.Parameters.AddWithValue("@Price",price);
                cmd.Parameters.AddWithValue("@BookGenreId",genre);
                cmd.Parameters.AddWithValue("@AuthorId",author);
                cmd.Parameters.AddWithValue("@PublisherId",publisher);
                cmd.Parameters.AddWithValue("@Summary",summary);
                cmd.Parameters.AddWithValue("@State", state);
                cmd.Parameters.AddWithValue("@Thumbnail", thumbnail);


                if (cmd.ExecuteNonQuery() <= 0)
                {
                    return false;
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally { DBHandler.close(); }
            return true;
        }

        public static bool EditBook(int id,int genre, int author, int publisher,
            int quantity, decimal import, decimal price, string name, string
            summary, string state,string thumbnail)
        {
            try
            {
                DBHandler.open();

                string query = "UpdateBooks";
                SqlCommand cmd = new SqlCommand(query, DBHandler.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookId", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@ImportPrice", import);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@BookGenreId", genre);
                cmd.Parameters.AddWithValue("@AuthorId", author);
                cmd.Parameters.AddWithValue("@PublisherId", publisher);
                cmd.Parameters.AddWithValue("@Summary", summary);
                cmd.Parameters.AddWithValue("@State", state);
                cmd.Parameters.AddWithValue("@Thumbnails", thumbnail);


                if (cmd.ExecuteNonQuery() <= 0)
                {
                    return false;

                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { DBHandler.close(); }
            return true;
        }

        public static string GetStateById(int id)
        {
            string state = string.Empty;
            try
            {
                DBHandler.open();
                string query = "GetStateById";
                using (SqlCommand cmd = new SqlCommand(query, DBHandler.con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);

                    state = cmd.ExecuteScalar().ToString();
                }

            }
            finally
            {
                state = "In stock";
                DBHandler.close();
            }
            return state;
        }

      


    }
}
