using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayRollAssignment
{
    public class ComissionEmployee : Employee
    {
        private float grossSales = 10000; 
        private float commissionRate;
        private string name;
        private string ssnNumber;
        public ComissionEmployee(string name, string ssnNumber) : base(name, ssnNumber)
        {
            name = this.name;
            ssnNumber = this.ssnNumber;


        }

        public override void personalInformation()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Comission  Employee : ");
            name = Console.ReadLine();


            Console.Write("Social Security Number : ");

            ssnNumber = Console.ReadLine();

            Console.WriteLine("Gross Sales : $" + grossSales);
           

            Console.Write("Comission rate : ");
            commissionRate = float.Parse(Console.ReadLine());
           
        }



        public override float calculateSalary()
        {

            return grossSales * commissionRate;
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
