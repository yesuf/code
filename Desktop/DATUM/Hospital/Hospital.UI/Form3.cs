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
    public partial class Form3 : Form
    {
        Business.Patient objPatient = new Patient();
        bool isNew = true;
        private int id = 0;



        public Form3()
        {
            InitializeComponent();
        }

        private void PatientName_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            DataAccess.Patient patient = new DataAccess.Patient();
            int age;
            int.TryParse(txtAge.Text, out age);
          
            patient.PatientName = txtName.Text;
            patient.Gender = txtGen.Text;
            patient.Age = age;
            patient.City = txtCity.Text;

            if (this.isNew)
                objPatient.Add(patient);
             else
               {
                   patient.Id = id;
                   objPatient.UpdatePatient(patient);
               }
               this.btnNew_Click(null, null);
               this.gvam.DataSource =  objPatient.GetAll();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            isNew = true;
            id = 0;
            txtName.Text = "";
            txtGen.Text = "";
            txtAge.Text = "";
            txtCity.Text = "";



        }

        private void txtDelete_Click(object sender, EventArgs e)
        {
            objPatient.DeletePatient  (id);
            this.btnNew_Click(null, null);
            this.gvam.DataSource = objPatient.GetAll();
        }

        private void gvam_Click(object sender, EventArgs e)
        {
            this.isNew = false;
            int.TryParse(this.gvam.SelectedRows[0].Cells["Id"].Value.ToString(), out this.id);
            txtName.Text = (this.gvam.SelectedRows[0].Cells["PatientName"].Value.ToString());
            txtGen.Text = (this.gvam.SelectedRows[0].Cells["Gender"].Value.ToString());
            txtGen.Text = (this.gvam.SelectedRows[0].Cells["Age"].Value.ToString());
            txtGen.Text = (this.gvam.SelectedRows[0].Cells["City"].Value.ToString());

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            gvam.DataSource = objPatient.GetAll();
        }
    }
}
