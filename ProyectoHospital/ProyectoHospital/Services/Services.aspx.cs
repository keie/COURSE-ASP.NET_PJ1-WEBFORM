

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
    }
}