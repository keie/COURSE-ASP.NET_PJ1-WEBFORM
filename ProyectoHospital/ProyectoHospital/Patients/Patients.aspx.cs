namespace ProyectoHospital.Patients
{
    using System;
    using System.Data;
    using BusinessRules.Patient;
    using System.Web.UI.WebControls;

    public partial class Patients : System.Web.UI.Page
    {
        BrPatient br = new BrPatient();
        string codePatient = "";
        string lastName = "";
        string name = "";
        string phone = "";
        string dni = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void loadData()
        {

            DataTable dt = new DataTable();
            string Request = br.GetListPatient();
            if (string.IsNullOrEmpty(Request))
            {
                Request = "ERROR";
            }
            else
            {
                var list = Request.Split('¬');
                var header = list[0];
                var columnsHeader = header.Split('|');
                for (int i = 0; i <= columnsHeader.Length - 1; i++) //cabeceras
                {
                    dt.Columns.Add(columnsHeader[i]);
                }
                for (int i = 1; i <= list.Length - 1; i++) //contenidoEmpleado
                {
                    var _patientColumns = list[i].Split('|');
                    dt.Rows.Add(_patientColumns[0],
                        _patientColumns[1],
                        _patientColumns[2],
                        _patientColumns[3],
                        _patientColumns[4]
                        );

                }
                this.GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            castToTexbox(e);
            Session["dataPatient"] = (codePatient + '|' +
              lastName + '|' +
              name + '|' +
              phone + '|' +
              dni);
            Response.Redirect("PatientEdition.aspx");
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1; loadData();
        }
        public void castToTexbox(GridViewUpdateEventArgs e)
        {

            codePatient = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            lastName = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            phone = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            dni = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;
            


        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string code_patient = GridView1.Rows[e.RowIndex].Cells[1].Text;
            bool Request = br.DeletePatient(code_patient);
            if (!Request)
            {
                lblData.Text = "HUBO UN ERROR";
                lblData.Visible = true;
                loadData();

            }
            else
            {
                lblData.Text = "Transaccion realizada con exito";
                lblData.Visible = true;
                lblData.ForeColor = System.Drawing.Color.Blue;
                loadData();
            }
        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}


       