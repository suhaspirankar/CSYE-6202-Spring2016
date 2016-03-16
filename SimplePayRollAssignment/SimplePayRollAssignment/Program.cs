using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayRollAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {

            string name = "";
            string ssnNumber = "";
            SalariedEmployee e1 = new SalariedEmployee(name, ssnNumber);
            e1.personalInformation();
            Console.Write("Earned $" + e1.calculateSalary());

            HourlyEmployee e2 = new HourlyEmployee(name, ssnNumber);
            e2.personalInformation();
            Console.Write("Earned $" + e2.calculateSalary());


            ComissionEmployee e3 = new ComissionEmployee(name, ssnNumber);
            e3.personalInformation();
            Console.Write("Earned $" + e3.calculateSalary());


            BaseSalaryComissionEmployee e4 = new BaseSalaryComissionEmployee(name, ssnNumber);
            e4.personalInformation();
            Console.Write("Earned $" + e4.calculateSalary());

            Console.WriteLine();

            Console.Read();
        }
    }
}
