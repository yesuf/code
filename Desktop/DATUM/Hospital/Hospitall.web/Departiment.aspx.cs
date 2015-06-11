using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hospital.Business;

namespace Hospitall.web
{
    public partial class Departiment : System.Web.UI.Page
    {
        Hospital.Business.Departiment objDepartment = new Hospital.Business.Departiment();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.btnSave.Attributes.Add("onclick", "javascript: return confirm('Are you sure?');");
            this.btnDelete.Attributes.Add("onclick", "javascript: return confirm('Are you sure you want to delete');");
            btnExportToExcel.Attributes.Add("onclick", "javascript:return confirm('are you sure you want to export?')");


        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(this.txtId.Text, out id);
            Hospital.DataAccess.Departiment departiment = new Hospital.DataAccess.Departiment();
            departiment.DeptName = txtName.Text;
            departiment.Code = txtCode.Text;
            if (id == 0)
            {
                objDepartment.Add(departiment);
            }
            else
            {
                departiment.ID = id;
                objDepartment.UpdateDeparitmient(departiment);
            }
            this.btnNew_Click(null, null);
            this.Gvam.DataBind();
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtCode.Text = "";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            if (id == 0) return;
            objDepartment.DeleteDeparitmient(id);
            this.btnNew_Click(null, null);
            this.Gvam.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnR_Click(object sender, EventArgs e)
        {
            this.Gvam.DataBind();
        }

        protected void Gvam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(this.Gvam.SelectedDataKey.Value.ToString());
            if (id > 0)
            {
                this.txtId.Text = id.ToString();
                this.txtName.Text = this.Gvam.SelectedRow.Cells[2].Text;
                this.txtCode.Text = this.Gvam.SelectedRow.Cells[3].Text;
            }
        }

        protected void btnExportToExcel_Click(object sender, EventArgs e)
        {
            //execute the downloading

        }
    }
}