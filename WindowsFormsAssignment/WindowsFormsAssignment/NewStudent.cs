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
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
            fullTimeRadio.Checked = true;
            deptComboBox.DataSource = Student.departmentList;
            addButton.Enabled = false;
            resetButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (this.studentIdTextField.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Student Id");

            }
           
            else if (this.firstNameText.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter First Name");

            }
            else if (this.lastNameText.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Last Name");

            }
            else if (this.studentIdTextField.Text.Trim().Equals(""))
            {
                MessageBox.Show("Please enter Student Id");

            }
            else if (fullTimeRadio.Checked == false & partTimeRadio.Checked == false)
            {
                MessageBox.Show("Please select enrollment type");

            }
            

            else {
                Student student = new Student();
                student.studentId = this.studentIdTextField.Text;
                student.firstName = this.firstNameText.Text;
                student.lastName = this.lastNameText.Text;
                student.department = this.deptComboBox.Text;


                if (fullTimeRadio.Checked == true)
                {
                    student.enrolType = "Full Time";
                }
                else if (partTimeRadio.Checked == true)
                {
                    student.enrolType = "Part Time";
                }
                StaticClass.getInstance().studentList.Add(student);

                MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.Show();



            }


        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.studentIdTextField.Clear();
            this.firstNameText.Clear();
            this.lastNameText.Clear();
            this.deptComboBox.ResetText();
            this.studentIdTextField.Focus();
        }
        private void studentIdTextField_TextChanged(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            resetButton.Enabled = true;
        }

        private void firstNameText_TextChanged(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            resetButton.Enabled = true;
        }

        private void lastNameText_TextChanged(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            resetButton.Enabled = true;
        }

        private void deptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            addButton.Enabled = true;
            resetButton.Enabled = true;
        }

      
  /*      public static bool validStudentId(String str)
        {
          
            if (str.Length != 11) return false;

            
                  else  if (!str.ElementAt(4).Equals("-")& !str.ElementAt(7).Equals("-"))
                    {
                return false;
            }
                    else
                    {
                return true;
            }
          

        }*/
        


    }

    }

