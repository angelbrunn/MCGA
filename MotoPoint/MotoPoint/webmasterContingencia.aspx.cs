using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MotoPoint
{
    public partial class admContingencia : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        SIS.BUSINESS.INegBitacora interfazNegocioBitacora = new SIS.BUSINESS.NegBitacora();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.IsInRole("Usuario"))
            {
                //SI EL USUARIO NO TIENE PERMISOS LO SACO DE LA WEBMASTER PAGE - CONTINGENCIAS DE BACKLOG SYSTEM!
                Response.Redirect("home.aspx");
            }
            else
            {
                // ARQ.BASE - GESTION DE BITACORA
                // 1 - BUSCO DATOS DE LOS ERRORES CRITICOS DEL SISTEMA
                //this.GridViewLogSystem.DataSource = interfazNegocioBitacora.obtenerLogSystem();
                // 2 - MUESTRO LOS ERRORES CRITICOS DEL SISTEMA
                this.GridViewLogSystem.DataBind();
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("webmaster.aspx");
        }
    }
}