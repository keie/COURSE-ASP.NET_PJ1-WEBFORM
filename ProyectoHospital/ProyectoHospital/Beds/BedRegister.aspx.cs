

namespace ProyectoHospital.Beds
{
    using System;
    using BusinessRules.Bed;
    public partial class Beds : System.Web.UI.Page
    {
        BrBed br = new BrBed();
        public string State = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtState.Text == "1")
                State = "Ocupada";
            else
                State = "Desocupada";
            
            String data = (txtPrice.Text + '|' +
                txtCategory.Text + '|' +
                State);
            if (!string.IsNullOrEmpty(data))
            {
                bool Request = br.RegisterBed(data);
                if (!Request)
                {
                    lblData.Text = "HUBO UN ERROR";
                    lblData.Visible = true;
                    lblData.ForeColor = System.Drawing.Color.Red;
                    Response.Redirect("Beds.aspx");
                }
                else
                {
                    lblData.Text = "Transaccion realizada con exito";
                    lblData.Visible = true;
                    lblData.ForeColor = System.Drawing.Color.Blue;
                    Response.Redirect("Beds.aspx");
                }
            }
        }
    }
}