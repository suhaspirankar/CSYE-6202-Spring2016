using System;
using SimplePayRollAssignment;
using NUnit.Framework;
namespace TestCase
{


    [TestFixture]
    public class UnitTest1

    {

        #region calculateSalary Tests


        [Test]
        public void When_CalculateSalary_SalariedEmployee_ResultShouldBeEqualToWeeklyWage()
        {

            var expected = 8000;
            SalariedEmployee e1 = new SalariedEmployee("suhas", "155-22-2222");
            var actual = e1.calculateSalary();
            Assert.That(expected, Is.EqualTo(actual));
        }
        #endregion
    }

}
