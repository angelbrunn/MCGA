using System;
using System.Collections.Generic;


namespace SIS.BUSINESS
{
    /// <summary>
    /// 
    /// </summary>
    public class NegMultiUsuario : INegMultiUsuario
    {
        /// <summary>
        /// 
        /// </summary>
        //private SIS.IO.IHash interfazHash = new SIS.IO.Hash();
        
        private INegBitacora interfazNegocioBitacora = new NegBitacora();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oUsuario"></param>
        public void insertarUsuario(SIS.ENTIDAD.Usuario oUsuario)
        {
            /*
            string passHasheada;
            string digiVerificador;
            string IdHASH = "HASH";
            // passHasheada = interfazHash.obtenerHash(oUsuario.password)
            // oUsuario.password = passHasheada

            // digiVerificador = interfazHash.obtenerHashUsuario(oUsuario)
            // oUsuario.digitoVerificador = digiVerificador
            // ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            try
            {
                passHasheada = interfazHash.obtenerHash(oUsuario.password);
                oUsuario.password = passHasheada;

                digiVerificador = interfazHash.obtenerHashUsuario(oUsuario);
                oUsuario.digitoVerificador = digiVerificador;
            }
            catch (Exception ex)
            {
                interfazNegocioBitacora.registrarEnBitacora_BLL(IdHASH, ex);
            }
            // ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            List<BE.SIS.ENTIDAD.Usuario> listaUsuarios = new List<BE.SIS.ENTIDAD.Usuario>();
            DAL.SIS.DATOS.DALUsuario oDalUsuaio = new DAL.SIS.DATOS.DALUsuario();
            listaUsuarios = oDalUsuaio.obtenerTablaUsuario();
            if (listaUsuarios.Count == 0)
            {
                BE.SIS.ENTIDAD.Usuario oUsuarioColumnHash = new BE.SIS.ENTIDAD.Usuario();
                oUsuarioColumnHash.idUsuario = 1;
                oUsuarioColumnHash.usuario = "a";
                oUsuarioColumnHash.password = "a";
                oUsuarioColumnHash.legajo = "a";
                oUsuarioColumnHash.idioma = true;
                listaUsuarios.Add(oUsuarioColumnHash);
            }

            listaUsuarios.Add(oUsuario);

            List<BE.SIS.ENTIDAD.Usuario> listaUsuariosConDigitosVerif = new List<BE.SIS.ENTIDAD.Usuario>();
            listaUsuariosConDigitosVerif = interfazHash.calcularHashTablaUsuario(listaUsuarios);

            oDalUsuaio.insertarUsuario(listaUsuariosConDigitosVerif);

            DAL.SIS.DATOS.DALUsuarioGrupo oDalUsuarioGrupo = new DAL.SIS.DATOS.DALUsuarioGrupo();
            List<BE.SIS.ENTIDAD.Grupo> listadoGruposAUsuario = oUsuario.listadoGrupos;
            IEnumerator<BE.SIS.ENTIDAD.Grupo> enu = listadoGruposAUsuario.GetEnumerator();
            while (enu.MoveNext())
            {
                BE.SIS.ENTIDAD.UsuarioGrupo oUsuarioGrupo = new BE.SIS.ENTIDAD.UsuarioGrupo();
                oUsuarioGrupo.idUsuario = oUsuario.idUsuario;
                oUsuarioGrupo.idGrupo = enu.Current.idGrupo;
                oDalUsuarioGrupo.insertarUsuarioGrupo(oUsuarioGrupo);
            }
            */
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int obtenerIdParaUsuario()
        {
            int ultimoIdUsuario = 1;
            /*

            DAL.SIS.DATOS.DALUsuario oDalUsuario = new DAL.SIS.DATOS.DALUsuario();
            ultimoIdUsuario = oDalUsuario.obtenerUltimoId;

            if (ultimoIdUsuario == 0)
                ultimoIdUsuario = 1;

            ultimoIdUsuario = ultimoIdUsuario + 1;
            */
            return ultimoIdUsuario;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public SIS.ENTIDAD.Usuario obtenerUsuario(int idUsuario)
        {
            // Instancio el usuario que voy a pasar por parametro
            SIS.ENTIDAD.Usuario oUsuario = new SIS.ENTIDAD.Usuario();
            /*

            // Instancio DAL Usuario para obtener el usuario
            DAL.SIS.DATOS.DALUsuario oDalUsuario = new DAL.SIS.DATOS.DALUsuario();
            oUsuario = oDalUsuario.obtenerUsuarioPorId(idUsuario);

            // Instancio el objeto UsuarioGrupo para buscar los grupos de ese usuario
            DAL.SIS.DATOS.DALUsuarioGrupo oDalUsuarioGrupo = new DAL.SIS.DATOS.DALUsuarioGrupo();
            List<BE.SIS.ENTIDAD.UsuarioGrupo> listaUsuarioGrupo;
            listaUsuarioGrupo = oDalUsuarioGrupo.obtenerGrupoPorIdUsuario(idUsuario);

            // Instancio una lista de grupos para el usuario
            List<BE.SIS.ENTIDAD.Grupo> listaGrupo = new List<BE.SIS.ENTIDAD.Grupo>();
            List<BE.SIS.ENTIDAD.Permiso> listaPermisos = new List<BE.SIS.ENTIDAD.Permiso>();

            // Recorro la lista y obtengo los objetos Grupo
            IEnumerator<BE.SIS.ENTIDAD.UsuarioGrupo> enu = listaUsuarioGrupo.GetEnumerator();
            while (enu.MoveNext())
            {
                BE.SIS.ENTIDAD.Grupo oGrupo = new BE.SIS.ENTIDAD.Grupo();
                DAL.SIS.DATOS.DALGrupo oDalGrupo = new DAL.SIS.DATOS.DALGrupo();
                oGrupo = oDalGrupo.obtenerGrupoPorId(enu.Current.idGrupo);

                DAL.SIS.DATOS.DALGrupoPermiso oDalGrupoPermiso = new DAL.SIS.DATOS.DALGrupoPermiso();
                List<BE.SIS.ENTIDAD.GrupoPermiso> listadoGrupoPermisos = new List<BE.SIS.ENTIDAD.GrupoPermiso>();
                listadoGrupoPermisos = oDalGrupoPermiso.obtenerPermisosPorIdGrupo(oGrupo.idGrupo);

                IEnumerator<BE.SIS.ENTIDAD.GrupoPermiso> enu2 = listadoGrupoPermisos.GetEnumerator();
                while (enu2.MoveNext())
                {
                    DAL.SIS.DATOS.DALPermiso oDalPermiso = new DAL.SIS.DATOS.DALPermiso();
                    BE.SIS.ENTIDAD.Permiso oPermiso;
                    oPermiso = oDalPermiso.obtenerPermisoPorId(enu2.Current.idPermiso);
                    listaPermisos.Add(oPermiso);
                    oGrupo.listadoPermisos = listaPermisos;
                }
                listaGrupo.Add(oGrupo);
            }
            oUsuario.listadoGrupos = listaGrupo;
            */
            return oUsuario;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="legajo"></param>
        /// <returns></returns>
        public SIS.ENTIDAD.Usuario obtenerUsuarioPorLegajo(int legajo)
        {
            SIS.ENTIDAD.Usuario oUsuario = new SIS.ENTIDAD.Usuario();
            /*
            DAL.SIS.DATOS.DALUsuario oDalUsuario = new DAL.SIS.DATOS.DALUsuario();

            oUsuario = oDalUsuario.obtenerUsuarioPorLegajo(legajo);

            // Instancio el objeto UsuarioGrupo para buscar los grupos de ese usuario
            DAL.SIS.DATOS.DALUsuarioGrupo oDalUsuarioGrupo = new DAL.SIS.DATOS.DALUsuarioGrupo();
            List<BE.SIS.ENTIDAD.UsuarioGrupo> listaUsuarioGrupo;
            listaUsuarioGrupo = oDalUsuarioGrupo.obtenerGrupoPorIdUsuario(oUsuario.idUsuario);

            // Instancio una lista de grupos para el usuario
            List<BE.SIS.ENTIDAD.Grupo> listaGrupo = new List<BE.SIS.ENTIDAD.Grupo>();
            List<BE.SIS.ENTIDAD.Permiso> listaPermisos = new List<BE.SIS.ENTIDAD.Permiso>();

            // Recorro la lista y obtengo los objetos Grupo
            IEnumerator<BE.SIS.ENTIDAD.UsuarioGrupo> enu = listaUsuarioGrupo.GetEnumerator();
            while (enu.MoveNext())
            {
                BE.SIS.ENTIDAD.Grupo oGrupo = new BE.SIS.ENTIDAD.Grupo();
                DAL.SIS.DATOS.DALGrupo oDalGrupo = new DAL.SIS.DATOS.DALGrupo();
                oGrupo = oDalGrupo.obtenerGrupoPorId(enu.Current.idGrupo);

                DAL.SIS.DATOS.DALGrupoPermiso oDalGrupoPermiso = new DAL.SIS.DATOS.DALGrupoPermiso();
                List<BE.SIS.ENTIDAD.GrupoPermiso> listadoGrupoPermisos = new List<BE.SIS.ENTIDAD.GrupoPermiso>();
                listadoGrupoPermisos = oDalGrupoPermiso.obtenerPermisosPorIdGrupo(oGrupo.idGrupo);

                IEnumerator<BE.SIS.ENTIDAD.GrupoPermiso> enu2 = listadoGrupoPermisos.GetEnumerator();
                while (enu2.MoveNext())
                {
                    DAL.SIS.DATOS.DALPermiso oDalPermiso = new DAL.SIS.DATOS.DALPermiso();
                    BE.SIS.ENTIDAD.Permiso oPermiso;
                    oPermiso = oDalPermiso.obtenerPermisoPorId(enu2.Current.idPermiso);
                    listaPermisos.Add(oPermiso);
                    oGrupo.listadoPermisos = listaPermisos;
                }
                listaGrupo.Add(oGrupo);
            }
            oUsuario.listadoGrupos = listaGrupo;
            */
            return oUsuario;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public int login(string usuario, string password)
        {
            // Cifro la password
            string passHasheada;
            int resultadoValidacion = 0;
            /*
            DAL.SIS.DATOS.DALUsuario oDalUsuario = new DAL.SIS.DATOS.DALUsuario();
            string IdDB = "DB";

            try
            {
                passHasheada = interfazHash.obtenerHash(password);
                resultadoValidacion = oDalUsuario.validarUsuario(usuario, passHasheada);
            }
            catch (Exception ex)
            {
                interfazNegocioBitacora.registrarEnBitacora_BLL(IdDB, ex);
            }
            */
            return resultadoValidacion;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool validarExistenciaUsuario(string usuario)
        {
            bool resultado = false;
            /*
            DAL.SIS.DATOS.DALUsuario oDalUsuario = new DAL.SIS.DATOS.DALUsuario();
            resultado = oDalUsuario.validarExistenciaUsuario(usuario);
            */
            return resultado;
        }
        // ##### GRUPO #####
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idGrupo"></param>
        /// <returns></returns>
        public SIS.ENTIDAD.Grupo obtenerGrupoPorId(int idGrupo)
        {

            SIS.ENTIDAD.Grupo oGrupo = new SIS.ENTIDAD.Grupo();
            /*
            DAL.SIS.DATOS.DALGrupo oDalGrupo = new DAL.SIS.DATOS.DALGrupo();
            oGrupo = oDalGrupo.obtenerGrupoPorId(idGrupo);
            */
            return oGrupo;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<SIS.ENTIDAD.Grupo> obtenerGrupos()
        {
            List<SIS.ENTIDAD.Grupo> listadoGrupos = new List<SIS.ENTIDAD.Grupo>();
            /*
            DAL.SIS.DATOS.DALGrupo oDalGrupo = new DAL.SIS.DATOS.DALGrupo();
            listadoGrupos = oDalGrupo.obtenerGrupos;
            */
            return listadoGrupos;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombreGrupo"></param>
        /// <returns></returns>
        public string obtenerDescripcionGrupoPorNombre(string nombreGrupo)
        {
            string descripcionGrupo = "";
            /*
            DAL.SIS.DATOS.DALGrupo oDalGrupo = new DAL.SIS.DATOS.DALGrupo();
            descripcionGrupo = oDalGrupo.obtenerDescripcionGrupoPorNombreGrupo(nombreGrupo);
            */
            return descripcionGrupo;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombreGrupo"></param>
        /// <returns></returns>
        public SIS.ENTIDAD.Grupo obtenerGrupoPorNombre(string nombreGrupo)
        {
            SIS.ENTIDAD.Grupo oGrupo = new SIS.ENTIDAD.Grupo();
            /*
            DAL.SIS.DATOS.DALGrupo oDalGrupo = new DAL.SIS.DATOS.DALGrupo();
            oGrupo = oDalGrupo.obtenerGrupoPorNombreGrupo(nombreGrupo);
            */
            return oGrupo;
        }
        // ##### PERMISO #####
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPermiso"></param>
        /// <returns></returns>
        public SIS.ENTIDAD.Permiso obtenerPermisoPorId(int idPermiso)
        {
            SIS.ENTIDAD.Permiso oPermiso = new SIS.ENTIDAD.Permiso();
            /*
            DAL.SIS.DATOS.DALPermiso oDalPermiso = new DAL.SIS.DATOS.DALPermiso();
            oPermiso = oDalPermiso.obtenerPermisoPorId(idPermiso);
            */
            return oPermiso;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool verificarConsistenciaBD()
        {
            bool estado = false;
            string IdDB = "DB";
            /*
            try
            {
                estado = interfazHash.verificarConsistenciaBD();
            }
            catch (EL.SIS.EXCEPCIONES.SEGExcepcion ex)
            {
                interfazNegocioBitacora.registrarEnBitacora_SEG(IdDB, ex);
            }
            */
            return estado;
        }
    }
}
