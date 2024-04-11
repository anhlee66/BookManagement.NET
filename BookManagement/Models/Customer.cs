using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    internal class Customer
    {
        public Customer() { }
        public Customer(DataRow r)
        {
            this.customerId = (int)r["CustomerId"];
            this.customerName = (string)r["Name"];
            this.phone = (string)r["Phone"];
            this.address = (string)r["Address"];
            this.gender = (int)r["Gender"];
        }
        public Customer(int id, string name, string phone, int gender, string address) {
            this.customerId = id;
            this.customerName = name;
            this.phone = phone;
            this.gender = gender;
            this.address = address;
        }
        private int customerId { get; set; }
        private string customerName { get; set; }
        private string phone { get; set; }
        private int gender { get;set; }
        private string address { get; set; }

    } 
}
