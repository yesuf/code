using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Hospital.Business;

namespace Hospital.UI
{
    public partial class Form4 : Form
    {
        Business.Doctor objDoctor = new Business.Doctor();
        Business.Departiment department = new Departiment();
        bool isNew = true;
        private int id = 0;


        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isNew = true;
            id = 0;
            txtName.Text = "";
            txtSal.Text = "";
            txtdis.Text = "";
            txtdob.Text = "";
            cmbDept.Text = "";
            TxtDate.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataAccess.Doctor doctor = new DataAccess.Doctor();
           
                doctor.Name = txtName.Text ;
                doctor.Salary = int.Parse(txtSal.Text );
                doctor.Designation = txtdis.Text;
                doctor.DOB = Convert.ToDateTime(txtdob.Text);
                doctor.DeptID = int.Parse(cmbDept.SelectedValue.ToString());

                doctor.JoinDate = Convert.ToDateTime(TxtDate.Text);

                if (this.isNew)
                    objDoctor.Add(doctor);

                else
                {
                    doctor.ID = id;
                    objDoctor.UpdateDoctor(doctor);
                }
                this.button2_Click(null, null);
                this.gvam.DataSource = objDoctor.GetAll();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objDoctor.DeleteDoctor (id);
            this.button2_Click(null, null);
            this.gvam.DataSource = objDoctor.GetAll();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            cmbDept.DataSource = department.GetAll();
            cmbDept.DisplayMember = "DeptName";
            cmbDept.ValueMember = "Id";
        }

        
    }
}
