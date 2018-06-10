using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace SIS.IO
{
    /// <summary>
    /// 
    /// </summary>
    public class Hash : IHash
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sCadena"></param>
        /// <returns></returns>
        public string generarSHA(string sCadena)
        {

            // Objeto de codificación
            UnicodeEncoding ueCodigo = new UnicodeEncoding();

            // Objeto para instanciar las codificación
            SHA256Managed SHA = new SHA256Managed();

            // Calcula el valor hash de la cadena recibida
            byte[] bHash = SHA.ComputeHash(ueCodigo.GetBytes(sCadena));

            // Convierte el hash en una cadena y lo devuelve
            return Convert.ToBase64String(bHash);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public string obtenerHash(string cadena)
        {
            string cadenaHasheada;

            IHash interfazHash = new Hash();
            cadenaHasheada = interfazHash.generarSHA(cadena);

            return cadenaHasheada;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oUsuario"></param>
        /// <returns></returns>
        public string obtenerHashUsuario(SIS.ENTIDAD.Usuario oUsuario)
        {
            string digiVerif = "ERROR";

            string cadena;
            cadena = oUsuario.IdUsuario.ToString() + oUsuario.usuario + oUsuario.Password + oUsuario.Legajo.ToString() + oUsuario.Idioma.ToString();

            digiVerif = this.obtenerHash(cadena);

            return digiVerif;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool verificarConsistenciaBD()
        {
            bool resultadoVerificacion = true;
            /*
            int resultado;
            string cadena;
            string cadenaHasheada;
            string hashVerificador;
            int contadorErroneo = 0;
            List<SIS.ENTIDAD.Usuario> listaUsuarios = new List<SIS.ENTIDAD.Usuario>();

            SIS.DATOS.DALUsuario oDalUsuario = new SIS.DATOS.DALUsuario();

            try
            {
                listaUsuarios = oDalUsuario.obtenerTablaUsuario;
            }
            catch (SIS.EXCEPCIONES.DALExcepcion ex)
            {
                throw new SIS.EXCEPCIONES.BLLExcepcion(ex.Message);
            }
            // #################### DIGITO VERIFICADOR HORIZONTAL ####################
            IEnumerator<SIS.ENTIDAD.Usuario> enu = listaUsuarios.GetEnumerator();
            while (enu.MoveNext())
            {
                cadena = "";
                cadenaHasheada = "";
                cadena = enu.Current.IdUsuario.ToString() + enu.Current.usuario + enu.Current.Password + enu.Current.Legajo + enu.Current.Idioma;
                cadenaHasheada = this.obtenerHash(cadena);
                hashVerificador = enu.Current.digitoVerificador;

                resultado = cadenaHasheada.CompareTo(hashVerificador);
                if (resultado == -1)
                    contadorErroneo = contadorErroneo + 1;
            }

            // #################### DIGITO VERIFICADOR VERTICAL ####################
            int bandera = 1;

            string columnaUsuario = "";
            string columnaPassword = "";
            string columnaLegajo = "";
            string columnaIdioma = "";

            string columnaUsuarioHasheada = "";
            string columnaPasswordHasheada = "";
            string columnaLegajoHasheada = "";
            string columnaIdiomaHasheada = "";

            string columDigiUsuario = "";
            string columDigiPassword = "";
            string columDigiLegajo = "";
            string columDigiIdioma = "";

            IEnumerator<SIS.ENTIDAD.Usuario> enuVert = listaUsuarios.GetEnumerator();
            while (enuVert.MoveNext())
            {
                if (bandera == 1)
                {
                    columDigiUsuario = enuVert.Current.usuario;
                    columDigiPassword = enuVert.Current.Password;
                    columDigiLegajo = enuVert.Current.Legajo.ToString();
                    columDigiIdioma = enuVert.Current.Idioma.ToString();
                    bandera = 2;
                }
                else
                {
                    columnaUsuario = columnaUsuario + enuVert.Current.usuario;
                    columnaPassword = columnaPassword + enuVert.Current.Password;
                    columnaLegajo = columnaLegajo + enuVert.Current.Legajo.ToString();
                    columnaIdioma = columnaIdioma + enuVert.Current.Idioma.ToString();
                }
            }

            columnaUsuarioHasheada = this.obtenerHash(columnaUsuario);
            resultado = columnaUsuarioHasheada.CompareTo(columDigiUsuario);
            if (resultado == 1)
                contadorErroneo = contadorErroneo + 1;

            columnaPasswordHasheada = this.obtenerHash(columnaPassword);
            resultado = columnaPasswordHasheada.CompareTo(columDigiPassword);
            if (resultado == 1)
                contadorErroneo = contadorErroneo + 1;

            columnaLegajoHasheada = this.obtenerHash(columnaLegajo);
            resultado = columnaLegajoHasheada.CompareTo(columDigiLegajo);
            if (resultado == 1)
                contadorErroneo = contadorErroneo + 1;

            columnaIdiomaHasheada = this.obtenerHash(columnaIdioma);
            resultado = columnaIdiomaHasheada.CompareTo(columDigiIdioma);
            if (resultado == 1)
                contadorErroneo = contadorErroneo + 1;

            // ###### EVALUACION FINAL ######
            // Evaluación final para saber si hubo algun error de comprobación
            // en los digitos verificadores tanto verticales como horizontales.

            if (contadorErroneo == 0)
                resultadoVerificacion = true;
            else
                resultadoVerificacion = false;
            */
            return resultadoVerificacion;
        }
        /// <summary>
        ///         ''' 
        ///         ''' </summary>
        ///         ''' <param name="listaUsuarios"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        public List<SIS.ENTIDAD.Usuario> calcularHashTablaUsuario(List<SIS.ENTIDAD.Usuario> listaUsuarios)
        {
            List<SIS.ENTIDAD.Usuario> listaUsuarioHash = new List<SIS.ENTIDAD.Usuario>();
            /*
            // #################### DIGITO VERIFICADOR VERTICAL ####################
            string columnaIdUsuario = "";
            string columnaUsuario = "";
            string columnaPassword = "";
            string columnaLegajo = "";
            string columnaIdioma = "";

            string columDigiIdUsuario = "";
            string columDigiUsuario = "";
            string columDigiPassword = "";
            string columDigiLegajo = "";
            string columDigiIdioma = "";

            IEnumerator<SIS.ENTIDAD.Usuario> enuVert = listaUsuarios.GetEnumerator();
            while (enuVert.MoveNext())
            {
                if (enuVert.Current.IdUsuario == 1)
                {
                }
                else
                {
                    columnaUsuario = columnaUsuario + enuVert.Current.usuario;
                    columnaPassword = columnaPassword + enuVert.Current.Password;
                    columnaLegajo = columnaLegajo + enuVert.Current.Legajo.ToString();
                    columnaIdioma = columnaIdioma + enuVert.Current.Idioma.ToString();
                }
            }

            IEnumerator<SIS.ENTIDAD.Usuario> enuVert2 = listaUsuarios.GetEnumerator();
            while (enuVert2.MoveNext())
            {
                if (enuVert2.Current.IdUsuario == 1)
                {
                    // No hay digito verificador de la PK
                    enuVert2.Current.usuario = this.obtenerHash(columnaUsuario);
                    enuVert2.Current.Password = this.obtenerHash(columnaPassword);
                    enuVert2.Current.Legajo = this.obtenerHash(columnaLegajo);
                    enuVert2.Current.Idioma = this.obtenerHash(columnaIdioma);
                }
            }

            listaUsuarioHash = listaUsuarios;

            string cadena = "";
            string cadenaHasheada = "";

            // #################### DIGITO VERIFICADOR HORIZONTAL ####################
            IEnumerator<SIS.ENTIDAD.Usuario> enu = listaUsuarios.GetEnumerator();
            while (enu.MoveNext())
            {
                cadena = "";
                cadenaHasheada = "";
                cadena = enu.Current.IdUsuario.ToString() + enu.Current.usuario + enu.Current.Password + enu.Current.Legajo + enu.Current.Idioma;
                cadenaHasheada = this.obtenerHash(cadena);
                enu.Current.digitoVerificador = cadenaHasheada;
            }
            */
            return listaUsuarioHash;
        }
    }
}
