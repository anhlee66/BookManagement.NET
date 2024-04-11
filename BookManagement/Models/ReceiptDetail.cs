using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    internal class ReceiptDetail
    {
        public ReceiptDetail() { }
        public ReceiptDetail(DataRow r) {
            this.receiptId = (int)r["ReceiptId"];
            this.bookId = (int)r["BookId"];
            this.quantity = (int)r["Quantity"];
        }
        private int receiptId { get; set; }
        private int bookId { get; set; }
        private int quantity { get; set; }
    }
}
