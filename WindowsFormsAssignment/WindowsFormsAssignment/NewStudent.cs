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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.firstName = this.studentId.Text;
            student.lastName = this.lastNameText.Text;
            student.studentId = this.studentId.Text;
            student.department = this.deptComboBox.Text;
            if (fullTimeRadio.Checked == true)
            {
                student.enrolType = "Full Time";
            }
            else if (partTimeRadio.Checked == true) {
                student.enrolType = "Part Time";
            }
            StaticClass.getInstance().studentList.Add(student);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.firstNameText.Clear();
        }
    }
}
