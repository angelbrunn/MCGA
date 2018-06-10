using System.Collections.Generic;


namespace SIS.BUSINESS
{
    /// <summary>
    /// 
    /// </summary>
    public interface INegBackup
    {
        // ### EXPORTAR ###
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        void exportarAArchivoUsuario(string ruta, string delim);
       /// <summary>
       /// 
       /// </summary>
       /// <param name="ruta"></param>
       /// <param name="delim"></param>
        void exportarAArchivoBitacora(string ruta, string delim);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        void exportarAArchivoUsuarioGrupo(string ruta, string delim);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        void exportarAArchivoGrupo(string ruta, string delim);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        void exportarAArchivoGrupoPermisos(string ruta, string delim);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        void exportarAArchivoMultiIdioma(string ruta, string delim);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        void exportarAArchivoPermisos(string ruta, string delim);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        void importarDesdeArchivoUsuario(string ruta, string delim);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        void importarDesdeArchivoBitacora(string ruta, string delim);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        void importarDesdeArchivoGrupo(string ruta, string delim);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        void importarDesdeArchivoGrupoPermiso(string ruta, string delim);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        void importarDesdeArchivoPermiso(string ruta, string delim);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        void importarDesdeArchivoMultiIdioma(string ruta, string delim);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        void importarDesdeArchivoUsuarioGrupo(string ruta, string delim);
        // ##### INSERT EN BD #####
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaUsuarios"></param>
        void insertarUsuarioDesdeBackup(List<SIS.ENTIDAD.Usuario> listaUsuarios);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaEventos"></param>
        void insertarBitacoraDesdeBackup(List<SIS.ENTIDAD.Bitacora> listaEventos);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaGrupo"></param>
        void insertarGrupoDesdeBackup(List<SIS.ENTIDAD.Grupo> listaGrupo);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaGrupoPermiso"></param>
        void insertarGrupoPermisoDesdeBackup(List<SIS.ENTIDAD.GrupoPermiso> listaGrupoPermiso);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaPermiso"></param>
        void insertarPermisoDesdeBackup(List<SIS.ENTIDAD.Permiso> listaPermiso);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaMultiIdioma"></param>
        void insertarMultiIdiomaDesdeBackup(List<SIS.ENTIDAD.MultiIdioma> listaMultiIdioma);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaUsuarioGrupo"></param>
        void insertarUsuarioGrupoDesdeBackup(List<SIS.ENTIDAD.UsuarioGrupo> listaUsuarioGrupo);
    }
}
