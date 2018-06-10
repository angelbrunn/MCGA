using System;

namespace SIS.EXCEPCIONES
{
    /// <summary>
    /// 
    /// </summary>
    public class IOException : System.Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        public IOException(string mensaje) : base(mensaje)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="inner"></param>
        public IOException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
    }
}
