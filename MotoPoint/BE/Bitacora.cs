using System;

namespace SIS.ENTIDAD
{
    /// <summary>
    /// 
    /// </summary>
    public class Bitacora
    {
        /// <summary>
        /// 
        /// </summary>
        public Bitacora()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        private int idEventoField;
        /// <summary>
        /// 
        /// </summary>
        public int IdEvento
        {
            get
            {
                return idEventoField;
            }
            set
            {
                idEventoField = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private int idUsuarioField;
        /// <summary>
        /// 
        /// </summary>
        public int IdUsuario
        {
            get
            {
                return idUsuarioField;
            }
            set
            {
                idUsuarioField = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private DateTime fechaField;
        /// <summary>
        /// 
        /// </summary>
        public DateTime Fecha
        {
            get
            {
                return fechaField;
            }
            set
            {
                fechaField = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private string descripcionField;
        /// <summary>
        /// 
        /// </summary>
        public string Descripcion
        {
            get
            {
                return descripcionField;
            }
            set
            {
                descripcionField = value;
            }
        }
    }
}
