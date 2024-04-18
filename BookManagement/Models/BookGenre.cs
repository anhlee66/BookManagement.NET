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
        public int genreId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
