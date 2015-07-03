using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Presentation
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var student in BusinessLogic.Student.GetStudentList())
            {
                dataGridView1.Rows.Add(new object[] { student.ID, student.Name, student.DOB, student.GPA, student.Active });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student_Registration studentRegistration = new Student_Registration(this, dataGridView1.Rows.Count);
            studentRegistration.MdiParent = this.MdiParent;
            studentRegistration.Show();          
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            dataGridView1.Rows.Add(new object[] { student.ID, student.Name, student.DOB, student.GPA, student.Active });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusinessLogic.Student.SaveList(students);
            students = new List<Student>();
        }

    }
}
