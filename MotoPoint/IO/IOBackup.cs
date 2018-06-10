using System;
using System.Collections.Generic;
using System.IO;


namespace SIS.ESCRITURA
{
    /// <summary>
    /// 
    /// </summary>
    public class IOBackup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        /// <returns></returns>
        public List<SIS.ENTIDAD.Usuario> leerArchivoUsuario(string ruta, string delim)
        {
            List<SIS.ENTIDAD.Usuario> lista = new List<SIS.ENTIDAD.Usuario>();
            /*
            try
            {
                string linea = "";
                StreamReader sr = new StreamReader(ruta);
                int contador = 0;
                do
                {
                    linea = sr.ReadLine();
                    if (!linea == null)
                    {
                        if (contador > 0)
                        {
                            string[] vec = linea.Split(delim);
                            BE.SIS.ENTIDAD.Usuario oUsuario = new BE.SIS.ENTIDAD.Usuario();
                            oUsuario.idUsuario = System.Convert.ToInt32(vec[0]);
                            oUsuario.usuario = System.Convert.ToString(vec[1]);
                            oUsuario.password = System.Convert.ToString(vec[2]);
                            oUsuario.legajo = System.Convert.ToString(vec[3]);
                            oUsuario.idioma = System.Convert.ToString(vec[4]);
                            oUsuario.digitoVerificador = System.Convert.ToString(vec[5]);
                            lista.Add(oUsuario);
                        }
                    }

                    contador = contador + 1;
                }
                while (!linea == null);
                sr.Close();
            }
            catch (Exception ex)
            {
            }
            */
            return lista;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        /// <returns></returns>
        public List<SIS.ENTIDAD.Bitacora> leerArchivoBitacora(string ruta, string delim)
        {
            List<SIS.ENTIDAD.Bitacora> lista = new List<SIS.ENTIDAD.Bitacora>();
            /*
            try
            {
                string linea = "";
                StreamReader sr = new StreamReader(ruta);
                int contador = 0;
                do
                {
                    linea = sr.ReadLine();
                    if (!linea == null)
                    {
                        if (contador > 0)
                        {
                            string[] vec = linea.Split(delim);
                            BE.SIS.ENTIDAD.Bitacora oBitacora = new BE.SIS.ENTIDAD.Bitacora();
                            oBitacora.idEvento = System.Convert.ToInt32(vec[0]);
                            oBitacora.idUsuario = System.Convert.ToInt32(vec[1]);
                            oBitacora.descripcion = System.Convert.ToString(vec[2]);
                            oBitacora.fecha = System.Convert.ToDateTime(vec[3]);
                            lista.Add(oBitacora);
                        }
                    }

                    contador = contador + 1;
                }
                while (!linea == null);
                sr.Close();
            }
            catch (Exception ex)
            {
            }
            */
            return lista;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        /// <returns></returns>
        public List<SIS.ENTIDAD.Grupo> leerArchivoGrupo(string ruta, string delim)
        {
            List<SIS.ENTIDAD.Grupo> lista = new List<SIS.ENTIDAD.Grupo>();
            /*
            try
            {
                string linea = "";
                StreamReader sr = new StreamReader(ruta);
                int contador = 0;
                do
                {
                    linea = sr.ReadLine();
                    if (!linea == null)
                    {
                        if (contador > 0)
                        {
                            string[] vec = linea.Split(delim);
                            BE.SIS.ENTIDAD.Grupo oGrupo = new BE.SIS.ENTIDAD.Grupo();
                            oGrupo.idGrupo = System.Convert.ToInt32(vec[0]);
                            oGrupo.grupo = System.Convert.ToString(vec[1]);
                            oGrupo.descripcion = System.Convert.ToString(vec[2]);
                            lista.Add(oGrupo);
                        }
                    }

                    contador = contador + 1;
                }
                while (!linea == null);
                sr.Close();
            }
            catch (Exception ex)
            {
            }
            */
            return lista;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        /// <returns></returns>
        public List<SIS.ENTIDAD.GrupoPermiso> leerArchivoGrupoPermiso(string ruta, string delim)
        {
            List<SIS.ENTIDAD.GrupoPermiso> lista = new List<SIS.ENTIDAD.GrupoPermiso>();
            /*
            try
            {
                string linea = "";
                StreamReader sr = new StreamReader(ruta);
                int contador = 0;
                do
                {
                    linea = sr.ReadLine();
                    if (!linea == null)
                    {
                        if (contador > 0)
                        {
                            string[] vec = linea.Split(delim);
                            BE.SIS.ENTIDAD.GrupoPermiso oGrupoPermiso = new BE.SIS.ENTIDAD.GrupoPermiso();
                            oGrupoPermiso.idGrupo = System.Convert.ToInt32(vec[0]);
                            oGrupoPermiso.idPermiso = System.Convert.ToInt32(vec[1]);
                            lista.Add(oGrupoPermiso);
                        }
                    }

                    contador = contador + 1;
                }
                while (!linea == null);
                sr.Close();
            }
            catch (Exception ex)
            {
            }
            */
            return lista;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        /// <returns></returns>
        public List<SIS.ENTIDAD.Permiso> leerArchivoPermiso(string ruta, string delim)
        {
            List<SIS.ENTIDAD.Permiso> lista = new List<SIS.ENTIDAD.Permiso>();
            /*
            try
            {
                string linea = "";
                StreamReader sr = new StreamReader(ruta);
                int contador = 0;
                do
                {
                    linea = sr.ReadLine();
                    if (!linea == null)
                    {
                        if (contador > 0)
                        {
                            string[] vec = linea.Split(delim);
                            BE.SIS.ENTIDAD.Permiso oPermiso = new BE.SIS.ENTIDAD.Permiso();
                            oPermiso.idPermiso = System.Convert.ToInt32(vec[0]);
                            oPermiso.descripcion = System.Convert.ToString(vec[1]);
                            lista.Add(oPermiso);
                        }
                    }

                    contador = contador + 1;
                }
                while (!linea == null);
                sr.Close();
            }
            catch (Exception ex)
            {
            }
            */
            return lista;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        /// <returns></returns>
        public List<SIS.ENTIDAD.UsuarioGrupo> leerArchivoUsuarioGrupo(string ruta, string delim)
        {
            List<SIS.ENTIDAD.UsuarioGrupo> lista = new List<SIS.ENTIDAD.UsuarioGrupo>();
            /*
            try
            {
                string linea = "";
                StreamReader sr = new StreamReader(ruta);
                int contador = 0;
                do
                {
                    linea = sr.ReadLine();
                    if (!linea == null)
                    {
                        if (contador > 0)
                        {
                            string[] vec = linea.Split(delim);
                            BE.SIS.ENTIDAD.UsuarioGrupo oUsuarioGrupo = new BE.SIS.ENTIDAD.UsuarioGrupo();
                            oUsuarioGrupo.idUsuario = System.Convert.ToInt32(vec[0]);
                            oUsuarioGrupo.idGrupo = System.Convert.ToInt32(vec[1]);
                            lista.Add(oUsuarioGrupo);
                        }
                    }

                    contador = contador + 1;
                }
                while (!linea == null);
                sr.Close();
            }
            catch (Exception ex)
            {
            }
            */
            return lista;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        /// <returns></returns>
        public List<SIS.ENTIDAD.MultiIdioma> leerArchivoMultiIdioma(string ruta, string delim)
        {
            List<SIS.ENTIDAD.MultiIdioma> lista = new List<SIS.ENTIDAD.MultiIdioma>();
            /*
            try
            {
                string linea = "";
                StreamReader sr = new StreamReader(ruta);
                int contador = 0;
                do
                {
                    linea = sr.ReadLine();
                    if (!linea == null)
                    {
                        if (contador > 0)
                        {
                            string[] vec = linea.Split(delim);
                            BE.SIS.ENTIDAD.MultiIdioma oMultiIdioma = new BE.SIS.ENTIDAD.MultiIdioma();
                            oMultiIdioma.componente = System.Convert.ToString(vec[0]);
                            oMultiIdioma.iKey = System.Convert.ToString(vec[1]);
                            oMultiIdioma.value = System.Convert.ToString(vec[2]);
                            lista.Add(oMultiIdioma);
                        }
                    }

                    contador = contador + 1;
                }
                while (!linea == null);
                sr.Close();
            }
            catch (Exception ex)
            {
            }
            */
            return lista;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        /// <param name="listaUsuario"></param>
        public void escribirArchivoUsuario(string ruta, string delim, List<SIS.ENTIDAD.Usuario> listaUsuario)
        {
            /*
            // idUsuario;usuario;password;legajo;idioma;digitoVerificador
            string cabecera = "idUsuario;usuario;password;legajo;idioma;digitoVerificador";

            StreamWriter sw = new StreamWriter(ruta);
            sw.WriteLine(cabecera);
            string linea;

            IEnumerator<BE.SIS.ENTIDAD.Usuario> enumC = listaUsuario.GetEnumerator();
            while ((enumC.MoveNext()))
            {
                linea = enumC.Current.idUsuario.ToString() + delim + enumC.Current.usuario
               + delim + enumC.Current.password + delim + enumC.Current.legajo + delim + enumC.Current.idioma + delim + enumC.Current.digitoVerificador;

                sw.WriteLine(linea);
            }
            sw.Close();
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        /// <param name="listaEventos"></param>
        public void escribirArchivoBitacora(string ruta, string delim, List<SIS.ENTIDAD.Bitacora> listaEventos)
        {
            /*
            // idEvento;idUsuario;descripcion;fecha
            string cabecera = "idEvento;idUsuario;descripcion;fecha";

            StreamWriter sw = new StreamWriter(ruta);
            sw.WriteLine(cabecera);
            string linea;

            IEnumerator<BE.SIS.ENTIDAD.Bitacora> enumC = listaEventos.GetEnumerator();
            while ((enumC.MoveNext()))
            {
                linea = enumC.Current.idEvento.ToString() + delim + enumC.Current.idUsuario.ToString
               + delim + enumC.Current.descripcion.ToString + delim + enumC.Current.fecha.ToString;

                sw.WriteLine(linea);
            }
            sw.Close();
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        /// <param name="listaUsuarioGrupo"></param>
        public void escribirArchivoUsuarioGrupo(string ruta, string delim, List<SIS.ENTIDAD.UsuarioGrupo> listaUsuarioGrupo)
        {
            /*
            // idUsuario;idGrupo
            string cabecera = "idUsuario;idGrupo";

            StreamWriter sw = new StreamWriter(ruta);
            sw.WriteLine(cabecera);
            string linea;

            IEnumerator<BE.SIS.ENTIDAD.UsuarioGrupo> enumC = listaUsuarioGrupo.GetEnumerator();
            while ((enumC.MoveNext()))
            {
                linea = enumC.Current.idUsuario.ToString() + delim + enumC.Current.idGrupo.ToString;
                sw.WriteLine(linea);
            }
            sw.Close();
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        /// <param name="listaGrupo"></param>
        public void escribirArchivoGrupo(string ruta, string delim, List<SIS.ENTIDAD.Grupo> listaGrupo)
        {

            /*
            // idUsuario;idGrupo
            string cabecera = "idGrupo;grupo;descripcion";

            StreamWriter sw = new StreamWriter(ruta);
            sw.WriteLine(cabecera);
            string linea;

            IEnumerator<BE.SIS.ENTIDAD.Grupo> enumC = listaGrupo.GetEnumerator();
            while ((enumC.MoveNext()))
            {
                linea = enumC.Current.idGrupo.ToString() + delim + enumC.Current.grupo.ToString + delim + enumC.Current.descripcion.ToString;
                sw.WriteLine(linea);
            }
            sw.Close();
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        /// <param name="listaGrupoPermiso"></param>
        public void escribirArchivoGrupoPermiso(string ruta, string delim, List<SIS.ENTIDAD.GrupoPermiso> listaGrupoPermiso)
        {
            /*
            string cabecera = "idGrupo;idPermiso";

            StreamWriter sw = new StreamWriter(ruta);
            sw.WriteLine(cabecera);
            string linea;

            IEnumerator<BE.SIS.ENTIDAD.GrupoPermiso> enumC = listaGrupoPermiso.GetEnumerator();
            while ((enumC.MoveNext()))
            {
                linea = enumC.Current.idGrupo.ToString() + delim + enumC.Current.idPermiso.ToString();
                sw.WriteLine(linea);
            }
            sw.Close();
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        /// <param name="listaPermiso"></param>
        public void escribirArchivoPermiso(string ruta, string delim, List<SIS.ENTIDAD.Permiso> listaPermiso)
        {
            /*
            string cabecera = "idPermiso;descripcion";

            StreamWriter sw = new StreamWriter(ruta);
            sw.WriteLine(cabecera);
            string linea;

            IEnumerator<BE.SIS.ENTIDAD.Permiso> enumC = listaPermiso.GetEnumerator();
            while ((enumC.MoveNext()))
            {
                linea = enumC.Current.idPermiso.ToString() + delim + enumC.Current.descripcion.ToString();
                sw.WriteLine(linea);
            }
            sw.Close();
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="delim"></param>
        /// <param name="listaPermiso"></param>
        public void escribirArchivoMultiIdioma(string ruta, string delim, List<SIS.ENTIDAD.MultiIdioma> listaPermiso)
        {
            /*
            string cabecera = "componente;idiomaEspanol;idiomaIngles";

            StreamWriter sw = new StreamWriter(ruta);
            sw.WriteLine(cabecera);
            string linea;

            IEnumerator<BE.SIS.ENTIDAD.MultiIdioma> enumC = listaPermiso.GetEnumerator();
            while ((enumC.MoveNext()))
            {
                linea = enumC.Current.componente.ToString() + delim + enumC.Current.iKey.ToString() + delim + enumC.Current.value.ToString();
                sw.WriteLine(linea);
            }
            sw.Close();
            */
        }
    }
}
