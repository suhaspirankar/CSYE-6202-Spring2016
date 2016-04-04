using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FizzWare.NBuilder;
namespace WindowsFormsAssignment
{
    public partial class MainMenu : Form
    {

        List<string> enrolType = new List<string>() { "Full Time", "Part Time" };
        public MainMenu()
        {
            InitializeComponent();
            CreateRandomStudents();
            this.studentIdText.Text = RandomString(9);
            deptComboBox.DataSource = Student.departmentList;
            dataGridView1.DataSource = StaticClass.getInstance().studentList;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewStudent newStudent = new NewStudent();
            this.Hide();
            newStudent.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveStudent removeStudent = new RemoveStudent();
            this.Hide();
            removeStudent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
              EditStudent editeStudent = new EditStudent();
              this.Hide();
              editeStudent.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void CreateRandomStudents()
        {

            for (int i = 0; i < 2; i++)
            {
                Student s = Builder<Student>.CreateNew().Build();
                s.studentId = RandomString(9);
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

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            string a = new string(Enumerable.Repeat(chars, 3).Select(s => s[random.Next(s.Length)]).ToArray());
            string b = new string(Enumerable.Repeat(chars, 2).Select(s => s[random.Next(s.Length)]).ToArray());
            string c = new string(Enumerable.Repeat(chars, 4).Select(s => s[random.Next(s.Length)]).ToArray());

            return a + "-" + b + "-" + c;
            //  return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
