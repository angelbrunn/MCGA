using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MotoPoint
{
    public partial class login : System.Web.UI.Page
    {
        /// <summary>
        /// Instancio la clase de arquitectura base | MultiUsuario
        /// </summary>
        //SIS.BUSINESS.INegMultiUsuario interfazNegocioUsuario = new SIS.BUSINESS.NegMultiUsuario();

        FormsAuthenticationTicket authTicket;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = txtUsuario.Text;
            Session["Contraseña"] = txtContrasenia.Text;
            
            //VALIDAR LOGIN | + INTENTOS

            //REDIREC SEGUN ROL
            Response.Redirect("Respuesta_EjercicioVarSession.aspx");

            
            var resultadoLogin = 0;
            SIS.ENTIDAD.Usuario user = new SIS.ENTIDAD.Usuario();

            user.usuario = txtUsuario.Text;
            user.Password = txtContrasenia.Text;

            if (txtUsuario.Text != null && txtContrasenia.Text != null)
            {
                //OBTENGO ID DEL USER SI EXISTE
                //resultadoLogin = interfazNegocioUsuario.login(user.usuario, user.password);
            }

            //EVALUO EL RESULTDO DEL LOGIN | SI ES 0 NO EXISTE -> CREAR USUARIO
            if (resultadoLogin != 0)
            {
                //BUSCO EL USUARIO POR SU ID
                var usuario = user;
                //var usuario = interfazNegocioUsuario.obtenerUsuario(resultadoLogin);
                //GUARDO EL USUARIO CONECTADO EN SESSION
                Session["Usuario"] = usuario.usuario;
                Session["UsuarioId"] = usuario.IdUsuario;
                //ME GUARDO LOS GRUPOS PARA EL USUARIO LOGEADO
                List<SIS.ENTIDAD.Grupo> lstGrupos = usuario.ListadoGrupos;
                //NIVEL DE ACCESO DEL USUARIO LOGEADO
                var nVisibilidad = "";

                foreach (SIS.ENTIDAD.Grupo g in lstGrupos)
                {
                    //TOMO LA VISIBILIDAD ASIGNADA A DICHO USUARIO
                    nVisibilidad = g.grupo;
                }

                if (nVisibilidad == "Admin")
                {
                    //SI USUARIO ADMIN -> PANTALLA ADMIN
                    /*
                    authTicket = new FormsAuthenticationTicket(1, usuario.usuario, DateTime.Now, DateTime.Now.AddMinutes(20), false, nVisibilidad);
                    string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                    var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                    HttpContext.Response.Cookies.Add(authCookie);
                    */
                    Response.Redirect("Admin.aspx");
                }
                else
                {
                    //SI USUARIO ES JERARQUICO O USUARIO -> PANTALLA HOME
                    /*
                    authTicket = new FormsAuthenticationTicket(1, usuario.usuario, DateTime.Now, DateTime.Now.AddMinutes(20), false, nVisibilidad);
                    string encryptedTicket = FormsAuthentication.Encrypt(authTicket);
                    var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                    HttpContext.Response.Cookies.Add(authCookie);
                    */
                    Response.Redirect("home.aspx");
                }
            }
            else
            {
                //MOSTRAR PANTALLA LOGIN | AVISAR USER INVALIDO
                Session["loginEstado"] = 1;
                FormsAuthentication.SignOut();
            }












        }
    }
}