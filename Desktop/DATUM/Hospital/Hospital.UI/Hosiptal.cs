using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital.UI
{
    public partial class Hosiptal : Form
    {
        public Hosiptal()
        {
            InitializeComponent();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dep = new Form2();
            dep.MdiParent = this;
            dep.Show();
        }

        

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 pain = new Form3();

            pain.ShowDialog();
        }

        private void doctorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 pain = new Form4();

            pain.ShowDialog();

        }

        private void patientHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 pain = new Form5();

            pain.ShowDialog();
        }

       
    }
}

     