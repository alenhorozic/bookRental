using System;
using System.Collections.Generic;
using System.Text;

namespace bookRental
{
    public interface ICommand
    {
        void Execute(Stack<Book> rental, Book newBook);
    }
}
