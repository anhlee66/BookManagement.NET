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
        public int publisherId { get; set; }
        public string name { get; set; }
        public string contact { get; set; }
        public string description { get; set; }
    }
}
