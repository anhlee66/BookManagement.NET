using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    internal class InvoiceDetail
    {
        public InvoiceDetail() { }
        public InvoiceDetail(DataRow r) {
            this.invoiceId = (int)r["InvoiceId"];
            this.bookId = (int)r["BookId"];
            this.quantity = (int)r["Quantity"];
        }
        public InvoiceDetail(int id,int bookId, int quantity) 
        {
            this.invoiceId = id;
            this.bookId = bookId;
            this.quantity = quantity;
        }
    
        private int invoiceId { get; set; }
        private int bookId { get; set; }
        private int quantity { get; set; }

    }
}
