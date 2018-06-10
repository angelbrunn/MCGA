using System.Collections.Generic;

namespace SIS.IO
{
    /// <summary>
    /// 
    /// </summary>
    public interface IHash
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sCadena"></param>
        /// <returns></returns>
        string generarSHA(string sCadena);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        string obtenerHash(string cadena);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oUsuario"></param>
        /// <returns></returns>
        string obtenerHashUsuario(SIS.ENTIDAD.Usuario oUsuario);
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
        bool verificarConsistenciaBD();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaUsuario"></param>
        /// <returns></returns>
        List<SIS.ENTIDAD.Usuario> calcularHashTablaUsuario(List<SIS.ENTIDAD.Usuario> listaUsuario);
    }
}
