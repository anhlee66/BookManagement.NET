using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    internal class BookGenre
    {
        public BookGenre() { }
        public BookGenre(DataRow r) {
            this.genreId = (int)r["BookGenreId"];
            this.name = (string)r["Name"];
            this.description = (string)r["Description"];
        }
        public BookGenre(int id,string name,string description) {
            this.genreId = id;
            this.name = name;
            this.description = description;
        }
        private int genreId { get; set; }
        private string name { get; set; }
        private string description { get; set; }
    }
}
