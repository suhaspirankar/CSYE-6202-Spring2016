using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Asssignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public string user = "s";
        public string pass = "s";
        int noOfLoginAttempts = 0;


        public MainWindow()
        {
            InitializeComponent();
          



        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            if (this.userNameTextBox.Text == this.user & this.passwordTextBox.Password== this.pass)
            {
                MainMenu m = new MainMenu("random");
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
}
