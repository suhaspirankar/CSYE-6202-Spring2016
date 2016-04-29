using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.View
{
    public partial class AdminMenu : Form
    {
        User user;
        public AdminMenu(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFlight addflight = new AddFlight(user);
            this.Hide();
            addflight.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu(user);
            this.Hide();
            m.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddFlightCrew adc = new AddFlightCrew(user);
            this.Hide();
            adc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteFlight df = new DeleteFlight(user);
            this.Hide();
            df.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DeleteCrew dc = new DeleteCrew(user);
            this.Hide();
            dc.Show();
        }
    }
}
