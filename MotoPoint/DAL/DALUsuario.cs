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
        /// EJ: https://social.msdn.microsoft.com/Forums/en-US/05d0e924-ad47-4d99-a5d8-e96f536a3bd1/sql-executescalar?forum=csharpgeneral
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
                        throw new SIS.EXCEPCIONES.DALExcepcion(ex.Message);
                    }
                }
            }
            return ultimoId;
        }
        /// <summary>
        ///         ''' 
        ///         ''' </summary>
        ///         ''' <param name="idUsuario"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        public int obtenerLegajoUsuario(int idUsuario)
        {
            int legajoVendedor;

            string conexString = System.Configuration.ConfigurationManager.ConnectionStrings("MotoPoint").ConnectionString;
            string sqlQuery = "SELECT legajo FROM tbl_Usuario WHERE idUsuario=@idUsuario";

            SqlConnection conex = new SqlConnection();
            conex.ConnectionString = conexString;

            SqlCommand comando = conex.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = sqlQuery;

            IDataParameter iPar = comando.CreateParameter();
            iPar.ParameterName = "idUsuario";
            iPar.DbType = DbType.Int32;
            iPar.Value = idUsuario;
            comando.Parameters.Add(iPar);

            try
            {
                conex.Open();

                legajoVendedor = comando.ExecuteScalar();

                conex.Close();
            }
            catch (Exception ex)
            {
            }
            return legajoVendedor;
        }


        /// <summary>
        ///         ''' 
        ///         ''' </summary>
        ///         ''' <param name="idUsuario"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        public BE.SIS.ENTIDAD.Usuario obtenerUsuarioPorId(int idUsuario)
        {
            BE.SIS.ENTIDAD.Usuario oUsuario = new BE.SIS.ENTIDAD.Usuario();

            string conexString = System.Configuration.ConfigurationManager.ConnectionStrings("MotoPoint").ConnectionString;
            string sqlQuery = "SELECT * FROM tbl_Usuario WHERE idUsuario=@idUsuario";

            SqlConnection conex = new SqlConnection();
            conex.ConnectionString = conexString;

            SqlCommand comando = conex.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = sqlQuery;

            IDataParameter iPar = comando.CreateParameter();
            iPar.ParameterName = "idUsuario";
            iPar.DbType = DbType.Int32;
            iPar.Value = idUsuario;
            comando.Parameters.Add(iPar);

            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet ds = new DataSet();

            try
            {
                adapter.Fill(ds, "Usuario");
                DataRow dr = ds.Tables("Usuario").Rows.Item(0);

                oUsuario.idUsuario = dr("idUsuario");
                oUsuario.usuario = dr("usuario");
                oUsuario.password = dr("password");
                oUsuario.legajo = dr("legajo");
                oUsuario.idioma = dr("idioma");
                oUsuario.digitoVerificador = dr("digitoVerificador");
            }
            catch (Exception ex)
            {
                throw new EL.SIS.EXCEPCIONES.DALExcepcion("Error en BD", ex);
            }
            return oUsuario;
        }
        /// <summary>
        ///         ''' 
        ///         ''' </summary>
        ///         ''' <param name="legajo"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        public BE.SIS.ENTIDAD.Usuario obtenerUsuarioPorLegajo(string legajo)
        {
            BE.SIS.ENTIDAD.Usuario oUsuario = new BE.SIS.ENTIDAD.Usuario();

            string conexString = System.Configuration.ConfigurationManager.ConnectionStrings("MotoPoint").ConnectionString;
            string sqlQuery = "SELECT * FROM tbl_Usuario WHERE legajo=@legajo";

            SqlConnection conex = new SqlConnection();
            conex.ConnectionString = conexString;

            SqlCommand comando = conex.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = sqlQuery;

            IDataParameter iPar = comando.CreateParameter();
            iPar.ParameterName = "legajo";
            iPar.DbType = DbType.String;
            iPar.Value = legajo;
            comando.Parameters.Add(iPar);

            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet ds = new DataSet();

            try
            {
                adapter.Fill(ds, "Usuario");
                DataRow dr = ds.Tables("Usuario").Rows.Item(0);

                oUsuario.idUsuario = dr("idUsuario");
                oUsuario.usuario = dr("usuario");
                oUsuario.password = dr("password");
                oUsuario.legajo = dr("legajo");
                oUsuario.idioma = dr("idioma");
                oUsuario.digitoVerificador = dr("digitoVerificador");
            }
            catch (Exception ex)
            {
                throw new EL.SIS.EXCEPCIONES.DALExcepcion("Error en BD", ex);
            }

            return oUsuario;
        }
        /// <summary>
        ///         ''' 
        ///         ''' </summary>
        ///         ''' <param name="usuario"></param>
        ///         ''' <param name="password"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        public int validarUsuario(string usuario, string password)
        {
            int resultadoValidacion = 0;

            string conexString = System.Configuration.ConfigurationManager.ConnectionStrings("MotoPoint").ConnectionString;
            string sqlQuery = "SELECT [idUsuario] FROM tbl_Usuario WHERE usuario=@usuario AND password=@password";

            SqlConnection conex = new SqlConnection();
            conex.ConnectionString = conexString;

            SqlCommand comando = conex.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = sqlQuery;

            IDataParameter iPar = comando.CreateParameter();

            iPar.ParameterName = "usuario";
            iPar.DbType = DbType.String;
            iPar.Value = usuario;
            comando.Parameters.Add(iPar);

            iPar = comando.CreateParameter();
            iPar.ParameterName = "password";
            iPar.DbType = DbType.String;
            iPar.Value = password;
            comando.Parameters.Add(iPar);

            try
            {
                conex.Open();
                resultadoValidacion = comando.ExecuteScalar();
                conex.Close();
            }
            catch (Exception ex)
            {
                throw new EL.SIS.EXCEPCIONES.DALExcepcion(ex.Message);
            }
            return resultadoValidacion;
        }
        /// <summary>
        ///         ''' 
        ///         ''' </summary>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        public List<BE.SIS.ENTIDAD.Usuario> obtenerTablaUsuario()
        {
            List<BE.SIS.ENTIDAD.Usuario> listadoUsuarios = new List<BE.SIS.ENTIDAD.Usuario>();

            string conexString = System.Configuration.ConfigurationManager.ConnectionStrings("MotoPoint").ConnectionString;
            string sqlQuery = "SELECT * FROM tbl_Usuario";

            SqlConnection conex = new SqlConnection();
            conex.ConnectionString = conexString;

            SqlCommand comando = conex.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = sqlQuery;

            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet ds = new DataSet();

            try
            {
                adapter.Fill(ds, "Usuario");
                IEnumerator<DataRow> enu = ds.Tables("Usuario").Rows.GetEnumerator;

                while (enu.MoveNext())
                {
                    BE.SIS.ENTIDAD.Usuario oUsuario = new BE.SIS.ENTIDAD.Usuario();
                    oUsuario.idUsuario = System.Convert.ToInt32(enu.Current("idUsuario"));
                    oUsuario.usuario = enu.Current("usuario");
                    oUsuario.password = enu.Current("password");
                    oUsuario.legajo = enu.Current("legajo");
                    oUsuario.idioma = enu.Current("idioma");
                    oUsuario.digitoVerificador = enu.Current("digitoVerificador");

                    listadoUsuarios.Add(oUsuario);
                }
            }
            catch (Exception ex)
            {
                throw new EL.SIS.EXCEPCIONES.DALExcepcion("Error en BD", ex);
            }
            return listadoUsuarios;
        }
        /// <summary>
        ///         ''' 
        ///         ''' </summary>
        ///         ''' <param name="usuario"></param>
        ///         ''' <returns></returns>
        ///         ''' <remarks></remarks>
        public bool validarExistenciaUsuario(string usuario)
        {
            int resultadoValidacion = 0;

            string conexString = System.Configuration.ConfigurationManager.ConnectionStrings("MotoPoint").ConnectionString;
            string sqlQuery = "SELECT [idUsuario] FROM tbl_Usuario WHERE usuario=@usuario";

            SqlConnection conex = new SqlConnection();
            conex.ConnectionString = conexString;

            SqlCommand comando = conex.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = sqlQuery;

            IDataParameter iPar = comando.CreateParameter();

            iPar.ParameterName = "usuario";
            iPar.DbType = DbType.String;
            iPar.Value = usuario;
            comando.Parameters.Add(iPar);

            try
            {
                conex.Open();
                resultadoValidacion = comando.ExecuteScalar();
                conex.Close();
            }
            catch (SqlException ex)
            {
                throw new EL.SIS.EXCEPCIONES.DALExcepcion("Error en la Base de Datos");
            }

            bool resultado;
            if (!resultadoValidacion == 0)
                resultado = false;
            else
                resultado = true;
            return resultado;
        }
        /// <summary>
        ///         ''' 
        ///         ''' </summary>
        ///         ''' <param name="listaUsuarios"></param>
        ///         ''' <remarks></remarks>
        public void insertarUsuario(List<BE.SIS.ENTIDAD.Usuario> listaUsuarios)
        {
            string conexString = System.Configuration.ConfigurationManager.ConnectionStrings("MotoPoint").ConnectionString;
            string sqlQuery = "SELECT * FROM tbl_Usuario";

            SqlDataAdapter adaptador = new SqlDataAdapter(sqlQuery, conexString);
            DataSet ds = new DataSet();
            SqlCommandBuilder cb = new SqlCommandBuilder(adaptador);
            adaptador.UpdateCommand = cb.GetUpdateCommand();
            adaptador.InsertCommand = cb.GetInsertCommand();
            adaptador.DeleteCommand = cb.GetDeleteCommand();

            try
            {
                adaptador.Fill(ds, "Usuario");

                if (ds.Tables("Usuario").Rows.Count == 0)
                {
                    BE.SIS.ENTIDAD.Usuario ColumnaVerificadora = listaUsuarios.Item[0];
                    DataRow dr = ds.Tables("Usuario").Rows.Add;
                    dr("idUsuario") = ColumnaVerificadora.idUsuario.ToString;
                    dr("usuario") = ColumnaVerificadora.usuario.ToString;
                    dr("password") = ColumnaVerificadora.password.ToString;
                    dr("legajo") = ColumnaVerificadora.legajo.ToString;
                    dr("idioma") = ColumnaVerificadora.idioma.ToString;
                    dr("digitoVerificador") = ColumnaVerificadora.digitoVerificador.ToString;
                }
                else
                {
                    // sobre escribir el regustro cuyo idUsuario=1 (digitos Verificadores verticales)

                    IEnumerator<DataRow> enu = ds.Tables("Usuario").Rows.GetEnumerator;
                    while (enu.MoveNext())
                    {
                        if (enu.Current.Item(0) == 1)
                        {
                            enu.Current.Item(1) = listaUsuarios.Item[0].usuario;
                            enu.Current.Item(2) = listaUsuarios.Item[0].password;
                            enu.Current.Item(3) = listaUsuarios.Item[0].legajo;
                            enu.Current.Item(4) = listaUsuarios.Item[0].idioma;
                            enu.Current.Item(5) = listaUsuarios.Item[0].digitoVerificador;
                        }
                    }
                }

                int posicionUltimo = listaUsuarios.Count;
                posicionUltimo = posicionUltimo - 1;
                BE.SIS.ENTIDAD.Usuario oUsuario2 = listaUsuarios.Item[posicionUltimo];
                DataRow dr2 = ds.Tables("Usuario").NewRow;
                dr2("idUsuario") = System.Convert.ToInt32(oUsuario2.idUsuario);
                dr2("usuario") = oUsuario2.usuario.ToString;
                dr2("password") = oUsuario2.password.ToString;
                dr2("legajo") = oUsuario2.legajo.ToString;
                dr2("idioma") = oUsuario2.idioma.ToString;
                dr2("digitoVerificador") = oUsuario2.digitoVerificador.ToString;
                ds.Tables("Usuario").Rows.Add(dr2);

                adaptador.Update(ds, "Usuario");
            }
            catch (Exception ex)
            {
                throw new EL.SIS.EXCEPCIONES.DALExcepcion(ex.Message);
            }
        }
        /// <summary>
        ///         ''' 
        ///         ''' </summary>
        ///         ''' <param name="listadoUsuarios"></param>
        ///         ''' <remarks></remarks>
        public void insertarUsuarioDesdeBackup(List<BE.SIS.ENTIDAD.Usuario> listadoUsuarios)
        {
            string conexString = System.Configuration.ConfigurationManager.ConnectionStrings("MotoPoint").ConnectionString;
            string sqlQuery = "SELECT * FROM tbl_Usuario";

            SqlDataAdapter adaptador = new SqlDataAdapter(sqlQuery, conexString);
            DataSet ds = new DataSet();
            SqlCommandBuilder cb = new SqlCommandBuilder(adaptador);
            adaptador.UpdateCommand = cb.GetUpdateCommand();
            adaptador.InsertCommand = cb.GetInsertCommand();
            adaptador.DeleteCommand = cb.GetDeleteCommand();

            SqlConnection conex = new SqlConnection();
            conex.ConnectionString = conexString;

            SqlCommand comando = conex.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "DELETE FROM [MotoPoint].[dbo].[tbl_Usuario]";
            try
            {
                conex.Open();
                comando.ExecuteScalar();
                conex.Close();
            }
            catch (Exception ex)
            {
                throw new EL.SIS.EXCEPCIONES.DALExcepcion(ex.Message);
            }

            try
            {
                adaptador.Fill(ds, "Usuario");

                IEnumerator<BE.SIS.ENTIDAD.Usuario> enu = listadoUsuarios.GetEnumerator();

                while (enu.MoveNext())
                {
                    DataRow dr = ds.Tables("Usuario").NewRow;
                    dr("idUsuario") = System.Convert.ToInt32(enu.Current.idUsuario);
                    dr("usuario") = enu.Current.usuario.ToString;
                    dr("password") = enu.Current.password.ToString;
                    dr("legajo") = enu.Current.legajo.ToString;
                    dr("idioma") = enu.Current.idioma.ToString;
                    dr("digitoVerificador") = enu.Current.digitoVerificador.ToString;
                    ds.Tables("Usuario").Rows.Add(dr);
                }
                adaptador.Update(ds, "Usuario");
            }
            catch (Exception ex)
            {
                throw new EL.SIS.EXCEPCIONES.DALExcepcion(ex.Message);
            }
        }
    }
}
