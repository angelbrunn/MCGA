using System;

namespace SIS.EXCEPCIONES
{
    public class BLLExcepcion : System.Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        public BLLExcepcion(string mensaje) : base(mensaje)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="inner"></param>
        public BLLExcepcion(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
    }
}
