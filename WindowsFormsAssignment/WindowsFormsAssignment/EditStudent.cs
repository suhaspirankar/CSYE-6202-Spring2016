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
    public partial class EditStudent : Form
    {
     
        public EditStudent()
        {
            InitializeComponent();
            fullTimeRadio.Checked = true;
            deptComboBox.DataSource = Student.departmentList;
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

                string id = this.studentIdTextField.Text;
           

                foreach(Student s in StaticClass.getInstance().studentList)
                {
                    

                    if (s.studentId == id)
                    {
                       
                        DialogResult dialogResult = MessageBox.Show("Are you sure you want to update the student", "Warning", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            s.firstName = this.firstNameText.Text;
                            s.lastName = this.lastNameText.Text;
                            s.department = this.deptComboBox.Text;
                            if (fullTimeRadio.Checked == true)
                            {
                                s.enrolType = "Full Time";
                            }
                            else if (partTimeRadio.Checked == true)
                            {
                                s.enrolType = "Part Time";
                            }
                            System.Windows.Forms.MessageBox.Show("Student details updated Successfully");
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

       
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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

        private void EditStudent_Load(object sender, EventArgs e)
        {

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
