

namespace ProyectoHospital.Services
{
    using BusinessRules.Service;
    using System;

    public partial class ServiceEdition : System.Web.UI.Page
    {
        BrService br = new BrService();
        String dataServ = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string data = (string)Session["dataService"];
                var list = data.Split('|');
                lblCode.Text = list[0];
                txtDesc.Text = list[1];
                txtType.Text = list[2];
                txtPrice.Text = list[3];
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dataServ = (lblCode.Text + '|' + txtDesc.Text + '|' +
                txtType.Text + '|' +
                txtPrice.Text);
            bool Request = br.UpdateService(dataServ);
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