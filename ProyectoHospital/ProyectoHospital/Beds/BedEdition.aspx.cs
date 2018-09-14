

namespace ProyectoHospital.Beds
{
    using System;
    using BusinessRules.Bed;
    public partial class BedEdition : System.Web.UI.Page
    {
        BrBed br = new BrBed();
        String dataBed = "";
        string state = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string data = (string)Session["dataBed"];
                var list = data.Split('|');
                lblCode.Text = list[0];
                txtPrice.Text = list[1];
                txtCategory.Text = list[2];
                // txtState.Text = list[3];
                if (list[3] == "Desocupada") txtState.Text = "1";
                else txtState.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtState.Text == "1") state = "Ocupada";
            else state = "Desocupada";
            dataBed = (lblCode.Text + '|' + txtPrice.Text + '|' +
               txtCategory.Text + '|' +
               state );
            bool Request = br.UpdateBed(dataBed);
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