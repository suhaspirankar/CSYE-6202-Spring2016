using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayRollAssignment
{
    public class HourlyEmployee : Employee
    {


        private float hourlyWage = 16.75f;
        private float hoursWorked = 0;
        private float totalEarned = 0.0f;
        private string name;
        private string ssnNumber;
        public HourlyEmployee(string name, string ssnNumber) : base(name, ssnNumber)
        {

            name = this.name;
            ssnNumber = this.ssnNumber;

        }

        public override void personalInformation()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Hourly Employee : ");
            name = Console.ReadLine();


            Console.Write("Social Security Number : ");

            ssnNumber = Console.ReadLine();



            Console.Write("Hourly Wage : " + hourlyWage + ";  Hours Worked : " + hoursWorked);
            hoursWorked = float.Parse(Console.ReadLine());


        }
        public override float calculateSalary()
        {
            totalEarned = hoursWorked * hourlyWage;
            return totalEarned;
            Console.WriteLine();
        }


        public static bool UserEnteredEmptyName(string name)
        {
            bool result = false;
            if (name.Length.Equals(0))
            {
                result = true;
            }
            return result;
        }

        public static bool UserEnteredInvalidSSN(int ssn)
        {
            bool result = false;
            if (ssn.ToString().Length.Equals(9))
            {
                result = false;
            }
            else {
                result = true;
            }
            return result;
        }
    }
}
