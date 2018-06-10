using System.Collections.Generic;

namespace SIS.ENTIDAD
{
    /// <summary>
    /// 
    /// </summary>
    public class Grupo
    {
        /// <summary>
        /// 
        /// </summary>
        private int idGrupoField;
        /// <summary>
        /// 
        /// </summary>
        public int IdGrupo
        {
            get
            {
                return idGrupoField;
            }
            set
            {
                idGrupoField = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private string grupoField;
        /// <summary>
        /// 
        /// </summary>
        public string grupo
        {
            get
            {
                return grupoField;
            }
            set
            {
                grupoField = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private string descripcionField;
        /// <summary>
        /// 
        /// </summary>
        public string Descripcion
        {
            get
            {
                return descripcionField;
            }
            set
            {
                descripcionField = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private List<Permiso> listadoPermisosField;
        /// <summary>
        /// 
        /// </summary>
        public List<Permiso> ListadoPermisos
        {
            get
            {
                return listadoPermisosField;
            }
            set
            {
                listadoPermisosField = value;
            }
        }
    }
}
