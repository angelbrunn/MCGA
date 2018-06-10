using System;

namespace SIS.EXCEPCIONES
{
    public class UIExcepcion : System.Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        public UIExcepcion(string mensaje) : base(mensaje)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="inner"></param>
        public UIExcepcion(string mensaje, Exception inner) : base(mensaje, inner)
        {
        }
    }
}
