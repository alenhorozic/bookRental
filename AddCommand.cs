using System;
using System.Collections.Generic;
using System.Text;

namespace bookRental
{
    public class AddCommand : ICommand
    {
        public void Execute(Stack<Book> books, Book newBook)
        {
            books.Push(newBook);
        }
    }
}
