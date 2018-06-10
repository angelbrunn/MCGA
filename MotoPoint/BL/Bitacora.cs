using System;
using System.Collections.Generic;

namespace SIS.BIT
{
    /// <summary>
    /// 
    /// </summary>
    public class Bitacora
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int obtenerUltimoId()
        {
            int ultimoId=1;
            /*
            DAL.SIS.DATOS.DALBitacora oDalBitacora = new DAL.SIS.DATOS.DALBitacora();
            try
            {
                ultimoId = oDalBitacora.obtenerUltimoId();
            }
            catch (Exception ex)
            {
            }
            */
            return ultimoId;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioI"></param>
        /// <param name="oBKPExc"></param>
        public void registrarEnBitacora_BKP(string usuarioI, SIS.EXCEPCIONES.BKPException oBKPExc)
        {
            /*
            BE.SIS.ENTIDAD.Bitacora oBitacora = new BE.SIS.ENTIDAD.Bitacora();
            // Guardo Usuario
            oBitacora.idUsuario = usuarioI;
            // Se agrega la fecha del evento.
            oBitacora.fecha = DateTime.Now;
            oBitacora.descripcion = "BKPException:" + oBKPExc.Message;

            try
            {
                // Obtengo el ultimo id para agregarselo al objeto oBitacora.
                oBitacora.idEvento = (this.obtenerUltimoId() + 1);

                // Realizo la insercion en la base de datos por medio de DALBitacora
                // si hay una excepcion cualquier que no me permite ingresar el resgistro
                // llamo a la insercion en el archivo local dentro de IOBitacora.
                DAL.SIS.DATOS.DALBitacora oDalBitacora = new DAL.SIS.DATOS.DALBitacora();


                oDalBitacora.registrarEnBitacoraBD(oBitacora);
            }
            catch (Exception ex)
            {
                System.IO.SIS.ESCRITURA.IOBitacora oIOBitacora = new System.IO.SIS.ESCRITURA.IOBitacora();
                oIOBitacora.registrarEnBitacoraIO(oBitacora);
            }
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioI"></param>
        /// <param name="oBLLExc"></param>
        public void registrarEnBitacora_BLL(string usuarioI, SIS.EXCEPCIONES.BLLExcepcion oBLLExc)
        {
            /*
            BE.SIS.ENTIDAD.Bitacora oBitacora = new BE.SIS.ENTIDAD.Bitacora();
            // Guardo Usuario
            oBitacora.idUsuario = usuarioI;
            // Se agrega la fecha del evento.
            oBitacora.fecha = DateTime.Now;
            oBitacora.descripcion = "BLLExcepcion:" + oBLLExc.Message;

            try
            {
                // Obtengo el ultimo id para agregarselo al objeto oBitacora.
                oBitacora.idEvento = (this.obtenerUltimoId() + 1);

                // Realizo la insercion en la base de datos por medio de DALBitacora
                // si hay una excepcion cualquier que no me permite ingresar el resgistro
                // llamo a la insercion en el archivo local dentro de IOBitacora.
                DAL.SIS.DATOS.DALBitacora oDalBitacora = new DAL.SIS.DATOS.DALBitacora();
                oDalBitacora.registrarEnBitacoraBD(oBitacora);
            }
            catch (Exception ex)
            {
                System.IO.SIS.ESCRITURA.IOBitacora oIOBitacora = new System.IO.SIS.ESCRITURA.IOBitacora();
                oIOBitacora.registrarEnBitacoraIO(oBitacora);
            }
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioI"></param>
        /// <param name="oDALExc"></param>
        public void registrarEnBitacora_DAL(string usuarioI, SIS.EXCEPCIONES.DALExcepcion oDALExc)
        {
            /*
            BE.SIS.ENTIDAD.Bitacora oBitacora = new BE.SIS.ENTIDAD.Bitacora();
            // Guardo Usuario
            oBitacora.idUsuario = usuarioI;
            // Se agrega la fecha del evento.
            oBitacora.fecha = DateTime.Now;
            oBitacora.descripcion = "DALExcepcion:" + oDALExc.Message;

            try
            {
                // Obtengo el ultimo id para agregarselo al objeto oBitacora.
                oBitacora.idEvento = (this.obtenerUltimoId() + 1);

                // Realizo la insercion en la base de datos por medio de DALBitacora
                // si hay una excepcion cualquier que no me permite ingresar el resgistro
                // llamo a la insercion en el archivo local dentro de IOBitacora.
                DAL.SIS.DATOS.DALBitacora oDalBitacora = new DAL.SIS.DATOS.DALBitacora();
                oDalBitacora.registrarEnBitacoraBD(oBitacora);
            }
            catch (Exception ex)
            {
                System.IO.SIS.ESCRITURA.IOBitacora oIOBitacora = new System.IO.SIS.ESCRITURA.IOBitacora();
                oIOBitacora.registrarEnBitacoraIO(oBitacora);
            }
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioI"></param>
        /// <param name="oIOExc"></param>
        public void registrarEnBitacora_IO(string usuarioI, SIS.EXCEPCIONES.IOException oIOExc)
        {
            /*
            BE.SIS.ENTIDAD.Bitacora oBitacora = new BE.SIS.ENTIDAD.Bitacora();
            // Guardo Usuario
            oBitacora.idUsuario = usuarioI;
            // Se agrega la fecha del evento.
            oBitacora.fecha = DateTime.Now;
            oBitacora.descripcion = "IOException:" + oIOExc.Message;

            try
            {
                // Obtengo el ultimo id para agregarselo al objeto oBitacora.
                oBitacora.idEvento = (this.obtenerUltimoId() + 1);

                // Realizo la insercion en la base de datos por medio de DALBitacora
                // si hay una excepcion cualquier que no me permite ingresar el resgistro
                // llamo a la insercion en el archivo local dentro de IOBitacora.
                DAL.SIS.DATOS.DALBitacora oDalBitacora = new DAL.SIS.DATOS.DALBitacora();
                oDalBitacora.registrarEnBitacoraBD(oBitacora);
            }
            catch (Exception ex)
            {
                System.IO.SIS.ESCRITURA.IOBitacora oIOBitacora = new System.IO.SIS.ESCRITURA.IOBitacora();
                oIOBitacora.registrarEnBitacoraIO(oBitacora);
            }
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioI"></param>
        /// <param name="oSEGExc"></param>
        public void registrarEnBitacora_SEG(string usuarioI, SIS.EXCEPCIONES.SEGExcepcion oSEGExc)
        {
            /*
            BE.SIS.ENTIDAD.Bitacora oBitacora = new BE.SIS.ENTIDAD.Bitacora();
            // Guardo Usuario
            oBitacora.idUsuario = usuarioI;
            // Se agrega la fecha del evento.
            oBitacora.fecha = DateTime.Now;
            oBitacora.descripcion = "SEGExcepcion:" + oSEGExc.Message;

            try
            {
                // Obtengo el ultimo id para agregarselo al objeto oBitacora.
                oBitacora.idEvento = (this.obtenerUltimoId() + 1);

                // Realizo la insercion en la base de datos por medio de DALBitacora
                // si hay una excepcion cualquier que no me permite ingresar el resgistro
                // llamo a la insercion en el archivo local dentro de IOBitacora.
                DAL.SIS.DATOS.DALBitacora oDalBitacora = new DAL.SIS.DATOS.DALBitacora();
                oDalBitacora.registrarEnBitacoraBD(oBitacora);
            }
            catch (Exception ex)
            {
                System.IO.SIS.ESCRITURA.IOBitacora oIOBitacora = new System.IO.SIS.ESCRITURA.IOBitacora();
                oIOBitacora.registrarEnBitacoraIO(oBitacora);
            }
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuarioI"></param>
        /// <param name="oUIExc"></param>
        public void registrarEnBitacora_UI(string usuarioI, SIS.EXCEPCIONES.UIExcepcion oUIExc)
        {
            /*
            BE.SIS.ENTIDAD.Bitacora oBitacora = new BE.SIS.ENTIDAD.Bitacora();
            // Guardo Usuario
            oBitacora.idUsuario = usuarioI;
            // Se agrega la fecha del evento.
            oBitacora.fecha = DateTime.Now;
            oBitacora.descripcion = "UIExcepcion:" + oUIExc.Message;

            try
            {
                // Obtengo el ultimo id para agregarselo al objeto oBitacora.
                oBitacora.idEvento = (this.obtenerUltimoId() + 1);

                // Realizo la insercion en la base de datos por medio de DALBitacora
                // si hay una excepcion cualquier que no me permite ingresar el resgistro
                // llamo a la insercion en el archivo local dentro de IOBitacora.
                DAL.SIS.DATOS.DALBitacora oDalBitacora = new DAL.SIS.DATOS.DALBitacora();
                oDalBitacora.registrarEnBitacoraBD(oBitacora);
            }
            catch (Exception ex)
            {
                System.IO.SIS.ESCRITURA.IOBitacora oIOBitacora = new System.IO.SIS.ESCRITURA.IOBitacora();
                oIOBitacora.registrarEnBitacoraIO(oBitacora);
            }
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<SIS.ENTIDAD.Bitacora> obtenerEventos()
        {
            List<SIS.ENTIDAD.Bitacora> listado = new List<SIS.ENTIDAD.Bitacora>();
            /*
            DAL.SIS.DATOS.DALBitacora oDalBitacora = new DAL.SIS.DATOS.DALBitacora();
            listado = oDalBitacora.obtenerEventos;
            */
            return listado;
        }
    }
}
