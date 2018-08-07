using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace MotoPoint
{
    public partial class admin : System.Web.UI.Page
    {
        /// <summary>
        /// 
        /// </summary>
        SIS.BUSINESS.INegMultiUsuario interfazNegocioUsuario = new SIS.BUSINESS.NegMultiUsuario();
        /// <summary>
        /// 
        /// </summary>
        SIS.BUSINESS.INegBitacora interfazNegocioBitacora = new SIS.BUSINESS.NegBitacora();
        /// <summary>
        /// 
        /// </summary>
        SIS.BUSINESS.INegBackup interfazNegocioBackup = new SIS.BUSINESS.NegBackup();
        /// <summary>
        /// 
        /// </summary>
        List<SIS.ENTIDAD.Bitacora> listBitacora = new List<SIS.ENTIDAD.Bitacora>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (User.IsInRole("Usuario"))
            {
                //SI EL USUARIO NO TIENE PERMISOS LO SACO DE LA WEBMASTER PAGE!
                Response.Redirect("home.aspx");
            }
            else
            {
                // ARQ.BASE - DIGITO VERIFICADO - TABLA:USUARIOS
                bool resultadoConsistenciaUsuarios = false;
                // ARQ.BASE - DIGITO VERIFICADO - TABLA:USUARIOS
                bool resultadoConsistenciaBitacora = false;

                // 1 - VERIFICO CONSISTENCIA DE LA BASE DE DATOS POR MEDIO DEL DIGITO VERIFICADOR - TABLA USUARIOS| FALSE:ERROR / TRUE:ISOK
                //resultadoConsistenciaUsuarios = interfazNegocioUsuario.verificarConsistenciaUsuarioBD();
                // 1 - VERIFICO CONSISTENCIA DE LA BASE DE DATOS POR MEDIO DEL DIGITO VERIFICADOR - TABLA USUARIOS| FALSE:ERROR / TRUE:ISOK
                //resultadoConsistenciaBitacora = interfazNegocioBitacora.verificarConsistenciaBD();

                if (resultadoConsistenciaUsuarios == false || resultadoConsistenciaBitacora == false)
                {
                    // MENSAJE ERROR CRITICO | BANNER ROJO
                    Session["dbEstado"] = 1;
                    Session["dbContingencia"] = 1;
                }
                else
                {
                    //MENSAJE OK | BANNER VERDE
                    Session["dbEstado"] = 0;
                    Session["dbContingencia"] = 0;
                }
                // ARQ.BASE - GESTION DE BACKUP
                var TxBackUp = Session["TxBackup"];
                var TxExportar = Session["fExportar"];
                var TxImportar = Session["fImportar"];
                string Tx = "0";
                string TxE = "0";
                string TxI = "0";
                if (TxBackUp != null)
                {
                    Tx = TxBackUp.ToString();
                }

                if (Tx == "1")
                {
                    TxE = TxExportar.ToString();
                    TxI = TxImportar.ToString();
                    if (TxE == "1")
                    {
                        Session["fExportar"] = 1;
                        Session["fImportar"] = 0;
                        TxE = "0";
                    }
                    else if (TxI == "1")
                    {
                        Session["fExportar"] = 0;
                        Session["fImportar"] = 1;
                        TxI = "0";
                    }
                }
                else if (Tx == "0")
                {
                    TxE = "0";
                    TxI = "0";
                    Session["fExportar"] = 0;
                    Session["fImportar"] = 0;
                }
            }
            // ARQ.BASE - GESTION DE BITACORA
            // 2 - BUSCO DATOS DE LA TABLA BITACORA PARA EVALUAR ERRORES DEL SISTEMA
            listBitacora = interfazNegocioBitacora.obtenerEventosBitacora();

            TableRow row;
            TableCell CellIdEvento;
            TableCell CellIdUsuario;
            TableCell CellDescripcion;
            TableCell CellFecha;

            foreach (SIS.ENTIDAD.Bitacora _bitacora in listBitacora)
            {
                row = new TableRow();
                CellIdEvento = new TableCell();
                CellIdUsuario = new TableCell();
                CellDescripcion = new TableCell();
                CellFecha = new TableCell();

                CellIdEvento.Text = _bitacora.IdEvento.ToString();
                CellIdUsuario.Text = _bitacora.IdUsuario.ToString();
                CellDescripcion.Text = _bitacora.Descripcion;
                CellFecha.Text = _bitacora.Fecha.ToString();

                if (CellIdEvento.Text != "1")
                {
                    row.Cells.Add(CellIdEvento);
                    row.Cells.Add(CellIdUsuario);
                    row.Cells.Add(CellDescripcion);
                    row.Cells.Add(CellFecha);

                    tbBitacora.Rows.Add(row);
                }

            }
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
            Response.Redirect("webmasterGestionPerfiles.aspx");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void linkContingencia_Click(object sender, EventArgs e)
        {
            Response.Redirect("webmasterContingencia.aspx");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSalir_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("login.aspx");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnExportar_Click(object sender, EventArgs e)
        {
            var ruta = "";
            var validarExportar = true;
            Session["fExportar"] = 0;
            Session["fImportar"] = 0;
            Session["TxBackup"] = 1;
            try
            {
                if (chkbxBitacora.Checked)
                {
                    ruta = "C:\\MotoPoint";
                    ruta = ruta + "\\bkp_Bitacora.csv";
                    interfazNegocioBackup.exportarAArchivoBitacora(ruta, ";");
                }

                if (chkbxUsuario.Checked)
                {
                    ruta = "C:\\MotoPoint";
                    ruta = ruta + "\\bkp_Usuario.csv";
                    interfazNegocioBackup.exportarAArchivoUsuario(ruta, ";");
                }

                if (chkbxGrupo.Checked)
                {
                    ruta = "C:\\MotoPoint";
                    ruta = ruta + "\\bkp_Grupo.csv";
                    interfazNegocioBackup.exportarAArchivoGrupo(ruta, ";");
                }

                if (chkbxGrupoPermiso.Checked)
                {
                    ruta = "C:\\MotoPoint";
                    ruta = ruta + "\\bkp_GrupoPermiso.csv";
                    interfazNegocioBackup.exportarAArchivoGrupoPermisos(ruta, ";");
                }

                if (chkbxPermiso.Checked)
                {
                    ruta = "C:\\MotoPoint";
                    ruta = ruta + "\\bkp_Permiso.csv";
                    interfazNegocioBackup.exportarAArchivoPermisos(ruta, ";");
                }

                if (chkbxMultiIdioma.Checked)
                {
                    ruta = "C:\\MotoPoint";
                    ruta = ruta + "\\bkp_MultiIdioma.csv";
                    interfazNegocioBackup.exportarAArchivoMultiIdioma(ruta, ";");
                }

                if (chkbxUsuarioGrupo.Checked)
                {
                    ruta = "C:\\MotoPoint";
                    ruta = ruta + "\\bkp_UsuarioGrupo.csv";
                    interfazNegocioBackup.exportarAArchivoUsuarioGrupo(ruta, ";");
                }

            }
            catch (Exception ex)
            {
                validarExportar = false;
                new SIS.EXCEPCIONES.UIExcepcion(ex.Message);
            }

            if (!(chkbxBitacora.Checked || chkbxUsuario.Checked || chkbxGrupo.Checked || chkbxGrupoPermiso.Checked || chkbxPermiso.Checked || chkbxMultiIdioma.Checked || chkbxUsuarioGrupo.Checked))
            {
                validarExportar = false;
            }

            if (validarExportar)
            {
                //Feedback de exportacion | 1:isok 0:isErrok
                Session["fExportar"] = 1;
            }

            Response.Redirect("webmaster.aspx");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnImportar_Click(object sender, EventArgs e)
        {
            var ruta = "";
            var validarImportar = true;
            Session["fImportar"] = 0;
            Session["fExportar"] = 0;
            Session["TxBackup"] = 1;
            try
            {
                if (chkbxBitacora.Checked)
                {
                    ruta = "C:\\MotoPoint";
                    ruta = ruta + "\\bkp_Bitacora.csv";
                    interfazNegocioBackup.importarDesdeArchivoBitacora(ruta, ";");
                }

                if (chkbxUsuario.Checked)
                {
                    ruta = "C:\\MotoPoint";
                    ruta = ruta + "\\bkp_Usuario.csv";
                    interfazNegocioBackup.importarDesdeArchivoUsuario(ruta, ";");
                }

                if (chkbxGrupo.Checked)
                {
                    ruta = "C:\\MotoPoint";
                    ruta = ruta + "\\bkp_Grupo.csv";
                    interfazNegocioBackup.importarDesdeArchivoGrupo(ruta, ";");
                }

                if (chkbxGrupoPermiso.Checked)
                {
                    ruta = "C:\\MotoPoint";
                    ruta = ruta + "\\bkp_GrupoPermiso.csv";
                    interfazNegocioBackup.importarDesdeArchivoGrupoPermiso(ruta, ";");
                }

                if (chkbxPermiso.Checked)
                {
                    ruta = "C:\\MotoPoint";
                    ruta = ruta + "\\bkp_Permiso.csv";
                    interfazNegocioBackup.importarDesdeArchivoPermiso(ruta, ";");
                }

                if (chkbxMultiIdioma.Checked)
                {
                    ruta = "C:\\MotoPoint";
                    ruta = ruta + "\\bkp_MultiIdioma.csv";
                    interfazNegocioBackup.importarDesdeArchivoMultiIdioma(ruta, ";");
                }

                if (chkbxUsuarioGrupo.Checked)
                {
                    ruta = "C:\\MotoPoint";
                    ruta = ruta + "\\bkp_UsuarioGrupo.csv";
                    interfazNegocioBackup.importarDesdeArchivoUsuarioGrupo(ruta, ";");
                }
            }
            catch (Exception ex)
            {
                validarImportar = false;
                new SIS.EXCEPCIONES.UIExcepcion(ex.Message);
            }

            if (!(chkbxBitacora.Checked || chkbxUsuario.Checked || chkbxGrupo.Checked || chkbxGrupoPermiso.Checked || chkbxPermiso.Checked || chkbxMultiIdioma.Checked || chkbxUsuarioGrupo.Checked))
            {
                validarImportar = false;
            }

            if (validarImportar)
            {
                //Feedback de Importacion | 1:isok 0:isErrok
                Session["fImportar"] = 1;
            }

            Response.Redirect("webmaster.aspx");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnTbitacora_Click(object sender, EventArgs e)
        {
            //##### USUARIO A PERSISTIR #####
            string usuarioIdSession = Session["UsuarioId"].ToString();
            //##### OBJETOS A PERSISTIR #####
            SIS.ENTIDAD.Bitacora oBitacora_DAL = new SIS.ENTIDAD.Bitacora();
            SIS.ENTIDAD.Bitacora oBitacora_IO = new SIS.ENTIDAD.Bitacora();
            SIS.ENTIDAD.Bitacora oBitacora_BLL = new SIS.ENTIDAD.Bitacora();
            SIS.ENTIDAD.Bitacora oBitacora_BKP = new SIS.ENTIDAD.Bitacora();
            SIS.ENTIDAD.Bitacora oBitacora_SEG = new SIS.ENTIDAD.Bitacora();
            SIS.ENTIDAD.Bitacora oBitacora_UI = new SIS.ENTIDAD.Bitacora();
            //##### EDITO UN MENSAJE PARA UNA EXCEPCION DE TEST #####
            oBitacora_DAL.Descripcion = "Probando desde depuracion,insercion de Trazas.";
            oBitacora_IO.Descripcion = "Probando desde depuracion,insercion de Trazas.";
            oBitacora_BLL.Descripcion = "Probando desde depuracion,insercion de Trazas.";
            oBitacora_BKP.Descripcion = "Probando desde depuracion,insercion de Trazas.";
            oBitacora_SEG.Descripcion = "Probando desde depuracion,insercion de Trazas.";
            oBitacora_UI.Descripcion = "Probando desde depuracion,insercion de Trazas.";
            //##### CONSTRUYO LA EXCEPCION DE TEST SEGUN TIPO DE EXCEPCION #####
            var exc_DAL = new SIS.EXCEPCIONES.DALExcepcion(oBitacora_DAL.Descripcion);
            var exc_IO = new SIS.EXCEPCIONES.IOException(oBitacora_IO.Descripcion);
            var exc_BLL = new SIS.EXCEPCIONES.BLLExcepcion(oBitacora_BLL.Descripcion);
            var exc_BKP = new SIS.EXCEPCIONES.BKPException(oBitacora_BKP.Descripcion);
            var exc_SEG = new SIS.EXCEPCIONES.SEGExcepcion(oBitacora_SEG.Descripcion);
            var exc_UI = new SIS.EXCEPCIONES.UIExcepcion(oBitacora_UI.Descripcion);
            //##### EJECUTO TRAZA VIA BLL SEGUN TIPO DE EXCP QUE CORRESPONDA #####
            interfazNegocioBitacora.registrarEnBitacora_BKP(usuarioIdSession, exc_BKP);

            /*
            interfazNegocioBitacora.registrarEnBitacora_BLL(usuarioIdSession, exc_BLL);
            interfazNegocioBitacora.registrarEnBitacora_DAL(usuarioIdSession, exc_DAL);
            interfazNegocioBitacora.registrarEnBitacora_IO(usuarioIdSession, exc_IO);
            interfazNegocioBitacora.registrarEnBitacora_SEG(usuarioIdSession, exc_SEG);
            interfazNegocioBitacora.registrarEnBitacora_UI(usuarioIdSession, exc_UI);
            */
            Response.Redirect("webmaster.aspx");
        }

    }
}