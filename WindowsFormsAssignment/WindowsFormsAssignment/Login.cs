using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAssignment
{
    public partial class Login : Form
    {
        public string userName = "s";
        public string pass = "s";
        int noOfLoginAttempts = 0;

        public Login()
        {
            InitializeComponent();
            passtextbox.PasswordChar = '*';

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(this.userNametextBox.Text == this.userName & this.passtextbox.Text == this.pass)
            {
                MainMenu m = new MainMenu("random");
                this.Hide();
                m.Show();
            }
            else
            {
                MessageBox.Show("Please enter valid credentiatls");
                noOfLoginAttempts = noOfLoginAttempts+ 1;


                if (noOfLoginAttempts >= 3)
                {
                    System.Environment.Exit(1);
                }

            }
        }
    }
}
