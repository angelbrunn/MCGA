using System;
using System.Collections.Generic;

namespace SIS.BUSINESS
{
    /// <summary>
    /// 
    /// </summary>
    public class NegMultiIdioma : INegMultiIdioma
    {
        /// <summary>
        /// 
        /// </summary>
        private SIS.ENTIDAD.Usuario unUsuarioField;
        /// <summary>
        /// 
        /// </summary>
        private INegBitacora interfazNegocioBitacora = new NegBitacora();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idioma"></param>
        /// <returns></returns>
        public List<SIS.ENTIDAD.MultiIdioma> obtenerTablaMultiIdioma(string idioma)
        {
            List<SIS.ENTIDAD.MultiIdioma> listaMultiIdioma = new List<SIS.ENTIDAD.MultiIdioma>(new SIS.ENTIDAD.MultiIdioma[] { });
            /*
            DAL.SIS.DATOS.DALMultiIdioma oDalMultiIdioma = new DAL.SIS.DATOS.DALMultiIdioma();

            try
            {
                listaMultiIdioma = oDalMultiIdioma.obtenerTablaMultiIdioma(idioma);
            }
            catch (Exception ex)
            {
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex);
            }
            */
            return listaMultiIdioma;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<SIS.ENTIDAD.MultiIdioma> obtenerIdiomasDisponibles()
        {
            List<SIS.ENTIDAD.MultiIdioma> listaIdiomas = new List<SIS.ENTIDAD.MultiIdioma>(new SIS.ENTIDAD.MultiIdioma[] { });
            /*
            SIS.DATOS.DALMultiIdioma oDalMultiIdioma = new DAL.SIS.DATOS.DALMultiIdioma();

            try
            {
                listaIdiomas = oDalMultiIdioma.idiomasDisponibles();
            }
            catch (Exception ex)
            {
                interfazNegocioBitacora.registrarEnBitacora_BLL(unUsuario.idUsuario, ex);
            }
            */
            return listaIdiomas;
        }
        /// <summary>
        /// 
        /// </summary>
        public SIS.ENTIDAD.Usuario unUsuario
        {
            get
            {
                return unUsuarioField;
            }
            set
            {
                unUsuarioField = value;
            }
        }
    }
}
