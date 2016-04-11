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
using System.Windows.Shapes;

namespace WPF_Asssignment
{
    /// <summary>
    /// Interaction logic for RemoveStudent.xaml
    /// </summary>
    public partial class RemoveStudent : Window
    {
        public RemoveStudent()
        {
            InitializeComponent();
            fullTime.IsChecked = true;
            deptComboBox.ItemsSource = Student.departmentList;
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            if (this.studentIdTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Student Id");

            }


            else if (this.firstNameTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter First Name");

            }
            else if (this.lastNameTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Last Name");

            }
            else if (this.studentIdTextBox.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Student Id");

            }
            else if (fullTime.IsChecked == false & partTime.IsChecked == false)
            {
                MessageBox.Show("Please select enrollment type");

            }

            else {

                string id = this.studentIdTextBox.Text;

                foreach (Student s in StaticClass.getInstance().studentList)
                {
                    if (s.studentId == id)
                    {

                        MessageBoxResult messageBoxResult = MessageBox.Show("Are you sure you want to remove the student", "Warning", MessageBoxButton.YesNo);
                        if (messageBoxResult == MessageBoxResult.Yes)
                        {
                            StaticClass.getInstance().studentList.Remove(s);
                            MessageBox.Show("Student Removed Successfully");
                            MainMenu mainMenu = new MainMenu();
                            this.Hide();
                            mainMenu.Show();
                            break;
                        }
                        else
                        {
                            this.Show();
                        }

                    }


                }

            }

        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messsageBoxResult = MessageBox.Show("Are you sure you want to cancel", "Warning", MessageBoxButton.YesNo);
            if (messsageBoxResult == MessageBoxResult.Yes)
            {
                MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.Show();
            }
            else
            {
                this.Show();


            }
        }
    }
}
