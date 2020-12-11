using System;
using System.Collections.Generic;
using System.Text;

namespace bookRental.Factory
{
    public abstract class MemberCardFactory
    {
        public abstract IMemberCard GetMemberCard(string memberType);

        public static MemberCardFactory CreateMemberCardFactory(string factoryType)
        {
            if (factoryType.ToLower() == "pay")
                return new PayFactory();

            return new FreeFactory();
        }
    }
}
