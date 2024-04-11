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
            this.importPrice = (int)r["Price"];
            this.genre = (int)r["Genre"];
            this.author = (int)r["Author"];
            this.publisher = (int)r["Publisher"];
            this.supplier = (int)r["Supplier"];

        }
        public Book(int id,string name, string summary, int quantity,
        int importPrice, int genre, int author, int publisher,int supplier)
        {
            this.bookId = id;
            this.name = name;
            this.summary = summary;
            this.quantity = quantity;
            this.importPrice = importPrice;
            this.genre = genre;
            this.author = author;
            this.publisher = publisher;
            this.supplier = supplier;

        }
        private int bookId { get; set; }
        private string name { get; set; } 
        private int genre { get; set; } 
        private string summary { get; set; } 
        private int quantity { get; set; } 
        private int importPrice { get; set; } 
        private int author { get; set; } 
        private int publisher { get; set; } 
        private int supplier { get; set; }
    }
}
