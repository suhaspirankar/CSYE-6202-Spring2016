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
    public partial class AddFlightCrew : Form
    {
        User user;
        public AddFlightCrew( User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
                con.Open();
                string cmdText = "INSERT INTO flight_crew(crew_id  ,firstName ,lastName  , email  ,contactNumber  ,address  ,flight_id  ) values (@crew_id  ,@firstName ,@lastName  , @email  ,@contactNumber  ,@address  ,@flight_id )";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);

                cmd.Parameters.AddWithValue("@crew_id", random.Next(1, 10000));
                cmd.Parameters.AddWithValue("@firstName", firstNameTextBox.Text);
                cmd.Parameters.AddWithValue("@lastName",lastNameTextBox.Text);
                cmd.Parameters.AddWithValue("@email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@contactNumber", contactNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@address", addressTextBox.Text);
                cmd.Parameters.AddWithValue("@flight_id", fligtIDTextBox.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show(" Person added to flight crew");
                con.Close();

               

            }
            catch (Exception e1)
            {
                MessageBox.Show("Connection Refused on Signup" + e1.ToString());

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
