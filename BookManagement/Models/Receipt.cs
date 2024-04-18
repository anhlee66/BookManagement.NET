using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    internal class Receipt
    {
        public Receipt() { }
        public Receipt(DataRow r)
        {
            this.receiptId = (int)r["ReceiptId"];
            this.date = (DateTime)r["DateOfReceipt"];
            this.supplerId = (int)r["SupplierId"];
            this.employeeId = (int)r["EmployeeId"];
        }
        public Receipt(int receiptId, DateTime date, int supplerId, int employeeId)
        {
            this.receiptId = receiptId;
            this.date = date;
            this.supplerId= supplerId;
            this.employeeId = employeeId;
        }
        private int receiptId { get; set; }
        private DateTime date { get; set; }
        private int supplerId { get; set; }
        private int employeeId { get; set; }
    }
}
