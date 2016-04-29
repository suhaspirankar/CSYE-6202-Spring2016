using FinalProject.Model;
using FinalProject.Presenter;
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
    public partial class ViewFlights : Form
    {
        public ViewFlightPresenter viewFlightPresenter;

        User user;

        public ViewFlights(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {

            
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
            con.Open();
            String query = "SELECT * From FLight";
            MySqlDataAdapter da = new MySqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Std");
            flightTable.DataSource = ds;
            flightTable.DataMember = "Std";
            flightTable.Refresh();
            con.Close();

        }


        public void AddPresenter(ViewFlightPresenter viewFlightPresenter)
        {
            this.viewFlightPresenter = viewFlightPresenter;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu(user);
            this.Hide();
            m.Show();
        }
    }
}
