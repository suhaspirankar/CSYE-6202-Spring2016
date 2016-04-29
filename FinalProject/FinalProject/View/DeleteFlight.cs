using FinalProject.Model;
using MySql.Data.MySqlClient;
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
    public partial class DeleteFlight : Form
    {
        User user;

        public DeleteFlight(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void DeleteFlight_Load(object sender, EventArgs e)
        {

        }

        private void deleteFlightButton_Click(object sender, EventArgs e)
        {
            if (deleteTextBox.Text == "")
            {
                MessageBox.Show("Please enter Flight ID");

            }
            else
            {


                String flight_id = deleteTextBox.Text;
                try
                {
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = "server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
                    con.Open();
                    string cmdText = "DELETE from flight where  flight_id=" + flight_id + "";
                    MySqlCommand cmd = new MySqlCommand(cmdText, con);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Flight unBooked Sucessfully");
                    con.Close();

                }
                catch (Exception e1)
                {
                    MessageBox.Show("Connection Refused to Book flight" + e1.ToString());


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu m = new AdminMenu(user);
            this.Hide();
            m.Show();
        }
    }
}
