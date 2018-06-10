using System.Collections.Generic;

namespace SIS.BUSINESS
{
    public interface INegMultiIdioma
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idioma"></param>
        /// <returns></returns>
        List<SIS.ENTIDAD.MultiIdioma> obtenerTablaMultiIdioma(string idioma);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<SIS.ENTIDAD.MultiIdioma> obtenerIdiomasDisponibles();
    }
}
