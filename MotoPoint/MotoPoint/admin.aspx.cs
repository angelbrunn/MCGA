using System;

namespace MotoPoint
{
    public partial class admin : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["dbEstado"] = 2;
        }
        /// <summary>
        /// REDIRECCIONO HACIA EL HOME PAGE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
        /// <summary>
        ///  ARQ.BASE: GESTION DE PERFILES
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkGestionPerfiles_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminGestionPerfiles.aspx");
        }
    }
}