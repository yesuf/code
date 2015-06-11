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
    public partial class Form2 : Form
    {
       Business.Departiment objDepartment = new Departiment();
        bool isNew= true;
        private int id = 0;
   



        public Form2()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            isNew = true;
            id = 0;
            txtName.Text ="";
            txtCode.Text= "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            DataAccess.Departiment departiment = new DataAccess.Departiment();
               departiment.DeptName = txtName.Text ;
               departiment.Code = txtCode.Text ;
               if (this.isNew)
                   objDepartment.Add(departiment);
               else
               {
                   departiment.ID = id;
                   objDepartment.UpdateDeparitmient(departiment);
               }
               this.btnNew_Click(null, null);
               this.gvam.DataSource = objDepartment.GetAll();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            objDepartment.DeleteDeparitmient(id);
            this.btnNew_Click(null, null);
            this.gvam.DataSource = objDepartment.GetAll();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            

        }

        
        private void Form2_Load(object sender, EventArgs e)
        {
            gvam.DataSource = objDepartment.GetAll();
        }

        private void Form2_Click(object sender, EventArgs e)
        {
           
        }

        private void gvam_Click(object sender, EventArgs e)
        {
            this.isNew = false;
            int.TryParse(this.gvam.SelectedRows[0].Cells["ID"].Value.ToString(),out this.id);
            txtName.Text = (this.gvam.SelectedRows[0].Cells["DeptName"].Value.ToString());
            txtCode.Text = (this.gvam.SelectedRows[0].Cells["Code"].Value.ToString());
        }

        

        
    }
}
