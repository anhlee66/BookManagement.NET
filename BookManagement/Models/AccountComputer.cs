using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    internal class AccountComputer
    {
        public AccountComputer() { }
        public AccountComputer(DataRow r)
        {
            this.loginName = (string)r["AccountName"];
            this.password = (string)r["Password"];
            this.RoleId = (int)r["RoleId"];
            this.EmployeeId = (int)r["EmployeeId"];
        }
        public AccountComputer(string loginName, string password, int roleId, int id)
        {
            this.loginName = loginName;
            this.password = password;
            this.RoleId=roleId;
            this.EmployeeId = id;

        }
        public string loginName { get; set; }
        public string password { get; set; }
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
    }
}
