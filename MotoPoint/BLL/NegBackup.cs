using System;
using System.Collections.Generic;
using System.IO;

namespace SIS.BUSINESS
{
    /// <summary>
    ///     ''' 
    ///     ''' </summary>
    ///     ''' <remarks></remarks>
    public class NegBackup : INegBackup
    {
        /// <summary>
        /// 
        /// </summary>
        //private INegMultiUsuario interfazNegMultiUsuario = new NegMultiUsuario();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        public void exportarAArchivoUsuario(string ruta, string delim)
        {
            /*
            System.IO.SIS.ESCRITURA.IOBackup oIOBackup = new System.IO.SIS.ESCRITURA.IOBackup();
            List<BE.SIS.ENTIDAD.Usuario> listaUsuario = new List<BE.SIS.ENTIDAD.Usuario>();
            DAL.SIS.DATOS.DALUsuario oDalUsuario = new DAL.SIS.DATOS.DALUsuario();

            try
            {
                listaUsuario = oDalUsuario.obtenerTablaUsuario();
                oIOBackup.escribirArchivoUsuario(ruta, delim, listaUsuario);
            }
            catch (Exception ex)
            {
            }
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        public void exportarAArchivoBitacora(string ruta, string delim)
        {
            /*
            System.IO.SIS.ESCRITURA.IOBackup oIOBackup = new System.IO.SIS.ESCRITURA.IOBackup();
            List<BE.SIS.ENTIDAD.Bitacora> listaEventos = new List<BE.SIS.ENTIDAD.Bitacora>();
            DAL.SIS.DATOS.DALBitacora oDalBitacora = new DAL.SIS.DATOS.DALBitacora();

            try
            {
                listaEventos = oDalBitacora.obtenerEventos();
                oIOBackup.escribirArchivoBitacora(ruta, delim, listaEventos);
            }
            catch (Exception ex)
            {
            }
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        public void exportarAArchivoUsuarioGrupo(string ruta, string delim)
        {
            /*
            System.IO.SIS.ESCRITURA.IOBackup oIOBackup = new System.IO.SIS.ESCRITURA.IOBackup();
            List<BE.SIS.ENTIDAD.UsuarioGrupo> listaUsuarioGrupo = new List<BE.SIS.ENTIDAD.UsuarioGrupo>();
            DAL.SIS.DATOS.DALUsuarioGrupo oDalUsuarioGrupo = new DAL.SIS.DATOS.DALUsuarioGrupo();

            try
            {
                listaUsuarioGrupo = oDalUsuarioGrupo.obtenerTablaUsuarioGrupo();
                oIOBackup.escribirArchivoUsuarioGrupo(ruta, delim, listaUsuarioGrupo);
            }
            catch (Exception ex)
            {
            }
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        public void exportarAArchivoGrupo(string ruta, string delim)
        {
            /*
            System.IO.SIS.ESCRITURA.IOBackup oIOBackup = new System.IO.SIS.ESCRITURA.IOBackup();
            List<BE.SIS.ENTIDAD.Grupo> listaGrupo = new List<BE.SIS.ENTIDAD.Grupo>();
            DAL.SIS.DATOS.DALGrupo oDalGrupo = new DAL.SIS.DATOS.DALGrupo();

            try
            {
                listaGrupo = oDalGrupo.obtenerGrupos();
                oIOBackup.escribirArchivoGrupo(ruta, delim, listaGrupo);
            }
            catch (IOException ex)
            {
            }
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        public void exportarAArchivoGrupoPermisos(string ruta, string delim)
        {
            /*
            System.IO.SIS.ESCRITURA.IOBackup oIOBackup = new System.IO.SIS.ESCRITURA.IOBackup();
            List<BE.SIS.ENTIDAD.GrupoPermiso> listaGrupoPermiso = new List<BE.SIS.ENTIDAD.GrupoPermiso>();
            DAL.SIS.DATOS.DALGrupoPermiso oDalGrupoPermiso = new DAL.SIS.DATOS.DALGrupoPermiso();

            try
            {
                listaGrupoPermiso = oDalGrupoPermiso.obtenerGrupoPermiso();
                oIOBackup.escribirArchivoGrupoPermiso(ruta, delim, listaGrupoPermiso);
            }
            catch (IOException ex)
            {
            }
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        public void exportarAArchivoPermisos(string ruta, string delim)
        {
            /*
            System.IO.SIS.ESCRITURA.IOBackup oIOBackup = new System.IO.SIS.ESCRITURA.IOBackup();
            List<BE.SIS.ENTIDAD.Permiso> listaPermiso = new List<BE.SIS.ENTIDAD.Permiso>();
            DAL.SIS.DATOS.DALPermiso oDalPermiso = new DAL.SIS.DATOS.DALPermiso();

            try
            {
                listaPermiso = oDalPermiso.obtenerPermiso();
                oIOBackup.escribirArchivoPermiso(ruta, delim, listaPermiso);
            }
            catch (IOException ex)
            {
            }
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        public void exportarAArchivoMultiIdioma(string ruta, string delim)
        {
            /*
            System.IO.SIS.ESCRITURA.IOBackup oIOBackup = new System.IO.SIS.ESCRITURA.IOBackup();
            List<BE.SIS.ENTIDAD.MultiIdioma> listaMultiIdioma = new List<BE.SIS.ENTIDAD.MultiIdioma>();
            DAL.SIS.DATOS.DALMultiIdioma oDalMultiIdioma = new DAL.SIS.DATOS.DALMultiIdioma();

            try
            {
                listaMultiIdioma = oDalMultiIdioma.obtenerTablaMultiIdiomaAll();
                oIOBackup.escribirArchivoMultiIdioma(ruta, delim, listaMultiIdioma);
            }
            catch (IOException ex)
            {
            }
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        public void importarDesdeArchivoUsuario(string ruta, string delim)
        {
            /*
            System.IO.SIS.ESCRITURA.IOBackup oIOBackup = new System.IO.SIS.ESCRITURA.IOBackup();
            List<BE.SIS.ENTIDAD.Usuario> listaUsuario = new List<BE.SIS.ENTIDAD.Usuario>();

            listaUsuario = oIOBackup.leerArchivoUsuario(ruta, delim);

            this.insertarUsuarioDesdeBackup(listaUsuario);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        public void importarDesdeArchivoBitacora(string ruta, string delim)
        {
            /*
            System.IO.SIS.ESCRITURA.IOBackup oIOBackup = new System.IO.SIS.ESCRITURA.IOBackup();
            List<BE.SIS.ENTIDAD.Bitacora> listaBitacora = new List<BE.SIS.ENTIDAD.Bitacora>();

            listaBitacora = oIOBackup.leerArchivoBitacora(ruta, delim);

            this.insertarBitacoraDesdeBackup(listaBitacora);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        public void importarDesdeArchivoGrupo(string ruta, string delim)
        {
            /*
            System.IO.SIS.ESCRITURA.IOBackup oIOBackup = new System.IO.SIS.ESCRITURA.IOBackup();
            List<BE.SIS.ENTIDAD.Grupo> listaGrupo = new List<BE.SIS.ENTIDAD.Grupo>();

            listaGrupo = oIOBackup.leerArchivoGrupo(ruta, delim);

            this.insertarGrupoDesdeBackup(listaGrupo);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        public void importarDesdeArchivoGrupoPermiso(string ruta, string delim)
        {
            /*
            System.IO.SIS.ESCRITURA.IOBackup oIOBackup = new System.IO.SIS.ESCRITURA.IOBackup();
            List<BE.SIS.ENTIDAD.GrupoPermiso> listaGrupoPermiso = new List<BE.SIS.ENTIDAD.GrupoPermiso>();

            listaGrupoPermiso = oIOBackup.leerArchivoGrupoPermiso(ruta, delim);

            this.insertarGrupoPermisoDesdeBackup(listaGrupoPermiso);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        public void importarDesdeArchivoPermiso(string ruta, string delim)
        {
            /*
            System.IO.SIS.ESCRITURA.IOBackup oIOBackup = new System.IO.SIS.ESCRITURA.IOBackup();
            List<BE.SIS.ENTIDAD.Permiso> listaPermiso = new List<BE.SIS.ENTIDAD.Permiso>();

            listaPermiso = oIOBackup.leerArchivoPermiso(ruta, delim);

            this.insertarPermisoDesdeBackup(listaPermiso);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        public void importarDesdeArchivoMultiIdioma(string ruta, string delim)
        {
            /*
            System.IO.SIS.ESCRITURA.IOBackup oIOBackup = new System.IO.SIS.ESCRITURA.IOBackup();
            List<BE.SIS.ENTIDAD.MultiIdioma> listaMultiIdioma = new List<BE.SIS.ENTIDAD.MultiIdioma>();

            listaMultiIdioma = oIOBackup.leerArchivoMultiIdioma(ruta, delim);

            this.insertarMultiIdiomaDesdeBackup(listaMultiIdioma);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        public void importarDesdeArchivoUsuarioGrupo(string ruta, string delim)
        {
            /*
            System.IO.SIS.ESCRITURA.IOBackup oIOBackup = new System.IO.SIS.ESCRITURA.IOBackup();
            List<BE.SIS.ENTIDAD.UsuarioGrupo> listaUsuarioGrupo = new List<BE.SIS.ENTIDAD.UsuarioGrupo>();

            listaUsuarioGrupo = oIOBackup.leerArchivoUsuarioGrupo(ruta, delim);

            this.insertarUsuarioGrupoDesdeBackup(listaUsuarioGrupo);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaUsuarios"></param>
        public void insertarUsuarioDesdeBackup(List<SIS.ENTIDAD.Usuario> listaUsuarios)
        {
            /*
            DAL.SIS.DATOS.DALUsuario oDalUsuario = new DAL.SIS.DATOS.DALUsuario();

            oDalUsuario.insertarUsuarioDesdeBackup(listaUsuarios);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaEventos"></param>
        public void insertarBitacoraDesdeBackup(List<SIS.ENTIDAD.Bitacora> listaEventos)
        {
            /*
            DAL.SIS.DATOS.DALBitacora oDalBitacora = new DAL.SIS.DATOS.DALBitacora();

            oDalBitacora.insertarBitacoraDesdeBackup(listaEventos);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaGrupo"></param>
        public void insertarGrupoDesdeBackup(List<SIS.ENTIDAD.Grupo> listaGrupo)
        {
            /*
            DAL.SIS.DATOS.DALBitacora oDalBitacora = new DAL.SIS.DATOS.DALBitacora();

            oDalBitacora.insertarGrupoDesdeBackup(listaGrupo);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaGrupoPermiso"></param>
        public void insertarGrupoPermisoDesdeBackup(List<SIS.ENTIDAD.GrupoPermiso> listaGrupoPermiso)
        {
            /*
            DAL.SIS.DATOS.DALBitacora oDalBitacora = new DAL.SIS.DATOS.DALBitacora();

            oDalBitacora.insertarGrupoPermisoDesdeBackup(listaGrupoPermiso);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaMultiIdioma"></param>
        public void insertarMultiIdiomaDesdeBackup(List<SIS.ENTIDAD.MultiIdioma> listaMultiIdioma)
        {
            /*
            DAL.SIS.DATOS.DALBitacora oDalBitacora = new DAL.SIS.DATOS.DALBitacora();

            oDalBitacora.insertarMultiIdiomaDesdeBackup(listaMultiIdioma);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaPermiso"></param>
        public void insertarPermisoDesdeBackup(List<SIS.ENTIDAD.Permiso> listaPermiso)
        {
            /*
            DAL.SIS.DATOS.DALBitacora oDalBitacora = new DAL.SIS.DATOS.DALBitacora();

            oDalBitacora.insertarPermisoDesdeBackup(listaPermiso);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaUsuarioGrupo"></param>
        public void insertarUsuarioGrupoDesdeBackup(List<SIS.ENTIDAD.UsuarioGrupo> listaUsuarioGrupo)
        {
            /*
            DAL.SIS.DATOS.DALBitacora oDalBitacora = new DAL.SIS.DATOS.DALBitacora();

            oDalBitacora.insertarUsuarioGrupoDesdeBackup(listaUsuarioGrupo);
            */
        }
    }
}
