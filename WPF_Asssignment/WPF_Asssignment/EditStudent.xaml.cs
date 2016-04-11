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
    /// Interaction logic for EditStudent.xaml
    /// </summary>
    public partial class EditStudent : Window
    {
        public EditStudent()
        {
            InitializeComponent();
            fullTime.IsChecked = true;
            deptComboBox.ItemsSource = Student.departmentList;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
           // MessageBoxResult
            MessageBoxResult dialogResult = MessageBox.Show("Are you sure you want to cancel", "Warning", MessageBoxButton.YesNo);
            if (dialogResult == MessageBoxResult.Yes)
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

        private void Update_Click(object sender, RoutedEventArgs e)
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

                        MessageBoxResult dialogResult = MessageBox.Show("Are you sure you want to update the student", "Warning", MessageBoxButton.YesNo);
                        if (dialogResult == MessageBoxResult.Yes)
                        {
                            s.firstName = this.firstNameTextBox.Text;
                            s.lastName = this.lastNameTextBox.Text;
                            s.department = this.deptComboBox.Text;
                            if (fullTime.IsChecked == true)
                            {
                                s.enrolType = "Full Time";
                            }
                            else if (partTime.IsChecked == true)
                            {
                                s.enrolType = "Part Time";
                            }
                          MessageBox.Show("Student details updated Successfully");
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
    }
}
