using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoHospital
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //lblData.Text = (String)Session["codeEmployee"];
        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            if (Menu1.Items[0].Selected)
            {
                Response.Redirect("Mantenimiento.aspx");
            }
            if (Menu1.Items[1].Selected)
            {
                Response.Redirect("Hospitalizacion.aspx");
            }
            if (Menu1.Items[2].Selected)
            {
                Response.Redirect("RegistroConsumo.aspx");
            }
            if (Menu1.Items[3].Selected)
            {
                Response.Redirect("ControlPago.aspx");
            }
            if (Menu1.Items[4].Selected)
            {
                Response.Redirect("Reportes.aspx");
            }
        }
    }
}
