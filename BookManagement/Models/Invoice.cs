using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    internal class Invoice
    {
        public Invoice() { }
        public Invoice(DataRow r)
        {
            this.invoicedId = (int)r["InvoiceId"];
            this.date = (DateTime)r["DateOfInvoice"];
            this.customerId = (int)r["CustomerId"];
            this.employeeId = (int)r["EmployeeId"];
        }
        private int invoicedId { get; set; }
        private DateTime date { get; set; }
        private int customerId { get; set; }
        private int employeeId { get; set; }
    }
}
