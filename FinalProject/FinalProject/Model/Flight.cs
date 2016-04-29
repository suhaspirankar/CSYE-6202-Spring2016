using FinalProject.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class Flight
    {
        public int flight_id { get; set; }
        public string flight_name { get; set; }
        public DateTime departure_Time { get; set; }
        public DateTime arrival_Time { get; set; }
        public string carrier { get; set; }
        public string seatClass { get; set; }
        public double prices { get; set; }
         
        public List<User> listOfPassengers = new List<User>();
        public List<User> listOfCrew = new List<User>();

        public ViewFlightPresenter viewFlightPresenter { get; set; }
    }
}
 