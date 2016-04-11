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
    /// Interaction logic for NewStudent.xaml
    /// </summary>
    public partial class NewStudent : Window
    {
        public NewStudent()
        {
            InitializeComponent();

            fullTime.IsChecked = true;
            deptComboBox.ItemsSource = Student.departmentList;
            Add.IsEnabled= false;
            Reset.IsEnabled = false;

        }

        private void Add_Click(object sender, RoutedEventArgs e)
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
                Student student = new Student();
                student.studentId = this.studentIdTextBox.Text;
                student.firstName = this.firstNameTextBox.Text;
                student.lastName = this.lastNameTextBox.Text;
                student.department = this.deptComboBox.Text;


                if (fullTime.IsChecked == true)
                {
                    student.enrolType = "Full Time";
                }
                else if (partTime.IsChecked == true)
                {
                    student.enrolType = "Part Time";
                }
                StaticClass.getInstance().studentList.Add(student);

                MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.Show();



            }





        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            this.studentIdTextBox.Clear();
            this.firstNameTextBox.Clear();
            this.lastNameTextBox.Clear();
            deptComboBox.ItemsSource = Student.departmentList;
            this.studentIdTextBox.Focus();
        }

        private void studentIdTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Add.IsEnabled = true;
            Reset.IsEnabled = true;
        }
    

        private void firstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        Add.IsEnabled = true;
        Reset.IsEnabled = true;

    }

        private void lastNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        Add.IsEnabled = true;
        Reset.IsEnabled = true;

    }

        private void deptComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Add.IsEnabled = true;
            Reset.IsEnabled = true;
        }
    }
}
