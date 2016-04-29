using FinalProject.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.View
{
    public partial class ViewFlightInformation : Form
    {
        User user;

        public ViewFlightInformation(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string flight_id = flight_IdTextBox.Text;

            // Code to get the carrier for the entered flight_id

            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
            conn.Open();
            string cmdText = "SELECT carrier FROM FLIGHT WHERE flight_id = @flight_id";
            MySqlCommand cmd = new MySqlCommand(cmdText, conn);
            cmd.Parameters.AddWithValue("@flight_id", flight_id);
            String result = System.Convert.ToString(cmd.ExecuteScalar());
            conn.Close();
            carrierInformationTextBox.Text = result;
            

            
            MySqlConnection cono = new MySqlConnection();
            cono.ConnectionString = "server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
            cono.Open();
            String queery = "SELECT  crew_id  ,firstName ,lastName ,email  ,contactNumber  ,address   From Flight_CREW where flight_id=" + flight_id;
        //    String query1 = "SELECT * From user where user_id IN (" + query + ")";
            MySqlDataAdapter da1 = new MySqlDataAdapter(queery, cono);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1, "Std");
            listOfFlightCrew.DataSource = ds1;
            listOfFlightCrew.DataMember = "Std";
            listOfFlightCrew.Refresh();
            cono.Close();

 
            // Code to get list of passengers
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
            con.Open();
            String query = "SELECT * From user_flights where flight_id=" + flight_id;
          //  String query1 = "SELECT * From user where user_id IN (" + query + ")";
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Std");
            listOfPassengers.DataSource = ds;
            listOfPassengers.DataMember = "Std";
            listOfPassengers.Refresh();
            con.Close();

        }

        private void listOfPassengers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PassengersLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu(user);
            this.Hide();
            m.Show();
        }
    }
}
