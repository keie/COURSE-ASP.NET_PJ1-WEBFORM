

namespace ProyectoHospital.Medicines
{
  
    using BusinessRules.Medicine;
    using System;
    using System.Data;
    using System.Web.UI.WebControls;

    public partial class Medicines : System.Web.UI.Page
    {
        BrMedicine br = new BrMedicine();
        string codeMedicine = "";
        string name = "";
        string lab = "";
        string price = "";
        string stock = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {

            DataTable dt = new DataTable();
            string Request = br.GetListMedicine();
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
                    var _medicineColumns = list[i].Split('|');
                    dt.Rows.Add(_medicineColumns[0],
                        _medicineColumns[1],
                        _medicineColumns[2],
                        _medicineColumns[3],
                        _medicineColumns[4]);

                }
                this.GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
        }

        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            castToTexbox(e);
            Session["dataMedicine"] = (codeMedicine + '|' +
              name + '|' +
              lab + '|' +
              price + '|' +
              stock );
            Response.Redirect("MedicineEdition.aspx");
        }

        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1; loadData();
        }
        public void castToTexbox(GridViewUpdateEventArgs e)
        {

            codeMedicine = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            lab = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            price = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            stock = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;
           


        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string code_medicine = GridView1.Rows[e.RowIndex].Cells[1].Text;
            bool Request = br.DeleteMedicine(code_medicine);
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