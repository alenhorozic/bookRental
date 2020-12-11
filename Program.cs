using System;

namespace bookRental
{
    class Program
    {
        static void Main(string[] args)
        {
            //var user = new User();
            var member = new Member();

            //user.SetCommandOption(1 /*Add command*/);
            //user.SetProduct(new Product("Dining table", 1500, 1));
            //user.RunCommand();
            member.SetCommandOption(1 /*Add command*/);
            member.SetProduct(new Product("Dining table", 1500, 1));
            member.RunCommand();

            member.SetCommandOption(1 /*Add command*/);
            member.SetProduct(new Product("dishwasher", 6000, 1));
            member.RunCommand();
            member.ShowOrder();

            SetPayment("Debit", "MasterCard");

            member.SetCommandOption(2 /*Redo command*/);
            member.RunCommand();
            member.ShowOrder();

            SetPayment("Credit", "Visa");

            member.SetCommandOption(3 /*Undo command*/);
            member.RunCommand();
            member.ShowOrder();

            SetPayment("Debit", "Maestro");

            member.SetCommandOption(4 /*Clear command*/);
            member.RunCommand();
            member.ShowOrder();

            Console.ReadLine();
        }

        private static void SetPayment(string paymentType, string bankCard)
        {
            var type = PaymentFactory.CreatePaymentFactory(paymentType);
            var card = type.GetPayment(bankCard);
            Console.WriteLine(card.Payment() + "\n----------------------------------");
        }
    }
}
