using FinalProject.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class User
    {
        public int user_id;
        public string firstName;
        public string lastName;
        public string userName;
        public string password;
        public string email;
        public string contactNumber;
        public string address;
        public string role;

        public SignUpPresenter Presenter { get; set; }

       public List<Flight> userFlights = new List<Flight>();

        public static bool validateFirstName()
        {
            
            return true; 
        }

    }
}
