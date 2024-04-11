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
        private int authorId { get; set; }
        private string name { get; set; }
        private string contact { get; set; }
        private string description {  get; set; }   
    }   
}
