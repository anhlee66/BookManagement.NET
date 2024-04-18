using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    internal class Employee
    {
        public Employee() { }
        public Employee(DataRow r)
        {
            this.employeeId = (int)r["EmployeeId"];
            this.name = (string)r["Name"];
            this.gender = (int)r["Gender"];
            this.address = (string)r["Address"];
            this.phone = (string)r["phone"];
            this.role = (string)r["Role"];
        }
        public Employee(int id,string name, int gender, string address, string phone, string role)
        {
            this.employeeId = id;
            this.name = name;
            this.gender = gender;
            this.address = address;
            this.phone = phone;
            this.role = role;
        }
        public int employeeId { get; set; }
        public string name { get; set; }
        public int gender { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string role { get; set; }
       
    }
}
