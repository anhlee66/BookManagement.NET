using BookManagement.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Controller
{
    internal class PublisherController
    {
        public static DataTable getPublisherToCombobox()
        {
            DataTable dt = new DataTable();
            DBHandler.open();
            string query = "SELECT PublisherId,Name FROM Publishers";
            using (SqlCommand cmd = new SqlCommand(query, DBHandler.con))
            {
                SqlDataAdapter dp= new SqlDataAdapter(cmd);
                dp.Fill(dt);
            }
            DBHandler.close();
            return dt;
        }
        public static DataTable getAllPublisherDataTable()
        {
            DataTable dt = new DataTable();
            DBHandler.open();
            string query = "SELECT * FROM Publishers";
            using (SqlCommand cmd = new SqlCommand(query, DBHandler.con))
            {
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                dp.Fill(dt);
            }
            DBHandler.close();
            return dt;
        }

        public static bool UpdatePublisher(Models.Publisher publisher)
        {
            try
            {
                DBHandler.open();
                int id = Convert.ToInt32(publisher.publisherId);
                string name = publisher.name;
                string contact = publisher.contact;
                string description = publisher.description;

                string query = string.Format("UPDATE Publishers SET Name=N'{0}',Contact=N'{1}', Description=N'{2}' WHERE PublisherId={3}", name, contact, description, id);
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

        public static bool InsertPublisher(Publisher publisher)
        {
            try
            {
                DBHandler.open();
                int id = Convert.ToInt32(publisher.publisherId);
                string name = publisher.name;
                string contact = publisher.contact;
                string description = publisher.description;

                string query = string.Format("INSERT INTO Publishers VALUES(N'{0}','{1}',N'{2}')", name, contact, description);
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
        public static bool DeletePublisher(int id)
        {
            try
            {
                DBHandler.open();
                string query = "DELETE Publishers WHERE PublisherId=" + id.ToString();
                SqlCommand cmd = new SqlCommand(query, DBHandler.con);
                if (cmd.ExecuteNonQuery() <= 0)
                {
                    return false;

                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                return false;
            }
            return true;
        }
        public static bool isPublisherEmpty(int id)
        {
            try
            {
                DBHandler.open();
                string query = "SELECT COUNT(BookId) FROM Books WHERE PublisherId=" + id;
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

        public static string GetPublisherName(int id)
        {
            string name = string.Empty;
            DBHandler.open();
            string query = "GetPublisherName";
            SqlCommand cmd = new SqlCommand(query, DBHandler.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            name = cmd.ExecuteScalar().ToString();
            if (name == null)
                return "";
            DBHandler.close();
            return name;
        }
    }
}
