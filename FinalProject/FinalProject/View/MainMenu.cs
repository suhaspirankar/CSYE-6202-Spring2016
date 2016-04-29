using FinalProject.Model;
using FinalProject.Presenter;
using FinalProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject
{
    public partial class MainMenu : Form
    {
        User user;

        public MainMenu()
        {
            InitializeComponent();

            if (user.role == "Admin")
                addFlightButton.Visible = true;
            else
             addFlightButton.Visible = false;
 
        }


        public MainMenu(User user)
        {
            InitializeComponent();
            this.user = user;

            if (user.role == "Admin")
                addFlightButton.Visible = true;
            else
                addFlightButton.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // View Flight

            ViewFlights viewflights = new ViewFlights(user);
            ViewFlightPresenter viewFlightPresenter = new ViewFlightPresenter(viewflights);
            viewflights.AddPresenter(viewFlightPresenter);
            this.Hide();
            viewflights.Show();


        }

        private void bookFlight_Click(object sender, EventArgs e)
        {
            BookFlight bookFlight = new BookFlight(user);
           // ViewFlightPresenter viewFlightPresenter = new ViewFlightPresenter(viewflights);
          //  viewflights.AddPresenter(viewFlightPresenter);
            this.Hide();
            bookFlight.Show();
        }

        private void unBookFlight_Click(object sender, EventArgs e)
        {
            unBookFlight unBookFlight = new unBookFlight(user);
            // ViewFlightPresenter viewFlightPresenter = new ViewFlightPresenter(viewflights);
            //  viewflights.AddPresenter(viewFlightPresenter);
            this.Hide();
            unBookFlight.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ViewFlightInformation viewFlightInformation = new ViewFlightInformation(user);
            // ViewFlightPresenter viewFlightPresenter = new ViewFlightPresenter(viewflights);
            //  viewflights.AddPresenter(viewFlightPresenter);
            this.Hide();
            viewFlightInformation.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void addFlightButton_Click(object sender, EventArgs e)
        {
            AdminMenu m = new AdminMenu(user);
            this.Hide();
            m.Show();
        }
    }
}
