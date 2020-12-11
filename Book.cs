using System;
using System.Collections.Generic;
using System.Text;

namespace bookRental
{
    class Book
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public Book(string name, decimal price, int amount)
        {
            Name = name;
            Price = price;
            Amount = amount;
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"\nName: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Amount: {Amount}");
        }
    }
}
