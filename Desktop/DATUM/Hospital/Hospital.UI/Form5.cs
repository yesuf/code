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
    public partial class Form5 : Form
    {
        Business.PatientHistory objPatientHistory = new PatientHistory();
        Business.Departiment department = new Departiment();
        Business.Doctor doctor = new  Doctor();
        Business.Patient patient = new Patient();
        bool isNew = true;
        private int id = 0;

        public Form5()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            id = 0;
            txtAD.Text = "";
            cmbdoctor.Text = "";
            cmbDID.Text = "";
            cmbPID.Text = "";
            txtRD.Text = "";
            txtwa.Text = "";
            txtAD.Text = "";
         

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataAccess.PatientHistory patientHistory = new DataAccess.PatientHistory  ();

            patientHistory.AdmissionDate = Convert.ToDateTime(txtAD.Text);
            
            patientHistory.DoctorID = int.Parse(cmbDID.SelectedValue.ToString());
            patientHistory.PatientID = int.Parse(cmbPID.SelectedValue.ToString());
            patientHistory.ReleaseDate = txtRD.Text;
            patientHistory.Ward = txtwa.Text;


          if (this.isNew)
                objPatientHistory.Add(patientHistory);
            else
            {

                patientHistory.ID = id;
                objPatientHistory.UpdatePatientHistory(patientHistory);
            }
          this.btnNew_Click(null, null);
          this.gvam.DataSource = objPatientHistory.GetAll();


        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cmbdoctor.DataSource = doctor.GetAll();
            cmbPID.DataSource =    patient.GetAll();
            cmbDID.DataSource = doctor.GetAll();
            
            
            cmbDID.DisplayMember = "Name";
            cmbdoctor.DisplayMember = "Name";
            cmbPID.DisplayMember = "PatientName";
            cmbDID.ValueMember = "Id";
            cmbPID.ValueMember = "ID";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            objPatientHistory.DeletePatientHistory (id);
            this.btnNew_Click(null, null);
            this.gvam.DataSource = objPatientHistory.GetAll();
        }
    }
}
