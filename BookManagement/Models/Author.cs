using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    internal class Author
    {
        public Author() { }
        public Author(DataRow r) 
        {
            this.authorId = (int)r["AuthorId"];
            this.name = (string)r["Name"];
            this.contact = (string)r["Contact"];
            this.description = (string)r["Description"];

        }
        public Author(int id,string name,string contact, string description) 
        {
            this.authorId = id;
            this.name = name;
            this.contact = contact;
            this.description = description;
        }
        public int authorId { get; set; }
        public string name { get; set; }
        public string contact { get; set; }
        public string description {  get; set; }   
    }   
}
