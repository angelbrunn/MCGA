using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MotoPoint
{
    public partial class AdminGestionPerfiles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (User.IsInRole("Usuario"))
            {
                //SI EL USUARIO NO TIENE PERMISOS LO SACO DE LA WEBMASTER PAGE - GESTION DE PERFILES!
                Response.Redirect("home.aspx");
            }
            else
            {

                //TODO: ARRANCA EL MODULO DE GESTION DE PERFILES
            }
        }
    }
}