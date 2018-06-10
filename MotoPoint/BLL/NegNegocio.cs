using System;

namespace SIS.BUSINESS
{
    public class NegNegocio
    {
        /// <summary>
        /// 
        /// </summary>
        private INegBitacora interfazNegocioBitacora = new NegBitacora();
        /// <summary>
        /// 
        /// </summary>
        private SIS.ENTIDAD.Usuario unUsuarioField;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool validarPrimeraConexion()
        {
            bool isFirts = false;
            /*
            SIS.DATOS.DALAuditoria oDalAuditoria = new SIS.DATOS.DALAuditoria();
            try
            {
                var id = oDalAuditoria.primeraConexion();

                if (id != 0)
                    // DB ESTA CONFIGURADA
                    isFirts = true;
                else
                    // NO DB ESTA CONFIGURADA
                    isFirts = false;
                return isFirts;
            }
            catch (Exception ex)
            {
                interfazNegocioBitacora.registrarEnBitacora_BLL("SYS_DB_CONN", ex);
                return isFirts;
            }
            */
            //FIXME: delete
            return isFirts;
        }
    }
}
