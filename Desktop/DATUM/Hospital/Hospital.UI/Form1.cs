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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Form3 dep = new Form3();
            
              dep.ShowDialog();
        }
        }
    }


