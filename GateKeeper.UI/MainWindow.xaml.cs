using System.Windows;
using GateKeeper.Logic;
using System;
using System.Collections.Generic;

namespace GateKeeper.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Registration> registrations = new List<Registration>();
        private Registration registration = new Registration();

        public MainWindow()
        {
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

        }
        private void PerformRemoveAdultOvernight(object sender, EventArgs e)
        {
            registration.SubtractAdultOvernight();
            UpdateDisplay();
        }

        private void PerformSubmit(object sender, EventArgs e)
        {
            // registration.TimeStamp = DateTime.Now;
            registrations.Add(registration);
            registration = new Registration();
            //TODO: update UI
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
            registration.SubtractYouthOvernight();
            UpdateDisplay();
        }
    }
}
