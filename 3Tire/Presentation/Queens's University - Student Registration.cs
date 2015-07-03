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
    public partial class Queens_s_University___Student_Registration : Form
    {

        public Queens_s_University___Student_Registration()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form1 studentDetail = new Form1();
            studentDetail.MdiParent = this;
            studentDetail.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 studentDetail = new Form1();
            studentDetail.MdiParent = this;
            studentDetail.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
