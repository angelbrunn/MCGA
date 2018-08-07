using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;

namespace MotoPoint
{
    public partial class login : System.Web.UI.Page
    {
        /// <summary>
        /// Instancio la clase de arquitectura base | MultiUsuario
        /// </summary>
        SIS.BUSINESS.INegMultiUsuario interfazNegocioUsuario = new SIS.BUSINESS.NegMultiUsuario();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //ARQ.BASE: GESTION LOGIN/LOGOUT - VALIDACION DE ESTADO DE LOGIN
            var loginEstado = Session["loginEstado"];
            if (loginEstado == null)
            {
                Session["loginEstado"] = 0;
            }
            else if (loginEstado.ToString() == "0")
            {
                Session["loginEstado"] = 0;
            }
            else if (loginEstado.ToString() == "1")
            {
                Session["loginEstado"] = 1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var resultadoLogin = 0;
            SIS.ENTIDAD.Usuario user = new SIS.ENTIDAD.Usuario();

            user.usuario = txtUsuario.Text;
            user.Password = txtContrasenia.Text;

            if (txtUsuario.Text != null && txtContrasenia.Text != null)
            {
                //OBTENGO ID DEL USER SI EXISTE
                resultadoLogin = interfazNegocioUsuario.login(user.usuario, user.Password);
            }

            //EVALUO EL RESULTDO DEL LOGIN | SI ES 0 NO EXISTE -> CREAR USUARIO
            if (resultadoLogin != 0)
            {
                //BUSCO EL USUARIO POR SU ID
                var usuario = interfazNegocioUsuario.obtenerUsuario(resultadoLogin);
                //GUARDO EL USUARIO CONECTADO EN SESSION
                Session["Usuario"] = usuario.usuario;
                Session["UsuarioId"] = usuario.IdUsuario;
                Session["UsuarioLoginFecha"] = DateTime.Now;
                Session["UsuarioHost"] = Request.UserHostAddress;
                Session["UsuarioAgent"] = Request.Browser.Browser + "-" + Request.Browser.Version;
                //ME GUARDO LOS GRUPOS PARA EL USUARIO LOGEADO
                List<SIS.ENTIDAD.Grupo> lstGrupos = usuario.ListadoGrupos;
                //NIVEL DE ACCESO DEL USUARIO LOGEADO
                var nVisibilidad = "";

                foreach (SIS.ENTIDAD.Grupo g in lstGrupos)
                {
                    //TOMO LA VISIBILIDAD ASIGNADA A DICHO USUARIO
                    nVisibilidad = g.grupo;
                }

                // CREO UN TICKET DE AUTENTIFICACION Y LO ENCRYPTO: ARQ.BASE.WEBSEGURITY
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                1, // Ticket version
                user.usuario, // Username associated with ticket
                DateTime.Now, // Date/time issued
                DateTime.Now.AddMinutes(30), // Date/time to expire
                true, // "true" for a persistent user cookie
                nVisibilidad, // User-data, in this case the roles
                FormsAuthentication.FormsCookiePath);// Path cookie valid for

                // Encrypt the cookie using the machine key for secure transport
                string hash = FormsAuthentication.Encrypt(ticket);
                HttpCookie loginCookie = new HttpCookie(
                FormsAuthentication.FormsCookieName, // Name of auth cookie
                hash); // Hashed ticket

                // Set the cookie's expiration time to the tickets expiration time
                if (ticket.IsPersistent) loginCookie.Expires = ticket.Expiration;

                // Add the cookie to the list for outgoing response
                Response.Cookies.Add(loginCookie);


                if (nVisibilidad == "Admin")
                {
                    //SI USUARIO ADMIN -> PANTALLA ADMIN
                    Session["loginEstado"] = 0;
                    Response.Redirect("webmaster.aspx");
                }
                else
                {
                    //SI USUARIO ES JERARQUICO O USUARIO -> PANTALLA HOME
                    Session["loginEstado"] = 0;
                    Response.Redirect("home.aspx");
                }
            }
            else
            {
                //MOSTRAR PANTALLA LOGIN | AVISAR USER INVALIDO
                Session["loginEstado"] = 1;
                FormsAuthentication.SignOut();
                Response.Redirect("login.aspx");
            }
        }
    }
}