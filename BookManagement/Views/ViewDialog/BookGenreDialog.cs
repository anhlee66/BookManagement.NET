using BookManagement.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement.Views.ViewDialog
{
    public partial class BookGenreDialog : Form
    {
        const int SUCCESS_CODE = 1;
        const int FAILURE_CODE = 0;
        public BookGenreDialog()
        {
            InitializeComponent();
        }
        internal void getData(BookGenre genre)
        {
            txtGenreName.Text = genre.name;
            txtGenreId.Text = genre.genreId.ToString();
            txtGenreDescription.Text = genre.description;

        }
        public void NotifyIdChangeVaulue()
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBHandler.open();
                int id = Convert.ToInt32(txtGenreId.Text);
                string name = txtGenreName.Text.Trim();
                string description = txtGenreDescription.Text.Trim();
                string query = string.Format("UPDATE BookGenres SET Name='{0}', Description='{1}' WHERE BookGenreId={2};", name, description, id);
                
                if (name == "" || description == "")
                {
                    MessageBox.Show("Needed values are empty.");
                    txtGenreName.Focus();
                    return;
                }
                using (SqlCommand cmd = new SqlCommand(query, DBHandler.con))
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        Debug.Print("Oke");
                        AdminCategory cate = new AdminCategory();
                        cate.gengerTab_Load();
                        this.Close();
                    }
                    else
                    {
                        Debug.Print("Faild");
                    }
                }
                DBHandler.close();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }
    }
}
