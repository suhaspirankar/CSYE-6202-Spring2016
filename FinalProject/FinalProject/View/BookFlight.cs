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
    public partial class BookFlight : Form,ICalculatePrice
    {
        User user;
        public static List<string> IdList = new List<string>() { "Passport", "Driving License","State ID" };
        public static List<string> seatCLass = new List<string>() { "Economy", "Economy Plus", "Business" };
        public BookFlight(User user)
        {
            InitializeComponent();
            this.user = user;
            IdcomboBox.DataSource = IdList;
            classComboBox.DataSource = seatCLass;
        }

        private void BookFlight_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
            con.Open();
            String query = "SELECT * From FLight";
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Std");
            dataGridView.DataSource = ds;
            dataGridView.DataMember = "Std";
            dataGridView.Refresh();
            con.Close();
        }

        private void bookFlightButton_Click(object sender, EventArgs e)
        {
           
            if (dataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView.Rows[selectedrowindex];

                string flightName = Convert.ToString(selectedRow.Cells[1].Value);
                String flight_id= Convert.ToString(selectedRow.Cells[0].Value);
                String seat_class = classComboBox.Text;
                String prices = priceTextBox.Text;

                String customerName = customerNameTextBox.Text;
                String IdType = IdcomboBox.Text;
                String IdNumber = idNumberTextBox.Text;

                MessageBox.Show("Prices is " + prices);

                DialogResult dialogResult = MessageBox.Show(" Are you sure you want to Book the flight for " + customerName, "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {


                    try
                    {
                        Random random = new Random();
                        MySqlConnection con = new MySqlConnection();
                        con.ConnectionString = "server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
                        con.Open();
                        string cmdText = "INSERT INTO USER_FLIGHTS (user_id,Customer_Name,idType,idNumber,Flight_id,flight_name,seat_class,prices)   values (@user_id,@Customer_Name,@IdType,@IdNumber,@Flight_id,@flight_name,@seat_class,@prices)";
                        MySqlCommand cmd = new MySqlCommand(cmdText, con);

                        cmd.Parameters.AddWithValue("@user_id", random.Next(1, 10000));


                        cmd.Parameters.AddWithValue("@Customer_Name", customerName);
                        cmd.Parameters.AddWithValue("@IdType", IdType);
                        cmd.Parameters.AddWithValue("@IdNumber", IdNumber);
                        cmd.Parameters.AddWithValue("@Flight_id", flight_id);
                        cmd.Parameters.AddWithValue("@flight_name", flightName);
                        cmd.Parameters.AddWithValue("@seat_class", seat_class);
                        cmd.Parameters.AddWithValue("@prices", prices);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(" Flight Booked Sucessfully");
                        con.Close();


                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("Connection Refused to Book flight" + e1.ToString());

                    }

                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Show();
                }
               else
                {

                    MessageBox.Show("Please select a flight from the List to Book");
                }


            }
            else if (priceTextBox.Text==null)
            {

                MessageBox.Show("Please calculate the ticket price and then book the flight ");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu(user);
            this.Hide();
            m.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void calculatePrice_Click(object sender, EventArgs e)
        {

            int price = CalculatePriceOfSeat(classComboBox.Text);
            priceTextBox.Text=Convert.ToString(price);



        }

        public int CalculatePriceOfSeat(string seatClass)
        {
            String price;
            if (classComboBox.Text == "Economy")
            {
                price = "15000";

            }
            else if (classComboBox.Text == "Economy Plus")
            {
                price = "25000";

            }
            else  if (classComboBox.Text == "Business")
            {
                price = "35000";

            }
            else
            {
                price = "0";
            }
            return Int32.Parse(price);
        }
    }
}
