


namespace ProyectoHospital.Patients
{
    using System;
    using BusinessRules.Patient;
    public partial class PatientEdition : System.Web.UI.Page
    {
        BrPatient br = new BrPatient();
        String dataPat = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string data = (string)Session["dataPatient"];
                var list = data.Split('|');
                lblCode.Text = list[0];
                txtLastName.Text = list[1];
                txtName.Text = list[2];
                txtPhone.Text = list[3];
                txtDni.Text = list[4];
            }
        }

        protected void btnMod_Click(object sender, EventArgs e)
        {
            dataPat = (lblCode.Text + '|' + txtLastName.Text + '|' +
               txtName.Text + '|' +
               txtPhone.Text + '|' +
               txtDni.Text);
            bool Request = br.UpdatePatient(dataPat);
            if (!Request)
            {
                lblData.Text = "HUBO UN ERROR";
                lblData.Visible = true;
                lblData.ForeColor = System.Drawing.Color.Red;
                Response.Redirect("Patients.aspx");
            }
            else
            {
                lblData.Text = "Transaccion realizada con exito";
                lblData.Visible = true;
                lblData.ForeColor = System.Drawing.Color.Blue;
                Response.Redirect("Patients.aspx");
            }

        }
    }
}