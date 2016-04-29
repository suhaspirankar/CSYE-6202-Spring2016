using FinalProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Windows.Forms;
using System.Data;
using FinalProject.View;


namespace FinalProject.Presenter
{
    public class SignUpPresenter
    {
        public SignUp signUpForm;
        public Flight flight;
        public User user = new User();
        Random random = new Random();

        public SignUpPresenter(SignUp signUpForm)
        {
            this.signUpForm = signUpForm;
        }

        public void onSubmit(SignUpPresenter signUpPresenter)
        {
            

            try
            {
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = "server=localhost;user id=root;password=suhas;persistsecurityinfo=True;database=airline_reservation_system";
                con.Open();
                string cmdText = "INSERT INTO USER (user_id,firstName,lastname,username,passwordColumn,email, contactNumber,address,role) values (@user_id,@firstName,@lastname,@username,@passwordColumn,@email, @contactNumber,@address,@role)";
                MySqlCommand cmd = new MySqlCommand(cmdText, con);

                cmd.Parameters.AddWithValue("@user_id", random.Next(1, 10000));
                cmd.Parameters.AddWithValue("@firstName", signUpPresenter.user.firstName);
                cmd.Parameters.AddWithValue("@lastName", signUpPresenter.user.lastName);
                cmd.Parameters.AddWithValue("@userName", signUpPresenter.user.userName);
                cmd.Parameters.AddWithValue("@passwordColumn", signUpPresenter.user.password);
                cmd.Parameters.AddWithValue("@email", signUpPresenter.user.email);
                cmd.Parameters.AddWithValue("@contactNumber", signUpPresenter.user.contactNumber);
                cmd.Parameters.AddWithValue("@address", signUpPresenter.user.address);
                cmd.Parameters.AddWithValue("@role", signUpPresenter.user.role);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show(" User Registered sucessfully");
                con.Close();

            //    MainMenu m = new MainMenu();
                 
             //   m.Show();

            }
            catch (Exception e1)
            {
                MessageBox.Show("Connection Refused on Signup" + e1.ToString());

            }


        }

       


    }
}
