using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    internal class SellingPrice
    {
        public SellingPrice() { }
        public SellingPrice(DataRow r) {
            this.price = (int)r["Price"];
            this.date = (DateTime)r["LastDateChange"];
            this.bookId = (int)r["BookId"];
        }
        public SellingPrice(int bookId, DateTime date, int price)
        {
            this.bookId = bookId;
            this.date = date;
            this.price = price;
        }
        private int bookId { get; set; }
        private DateTime date { get; set; }
        private int price { get; set; }
    }
}
