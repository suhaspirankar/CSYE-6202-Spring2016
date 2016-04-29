using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject.Presenter
{
    public class DemoPresenter
    {
        private Flight flight;
        private Login login;

        public DemoPresenter(Flight flight, Login login)
        {
            this.flight = flight;
            this.login = login;

            login.Presenter = this;
        }  

        public void onSubmit()
        {


        }
    }
}
