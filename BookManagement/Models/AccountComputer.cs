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
            this.loginName = (string)r["LoginName"];
            this.password = (string)r["Password"];
        }
        public AccountComputer(string loginName, string password)
        {
            this.loginName = loginName;
            this.password = password;
        }
        private string loginName { get; set; }
        private string password { get; set; }
    }
}
