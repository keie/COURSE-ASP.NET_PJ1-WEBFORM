
namespace ProyectoHospital.Employess
{
    using BusinessRules.Employee;
    using System;
    using System.Data;


    public partial class Employess : System.Web.UI.Page
    {
        BrEmployee br = new BrEmployee();
        protected void Page_Load(object sender, EventArgs e)
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
                for(int i = 0; i <= columnsHeader.Length-1; i++) //cabeceras
                {
                    dt.Columns.Add(columnsHeader[i]);
                }
                for (int i = 1; i <= list.Length-1; i++) //contenidoEmpleado
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
    }
}