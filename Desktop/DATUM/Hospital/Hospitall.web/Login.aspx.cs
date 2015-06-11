using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hospital.DataAccess;

namespace Hospitall.web
{
    public partial class Login1 : System.Web.UI.Page
    {
        Hospital.Business.Login1 objLogin1 = new Hospital.Business.Login1();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.Identity.IsAuthenticated)
            {
                Page.Title = "Home page for " + User.Identity.Name;
            }
            else
            {
                Page.Title = "Home page for guest user.";
            }
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
           // var user = objLogin1.Autentication (txtName.Text, txtP.Text);
         //   if (user == null)
      //      {

          //  }
          //  else
            {
                Session["UserName"] = txtName.Text;
                Session["password"] = txtP.Text;
                Response.Redirect("~/Default.aspx");
            }


           


        }
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Hospital.DataAccess.Login1 login = new Hospital.DataAccess.Login1();
            login.FirstName= txtNamee.Text;
            login.LastName= txtL.Text;
            login.password = int.Parse(txtPP.Text);
            objLogin1.Add(login);
        }
        
    }
}