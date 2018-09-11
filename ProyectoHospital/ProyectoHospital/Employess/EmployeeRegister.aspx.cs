

namespace ProyectoHospital.Employess
{
    using System;
    using BusinessRules.Employee;
    public partial class EmployeeRegister : System.Web.UI.Page
    {
        BrEmployee br = new BrEmployee();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                string[] EmployeeType = { "Administrador", "Cajero" };
                ddlType.DataSource = EmployeeType;
                ddlType.DataBind();
                string[] EmployeeTurn = { "Noche","Dia" };
                ddlTurn.DataSource = EmployeeTurn;
                ddlTurn.DataBind();
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            String data = (txtLastName.Text + '|' +
                txtName.Text + '|' +
                ddlType.SelectedItem.Text + '|' +
                txtAccount.Text + '|' +
                txtPass.Text + '|' +
                ddlTurn.SelectedItem.Text);
           if (!string.IsNullOrEmpty(data))
            {
                bool Request = br.RegisterEmployee(data);
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
}