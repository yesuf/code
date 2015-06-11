using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospitall.web
{
    public partial class PatientHistory : System.Web.UI.Page
    {

        Hospital.Business.PatientHistory objPatientHistory = new Hospital.Business.PatientHistory();
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Hospital.DataAccess.PatientHistory patientHistory = new Hospital.DataAccess.PatientHistory();
            patientHistory.AdmissionDate = Convert.ToDateTime( txtAd.Text);
            patientHistory.Doctor = txtDN.Text;
            patientHistory.DoctorID = int.Parse(txtD.Text);
            patientHistory.PatientID = int.Parse(txtP.Text);
                   patientHistory.ReleaseDate = txtRD.Text;
                   patientHistory.Ward = txtward.Text;

           
                objPatientHistory.Add(patientHistory);
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            
            txtAd.Text = "";
            txtDN.Text = "";
            txtD.Text = "";
            txtP.Text = "";
            txtRD.Text = "";
            txtward.Text = "";
        }

    }
}