using System;
using System.Collections.Generic;
using System.Text;

namespace bookRental.MemberCard
{
    public class Senior : IMemberCard
    {
        public string MemberCard()
        {
            return "MemberCard: Senior (Free)";
        }
    }
}
