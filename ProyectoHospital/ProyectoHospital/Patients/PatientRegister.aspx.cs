


namespace ProyectoHospital.Pacientes
{
    using System;
    using BusinessRules.Patient;
    public partial class CreatePatient : System.Web.UI.Page
    {
        BrPatient br = new BrPatient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            var LastName = txtLastName.Text;
            var Name = txtName.Text;
            var Phone = txtPhone.Text;
            var Dni = txtDni.Text;
            var data = (LastName + '|' +
                Name + '|' +
                Phone + '|' +
                Dni);
            if (!string.IsNullOrEmpty(data))
            {
                bool Request = br.RegisterPatient(data);
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
}