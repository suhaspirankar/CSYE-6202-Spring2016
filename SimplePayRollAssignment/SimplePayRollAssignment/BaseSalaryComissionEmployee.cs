using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayRollAssignment
{
    class BaseSalaryComissionEmployee :Employee
    {
        private float grossSales;
        private float commissionRate;
        private float baseSalary=300;
        private float earned;
        private string name;
        private string ssnNumber;


        public BaseSalaryComissionEmployee(string name, string ssnNumber):base(name,ssnNumber)
		{
            name = this.name;
            ssnNumber = this.ssnNumber;

        }


       
             public override void personalInformation()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Base Salaried Comission  Employee : ");
            name = Console.ReadLine();


            Console.Write("Social Security Number : ");

            ssnNumber = Console.ReadLine();

            Console.Write("Gross Sales : $ ");
            grossSales = float.Parse(Console.ReadLine());
         //   Console.Write(grossSales);

            Console.Write("Comission rate : ");
            commissionRate = float.Parse(Console.ReadLine());
          //  Console.Write(commissionRate);
            Console.WriteLine("Base Salary : $" + baseSalary);


        }


        public override float calculateSalary()
        {
            earned = baseSalary+ grossSales * commissionRate;
            return earned;

        }


    }
}
