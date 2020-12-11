using System;
using System.Collections.Generic;
using System.Text;

namespace bookRental
{
    public class Book
    {
        public string Titel { get; set; }
        public int Pages { get; set; }
        public string ReturDate { get; set; }

        public Book(string titel, int pages, string returDate)
        {
            Titel = titel;
            Pages = pages;
            ReturDate = returDate;
        }

        public void DisplayBook()
        {
            Console.WriteLine($"\nName: {Titel}");
            Console.WriteLine($"Price: {Pages}");
            Console.WriteLine($"Amount: {ReturDate}");
        }
    }
}
