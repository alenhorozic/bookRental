using System;
using System.Collections.Generic;
using System.Text;

namespace bookRental
{
    public class UndoCommand : ICommand
    {
        public void Execute(Stack<Book> books, Book newBook = null)
        {
            books.Pop();
        }
    }
}
