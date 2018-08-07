using SIS.ENTIDAD;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace SIS.DATOS
{
    public class DALBitacora
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int ObtenerUltimoId()
        {
            int ultimoId = 0;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5CK9SEI\\SQLEXPRESS;Initial Catalog=MotoPoint;Integrated Security=True");

            using (SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoPoint"].ConnectionString))
            {
                using (SqlCommand cmdSelect = new SqlCommand("SELECT MAX(idEvento) FROM tbl_Bitacora", con))
                {
                    try
                    {
                        con.Open();
                        ultimoId = (int)cmdSelect.ExecuteScalar();
                        con.Close();
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oBitacora"></param>
        public void RegistrarEnBitacoraBD(Bitacora oBitacora)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoPoint"].ConnectionString))
            {
                using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_Bitacora (IdEvento,IdUsuario,Descripcion,Fecha,DigitoVerificador) VALUES (@IdEvento,@IdUsuario,@Descripcion,@Fecha,@DigitoVerificador)", con))
                {
                    cmdInsert.Parameters.AddWithValue("@IdEvento", oBitacora.IdEvento);
                    cmdInsert.Parameters.AddWithValue("@IdUsuario", oBitacora.IdUsuario);
                    cmdInsert.Parameters.AddWithValue("@Descripcion", oBitacora.Descripcion);
                    cmdInsert.Parameters.AddWithValue("@Fecha", oBitacora.Fecha);
                    cmdInsert.Parameters.AddWithValue("@DigitoVerificador", oBitacora.DigitoVerificador);

                    try
                    {
                        con.Open();
                        cmdInsert.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Bitacora> ObtenerEventos()
        {
            List<Bitacora> listBitacora = new List<Bitacora>();
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoPoint"].ConnectionString))
            {
                using (SqlCommand cmdSelect = new SqlCommand("SELECT * FROM tbl_Bitacora", con))
                {
                    try
                    {
                        con.Open();
                        using (var reader = cmdSelect.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Bitacora oBitacora = new Bitacora();
                                oBitacora.IdEvento = Convert.ToInt32(reader["IdEvento"]);
                                oBitacora.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                                oBitacora.Descripcion = reader["Descripcion"].ToString();
                                oBitacora.Fecha = Convert.ToDateTime(reader["Fecha"]);
                                oBitacora.DigitoVerificador = reader["DigitoVerificador"].ToString();
                                listBitacora.Add(oBitacora);
                            }
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }
                }
                return listBitacora;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaEventos"></param>
        public void InsertarBitacoraDesdeBackup(List<Bitacora> listaEventos)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoPoint"].ConnectionString))
            {
                using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM [MotoPoint].[dbo].[tbl_Bitacora]", con))
                {
                    try
                    {
                        con.Open();
                        cmdDelete.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }
                }

                using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_Bitacora (idEvento,idUsuario,descripcion,fecha,digitoVerificador) VALUES (@IdEvento,@IdUsuario,@Descripcion,@Fecha,@DigitoVerificador)", con))
                {
                    con.Open();
                    try
                    {
                        foreach (Bitacora element in listaEventos)
                        {
                            //FIXME: SI NO FUNCIONA PROBAR CON ADD
                            //cmdInsert.Parameters.Add("@IdEvento", element.IdEvento);
                            cmdInsert.Parameters.AddWithValue("@IdEvento", element.IdEvento);
                            cmdInsert.Parameters.AddWithValue("@IdUsuario", element.IdUsuario);
                            cmdInsert.Parameters.AddWithValue("@Descripcion", element.Descripcion);
                            cmdInsert.Parameters.AddWithValue("@Fecha", element.Fecha);
                            cmdInsert.Parameters.AddWithValue("@DigitoVerificador", element.DigitoVerificador);

                            cmdInsert.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaGrupo"></param>
        public void InsertarGrupoDesdeBackup(List<Grupo> listaGrupo)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoPoint"].ConnectionString))
            {
                using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM [MotoPoint].[dbo].[tbl_Grupo]", con))
                {
                    try
                    {
                        con.Open();
                        cmdDelete.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }
                }

                using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_Grupo (idGrupo,grupo,descripcion) VALUES (@IdGrupo,@Grupo,@Descripcion)", con))
                {
                    con.Open();
                    try
                    {
                        foreach (Grupo element in listaGrupo)
                        {
                            //FIXME: SI NO FUNCIONA PROBAR CON ADD
                            //cmdInsert.Parameters.Add("@IdEvento", element.IdEvento);
                            cmdInsert.Parameters.AddWithValue("@IdGrupo", element.IdGrupo);
                            cmdInsert.Parameters.AddWithValue("@Grupo", element.grupo);
                            cmdInsert.Parameters.AddWithValue("@Descripcion", element.Descripcion);
                            cmdInsert.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }

                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaGrupoPermiso"></param>
        public void InsertarGrupoPermisoDesdeBackup(List<GrupoPermiso> listaGrupoPermiso)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoPoint"].ConnectionString))
            {
                using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM [MotoPoint].[dbo].[tbl_GrupoPermisos]", con))
                {
                    try
                    {
                        con.Open();
                        cmdDelete.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }
                }

                using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_GrupoPermisos (idGrupo,idPermisos) VALUES (@IdGrupo,@IdPermisos)", con))
                {
                    con.Open();
                    try
                    {
                        foreach (GrupoPermiso element in listaGrupoPermiso)
                        {
                            //FIXME: SI NO FUNCIONA PROBAR CON ADD
                            //cmdInsert.Parameters.Add("@IdEvento", element.IdEvento);
                            cmdInsert.Parameters.AddWithValue("@IdGrupo", element.IdGrupo);
                            cmdInsert.Parameters.AddWithValue("@IdPermisos", element.IdPermiso);
                            cmdInsert.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }

                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaPermiso"></param>
        public void InsertarPermisoDesdeBackup(List<Permiso> listaPermiso)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoPoint"].ConnectionString))
            {
                using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM [MotoPoint].[dbo].[tbl_Permisos]", con))
                {
                    try
                    {
                        con.Open();
                        cmdDelete.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }
                }

                using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_Permisos (IdPermiso,Descripcion) VALUES (@IdPermiso,@Descripcion)", con))
                {
                    con.Open();
                    try
                    {
                        foreach (Permiso element in listaPermiso)
                        {
                            //FIXME: SI NO FUNCIONA PROBAR CON ADD
                            //cmdInsert.Parameters.Add("@IdEvento", element.IdEvento);
                            cmdInsert.Parameters.AddWithValue("@IdPermiso", element.IdPermiso);
                            cmdInsert.Parameters.AddWithValue("@Descripcion", element.Descripcion);
                            cmdInsert.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }

                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaMultiIdioma"></param>
        public void InsertarMultiIdiomaDesdeBackup(List<MultiIdioma> listaMultiIdioma)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoPoint"].ConnectionString))
            {
                using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM [MotoPoint].[dbo].[tbl_MultiIdioma]", con))
                {
                    try
                    {
                        con.Open();
                        cmdDelete.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }
                }

                using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_MultiIdioma (Componente,IKey,Value) VALUES (@Componente,@IKey,@Value)", con))
                {
                    con.Open();
                    try
                    {
                        foreach (MultiIdioma element in listaMultiIdioma)
                        {
                            //FIXME: SI NO FUNCIONA PROBAR CON ADD
                            //cmdInsert.Parameters.Add("@IdEvento", element.IdEvento);
                            cmdInsert.Parameters.AddWithValue("@Componente", element.Componente);
                            cmdInsert.Parameters.AddWithValue("@IKey", element.IKey);
                            cmdInsert.Parameters.AddWithValue("@Value", element.Value);
                            cmdInsert.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }

                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaUsuarioGrupo"></param>
        public void InsertarUsuarioGrupoDesdeBackup(List<UsuarioGrupo> listaUsuarioGrupo)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoPoint"].ConnectionString))
            {
                using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM [MotoPoint].[dbo].[tbl_UsuarioGrupo]", con))
                {
                    try
                    {
                        con.Open();
                        cmdDelete.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }
                }

                using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_UsuarioGrupo (IdGrupo,IdUsuario) VALUES (@IdGrupo,@IdUsuario)", con))
                {
                    con.Open();
                    try
                    {
                        foreach (UsuarioGrupo element in listaUsuarioGrupo)
                        {
                            //FIXME: SI NO FUNCIONA PROBAR CON ADD
                            //cmdInsert.Parameters.Add("@IdEvento", element.IdEvento);
                            cmdInsert.Parameters.AddWithValue("@IdGrupo", element.IdGrupo);
                            cmdInsert.Parameters.AddWithValue("@IdUsuario", element.IdUsuario);
                            cmdInsert.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }

                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaUsuarios"></param>
        public void InsertarUsuarioDesdeBackup(List<Usuario> listaUsuarios)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoPoint"].ConnectionString))
            {
                using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM [MotoPoint].[dbo].[tbl_Usuario]", con))
                {
                    try
                    {
                        con.Open();
                        cmdDelete.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }
                }

                using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO tbl_Usuario (IdUsuario,usuario,Password,Legajo,Idioma,DigitoVerificador) VALUES (@IdUsuario,@usuario,@Password,@Legajo,@Idioma,@DigitoVerificador)", con))
                {
                    con.Open();
                    try
                    {
                        foreach (Usuario element in listaUsuarios)
                        {
                            //FIXME: SI NO FUNCIONA PROBAR CON ADD
                            //cmdInsert.Parameters.Add("@IdEvento", element.IdEvento);
                            cmdInsert.Parameters.AddWithValue("@IdUsuario", element.IdUsuario);
                            cmdInsert.Parameters.AddWithValue("@usuario", element.usuario);
                            cmdInsert.Parameters.AddWithValue("@Password", element.Password);
                            cmdInsert.Parameters.AddWithValue("@Legajo", element.Legajo);
                            cmdInsert.Parameters.AddWithValue("@Idioma", element.Idioma);
                            cmdInsert.Parameters.AddWithValue("@DigitoVerificador", element.DigitoVerificador);
                            cmdInsert.ExecuteNonQuery();
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }

                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Bitacora> ObtenerTablaBitacora()
        {
            List<Bitacora> listBitacora = new List<Bitacora>();
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoPoint"].ConnectionString))
            {
                using (SqlCommand cmdSelect = new SqlCommand("SELECT * FROM tbl_Bitacora", con))
                {
                    try
                    {
                        con.Open();
                        using (var reader = cmdSelect.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Bitacora oBitacora = new Bitacora();
                                oBitacora.IdEvento = Convert.ToInt32(reader["IdEvento"]);
                                oBitacora.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                                oBitacora.Descripcion = reader["Descripcion"].ToString();
                                oBitacora.Fecha = Convert.ToDateTime(reader["Fecha"]);
                                oBitacora.DigitoVerificador = reader["DigitoVerificador"].ToString();
                                listBitacora.Add(oBitacora);
                            }
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }
                }
                return listBitacora;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oBitacora"></param>
        public void ActualizarDigitoVerificadorBitacora(Bitacora oBitacora)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MotoPoint"].ConnectionString))
            {
                using (SqlCommand cmdSelect = new SqlCommand("UPDATE tbl_Bitacora SET idUsuario = @idUsuario, descripcion = @descripcion, fecha = @fecha, digitoVerificador = @digitoVerificador WHERE idEvento = @idEvento", con))
                {
                    try
                    {
                        con.Open();
                        cmdSelect.Parameters.AddWithValue("@idEvento", oBitacora.IdEvento);
                        cmdSelect.Parameters.AddWithValue("@idUsuario", oBitacora.IdUsuario);
                        cmdSelect.Parameters.AddWithValue("@descripcion", oBitacora.Descripcion);
                        cmdSelect.Parameters.AddWithValue("@fecha", oBitacora.Fecha);
                        cmdSelect.Parameters.AddWithValue("@digitoVerificador", oBitacora.DigitoVerificador);


                        cmdSelect.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }
                }
            }
        }
    }
}
