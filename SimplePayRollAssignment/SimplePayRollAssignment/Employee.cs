using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePayRollAssignment
{
   public  abstract class Employee   :  IEmployee
    {    
        private string name;
        private string ssnNumber;
        public Employee(string name, string ssnNumber)
        {
            name = this.name;
            ssnNumber = this.ssnNumber;
        }

        public abstract void personalInformation();
        public abstract float calculateSalary();


    }
}
