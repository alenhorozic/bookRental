using System;
using System.Collections.Generic;
using System.Text;

namespace bookRental.MemberCard
{
    public class Student : IMemberCard
    {
        public string MemberCard()
        {
            return "MemberCard: Student (Free)";
        }
    }
}
