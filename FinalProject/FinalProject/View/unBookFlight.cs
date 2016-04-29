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
    public partial class unBookFlight : Form
    {

        User user;
        public unBookFlight(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void bookFlightButton_Click(object sender, EventArgs e)
        {

        }

        private void flightTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void populateTable()
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
            con.Open();
            // String query = "SELECT * From FLight where flight_id IN (SELECT flight_id from user_flights where user_id=" + user.user_id + ")";
      String query = "SELECT * From USER_FLights ";

            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Std");
            flightTable.DataSource = ds;
            flightTable.DataMember = "Std";
            flightTable.Refresh();

        }
        private void unBookFlight_Load(object sender, EventArgs e)
        {
            populateTable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void unBookFlightButton_Click(object sender, EventArgs e)
        {

            if (flightTable.SelectedCells.Count > 0)
            {
                int selectedrowindex = flightTable.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = flightTable.Rows[selectedrowindex];

                string flightName = Convert.ToString(selectedRow.Cells[5].Value);

                String flight_id = Convert.ToString(selectedRow.Cells[4].Value);
               // String seat_class = Convert.ToString(selectedRow.Cells[6].Value);
                String customer_id = Convert.ToString(selectedRow.Cells[3].Value);
                String customer_name = Convert.ToString(selectedRow.Cells[1].Value);

                DialogResult dialogResult = MessageBox.Show(user.userName + " are you sure you want to Unbook Book this flight  " + flightName+" for customer "+ customer_name, "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {


                    try
                    {
                        MySqlConnection con = new MySqlConnection();
                        con.ConnectionString = "server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
                        con.Open();
                        string cmdText = "DELETE from user_flights where IdNumber=\"" + customer_id+"\" and flight_id="+flight_id+"";
                        MySqlCommand cmd = new MySqlCommand(cmdText, con);
                       

                       cmd.ExecuteNonQuery();
                        MessageBox.Show(" Flight unBooked Sucessfully");
                        con.Close();
                        populateTable();

                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show("Connection Refused to Book flight" + e1.ToString());


                    }
                    }
                else
                {
                    this.Show();
                }



            }
            else
            {

                MessageBox.Show("Please select a flight from the List to UNBOOK");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu(user);
            this.Hide();
            m.Show();
        }
    }
}
