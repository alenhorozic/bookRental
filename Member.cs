﻿using System;
using System.Collections.Generic;
using System.Text;

namespace bookRental
{
    class Member
    {
        private Book __book;
        private ICommand _command;
        private Rental _rental;

        public Member()
        {
            _rental = new Rental();
        }

        public void SetCommandOption(int option)
        {
            _command = CommandFactory.GetCommand(option);
        }

        public void SetProduct(Book book)
        {
            _book = book;
        }

        public void RunCommand()
        {
            _rental.RunCommand(_command, _book);
        }

        public void ShowOrder()
        {
            _rental.ShowCurrentProducts();
        }
    }
}
