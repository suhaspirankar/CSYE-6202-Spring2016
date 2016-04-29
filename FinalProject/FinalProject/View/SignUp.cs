using FinalProject.Model;
using FinalProject.Presenter;
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
    public partial class SignUp : Form
    {
        public User user;
        public SignUpPresenter signUpPresenter;
        public static List<string> roleList = new List<string>() { "Admin", "End User" };
  
        public SignUp ()
        {
            InitializeComponent();
            roleComboBox.DataSource = roleList;
            passwordTextBox.PasswordChar = '*';
         
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
 
             user = new User();
            user.userName = userNameTextBox.Text;
            user.password = passwordTextBox.Text;
            user.role = roleComboBox.Text;

            signUpPresenter.user.firstName= firstNameTextBox.Text; 
            signUpPresenter.user.lastName  = lastNameTextBox.Text;
            signUpPresenter.user.userName = userNameTextBox.Text;
            signUpPresenter.user.password = passwordTextBox.Text;
            signUpPresenter.user.email = emailTextBox.Text;
            signUpPresenter.user.contactNumber = contactNumberTextBox.Text;
            signUpPresenter.user.address = addressTextBox.Text;
            signUpPresenter.user.role = roleComboBox.Text;


            //var test = user.validateFirstName();
            signUpPresenter.onSubmit(signUpPresenter);
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

           
        }
        public void AddPresenter(SignUpPresenter presenter)
        {
            this.signUpPresenter = presenter;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu(user);
            this.Hide();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            this.Hide();
            lo.Show();
        }
    }
}
