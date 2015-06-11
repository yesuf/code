using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hospitall.web
{
    public partial class Doctor : System.Web.UI.Page
    {
        Hospital.Business.Doctor objDoctor = new Hospital.Business.Doctor();
      


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Hospital.DataAccess.Doctor doctor = new Hospital.DataAccess.Doctor();
            doctor.Name = txtName.Text;
            doctor.Salary = int.Parse(txtS.Text);
            doctor.Designation= txtD.Text;
            doctor.DeptID = int.Parse(txtDID.Text);
            doctor.DOB = Convert.ToDateTime (txtDOB.Text);
            doctor.JoinDate =Convert.ToDateTime (txtJ.Text);

          
                objDoctor.Add(doctor);
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
           
            txtName.Text = "";
            txtS.Text = "";
            txtDID.Text = "";
            txtDOB.Text = "";
            txtJ.Text = "";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtDID.Text);
            if (id == 0) return;
            objDoctor.DeleteDoctor(id);
            this.btnNew_Click(null, null);
            this.Gvam.DataBind();
        }
    }
}