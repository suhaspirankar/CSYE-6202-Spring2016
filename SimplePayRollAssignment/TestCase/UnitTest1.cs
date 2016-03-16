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


        #region ValidateEmptyName Tests
        [Test]
        public void When_UserNameIsEmpty_SalariedEmployee()
        {

            var e = true;
            var a = SalariedEmployee.UserEnteredEmptyName("");
            Assert.That(e, Is.EqualTo(a));
        }

        [Test]
        public void When_UserNameIsEmpty_HourlyEmployee()
        {

            var e = true;
            var a = HourlyEmployee.UserEnteredEmptyName("");
            Assert.That(e, Is.EqualTo(a));
        }

        [Test]
        public void When_UserNameIsEmpty_SaleCommssionEmployee()
        {

            var e = true;
            var a = ComissionEmployee.UserEnteredEmptyName("");
            Assert.That(e, Is.EqualTo(a));
        }

        [Test]
        public void When_UserNameIsEmpty_BaseSaleCommsionEmployee()
        {

            var e = true;
            var a = SalariedEmployee.UserEnteredEmptyName("");
            Assert.That(e, Is.EqualTo(a));
        }
        #endregion

        #region ValidateSSN Tests
        [Test]
        public void When_UserEnteredSSN_IsNotValid_SalariedEmployee()
        {
            var e = true;
            var a = SalariedEmployee.UserEnteredInvalidSSN(1212);
            Assert.That(e, Is.EqualTo(a));
        }

        [Test]
        public void When_UserEnteredSSN_IsNotValid_HourlyEmployee()
        {
            var e = true;
            var a = HourlyEmployee.UserEnteredInvalidSSN(1212);
            Assert.That(e, Is.EqualTo(a));
        }

        [Test]
        public void When_UserEnteredSSN_IsNotValid_CommissionSales()
        {
            var e = true;
            var a = ComissionEmployee.UserEnteredInvalidSSN(1212); 
            Assert.That(e, Is.EqualTo(a));
        }

        [Test]
        public void When_UserEnteredSSN_IsNotValid_SalaryBasedCommission()
        {
            var e = true;
            var a = SalariedEmployee.UserEnteredInvalidSSN(1212);
            Assert.That(e, Is.EqualTo(a));
        }
        #endregion
    }

}
