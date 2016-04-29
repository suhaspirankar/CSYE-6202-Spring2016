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
    public partial class DeleteCrew : Form
    {
        User user;
        public DeleteCrew(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void label2_Click(object sender, EventArgs e)
        {
                    }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu m = new AdminMenu(user);
            this.Hide();
            m.Show();
        }

        private void deleteFlightButton_Click(object sender, EventArgs e)
        {

            if (crewIdTextBox.Text == "")
            {
                MessageBox.Show("Please enter Crew ID");

            }
            else
            {


                String crew_id = crewIdTextBox.Text;
                try
                {
                    MySqlConnection con = new MySqlConnection();
                    con.ConnectionString = "server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
                    con.Open();
                    string cmdText = "DELETE from flight_crew where  crew_id=" + crew_id + "";
                    MySqlCommand cmd = new MySqlCommand(cmdText, con);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Flight crew deleted Sucessfully");
                    con.Close();


                }
                catch (Exception e1)
                {
                    MessageBox.Show("Connection Refused to delete flight" + e1.ToString());


                }
            }


        }

        private void deleteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
