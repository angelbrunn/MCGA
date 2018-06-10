using System;

namespace SIS.EXCEPCIONES
{
    /// <summary>
    /// 
    /// </summary>
    public class SEGExcepcion : System.Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        public SEGExcepcion(string mensaje) : base(mensaje)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="inner"></param>
        public SEGExcepcion(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
    }
}
