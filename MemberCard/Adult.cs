using System;
using System.Collections.Generic;
using System.Text;

namespace bookRental.MemberCard
{
    public class Adult : IMemberCard
    {
        public string MemberCard()
        {
            return "MemberCard: Adult (Pey)";
        }
    }
}
