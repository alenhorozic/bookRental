using bookRental.Factory;
using System;

namespace bookRental
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var member = new Member();

            
            member.SetCommandOption(1 /*Add*/);
            member.SetBook(new Book("C# in NET Core", 350, "2021-01-15"));
            member.RunCommand();

            member.SetCommandOption(1 /*Add*/);
            member.SetBook(new Book("ASP.net", 478, "2021-02-05"));
            member.RunCommand();
            member.ShowRental();

            SetMemberCard("Free", "Student");

            member.SetCommandOption(2 /*Redo*/);
            member.RunCommand();
            member.ShowRental();

            SetMemberCard("Free", "Senior");

            member.SetCommandOption(3 /*Undo*/);
            member.RunCommand();
            member.ShowRental();

            SetMemberCard("Pay", "Adult");

            member.SetCommandOption(4 /*Clear*/);
            member.RunCommand();
            member.ShowRental();

            Console.ReadLine();
        }
        private static void SetMemberCard(string memberType, string memberFee)
        {
            var type = MemberCardFactory.CreateMemberCardFactory(memberType);
            var fee = type.GetMemberCard(memberFee);
            Console.WriteLine(fee.MemberCard() + "\n----------------------------------");
        }

    }
}
