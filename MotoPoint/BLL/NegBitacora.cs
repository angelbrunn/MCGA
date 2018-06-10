using System.Collections.Generic;

namespace SIS.BUSINESS
{
    /// <summary>
    /// 
    /// </summary>
    public class NegBitacora : INegBitacora
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="oBKP"></param>
        public void registrarEnBitacora_BKP(string usuarioId, SIS.EXCEPCIONES.BKPException oBKP)
        {
            /*
            SIS.BIT.Bitacora oBITBitacora = new SIS.BIT.Bitacora();
            oBITBitacora.registrarEnBitacora_BKP(usuarioId, oBKP);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="oBLL"></param>
        public void registrarEnBitacora_BLL(string usuarioId, SIS.EXCEPCIONES.BLLExcepcion oBLL)
        {
            /*
            BL.SIS.BIT.Bitacora oBITBitacora = new BL.SIS.BIT.Bitacora();
            oBITBitacora.registrarEnBitacora_BLL(usuarioId, oBLL);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="oDAL"></param>
        public void registrarEnBitacora_DAL(string usuarioId, SIS.EXCEPCIONES.DALExcepcion oDAL)
        {
            /*
            BL.SIS.BIT.Bitacora oBITBitacora = new BL.SIS.BIT.Bitacora();
            oBITBitacora.registrarEnBitacora_DAL(usuarioId, oDAL);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="oIO"></param>
        public void registrarEnBitacora_IO(string usuarioId, SIS.EXCEPCIONES.IOException oIO)
        {
            /*
            BL.SIS.BIT.Bitacora oBITBitacora = new BL.SIS.BIT.Bitacora();
            oBITBitacora.registrarEnBitacora_IO(usuarioId, oIO);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="oSEG"></param>
        public void registrarEnBitacora_SEG(string usuarioId, SIS.EXCEPCIONES.SEGExcepcion oSEG)
        {
            /*
            BL.SIS.BIT.Bitacora oBITBitacora = new BL.SIS.BIT.Bitacora();
            oBITBitacora.registrarEnBitacora_SEG(usuarioId, oSEG);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioId"></param>
        /// <param name="oUI"></param>
        public void registrarEnBitacora_UI(string usuarioId, SIS.EXCEPCIONES.UIExcepcion oUI)
        {
            /*
            BL.SIS.BIT.Bitacora oBITBitacora = new BL.SIS.BIT.Bitacora();
            oBITBitacora.registrarEnBitacora_UI(usuarioId, oUI);
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<SIS.ENTIDAD.Bitacora> obtenerEventosBitacora()
        {
            List<SIS.ENTIDAD.Bitacora> listadoEventos = new List<SIS.ENTIDAD.Bitacora>();
            /*

            BL.SIS.BIT.Bitacora oBITBitacora = new BL.SIS.BIT.Bitacora();
            listadoEventos = oBITBitacora.obtenerEventos;

            */
            return listadoEventos;
        }
    }
}
