using System;
using System.Collections.Generic;
using System.Text;

namespace bookRental
{
    class Rental
    {
        public Stack<Book> listOfbooks { get; set; }

        public Rental()
        {
            listOfbooks = new Stack<Book>();
        }

        public void RunCommand(ICommand command, Book book)
        {
            command.Execute(listOfbooks, book);
        }

        public void ShowCurrentBooks()
        {
            foreach (var prod in listOfbooks)
            {
                prod.DisplayProduct();
            }

            if (!listOfbooks.Any())
            {
                Console.WriteLine("\nEmpty shopping list :(\n");
            }

            Console.WriteLine("----------------------------------");
        }
    }
}
