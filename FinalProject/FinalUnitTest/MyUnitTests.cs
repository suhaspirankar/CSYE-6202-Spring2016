using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalProject.Model;
using NUnit.Framework;
using FinalProject.View;

namespace FinalUnitTest
{
    [TestFixture]
    public class MyUnitTests
    {
        [Test]
        public void TestThePriceOfEachBusinessSeatInTheFlight()
        { 
            User user=new User();
            ICalculatePrice seat = new BookFlight(user);
            var price = seat.CalculatePriceOfSeat("Business");
            NUnit.Framework.Assert.That(35000, Is.EqualTo(price));
        }
        [Test]
        public void TestThePriceOfEachEconomyPlusSeatInTheFlight()
        {
            User user = new User();
            ICalculatePrice seat = new BookFlight(user);
            var price = seat.CalculatePriceOfSeat("Economy Plus");
            NUnit.Framework.Assert.That(25000, Is.EqualTo(price));
        }
        [Test]
        public void TestThePriceOfEachEconomySeatInTheFlight()
        {
            User user = new User();
            ICalculatePrice seat = new BookFlight(user);
            var price = seat.CalculatePriceOfSeat("Economy");
            NUnit.Framework.Assert.That(15000, Is.EqualTo(price));
        }
    }
}
