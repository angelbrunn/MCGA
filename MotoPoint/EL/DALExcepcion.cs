using System;

namespace SIS.EXCEPCIONES
{
    /// <summary>
    /// 
    /// </summary>
    public class DALExcepcion : System.Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        public DALExcepcion(string mensaje) : base(mensaje)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="inner"></param>
        public DALExcepcion(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
    }
}
