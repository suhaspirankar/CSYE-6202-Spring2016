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
    public partial class AddFlight : Form
    {
        User user;
        public AddFlight(User user)
        {
            InitializeComponent();
            this.user = user;
            /*  dateTimePicker1.Format = DateTimePickerFormat.Custom;
              dateTimePicker1.CustomFormat = "yyyy/MM/dd";
              dateTimePicker2.Format = DateTimePickerFormat.Custom;
              dateTimePicker2.CustomFormat = "yyyy/MM/dd"; */

            FillTimeCombo(TimeCombo1, new DateTime(2000, 1, 1, 0, 0, 0), new DateTime(2000, 1, 1, 23, 30, 0), new TimeSpan(0, 30, 0));
            FillTimeCombo(TimeCombo2, new DateTime(2000, 1, 1, 0, 0, 0), new DateTime(2000, 1, 1, 23, 30, 0), new TimeSpan(0, 30, 0));

        }

        private void addFlightButton_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
                con.Open();
                string cmdText = "INSERT INTO  flight (flight_id , flight_Name, departure_time , arrival_time,departure_date , arrival_date,departure, destination , carrier   )  values(@flight_id , @flight_Name, @departure_time , @arrival_time,@departure_date , @arrival_date,@departure, @destination , @carrier    )";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);
               
                cmd.Parameters.AddWithValue("@flight_id", random.Next(1, 10000));
                cmd.Parameters.AddWithValue("@flight_Name", flightNameTextBox.Text);

                cmd.Parameters.AddWithValue("@departure_time", TimeCombo1.Text);
                cmd.Parameters.AddWithValue("@arrival_time", TimeCombo2.Text);

                cmd.Parameters.AddWithValue("@departure_date", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@arrival_date", dateTimePicker2.Text);

                cmd.Parameters.AddWithValue("@departure", departureTextBox.Text);
                cmd.Parameters.AddWithValue("@destination", destinationTextBox.Text);

                cmd.Parameters.AddWithValue("@carrier", carrierTextBox.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show(" Flight Added sucessfully");
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void FillTimeCombo(ComboBox box, DateTime startTime, DateTime endTime, TimeSpan interval)
        {
            int count = 48;
            box.Items.Clear();
            DateTime time = startTime;
            while (count > 0)
            {
                box.Items.Add(time.ToString("HH : mm"));
                time = time.Add(interval);
                count = count - 1;
            }
        }
    }
}
