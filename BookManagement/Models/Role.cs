using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    internal class Role
    {
        public Role() { }
        public Role(DataRow r) {
            this.roleId = (int)r["RoleId"];
            this.roleName = (string)r["Name"];
            this.description = (string)r["Description"];
        }
        private int roleId { get; set; }
        private string roleName { get; set; }
        private string description { get; set; }
    }
}
