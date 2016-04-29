using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;


using FinalProject.Presenter;
using FinalProject.View;
using FinalProject.Model;

namespace FinalProject
{
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd;
        public string userName = "s";
        public string pass = "s";
        int noOfLoginAttempts = 0;
        public static List<string> roleList = new List<string>() { "Admin", "End User" };
     

        public DemoPresenter Presenter { get; set; }
        public Login()
        {
            //this.BackgroundImage = Properties.Resources.Airline;
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
            RoleComboBox.DataSource = roleList;
        }

    private void Form1_Load(object sender, EventArgs e)
        {
      /*    try
            {
                con.ConnectionString="server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
                con.Open();
                MessageBox.Show("Suhas you are connected to database");
            }
            catch(Exception e1)
                {
                MessageBox.Show("Connection Refused"+e1.ToString());

            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            /* if (this.userNameTextBox.Text == this.userName & this.passwordTextBox.Text == this.pass)
             {
                MainMenu m = new MainMenu();
                 this.Hide();
                 m.Show();
             }*/

            if (RoleComboBox.Text == "Admin")
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
                con.Open();
                string cmdText = "SELECT Count(*) FROM USER WHERE userName = @userName AND passwordColumn = @password and role =@role";
                Console.WriteLine("suhas " + cmdText);
                MySqlCommand cmd = new MySqlCommand(cmdText, con);

                cmd.Parameters.AddWithValue("@userName", userNameTextBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                cmd.Parameters.AddWithValue("@role", RoleComboBox.Text);
               int result = System.Convert.ToInt32(cmd.ExecuteScalar());
                //Int32 result = (Int32)cmd.ExecuteScalar();
                if (result > 0)
                {
                    User user = new User();
                    user.userName = userNameTextBox.Text;
                    user.password = passwordTextBox.Text;
                    user.role = RoleComboBox.Text;

                    MessageBox.Show("You will login now as Admin");
                    MainMenu m = new MainMenu(user);
                    this.Hide();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("Please enter valid credentiatls");
                    noOfLoginAttempts = noOfLoginAttempts + 1;

                    if (noOfLoginAttempts >= 3)
                    {
                        System.Environment.Exit(1);
                    }

                }
            }

              else  if (RoleComboBox.Text == "End User")
            {

                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
                con.Open();
                string cmdText = "SELECT Count(*) FROM USER WHERE userName = @userName AND passwordColumn = @password and role =@role";
               
                MySqlCommand cmd = new MySqlCommand(cmdText, con);

                cmd.Parameters.AddWithValue("@userName", userNameTextBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordTextBox.Text);
                cmd.Parameters.AddWithValue("@role", RoleComboBox.Text);
                int result = System.Convert.ToInt32(cmd.ExecuteScalar());
              

                //get user_id from userName


                string cmdText1 = "SELECT user_id FROM USER WHERE userName = @userName AND passwordColumn = @password and role =@role";
             
                MySqlCommand cmd1 = new MySqlCommand(cmdText1, con);

                cmd1.Parameters.AddWithValue("@userName", userNameTextBox.Text);
                cmd1.Parameters.AddWithValue("@password", passwordTextBox.Text);
                cmd1.Parameters.AddWithValue("@role", RoleComboBox.Text);
                int user_id = System.Convert.ToInt32(cmd1.ExecuteScalar());

                if (result > 0)
                {

                    User user = new User();
                    user.userName = userNameTextBox.Text;
                    user.password = passwordTextBox.Text;
                    user.role = RoleComboBox.Text;
                    user.user_id = user_id;


                    MessageBox.Show("You will login now as End User");
                    MainMenu m = new MainMenu(user);
                    this.Hide();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("Please enter valid credentiatls");
                    noOfLoginAttempts = noOfLoginAttempts + 1;

                    if (noOfLoginAttempts >= 3)
                    {
                        System.Environment.Exit(1);
                    }

                }
            }
           
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            SignUp signUp = new SignUp(  );
            SignUpPresenter suPresenter = new SignUpPresenter(signUp);
            signUp.AddPresenter(suPresenter);
            this.Hide();
            signUp.Show(); 
        }
    }
}
