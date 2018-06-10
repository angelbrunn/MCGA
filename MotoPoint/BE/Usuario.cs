using System.Collections.Generic;

namespace SIS.ENTIDAD
{
    /// <summary>
    /// 
    /// </summary>
    public class Usuario
    {
        /// <summary>
        /// 
        /// </summary>
        private string idUsuarioField;
        /// <summary>
        /// 
        /// </summary>
        public string IdUsuario
        {
            get
            {
                return idUsuarioField;
            }
            set
            {
                idUsuarioField = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private string usuarioField;
        /// <summary>
        /// 
        /// </summary>
        public string usuario
        {
            get
            {
                return usuarioField;
            }
            set
            {
                usuarioField = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private string passwordField;
        /// <summary>
        /// 
        /// </summary>
        public string Password
        {
            get
            {
                return passwordField;
            }
            set
            {
                passwordField = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private string legajoField;
        /// <summary>
        /// 
        /// </summary>
        public string Legajo
        {
            get
            {
                return legajoField;
            }
            set
            {
                legajoField = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private string idiomaField;
        /// <summary>
        /// 
        /// </summary>
        public string Idioma
        {
            get
            {
                return idiomaField;
            }
            set
            {
                idiomaField = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private string digitoVerificadorField;
        /// <summary>
        /// 
        /// </summary>
        public string DigitoVerificador
        {
            get
            {
                return digitoVerificadorField;
            }
            set
            {
                digitoVerificadorField = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private List<Grupo> listadoGruposField;
        /// <summary>
        /// 
        /// </summary>
        public List<Grupo> ListadoGrupos
        {
            get
            {
                return listadoGruposField;
            }
            set
            {
                listadoGruposField = value;
            }
        }
    }
}
