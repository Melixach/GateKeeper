using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GateKeeper
{
    [TestClass]
    public class RegistrationTests
    {
        [TestMethod]
        public void AdultOvernightStartsAtZero()
        {
            var registration = new GateKeeper.Logic.Registration();
            Assert.AreEqual(0, registration.AdultOvernightCount);
        }

        [TestMethod]
        public void AdultOvernightRegistrationPriceAtZero()
        {
            var registration = new GateKeeper.Logic.Registration();
            Assert.AreEqual(0, registration.AdultOvernightTotalPrice);
        }

        [TestMethod]
        public void addAdultOvernightIncrementsAdultOvernightCount()
        {
            var registration = new GateKeeper.Logic.Registration();
            registration.AddAdultOvernight();
            Assert.AreEqual(1, registration.AdultOvernightCount);
        }

        [TestMethod]
        public void addAdultOvernightIncrementsAdultOvernightCountTwiceReturnsTwo()
        {
            var registration = new GateKeeper.Logic.Registration();
            registration.AddAdultOvernight();
            registration.AddAdultOvernight();
            Assert.AreEqual(2, registration.AdultOvernightCount);
        }

        [TestMethod]
        public void addAdultOvernightSetsAdultOverNightPriceToCostOfSingleOvernight()
        {
            var registration = new GateKeeper.Logic.Registration();
            registration.AddAdultOvernight();
            Assert.AreEqual(50, registration.AdultOvernightTotalPrice);
        }

        [TestMethod]
        public void SubtractAdultOvernightdeccrimentsAdultOvernightCount()
        {
            var registration = new GateKeeper.Logic.Registration();
            registration.AddAdultOvernight();
            registration.SubtractAdultOvernight();
            Assert.AreEqual(0, registration.AdultOvernightCount);
        }

        [TestMethod]
        public void SubtractAdultOvernightdeccrimentsAdultOvernightCountButNotBelowZero()
        {
            var registration = new GateKeeper.Logic.Registration();
            registration.SubtractAdultOvernight();
            Assert.AreEqual(0, registration.AdultOvernightCount);
        }

        [TestMethod]
        public void SubtractAdultOvernightRemovesAdultOverNightPriceToCostOfSingleOvernight()
        {
            var registration = new GateKeeper.Logic.Registration();
            registration.AddAdultOvernight();
            registration.AddAdultOvernight();
            registration.SubtractAdultOvernight();
            Assert.AreEqual(50, registration.AdultOvernightTotalPrice);
        }

        [TestMethod]
        public void AddThreeMemberOvernightsAndSubtractOneEquals90()
        {
            var registration = new GateKeeper.Logic.Registration();
            registration.AddMemberOvernight();
            registration.AddMemberOvernight();
            registration.AddMemberOvernight();
            registration.SubtractMemberOvernight();
            Assert.AreEqual(90, registration.MemberOvernightTotalPrice);
        }

        [TestMethod]
        public void SubtractoneTeenandAddTwoTeensEquals70()
        {
            var registration = new GateKeeper.Logic.Registration();
            registration.SubtractMemberOvernight();
            registration.AddYouthOvernight();
            registration.AddYouthOvernight();
            Assert.AreEqual(70, registration.YouthOvernightTotalPrice);
        }

        [TestMethod]
        public void AddTwoMemberOvernightsAndOneTeenEquals125()
        {
            var registration = new GateKeeper.Logic.Registration();
            registration.AddMemberOvernight();
            registration.AddMemberOvernight();
            registration.AddYouthOvernight();
            Assert.AreEqual(125, registration.MemberOvernightTotalPrice + registration.YouthOvernightTotalPrice);
        }

        [TestMethod]
        public void AddTwoMemberOvernightsAndThreeChildOvernightEquals120()
        {
            var registration = new GateKeeper.Logic.Registration();
            registration.AddMemberOvernight();
            registration.AddMemberOvernight();
            registration.AddChildOvernight();
            registration.AddChildOvernight();
            registration.AddChildOvernight();
            Assert.AreEqual(120, registration.MemberOvernightTotalPrice + registration.ChildOvernightTotalPrice);
        }

        [TestMethod]
        public void AddTwoAdultOvernightOneChildOvernightAndOneUnder6Equals110()
        {
            var registration = new GateKeeper.Logic.Registration();
            registration.AddAdultOvernight();
            registration.AddAdultOvernight();
            registration.AddChildOvernight();
            registration.AddUnder6Overnight();
            registration.FindTotalPrice();
            Assert.AreEqual(110, registration.TotalPrice);
        }


        [TestMethod]
        public void AddTwoAdultDaytripSubtractOneAndAddTwoEquals75()
        {
            var registration = new GateKeeper.Logic.Registration();
            registration.AddAdultDaytrip();
            registration.AddAdultDaytrip();
            registration.SubtractAdultDaytrip();
            registration.AddAdultDaytrip();
            registration.AddAdultDaytrip();
            registration.FindTotalPrice();
            Assert.AreEqual(75, registration.TotalPrice);
        }

        [TestMethod]
        public void AddOneMemberDaytripOneTeenDaytripTwoChildDaytripandOneUnder6DaytripEquals40()
        {
            var registration = new GateKeeper.Logic.Registration();
            registration.AddMemberDaytrip();
            registration.AddYouthDaytrip();
            registration.AddChildDaytrip();
            registration.AddChildDaytrip();
            registration.AddUnder6Daytrip();
            registration.FindTotalPrice();
            Assert.AreEqual(40, registration.TotalPrice);
        }
    }
}
