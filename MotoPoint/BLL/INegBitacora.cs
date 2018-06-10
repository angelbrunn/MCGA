using System.Collections.Generic;

namespace SIS.BUSINESS
{
    /// <summary>
    /// 
    /// </summary>
    public interface INegBitacora
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="oBKP"></param>
        void registrarEnBitacora_BKP(string usuarioId, SIS.EXCEPCIONES.BKPException oBKP);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="oBLL"></param>
        void registrarEnBitacora_BLL(string usuarioId, SIS.EXCEPCIONES.BLLExcepcion oBLL);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="oDAL"></param>
        void registrarEnBitacora_DAL(string usuarioId, SIS.EXCEPCIONES.DALExcepcion oDAL);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="oIO"></param>
        void registrarEnBitacora_IO(string usuarioId, SIS.EXCEPCIONES.IOException oIO);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="oSEG"></param>
        void registrarEnBitacora_SEG(string usuarioId, SIS.EXCEPCIONES.SEGExcepcion oSEG);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="oUI"></param>
        void registrarEnBitacora_UI(string usuarioId, SIS.EXCEPCIONES.UIExcepcion oUI);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<SIS.ENTIDAD.Bitacora> obtenerEventosBitacora();
    }
}
