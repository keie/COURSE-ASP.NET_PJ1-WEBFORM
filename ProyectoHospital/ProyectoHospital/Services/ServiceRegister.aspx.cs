

namespace ProyectoHospital.Services
{
    using BusinessRules.Service;
    using System;
   
    public partial class ServiceRegister : System.Web.UI.Page
    {
        BrService br = new BrService();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            String data = (txtDesc.Text + '|' +
                txtType.Text + '|' +
                txtPrice.Text);
            if (!string.IsNullOrEmpty(data))
            {
                bool Request = br.RegisterService(data);
                if (!Request)
                {
                    lblData.Text = "HUBO UN ERROR";
                    lblData.Visible = true;
                    lblData.ForeColor = System.Drawing.Color.Red;
                    Response.Redirect("Services.aspx");
                }
                else
                {
                    lblData.Text = "Transaccion realizada con exito";
                    lblData.Visible = true;
                    lblData.ForeColor = System.Drawing.Color.Blue;
                    Response.Redirect("Services.aspx");
                }
            }
        }
    }
}