using System;
using System.IO;

namespace SIS.ESCRITURA
{
    /// <summary>
    /// 
    /// </summary>
    public class IOBitacora
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oBitacora"></param>
        public void RegistrarEnBitacoraIO(SIS.ENTIDAD.Bitacora oBitacora)
        {
            string delimitador = ";";
            string ruta = @"C:\Logs MotoPoint\log.csv";
            string cabecera = "idEvento" + delimitador + "idUsuario" + delimitador + "descripcion" + delimitador + "fecha";
            try
            {
                StreamWriter archivo = new StreamWriter(ruta, true);
                archivo.WriteLine(cabecera);
                string linea;
                string idEvento = oBitacora.IdEvento.ToString();
                string idUsuario = oBitacora.IdUsuario.ToString();
                string descripcion = oBitacora.Descripcion.ToString();
                string fecha = oBitacora.Fecha.ToString();
                linea = idEvento + delimitador + idUsuario + delimitador
                + descripcion + delimitador + fecha;
                archivo.WriteLine(linea);
                archivo.Close();
            }
            catch (Exception ex)
            {
                throw new SIS.EXCEPCIONES.IOException(ex.Message);
            }
        }
    }
}
