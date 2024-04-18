using Microsoft.Data.SqlClient;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement.Views
{
    public partial class AdminDashborad : Form
    {
        public AdminDashborad()
        {
            InitializeComponent();
        }

        ////Hàm GetCurrentYear() trích xuất năm hiện tại từ lớp DateTime có thuộc tính Now trả về thời gian hiện tại
        private int GetCurrentYear()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear;
        }

        //Hàm GetCurrentMonth() trích xuất tháng hiện tại từ lớp DateTime có thuộc tính Now trả về thời gian hiện tại
        private int GetCurrentMonth()
        {
            int currentMonth = DateTime.Now.Month;
            return currentMonth;
        }

        //Hàm GetCurrentQuarter() trả về quý hiện tại từ tháng hiện tại
        private int GetCurrentQuarter()
        {
            int currentMonth = DateTime.Now.Month;
            int currentQuarter = ((currentMonth - 1) / 3) + 1;
            return currentQuarter;
        }

        //Hàm GetCurrentWeek() sử dụng logic lấy vùng quốc gia của hệ thống vì một số quốc gia lấy ngày đầu tuần là CN, còn ở VN là T2
        private int GetCurrentWeek()
        {
            CultureInfo culture = CultureInfo.CurrentCulture;
            int currentWeek = culture.Calendar.GetWeekOfYear(DateTime.Now, culture.DateTimeFormat.CalendarWeekRule, culture.DateTimeFormat.FirstDayOfWeek);
            return currentWeek;
        }
        public class RevenueCalculator
        {
            // Kết nối đến cơ sở dữ liệu
            private string connectionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password;";


            public decimal CalculateRevenueByYear(int year)
            {
                decimal totalRevenueByYear = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT SUM(s.Price * id.Quantity) " +
                                                        "FROM InvoiceDetail id " +
                                                        "JOIN Invoices i ON id.InvoiceId = i.InvoiceId " +
                                                        "JOIN SellingPrice s ON id.BookId = s.BookId AND s.LastChangeDate = (SELECT MAX(LastChangeDate) FROM SellingPrice WHERE BookId = s.BookId AND LastChangeDate <= i.DateOfInvoice) " +
                                                        "WHERE YEAR(i.DateOfInvoice) = @Year", connection);

                    command.Parameters.AddWithValue("@Year", year);

                    totalRevenueByYear = (decimal)command.ExecuteScalar();

                    connection.Close();
                }

                return totalRevenueByYear;
            }

            public decimal CalculateRevenueByQuarter(int year, int quarter)
            {
                decimal totalRevenueByQuarter = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT SUM(s.Price * id.Quantity) " +
                                                        "FROM InvoiceDetail id " +
                                                        "JOIN Invoices i ON id.InvoiceId = i.InvoiceId " +
                                                        "JOIN SellingPrice s ON id.BookId = s.BookId AND s.LastChangeDate = (SELECT MAX(LastChangeDate) FROM SellingPrice WHERE BookId = s.BookId AND LastChangeDate <= i.DateOfInvoice) " +
                                                        "WHERE YEAR(i.DateOfInvoice) = @Year AND DATEPART(QUARTER, i.DateOfInvoice) = @Quarter", connection);

                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Quarter", quarter);

                    totalRevenueByQuarter = (decimal)command.ExecuteScalar();

                    connection.Close();
                }

                return totalRevenueByQuarter;
            }


            public decimal CalculateRevenueByMonth(int year, int month)
            {
                decimal totalRevenueByMonth = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT SUM(s.Price * id.Quantity) " +
                        "FROM InvoiceDetail id " +
                        "JOIN Invoices i ON id.InvoiceId = i.InvoiceId " +
                        "JOIN SellingPrice s ON id.BookId = s.BookId AND s.LastChangeDate = (SELECT MAX(LastChangeDate) FROM SellingPrice WHERE BookId = s.BookId AND LastChangeDate <= i.DateOfInvoice) " +
                        "WHERE YEAR(i.DateOfInvoice) = @Year AND MONTH(i.DateOfInvoice) = @Month", connection);

                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Month", month);

                    totalRevenueByMonth = (decimal)command.ExecuteScalar();

                    connection.Close();
                }

                return totalRevenueByMonth;
            }

            public decimal CalculateRevenueByWeek(int year, int week)
            {
                decimal totalRevenueByWeek = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT SUM(s.Price * id.Quantity) " +
                                                        "FROM InvoiceDetail id " +
                                                        "JOIN Invoices i ON id.InvoiceId = i.InvoiceId " +
                                                        "JOIN SellingPrice s ON id.BookId = s.BookId AND s.LastChangeDate = (SELECT MAX(LastChangeDate) FROM SellingPrice WHERE BookId = s.BookId AND LastChangeDate <= i.DateOfInvoice) " +
                                                        "WHERE YEAR(i.DateOfInvoice) = @Year AND DATEPART(WEEK, i.DateOfInvoice) = @Week", connection);

                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Week", week);

                    totalRevenueByWeek = (decimal)command.ExecuteScalar();

                    connection.Close();
                }

                return totalRevenueByWeek;
            }

            public List<string> Top3ByWeek(int year, int week)
            {
                List<string> top3Books = new List<string>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT TOP 3 b.Name " +
                                                        "FROM Books b " +
                                                        "JOIN InvoiceDetail id ON b.BookId = id.BookId " +
                                                        "JOIN Invoices i ON id.InvoiceId = i.InvoiceId " +
                                                        "WHERE YEAR(i.DateOfInvoice) = @Year AND DATEPART(WEEK, i.DateOfInvoice) = @Week " +
                                                        "GROUP BY b.Name " +
                                                        "ORDER BY SUM(id.Quantity) DESC", connection);

                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Week", week);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        top3Books.Add(reader.GetString(0));
                    }

                    connection.Close();
                }

                return top3Books;
            }

            public List<string> Top3ByMonth(int year, int month)
            {
                List<string> top3Books = new List<string>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT TOP 3 b.Name " +
                                                        "FROM Books b " +
                                                        "JOIN InvoiceDetail id ON b.BookId = id.BookId " +
                                                        "JOIN Invoices i ON id.InvoiceId = i.InvoiceId " +
                                                        "WHERE YEAR(i.DateOfInvoice) = @Year AND MONTH(i.DateOfInvoice) = @Month " +
                                                        "GROUP BY b.Name " +
                                                        "ORDER BY SUM(id.Quantity) DESC", connection);

                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Month", month);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        top3Books.Add(reader.GetString(0));
                    }

                    connection.Close();
                }

                return top3Books;
            }

            public List<string> Top3ByQuarter(int year, int quarter)
            {
                List<string> top3Books = new List<string>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT TOP 3 b.Name " +
                                                        "FROM Books b " +
                                                        "JOIN InvoiceDetail id ON b.BookId = id.BookId " +
                                                        "JOIN Invoices i ON id.InvoiceId = i.InvoiceId " +
                                                        "WHERE YEAR(i.DateOfInvoice) = @Year AND DATEPART(QUARTER, i.DateOfInvoice) = @Quarter " +
                                                        "GROUP BY b.Name " +
                                                        "ORDER BY SUM(id.Quantity) DESC", connection);

                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Quarter", quarter);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        top3Books.Add(reader.GetString(0));
                    }

                    connection.Close();
                }

                return top3Books;
            }

            public List<string> Top3ByYear(int year)
            {
                List<string> top3Books = new List<string>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT TOP 3 b.Name " +
                                                        "FROM Books b " +
                                                        "JOIN InvoiceDetail id ON b.BookId = id.BookId " +
                                                        "JOIN Invoices i ON id.InvoiceId = i.InvoiceId " +
                                                        "WHERE YEAR(i.DateOfInvoice) = @Year " +
                                                        "GROUP BY b.Name " +
                                                        "ORDER BY SUM(id.Quantity) DESC", connection);

                    command.Parameters.AddWithValue("@Year", year);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        top3Books.Add(reader.GetString(0));
                    }

                    connection.Close();
                }

                return top3Books;
            }
            public string StaffNameByWeek(int year, int week)
            {
                string employeeName = "";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT TOP 1 e.Name " +
                        "FROM Invoices i " +
                        "JOIN Employees e ON i.EmployeeId = e.EmployeeId " +
                        "WHERE DATEPART(YEAR, i.DateOfInvoice) = @Year AND DATEPART(WEEK, i.DateOfInvoice) = @Week " +
                        "GROUP BY e.Name " +
                        "ORDER BY COUNT(i.InvoiceId) DESC", connection);

                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Week", week);

                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        employeeName = result.ToString();
                    }

                    connection.Close();
                }

                return employeeName;
            }

            public string StaffNameByMonth(int year, int month)
            {
                string employeeName = "";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT TOP 1 e.Name " +
                        "FROM Invoices i " +
                        "JOIN Employees e ON i.EmployeeId = e.EmployeeId " +
                        "WHERE YEAR(i.DateOfInvoice) = @Year AND MONTH(i.DateOfInvoice) = @Month " +
                        "GROUP BY e.Name " +
                        "ORDER BY COUNT(i.InvoiceId) DESC", connection);

                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Month", month);

                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        employeeName = result.ToString();
                    }

                    connection.Close();
                }

                return employeeName;
            }
            public string StaffNameByQuarter(int year, int quarter)
            {
                string employeeName = "";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT TOP 1 e.Name " +
                        "FROM Invoices i " +
                        "JOIN Employees e ON i.EmployeeId = e.EmployeeId " +
                        "WHERE DATEPART(YEAR, i.DateOfInvoice) = @Year AND DATEPART(QUARTER, i.DateOfInvoice) = @Quarter " +
                        "GROUP BY e.Name " +
                        "ORDER BY COUNT(i.InvoiceId) DESC", connection);

                    command.Parameters.AddWithValue("@Year", year);
                    command.Parameters.AddWithValue("@Quarter", quarter);

                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        employeeName = result.ToString();
                    }

                    connection.Close();
                }

                return employeeName;
            }
            public string StaffNameByYear(int year)
            {
                string employeeName = "";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT TOP 1 e.Name " +
                        "FROM Invoices i " +
                        "JOIN Employees e ON i.EmployeeId = e.EmployeeId " +
                        "WHERE YEAR(i.DateOfInvoice) = @Year " +
                        "GROUP BY e.Name " +
                        "ORDER BY COUNT(i.InvoiceId) DESC", connection);

                    command.Parameters.AddWithValue("@Year", year);

                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        employeeName = result.ToString();
                    }

                    connection.Close();
                }

                return employeeName;
            }

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dashboard_Load(Object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSort.SelectedItem != null)
            {
                string selectedOption = cbSort.SelectedItem.ToString();
                RevenueCalculator revenueCalculator = new RevenueCalculator(); // Tạo một đối tượng RevenueCalculator
                if (selectedOption.StartsWith("Year"))
                {
                    int selectedYear = int.Parse(selectedOption.Split(' ')[1]);
                    decimal revenueByYear = revenueCalculator.CalculateRevenueByYear(selectedYear); // Gọi hàm tính doanh thu theo năm
                    bigLabel1.Text = revenueByYear.ToString("C");

                    List<string> top3BooksByYear = revenueCalculator.Top3ByYear(selectedYear);
                    DisplayTop3Books(top3BooksByYear);

                    string topEmployeeByYear = revenueCalculator.StaffNameByYear(selectedYear);
                    headerLabel6.Text = topEmployeeByYear;
                }
                else if (selectedOption.StartsWith("Month"))
                {
                    int selectedYear = int.Parse(selectedOption.Split(' ')[1]);
                    int selectedMonth = int.Parse(selectedOption.Split(' ')[3]);
                    decimal revenueByMonth = revenueCalculator.CalculateRevenueByMonth(selectedYear, selectedMonth); // Gọi hàm tính doanh thu theo tháng
                    bigLabel1.Text = revenueByMonth.ToString("C");

                    List<string> top3BooksByMonth = revenueCalculator.Top3ByMonth(selectedYear, selectedMonth);
                    DisplayTop3Books(top3BooksByMonth);

                    string topEmployeeByMonth = revenueCalculator.StaffNameByMonth(selectedYear, selectedMonth);
                    headerLabel6.Text = topEmployeeByMonth;
                }
                else if (selectedOption.StartsWith("Quarter"))
                {
                    int selectedYear = int.Parse(selectedOption.Split(' ')[1]);
                    int selectedQuarter = int.Parse(selectedOption.Split(' ')[3]);
                    decimal revenueByQuarter = revenueCalculator.CalculateRevenueByQuarter(selectedYear, selectedQuarter); // Gọi hàm tính doanh thu theo quý
                    bigLabel1.Text = revenueByQuarter.ToString("C");

                    List<string> top3BooksByQuarter = revenueCalculator.Top3ByQuarter(selectedYear, selectedQuarter);
                    DisplayTop3Books(top3BooksByQuarter);

                    string topEmployeeByQuarter = revenueCalculator.StaffNameByQuarter(selectedYear, selectedQuarter);
                    headerLabel6.Text = topEmployeeByQuarter;
                }
                else if (selectedOption.StartsWith("Week"))
                {
                    int selectedYear = int.Parse(selectedOption.Split(' ')[1]);
                    int selectedWeek = int.Parse(selectedOption.Split(' ')[3]);
                    decimal revenueByWeek = revenueCalculator.CalculateRevenueByWeek(selectedYear, selectedWeek); // Gọi hàm tính doanh thu theo tuần
                    bigLabel1.Text = revenueByWeek.ToString("C");

                    List<string> top3BooksByWeek = revenueCalculator.Top3ByWeek(selectedYear, selectedWeek);
                    DisplayTop3Books(top3BooksByWeek);

                    string topEmployeeByWeek = revenueCalculator.StaffNameByWeek(selectedYear, selectedWeek);
                    headerLabel6.Text = topEmployeeByWeek;
                }
            }
        }
        private void DisplayTop3Books(List<string> top3Books)
        {
            // Hiển thị top 3 sách lên các label tương ứng
            headerLabel3.Text = top3Books.Count > 0 ? top3Books[0] : "No data";
            headerLabel4.Text = top3Books.Count > 1 ? top3Books[1] : "No data";
            headerLabel5.Text = top3Books.Count > 2 ? top3Books[2] : "No data";
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void headerLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pbThumbnail_Click(object sender, EventArgs e)
        {

        }

        private void headerLabel2_Click(object sender, EventArgs e)
        {

        }

        private void headerLabel5_Click(object sender, EventArgs e)
        {

        }

        private void headerLabel7_Click(object sender, EventArgs e)
        {

        }
    }
}
