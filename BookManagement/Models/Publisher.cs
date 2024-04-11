using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    internal class Publisher
    {
        public Publisher() { }
        public Publisher(DataRow r)
        {
            this.publisherId = (int)r["PublisherId"];
            this.name = (string)r["Name"];
            this.contact = (string)r["Contact"];
            this.description = (string)r["Description"];
        }
        public Publisher(int id,string name,string contact, string description ) {
            this.publisherId = id;
            this.name = name;
            this.contact = contact;
            this.description = description;
        }
        private int publisherId { get; set; }
        private string name { get; set; }
        private string contact { get; set; }
        private string description { get; set; }
    }
}
