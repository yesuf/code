using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospitall.web
{
    public partial class Patient : System.Web.UI.Page
    {
        Hospital.Business.Patient objPatient = new Hospital.Business.Patient();
        bool isNew = true;
        private int id = 0;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Hospital.DataAccess.Patient patient= new Hospital.DataAccess.Patient();
            patient.PatientName = txtName.Text;
            patient.Gender = txtG.Text;
            patient.Age = int.Parse(txtA.Text);
            patient.City = txtC.Text;
            if (this.isNew)
                objPatient.Add(patient);
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            id = 0;
            txtName.Text = "";
            txtG.Text = "";
            txtA.Text = "";
            txtC.Text = "";
        }
    }
}