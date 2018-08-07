using System;
using System.Configuration;
using System.Data.SqlClient;

namespace SIS.DATOS
{
    /// <summary>
    /// 
    /// </summary>
    public class DALUsuario
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int ObtenerUltimoId()
        {
            int ultimoId = 0;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoPoint"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT MAX(idUsuario) FROM tbl_Usuario", con))
                {
                    //cmd.Parameters.AddWithValue("@PersonID", personid);
                    try
                    {
                        con.Open();
                        ultimoId = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }
                }
            }
            return ultimoId;
        }
    }
}
