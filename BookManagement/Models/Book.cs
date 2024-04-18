using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    internal class Book
    {
        public Book() { }
        public Book(DataRow r)
        {
            this.bookId = (int)r["BookId"];
            this.name =(string) r["Name"];
            this.summary = (string)r["Summary"];
            this.quantity = (int)r["Quantity"];
            this.importPrice = (decimal)r["ImportPrice"];
            this.genre = (int)r["BookGenreId"];
            this.publisher = (int)r["PublisherId"];
            this.thumbnail = (string)r["Thumbnails"];

        }
        public Book(int id,string name, string summary, int quantity,
        int importPrice, int genre, int author, int publisher,string thumbnail)
        {
            this.bookId = id;
            this.name = name;
            this.summary = summary;
            this.quantity = quantity;
            this.importPrice = importPrice;
            this.genre = genre;
            this.publisher = publisher;
            this.thumbnail = thumbnail;

        }
        public int bookId { get; set; }
        public string name { get; set; }
        public int genre { get; set; }
        public string summary { get; set; }
        public int quantity { get; set; }
        public decimal importPrice { get; set; }
        public int publisher { get; set; }
        public string thumbnail { get; set; }
    }
}
