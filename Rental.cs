using System;
using System.Collections.Generic;
using System.Linq;
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
                prod.DisplayBook();
            }

            if (!listOfbooks.Any())
            {
                Console.WriteLine("\n  And Clear List :(\n");
            }

            Console.WriteLine("*************************");
        }
    }
}
