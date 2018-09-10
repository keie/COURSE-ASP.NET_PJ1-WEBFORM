
namespace ProyectoHospital.Employess
{
    using BusinessRules.Employee;
    using System;
    using System.Data;
    using System.Web.Services.Description;
    using System.Web.UI.WebControls;
    using static System.Net.Mime.MediaTypeNames;

    public partial class Employess : System.Web.UI.Page
    {
        BrEmployee br = new BrEmployee();
        string codeEmployee = "";
        string lastName = "";
        string name = "";
        string occupation = "";
        string account = "";
        string password = "";
        string turn = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            
                loadData();
            
           
        }

        public void loadData()
        {
            
                DataTable dt = new DataTable();
                string Request = br.GetListEmployee();
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
                        var _employeeColumns = list[i].Split('|');
                        dt.Rows.Add(_employeeColumns[0],
                            _employeeColumns[1],
                            _employeeColumns[2],
                            _employeeColumns[3],
                            _employeeColumns[4],
                            _employeeColumns[5],
                            _employeeColumns[6]
                            );

                    }
                    this.GridView1.DataSource = dt;
                    GridView1.DataBind();

                }
            

            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1; loadData();
        }

        protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string code_employee = GridView1.Rows[e.RowIndex].Cells[2].Text;
            bool Request = br.DeleteEmployee(code_employee);
            if (!Request)
            {
                lblData.Text = "HUBO UN ERROR";
                lblData.Visible = true;
                loadData();

            }
            else
            {
                lblData.Text = "Transaccion realizada con exito";
                lblData.Visible=true;
                lblData.ForeColor = System.Drawing.Color.Blue;
                loadData();
            }
            
           
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex =  e.NewEditIndex;
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            castToTexbox(e);
            string data = (codeEmployee + '|' +
              lastName + '|' +
              name + '|' +
              occupation + '|' +
              account + '|' +
              password + '|' +
              turn);
            bool Request = br.UpdateEmployee(data);
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

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
           
        }

        public void castToTexbox(GridViewUpdateEventArgs e)
        {
            
            codeEmployee = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
             lastName = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
             name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
             occupation = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;
             account = ((TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0]).Text;
             password = ((TextBox)GridView1.Rows[e.RowIndex].Cells[7].Controls[0]).Text;
             turn = ((TextBox)GridView1.Rows[e.RowIndex].Cells[8].Controls[0]).Text;

          
        }
    }
}