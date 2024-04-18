using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Web;

namespace BookManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                DBHandler.open();
                string query = "SELECT * FROM BookGenres;";
                SqlCommand cmd = new SqlCommand(query, DBHandler.con);
                dt = new DataTable();
                dp = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(dp);
                dp.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    dgvGenre.DataSource = dt;
                    Debug.Print(dt.Rows.Count.ToString());
                }
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string genre = txtGenre.Text;
            string description = txtDescription.Text;
           try
            {
                /*DBHandler.open();
                string query = string.Format("INSERT INTO BookGenres(Name,Description) values('{0}','{1}')", genre, description);
                SqlCommand cmd = new SqlCommand(query, DBHandler.con);
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("inserted");
                }
                DBHandler.close();*/

                dt.Rows.Add(genre, description);
                dp.Update(dt);
            }
            catch(Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }
    }
}
