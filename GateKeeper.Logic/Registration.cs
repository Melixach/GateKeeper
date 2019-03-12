﻿using System;


namespace GateKeeper.Logic
{
    public class Registration
    {
        public Registration()
        {
        }

        const int AdultOvernightPrice = 50;
        const int MemberOvernightPrice = 45;
        const int YouthOvernightPrice = 35;
        const int ChildOvernightPrice = 10;
        const int AdultDaytripPrice = 25;
        const int MemberDaytripPrice = 20;
        const int YouthDaytripPrice = 10;
        const int ChildDaytripPrice = 5;
        const int LocalPrice = 5;
        const int NMRConversionPrice = 5;
        const int FeeReimbursmentPrice = 12;

        public int AdultOvernightCount { get; private set; }
        public int AdultOvernightTotalPrice { get; private set; }
        public int MemberOvernightCount { get; private set; }
        public int MemberOvernightTotalPrice { get; private set; }
        public int YouthOvernightCount { get; private set; }
        public int YouthOvernightTotalPrice { get; private set; }
        public int ChildOvernightCount { get; private set; }
        public int ChildOvernightTotalPrice { get; private set; }
        public int Under6OvernightCount { get; private set; }
        public int AdultDaytripCount { get; private set; }
        public int AdultDaytripTotalPrice { get; private set; }
        public int MemberDaytripCount { get; private set; }
        public int MemberDaytripTotalPrice { get; private set; }
        public int YouthDaytripCount { get; private set; }
        public int YouthDaytripTotalPrice { get; private set; }
        public int ChildDaytripCount { get; private set; }
        public int ChildDaytripTotalPrice { get; private set; }
        public int Under6DaytripCount { get; private set; }
        public int LocalCount { get; private set; }
        public int LocalTotalPrice { get; private set; }
        public int CompCount { get; private set; }
        public int NMRConversionCount { get; private set; }
        public int NMRConversionTotalPrice { get; private set; }
        public int DaytripConversionCount { get; private set; }
        public int FeeReimbursementTotalPrice { get; private set; }
        public int FeeReimbursementCount { get; private set; }
        public int TotalPrice { get; private set; }
        public int TotalCount { get; private set; }
        public DateTime ShiftStart { get; set; }

        public void AddAdultOvernight()
        {
            AdultOvernightCount++;
            AdultOvernightTotalPrice = AdultOvernightPrice * AdultOvernightCount;
            UpdateTotals();
        }

        public void SubtractAdultOvernight()
        {
            if (AdultOvernightCount > 0)
            {
                AdultOvernightCount--;
            }
            AdultOvernightTotalPrice = AdultOvernightPrice * AdultOvernightCount;
            UpdateTotals();
        }

        public void AddMemberOvernight()
        {
            MemberOvernightCount++;
            MemberOvernightTotalPrice = MemberOvernightPrice * MemberOvernightCount;
            UpdateTotals();
        }

        public void SubtractMemberOvernight()
        {
            if (MemberOvernightCount > 0)
            {
                MemberOvernightCount--;
            }
            MemberOvernightTotalPrice = MemberOvernightPrice * MemberOvernightCount;
            UpdateTotals();
        }

        public void AddYouthOvernight()
        {
            YouthOvernightCount++;
            YouthOvernightTotalPrice = YouthOvernightPrice * YouthOvernightCount;
            UpdateTotals();
        }

        public void SubtractYouthOvernight()
        {
            if (YouthOvernightCount > 0)
            {
                YouthOvernightCount--;
            }
            YouthOvernightTotalPrice = YouthOvernightPrice * YouthOvernightCount;
            UpdateTotals();
        }

        public void AddChildOvernight()
        {
            ChildOvernightCount++;
            ChildOvernightTotalPrice = ChildOvernightPrice * ChildOvernightCount;
            UpdateTotals();
        }

        public void SubtractChildOvernight()
        {
            if (ChildOvernightCount > 0)
            {
                ChildOvernightCount--;
            }
            ChildOvernightTotalPrice = ChildOvernightPrice * ChildOvernightCount;
            UpdateTotals();
        }

        public void AddUnder6Overnight()
        {
            Under6OvernightCount++;
            UpdateTotals();
        }

        public void SubtractUnder6Overnight()
        {
            if (Under6OvernightCount > 0)
            {
                Under6OvernightCount--;
            }
            UpdateTotals();
        }

        public void AddAdultDaytrip()
        {
            AdultDaytripCount++;
            AdultDaytripTotalPrice = AdultDaytripPrice * AdultDaytripCount;
            UpdateTotals();
        }

        public void SubtractAdultDaytrip()
        {
            if (AdultDaytripCount > 0)
            {
                AdultDaytripCount--;
            }
            AdultDaytripTotalPrice = AdultDaytripPrice * AdultDaytripCount;
            UpdateTotals();
        }

        public void AddMemberDaytrip()
        {
            MemberDaytripCount++;
            MemberDaytripTotalPrice = MemberDaytripPrice * MemberDaytripCount;
            UpdateTotals();
        }

        public void SubtractMemberDaytrip()
        {
            if (MemberDaytripCount > 0)
            {
                MemberDaytripCount--;
            }
            MemberDaytripTotalPrice = MemberDaytripPrice * MemberDaytripCount;
            UpdateTotals();
        }

        public void AddYouthDaytrip()
        {
            YouthDaytripCount++;
            YouthDaytripTotalPrice = YouthDaytripPrice * YouthDaytripCount;
            UpdateTotals();
        }

        public void SubtractYouthDaytrip()
        {
            if (YouthDaytripCount > 0)
            {
                YouthDaytripCount--;
            }
            YouthDaytripTotalPrice = YouthDaytripPrice * YouthDaytripCount;
            UpdateTotals();
        }

        public void AddChildDaytrip()
        {
            ChildDaytripCount++;
            ChildDaytripTotalPrice = ChildDaytripPrice * ChildDaytripCount;
            UpdateTotals();
        }

        public void SubtractChildDaytrip()
        {
            if (ChildDaytripCount > 0)
            {
                ChildDaytripCount--;
            }
            ChildDaytripTotalPrice = ChildDaytripPrice * ChildDaytripCount;
            UpdateTotals();
        }

        public void AddUnder6Daytrip()
        {
            Under6DaytripCount++;
            UpdateTotals();
        }

        public void SubtractUnder6Daytrip()
        {
            if (Under6DaytripCount > 0)
            {
                Under6DaytripCount--;
            }
            UpdateTotals();
        }

        public void AddLocalDaytrip()
        {
            LocalCount++;
            LocalTotalPrice = LocalPrice * LocalCount;
            UpdateTotals();
        }

        public void SubtractLocalDaytrip()
        {
            if (LocalCount > 0)
            {
                LocalCount--;
            }
            LocalTotalPrice = LocalPrice * LocalCount;
            UpdateTotals();
        }

        public void AddComp()
        {
            CompCount++;
            UpdateTotals();
        }

        public void SubtractComp()
        {
            if (CompCount > 0)
            {
                CompCount--;
            }
            UpdateTotals();
        }

        public void AddNMRConversion()
        {
            NMRConversionCount++;
            NMRConversionTotalPrice = NMRConversionPrice * NMRConversionCount;
            UpdateTotals();
        }

        public void SubtractNMRConversion()
        {
            if (NMRConversionCount > 0)
            {
                NMRConversionCount--;
            }
            NMRConversionTotalPrice = NMRConversionPrice * NMRConversionCount;
            UpdateTotals();
        }

        public void AddDaytripConversion()
        {
            DaytripConversionCount++;
            UpdateTotals();
        }

        public void SubtractDaytripConversion()
        {
            if (DaytripConversionCount > 0)
            {
                DaytripConversionCount--;
            }
            UpdateTotals();
        }

        public void AddFeeReimbursement()
        {
            FeeReimbursementCount++;
            FeeReimbursementTotalPrice = FeeReimbursmentPrice * FeeReimbursementCount;
            UpdateTotals();
        }

        public void SubtractFeeReimbursement()
        {
            if (FeeReimbursementCount > 0)
            {
                FeeReimbursementCount--;
            }
            FeeReimbursementTotalPrice = FeeReimbursmentPrice * FeeReimbursementCount;
            UpdateTotals();
        }

        public void FindTotalPrice()
        {
            TotalPrice = AdultOvernightTotalPrice + MemberOvernightTotalPrice + YouthOvernightTotalPrice +
            ChildOvernightTotalPrice + AdultDaytripTotalPrice + MemberDaytripTotalPrice + YouthDaytripTotalPrice + NMRConversionTotalPrice + LocalTotalPrice +
            ChildDaytripTotalPrice + FeeReimbursementTotalPrice;
        }

        public void FindTotalCount()
        {
            TotalCount = AdultOvernightCount + MemberOvernightCount + YouthOvernightCount +
            ChildOvernightCount + Under6OvernightCount + AdultDaytripCount + MemberDaytripCount + YouthDaytripCount +
            ChildDaytripCount + Under6DaytripCount + LocalCount + CompCount + NMRConversionCount + DaytripConversionCount + FeeReimbursementCount;
        }

        public void UpdateTotals()
        {
            FindTotalCount();
            FindTotalPrice();
        }

        public override string ToString()
        {
            return $"{ShiftStart}, {AdultOvernightCount}, {AdultOvernightTotalPrice}, {MemberOvernightCount}, {MemberOvernightTotalPrice}, {YouthOvernightCount}, {YouthOvernightTotalPrice}, {ChildOvernightCount}, {ChildOvernightTotalPrice}, {Under6OvernightCount}, {AdultDaytripCount}, {AdultDaytripTotalPrice}, {MemberDaytripCount}, {MemberDaytripTotalPrice}, {YouthDaytripCount}, {YouthDaytripTotalPrice}, {ChildDaytripCount}, {ChildDaytripTotalPrice}, {Under6DaytripCount}, {DaytripConversionCount}, {LocalCount}, {CompCount}, {NMRConversionCount}, {FeeReimbursementCount}, {FeeReimbursementTotalPrice}";
        }

        public string GetHeaders()
        {
            return "ShiftStart, AdultOvernightCount, AdultOvernightTotalPrice, MemberOvernightCount, MemberOvernightTotalPrice, YouthOvernightCount, YouthOvernightTotalPrice, ChildOvernightCount, ChildOvernightTotalPrice, Under6OvernightCount, AdultDaytripCount, AdultDaytripTotalPrice, MemberDaytripCount, MemberDaytripTotalPrice, YouthDaytripCount, YouthDaytripTotalPrice, ChildDaytripCount, ChildDaytripTotalPrice, Under6DaytripCount, DaytripConversionCount, LocalCount, CompCount, NMRConversionCount, FeeReimbursementCount, FeeReimbursementTotalPrice";
        }
    }
}