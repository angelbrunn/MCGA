namespace SIS.ENTIDAD
{
    /// <summary>
    /// 
    /// </summary>
    public class Permiso
    {
        /// <summary>
        /// 
        /// </summary>
        private int idPermisoField;
        /// <summary>
        /// 
        /// </summary>
        public int IdPermiso
        {
            get
            {
                return idPermisoField;
            }
            set
            {
                idPermisoField = value;
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
    }
}
