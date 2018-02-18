using System;

namespace GateKeeper.Logic
{
    public class Registration
    {
        public Registration()
        {
        }

        const double AdultOvernightPrice = 50.00;
        const double MemberOvernightPrice = 45.00;

        public int AdultOvernightCount { get; private set; }
        public double AdultOvernightTotalPrice { get; private set; }
        public int MemberOvernightCount { get; private set; }
        public double MemberOvernightTotalPrice { get; private set; }

        public void AddAdultOvernight()
        {
            AdultOvernightCount++;
            AdultOvernightTotalPrice = AdultOvernightPrice * AdultOvernightCount;
        }

        public void SubtractAdultOvernight()
        {
            if(AdultOvernightCount > 0)
            {
                AdultOvernightCount--;
            }
            else AdultOvernightCount = 0;
            AdultOvernightTotalPrice = AdultOvernightPrice * AdultOvernightCount;
        }

        public void AddMemberOvernight()
        {
            MemberOvernightCount++;
            MemberOvernightTotalPrice = MemberOvernightPrice * MemberOvernightCount;
        }

        public void SubtractMemberOvernight()
        {
            if (MemberOvernightCount > 0)
            {
                MemberOvernightCount--;
            }
            else MemberOvernightCount = 0;
            MemberOvernightTotalPrice = MemberOvernightPrice * MemberOvernightCount;
        }
    }
}