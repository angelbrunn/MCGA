using System;

namespace SIS.EXCEPCIONES
{
    /// <summary>
    /// 
    /// </summary>
    public class BKPException : System.Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        public BKPException(string mensaje) : base(mensaje)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="inner"></param>
        public BKPException(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
    }
}
