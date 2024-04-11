using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    internal class Composition
    {
        public Composition() { }   
        public Composition(DataRow r) {
            this.bookId = (int)r["BookId"];
            this.authorId = (int)r["AuthorId"];
        }
        public Composition(int bookId, int authorId)
        {
            this.bookId = bookId;
            this.authorId = authorId;
        }
        private int bookId { get; set; }
        private int authorId { get; set; }
    }
}
