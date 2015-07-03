using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Student_Registration : Form
    {
        Form1 owner;
        BusinessLogic.Student student = new BusinessLogic.Student();
        
        public Student_Registration(Form1 owner, int startIndex)
        {
            this.owner = owner;
            BusinessLogic.Student.id = startIndex;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            owner.AddStudent(student);
            this.Close();
        }

        private void Student_Registration_Load(object sender, EventArgs e)
        {
            student.GetNewID();
            textBox1.Text = student.ID;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            student.Name = textBox2.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            student.DOB = dateTimePicker1.Value;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            double val  =0;
            double.TryParse(maskedTextBox1.Text, out val);
            if(val <=4)
                student.GPA = val; 
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            student.Active = checkBox1.Checked;
        }
    }
}
