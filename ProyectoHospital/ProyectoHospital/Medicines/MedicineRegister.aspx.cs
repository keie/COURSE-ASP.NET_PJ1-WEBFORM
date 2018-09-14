

namespace ProyectoHospital.Medicines
{
    using System;
    using BusinessRules.Medicine;
    public partial class MedicineRegister : System.Web.UI.Page
    {
        BrMedicine br = new BrMedicine();
        string stock = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] MedicineStock = { "1", "0" };
                ddlStock.DataSource = MedicineStock;
                ddlStock.DataBind();
                
            }
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            if (ddlStock.SelectedItem.Text == "1") stock = "Disponible";
            else stock = "No Disponible";
            String data = (txtName.Text + '|' +
                txtLab.Text + '|' +
                txtPrice.Text+'|'+
                stock);
            if (!string.IsNullOrEmpty(data))
            {
                bool Request = br.RegisterEmployee(data);
                if (!Request)
                {
                    lblData.Text = "HUBO UN ERROR";
                    lblData.Visible = true;
                    lblData.ForeColor = System.Drawing.Color.Red;
                    Response.Redirect("Medicines.aspx");
                }
                else
                {
                    lblData.Text = "Transaccion realizada con exito";
                    lblData.Visible = true;
                    lblData.ForeColor = System.Drawing.Color.Blue;
                    Response.Redirect("Medicines.aspx");
                }
            }
        }
    }
}