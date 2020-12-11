using bookRental.MemberCard;
using System;
using System.Collections.Generic;
using System.Text;

namespace bookRental.Factory
{
    public class FreeFactory : MemberCardFactory
    {
        public override IMemberCard GetMemberCard(string memberType)
        {
            if (memberType.ToLower() == "student")
            {
                return new Student();
            }
            else if (memberType.ToLower() == "senior")
            {
                return new Senior();
            }

            return null;
        }
    }
}
