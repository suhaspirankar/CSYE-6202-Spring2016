using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
   public  interface ICalculatePrice
    {
        int CalculatePriceOfSeat(String seatClass);
    }
}
