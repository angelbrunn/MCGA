using System.Collections.Generic;

namespace SIS.BUSINESS
{
    /// <summary>
    /// 
    /// </summary>
    public interface INegMultiUsuario
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oUsuario"></param>
        void insertarUsuario(SIS.ENTIDAD.Usuario oUsuario);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int obtenerIdParaUsuario();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        SIS.ENTIDAD.Usuario obtenerUsuario(int idUsuario);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="legajo"></param>
        /// <returns></returns>
        SIS.ENTIDAD.Usuario obtenerUsuarioPorLegajo(int legajo);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        bool validarExistenciaUsuario(string usuario);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idGrupo"></param>
        /// <returns></returns>
        SIS.ENTIDAD.Grupo obtenerGrupoPorId(int idGrupo);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<SIS.ENTIDAD.Grupo> obtenerGrupos();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombreGrupo"></param>
        /// <returns></returns>
        string obtenerDescripcionGrupoPorNombre(string nombreGrupo);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombreGrupo"></param>
        /// <returns></returns>
        SIS.ENTIDAD.Grupo obtenerGrupoPorNombre(string nombreGrupo);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPermiso"></param>
        /// <returns></returns>
        SIS.ENTIDAD.Permiso obtenerPermisoPorId(int idPermiso);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        int login(string usuario, string password);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool verificarConsistenciaBD();
    }
}
