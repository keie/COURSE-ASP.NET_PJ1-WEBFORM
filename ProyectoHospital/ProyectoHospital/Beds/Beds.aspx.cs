


namespace ProyectoHospital.Beds
{
    using BusinessRules.Bed;
    using System;
    using System.Data;
    using System.Web.UI.WebControls;
    public partial class Beds1 : System.Web.UI.Page
    {
        BrBed br = new BrBed();
        string nro_cama = "";
        string category = "";
        string price_daily = "";
        string state = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {

            DataTable dt = new DataTable();
            string Request = br.GetListBed();
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
                    var _bedColumns = list[i].Split('|');
                    dt.Rows.Add(_bedColumns[0],
                        _bedColumns[1],
                        _bedColumns[2],
                        _bedColumns[3]
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