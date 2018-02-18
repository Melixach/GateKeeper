using System;

namespace GateKeeper.Logic
{
    public class Registration
    {
        public Registration()
        {
        }

        const int AdultOvernightPrice = 50;
        const int MemberOvernightPrice = 45;
        const int TeenOvernightPrice = 35;
        const int ChildOvernightPrice = 10;
        const int AdultDaytripPrice = 25;
        const int MemberDaytripPrice = 20;
        const int TeenDaytripPrice = 10;
        const int ChildDaytripPrice = 5;

        public int AdultOvernightCount { get; private set; }
        public int AdultOvernightTotalPrice { get; private set; }
        public int MemberOvernightCount { get; private set; }
        public int MemberOvernightTotalPrice { get; private set; }
        public int TeenOvernightCount { get; private set; }
        public int TeenOvernightTotalPrice { get; private set; }
        public int ChildOvernightCount { get; private set; }
        public int ChildOvernightTotalPrice { get; private set; }
        public int Under6OvernightCount { get; private set; }
        public int AdultDaytripCount { get; private set; }
        public int AdultDaytripTotalPrice { get; private set; }
        public int MemberDaytripCount { get; private set; }
        public int MemberDaytripTotalPrice { get; private set; }
        public int TeenDaytripCount { get; private set; }
        public int TeenDaytripTotalPrice { get; private set; }
        public int ChildDaytripCount { get; private set; }
        public int ChildDaytripTotalPrice { get; private set; }
        public int Under6DaytripCount { get; private set; }
        public int LocalCount { get; private set; }
        public int CompCount { get; private set; }
        public int OtherCount { get; private set; }
        public int DaytripConversionCount { get; private set; }
        public int TotalCount { get; private set; }
        public int TotalPrice { get; private set; }

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
            MemberOvernightTotalPrice = MemberOvernightPrice * MemberOvernightCount;
        }

        public void AddTeenOvernight()
        {
            TeenOvernightCount++;
            TeenOvernightTotalPrice = TeenOvernightPrice * TeenOvernightCount;
        }

        public void SubtractTeenOvernight()
        {
            if (TeenOvernightCount > 0)
            {
                TeenOvernightCount--;
            }
            TeenOvernightTotalPrice = TeenOvernightPrice * TeenOvernightCount;
        }

        public void AddChildOvernight()
        {
            ChildOvernightCount++;
            ChildOvernightTotalPrice = ChildOvernightPrice * ChildOvernightCount;
        }

        public void SubtractChildOvernight()
        {
            if (ChildOvernightCount > 0)
            {
                ChildOvernightCount--;
            }
            ChildOvernightTotalPrice = ChildOvernightPrice * ChildOvernightCount;
        }

        public void AddUnder6Overnight()
        {
            Under6OvernightCount++;
        }

        public void SubtractUnder6Overnight()
        {
            if (Under6OvernightCount > 0)
            {
                ChildOvernightCount--;
            }
        }

        public void AddAdultDaytrip()
        {
            AdultDaytripCount++;
            AdultDaytripTotalPrice = AdultDaytripPrice * AdultDaytripCount;
        }

        public void SubtractAdultDaytrip()
        {
            if (AdultDaytripCount > 0)
            {
                AdultDaytripCount--;
            }
            AdultDaytripTotalPrice = AdultDaytripPrice * AdultDaytripCount;
        }

        public void AddMemberDaytrip()
        {
            MemberDaytripCount++;
            MemberDaytripTotalPrice = MemberDaytripPrice * MemberDaytripCount;
        }

        public void SubtractMemberDaytrip()
        {
            if (MemberDaytripCount > 0)
            {
                MemberDaytripCount--;
            }
            MemberDaytripTotalPrice = MemberDaytripPrice * MemberDaytripCount;
        }

        public void AddTeenDaytrip()
        {
            TeenDaytripCount++;
            TeenDaytripTotalPrice = TeenDaytripPrice * TeenDaytripCount;
        }

        public void SubtractTeenDaytrip()
        {
            if (TeenDaytripCount > 0)
            {
                TeenDaytripCount--;
            }
            TeenDaytripTotalPrice = TeenDaytripPrice * TeenDaytripCount;
        }

        public void AddChildDaytrip()
        {
            ChildDaytripCount++;
            ChildDaytripTotalPrice = ChildDaytripPrice * ChildDaytripCount;
        }

        public void SubtractChildDaytrip()
        {
            if (ChildDaytripCount > 0)
            {
                ChildDaytripCount--;
            }
            ChildDaytripTotalPrice = ChildDaytripPrice * ChildDaytripCount;
        }

        public void AddUnder6Daytrip()
        {
            Under6DaytripCount++;
        }

        public void SubtractUnder6hildDaytrip()
        {
            if (ChildDaytripCount > 0)
            {
                ChildDaytripCount--;
            }
        }

        public void AddLocalDaytrip()
        {
            LocalCount++;
        }

        public void SubtractLocalDaytrip()
        {
            if (LocalCount > 0)
            {
                LocalCount--;
            }
        }

        public void AddCompCount()
        {
            CompCount++;
        }

        public void SubtractCompCount()
        {
            if (CompCount > 0)
            {
                CompCount--;
            }
        }

        public void AddOtherCount()
        {
            OtherCount++;
        }

        public void SubtractOtherCount()
        {
            if (OtherCount > 0)
            {
                OtherCount--;
            }
        }

        public void AddDaytripConversion()
        {
            DaytripConversionCount++;
        }

        public void SubtractDaytripConversionCount()
        {
            if (DaytripConversionCount > 0)
            {
                DaytripConversionCount--;
            }
        }

        public void FindTotalCount()
        {
            TotalCount = AdultOvernightCount + MemberOvernightCount + TeenOvernightCount +
                  ChildOvernightCount + Under6OvernightCount + AdultDaytripCount +
                  MemberDaytripCount + TeenDaytripCount + ChildDaytripCount + Under6DaytripCount +
                  LocalCount + CompCount + OtherCount + DaytripConversionCount; }




        public void FindTotalPrice()
        {
            TotalPrice = AdultOvernightTotalPrice + MemberOvernightTotalPrice + TeenOvernightTotalPrice +
            ChildOvernightTotalPrice + AdultDaytripTotalPrice + MemberDaytripTotalPrice + TeenDaytripTotalPrice +
            ChildDaytripTotalPrice;
         }
        
    }
}