using bookRental.MemberCard;
using System;
using System.Collections.Generic;
using System.Text;

namespace bookRental.Factory
{
    public class PayFactory : MemberCardFactory
    {
        public override IMemberCard GetMemberCard(string memberType)
        {
            if (memberType.ToLower() == "adult")
                return new Adult();

            return null;
        }
    }
}
