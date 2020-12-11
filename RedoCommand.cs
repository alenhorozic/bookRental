using System;
using System.Collections.Generic;
using System.Text;

namespace bookRental
{
    public class RedoCommand : ICommand
    {
        public void Execute(Stack<Book> books, Book newBook = null)
        {
            books.Push(books.Peek());
        }
    }
}
