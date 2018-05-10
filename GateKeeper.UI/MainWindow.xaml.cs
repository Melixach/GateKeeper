using System.Windows;
using GateKeeper.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace GateKeeper.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Registration> registrations = new List<Registration>();
        private DateTime shiftTime = DateTime.Now;
        private Registration registration ;

        public MainWindow()
        {
            registration = new Registration { ShiftStart = shiftTime };
            InitializeComponent();
        }

        private void UpdateDisplay()
        {
            adultOvernightDisplay.Content = registration.AdultOvernightCount;
            memberOvernightDisplay.Content = registration.MemberOvernightCount;
            youthOvernightDisplay.Content = registration.YouthOvernightCount;
            childOvernightDisplay.Content = registration.ChildOvernightCount;
            under6OvernightDisplay.Content = registration.Under6OvernightCount;
            adultDaytripDisplay.Content = registration.AdultDaytripCount;
            memberDaytripDisplay.Content = registration.MemberDaytripCount;
            youthDaytripDisplay.Content = registration.YouthDaytripCount;
            childDaytripDisplay.Content = registration.ChildDaytripCount;
            under6DaytripDisplay.Content = registration.Under6DaytripCount;
            daytripConversionDisplay.Content = registration.DaytripConversionCount;
            localDisplay.Content = registration.LocalCount;
            compDisplay.Content = registration.CompCount;
            otherDisplay.Content = registration.NMRConversionCount;
            // displayTotalCount.Content = registration.TotalCount;
            displayTotalCount.Content = $"{registration.TotalCount} => ${registration.TotalPrice}";
           // displayTotalPrice.Content = registration.TotalPrice;

        }
        private void PerformRemoveAdultOvernight(object sender, EventArgs e)
        {
            registration.SubtractAdultOvernight();
            UpdateDisplay();
        }

        private void PerformAddAdultOvernight(object sender, RoutedEventArgs e)
        {
            registration.AddAdultOvernight();
            UpdateDisplay();
        }

        private void PerformMinusMemberOvernight(object sender, RoutedEventArgs e)
        {
            registration.SubtractMemberOvernight();
            UpdateDisplay();
        }

        private void PerformAddMemberOvernight(object sender, RoutedEventArgs e)
        {
            registration.AddMemberOvernight();
            UpdateDisplay();
        }

        private void PerformMinusYouthOvernightAction(object sender, RoutedEventArgs e)
        {
            registration.SubtractYouthOvernight();
            UpdateDisplay();
        }

        private void PerformAddYouthOvernightAction(object sender, RoutedEventArgs e)
        {
            registration.AddYouthOvernight();
            UpdateDisplay();
        }

        private void PerformMinusChildOvernight(object sender, RoutedEventArgs e)
        {
            registration.SubtractChildOvernight();
            UpdateDisplay();
        }

        private void PerformAddChildOvernight(object sender, RoutedEventArgs e)
        {
            registration.AddChildOvernight();
            UpdateDisplay();
        }

        private void PerformMinusUnder6Overnight(object sender, RoutedEventArgs e)
        {
            registration.SubtractUnder6Overnight();
            UpdateDisplay();
        }

        private void PerformAddUnder6Overnight(object sender, RoutedEventArgs e)
        {
            registration.AddUnder6Overnight();
            UpdateDisplay();
        }

        private void PerformMinusAdultDaytrip(object sender, RoutedEventArgs e)
        {
            registration.SubtractAdultDaytrip();
            UpdateDisplay();
        }

        private void PerformAddAdultDaytrip(object sender, RoutedEventArgs e)
        {
            registration.AddAdultDaytrip();
            UpdateDisplay();
        }

        private void PerformMinusMemberDaytrip(object sender, RoutedEventArgs e)
        {
            registration.SubtractMemberDaytrip();
            UpdateDisplay();
        }

        private void PerformAddMemberDaytrip(object sender, RoutedEventArgs e)
        {
            registration.AddMemberDaytrip();
            UpdateDisplay();
        }

        private void PerformMinusYouthDaytrip(object sender, RoutedEventArgs e)
        {
            registration.SubtractYouthDaytrip();
            UpdateDisplay();
        }

        private void PerformAddYouthDaytrip(object sender, RoutedEventArgs e)
        {
            registration.AddYouthDaytrip();
            UpdateDisplay();
        }

        private void PerformMinusChildDaytrip(object sender, RoutedEventArgs e)
        {
            registration.SubtractChildDaytrip();
            UpdateDisplay();
        }

        private void PerformAddChildDaytrip(object sender, RoutedEventArgs e)
        {
            registration.AddChildDaytrip();
            UpdateDisplay();
        }

        private void PerformMinusUnder6Daytrip(object sender, RoutedEventArgs e)
        {
            registration.SubtractUnder6Daytrip();
            UpdateDisplay();
        }

        private void PerformAddUnder6Daytrip(object sender, RoutedEventArgs e)
        {
            registration.AddUnder6Daytrip();
            UpdateDisplay();
        }

        private void PerformMinusDaytripConversion(object sender, RoutedEventArgs e)
        {
            registration.SubtractDaytripConversion();
            UpdateDisplay();
        }

        private void PerformAddDaytripConversion(object sender, RoutedEventArgs e)
        {
            registration.AddDaytripConversion();
            UpdateDisplay();
        }

        private void PerformMinusLocal(object sender, RoutedEventArgs e)
        {
            registration.SubtractLocalDaytrip();
            UpdateDisplay();
        }

        private void PerformAddLocalDaytrip(object sender, RoutedEventArgs e)
        {
            registration.AddLocalDaytrip();
            UpdateDisplay();
        }

        private void PerformMinusComp(object sender, RoutedEventArgs e)
        {
            registration.SubtractComp();
            UpdateDisplay();
        }

        private void PerformAddComp(object sender, RoutedEventArgs e)
        {
            registration.AddComp();
            UpdateDisplay();
        }

        private void PerformMinusNMRConversion(object sender, RoutedEventArgs e)
        {
            registration.SubtractNMRConversion();
            UpdateDisplay();
        }

        private void PerformAddNMRConversion(object sender, RoutedEventArgs e)
        {
            registration.AddNMRConversion();
            UpdateDisplay();
        }

        private void PerformAddFeeReimbursement(object sender, RoutedEventArgs e)
        {
            registration.AddFeeReimbursement();
            UpdateDisplay();
        }

        private void PerformMinusFeeReimbursement(object sender, RoutedEventArgs e)
        {
            registration.SubtractFeeReimbursement();
            UpdateDisplay();
        }

        private void PerformSubmitAction(object sender, RoutedEventArgs e)
        {
            registrations.Add(registration);
            var registrationText = registrations.Select(r => r.ToString());
            var jasonNeedsAName = string.Join("\n", registrationText);
            jasonNeedsAName = registration.GetHeaders() + "\n" + jasonNeedsAName;
            File.WriteAllText($"c:\\war\\registrations{shiftTime:yyyyMMddhhmm}.csv", jasonNeedsAName);
            PerformClearAction();
        }

        private void PerformClearAction(object sender, RoutedEventArgs e)
        {
            PerformClearAction();
        }

        private void PerformClearAction()
        {
            registration = new Registration();
            registration.ShiftStart = shiftTime;
            UpdateDisplay();
        }

        private void PerformSaveAction(object sender, RoutedEventArgs e)
        {
            shiftTime = DateTime.Now;
            PerformClearAction();
            registrations.Clear();
        }

        
    }
}
