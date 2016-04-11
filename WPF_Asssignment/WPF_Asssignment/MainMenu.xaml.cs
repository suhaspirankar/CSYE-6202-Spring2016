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
using FizzWare.NBuilder;

namespace WPF_Asssignment
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {

        List<string> enrolType = new List<string>() { "Full Time", "Part Time" };

        int callRandom = 0;
        public MainMenu()
        {
            InitializeComponent();
            firstNameTextBox.IsEnabled = false;
            lastNameTextBox.IsEnabled = false;
            studentIdTextBox.IsEnabled = false;
            fullTime.IsEnabled = false;
            partTime.IsEnabled = false;

            populateGrid();


        }

        public MainMenu(string randomGenerator)
        {
            InitializeComponent();
            //New Constructor created so that evey time no random function is called and 10 records are inserted
            CreateRandomStudents();
            this.studentIdTextBox.Text = RandomString();
            this.firstNameTextBox.Text = Faker.NameFaker.FirstName();
            this.lastNameTextBox.Text = Faker.NameFaker.LastName();
            this.fullTime.IsChecked = true;
            deptComboBox.ItemsSource = Student.departmentList;
            dataGridView1.ItemsSource = StaticClass.getInstance().studentList;

            firstNameTextBox.IsEnabled = false;
            lastNameTextBox.IsEnabled = false;
            studentIdTextBox.IsEnabled = false;
            fullTime.IsEnabled = false;
            partTime.IsEnabled = false;

        }

        private void populateGrid()
        {
            this.studentIdTextBox.Text = RandomString();
            this.firstNameTextBox.Text = Faker.NameFaker.FirstName();
            this.lastNameTextBox.Text = Faker.NameFaker.LastName();
            this.fullTime.IsChecked = true;
            deptComboBox.ItemsSource = Student.departmentList;
            dataGridView1.ItemsSource = StaticClass.getInstance().studentList;
        }

        private void deptComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        public void CreateRandomStudents()
        {

            for (int i = 0; i < 10; i++)
            {
                Student s = Builder<Student>.CreateNew().Build();
                s.studentId = RandomString();
                s.firstName = Faker.NameFaker.FirstName();
                s.lastName = Faker.NameFaker.LastName();
                s.department = Student.departmentList[getRandomIndex()];
                s.enrolType = enrolType[getRandomEnrolType()];

                StaticClass.getInstance().studentList.Add(s);

            }


        }

        public int getRandomIndex()
        {
            Random random = new Random();
            int i = random.Next(0, 6);
            return random.Next(0, 6);
        }

        public int getRandomEnrolType()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }

        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            string a = new string(Enumerable.Repeat(chars, 3).Select(s => s[random.Next(s.Length)]).ToArray());
            string b = new string(Enumerable.Repeat(chars, 2).Select(s => s[random.Next(s.Length)]).ToArray());
            string c = new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());

            return a + "-" + b + "-" + c;
            //  return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void newStudent_Click(object sender, RoutedEventArgs e)
        {
            NewStudent newStudent = new NewStudent();
            this.Hide();
            newStudent.Show();
        }

        private void removeStudent_Click(object sender, RoutedEventArgs e)
        {
            RemoveStudent removeStudent = new RemoveStudent();
            this.Hide();
            removeStudent.Show();
        }

        private void editStudent_Click(object sender, RoutedEventArgs e)
        {

            EditStudent editeStudent = new EditStudent();
            this.Hide();
            editeStudent.Show();
        }
    }
}
