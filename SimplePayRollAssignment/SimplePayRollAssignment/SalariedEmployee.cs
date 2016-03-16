using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayRollAssignment
{
    public class SalariedEmployee : Employee
    {
        private float salary = 8000;
        private float earned = 0.0f;
        private string name;
        private string ssnNumber;
        public SalariedEmployee(string  name, string ssnNumber ):base(name,ssnNumber)
		{

            name = this.name;
            ssnNumber = this.ssnNumber;          
        }
        
        public override void personalInformation()
        {

            Console.Write("Salaried Employee : ");
            name = Console.ReadLine();


            Console.Write("Social Security Number : ");

            ssnNumber = Console.ReadLine();

        }

        public override float calculateSalary()
        {
            Console.WriteLine("Weekly Salary : $" + salary);
            earned = salary;
            return earned;
            Console.WriteLine();
        }


    }
}
