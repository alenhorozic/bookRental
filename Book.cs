using System;
using System.Collections.Generic;
using System.Text;

namespace bookRental
{
    public class Book
    {
        public string Titel { get; set; }
        public int Pages { get; set; }
        public string Autor { get; set; }
        public string ReturDate { get; set; }

        public Book(string titel, string autor, int pages, string returDate)
        {
            Titel = titel;
            Autor = autor;
            Pages = pages;
            ReturDate = returDate;
        }

        public void DisplayBook()
        {
            Console.WriteLine($"\n Name: {Titel}");
            Console.WriteLine($" Autor: {Autor}");
            Console.WriteLine($" Pages: {Pages}");
            Console.WriteLine($" ReturDate: {ReturDate}");
        }
    }
}
