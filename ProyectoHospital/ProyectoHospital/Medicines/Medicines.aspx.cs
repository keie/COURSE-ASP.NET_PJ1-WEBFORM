

namespace ProyectoHospital.Medicines
{
  
    using BusinessRules.Medicine;
    using System;
    using System.Data;
  
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
    }
}