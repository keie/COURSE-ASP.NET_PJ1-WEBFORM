

namespace ProyectoHospital.Services
{
    using BusinessRules.Service;
    using System;
    using System.Data;
    using System.Web.UI.WebControls;
    public partial class Services : System.Web.UI.Page
    {
        BrService br = new BrService();
        string codeService = "";
        string description = "";
        string type = "";
        string price = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {

            DataTable dt = new DataTable();
            string Request = br.GetListService();
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
                    var _servcieColumns = list[i].Split('|');
                    dt.Rows.Add(_servcieColumns[0],
                        _servcieColumns[1],
                        _servcieColumns[2],
                        _servcieColumns[3]
                        );

                }
                this.GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            castToTexbox(e);
            Session["dataService"] = (codeService + '|' +
              description + '|' +
              type + '|' +
              price );
            Response.Redirect("ServiceEdition.aspx");
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1; loadData();
        }
        public void castToTexbox(GridViewUpdateEventArgs e)
        {

            codeService = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            description = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            type = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            price = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
           


        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string code_service = GridView1.Rows[e.RowIndex].Cells[1].Text;
            bool Request = br.DeleteService(code_service);
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
    }
}