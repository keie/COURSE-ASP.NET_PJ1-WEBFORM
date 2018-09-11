using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoHospital.Employess
{
    using BusinessRules.Employee;
    public partial class EmployeeEdition : System.Web.UI.Page
    {
        BrEmployee br = new BrEmployee();
        String dataEmp = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string data = (string)Session["dataEmployee"];
                var list = data.Split('|');
                lblCode.Text = list[0];
                txtLastName.Text = list[1];
                txtName.Text = list[2];
                txtType.Text = list[3];
                txtAccount.Text = list[4];
                txtPassword.Text = list[5];
                txtTurn.Text = list[6];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dataEmp = (lblCode.Text+'|'+txtLastName.Text + '|' +
                txtName.Text + '|' +
                txtType.Text + '|' +
                txtAccount.Text + '|' +
                txtPassword.Text + '|' +
                txtTurn.Text);
            bool Request = br.UpdateEmployee(dataEmp);
          if (!Request)
          {
              lblData.Text = "HUBO UN ERROR";
              lblData.Visible = true;
              lblData.ForeColor = System.Drawing.Color.Red;
                Response.Redirect("Employess.aspx");
          }
          else
          {
              lblData.Text = "Transaccion realizada con exito";
              lblData.Visible = true;
              lblData.ForeColor = System.Drawing.Color.Blue;
              Response.Redirect("Employess.aspx");
            }
        }
    }
}