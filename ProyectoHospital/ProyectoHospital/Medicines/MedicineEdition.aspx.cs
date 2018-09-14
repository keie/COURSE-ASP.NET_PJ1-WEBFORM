

namespace ProyectoHospital.Medicines
{
    using BusinessRules.Medicine;
    using System;

    public partial class MedicineEdition : System.Web.UI.Page
    {
        string stock = "";
        BrMedicine br = new BrMedicine();
        String dataMedicine = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string data = (string)Session["dataMedicine"];
                var list = data.Split('|');
                lblCode.Text = list[0];
                txtName.Text = list[1];
                txtLab.Text = list[2];
                txtPrice.Text = list[3];
                var type = list[4];
                if (type == "0")
                {
                    string[] stockArr = { "No Disponible", "Disponible" };
                    ddlStock.DataSource = stockArr;
                    ddlStock.DataBind();
                }
                else
                {
                    string[] stockArr = { "Disponible", "No Disponible" };
                    ddlStock.DataSource = stockArr;
                    ddlStock.DataBind();
                }

            }
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            if (ddlStock.SelectedItem.Text == "Disponible") stock = "1";
            else stock = "0";
            dataMedicine = (lblCode.Text + '|' + txtName.Text + '|' +
               txtLab.Text + '|' +
               txtPrice.Text + '|' + stock.ToString()) ;
            bool Request = br.UpdateMedicine(dataMedicine);
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