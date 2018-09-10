

namespace ProyectoHospital
{
    using System;
    using BusinessRules.Employee;
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnter_Click(object sender, EventArgs e)
        {
            var user = txtUser.Text;
            var password = txtPassword.Text;
            var data = user + '|' + password;
            BrEmployee brEmployee = new BrEmployee();
            string Request = brEmployee.Login(data);
            if (Request == null)
            {
                Request = "ERROR";
            }
            else
            {
                var obj = Request.Split('|');
                Session["codeEmployee"] = obj[0];
                Response.Redirect("Menu.aspx");
            }
        }
    }
}