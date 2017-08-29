using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.AccesoDatos
{
    /// <summary>
    ///Clase que Comunica SQL SERVER con el Programa
    /// </summary>
    public class UsuariosDatos
    {

        /// <summary>
        /// Obtiene todos los Usuarios
        /// </summary>
        /// <returns></returns>
        public static List<Entidades.UsuarioEnt> ObtenerTodosUsuarios()
        {
            List<Entidades.UsuarioEnt> listaUsuarios = new List<Entidades.UsuarioEnt>();

            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_ObtenerUsuarios";


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();

                

                while (reader.Read())
                {
                    Entidades.UsuarioEnt usuario = new Entidades.UsuarioEnt();

                    usuario.id = (int)reader["ID"];
                    usuario.Nombre = reader["NOMBRE"].ToString();
                    usuario.rol = new Entidades.RolesEnt();
                    usuario.rol.idRol = (int)reader["ID_ROL"];
                    usuario.rol.Descrip = reader["DESCRIP"].ToString();
                    usuario.Contrasenia = reader["CON"].ToString();
                    usuario.NombreUsuario = reader["NOMBREUSUAR"].ToString();
                    listaUsuarios.Add(usuario);
                }


            }

            catch
            {
                throw;
            }


            finally
            {
                conn.Close();
            }


            return listaUsuarios;
        }


        //public static Entidades.UsuarioEnt BuscarPorId(int Id)
        //{
        //    Entidades.UsuarioEnt usuario = null;

        //    SqlConnection conn = new SqlConnection(Conexion.cadena);

        //    string sql = "select ID,NOMBRE, ID_ROL, NOMBREUSUAR from Usuarios where ID = @Id";


        //    try
        //    {
        //        conn.Open();


        //        SqlCommand cmd = new SqlCommand(sql,conn);

        //        cmd.Parameters.AddWithValue("@ID", Id);
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            usuario = new Entidades.UsuarioEnt();
        //            usuario.Id = (int)reader["ID"];
        //            usuario.Nombre = reader["NOMBRE"].ToString();
        //            usuario.IdRol = (int)reader["ID_ROL"];
        //            usuario.NombreUsuario = reader["NOMBREUSUAR"].ToString();

        //            return usuario;
        //        }



        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }


        //    return usuario; 
        //}
        /// <summary>
        /// Inserta en la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        public static void InsertarUsuario(Entidades.UsuarioEnt usuario)
        {
            SqlConnection conn = new SqlConnection(Conexion.cadena);


            string sql = "SP_InsertarUsuario";


            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();
                
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@IdRol", usuario.rol.idRol);
                cmd.Parameters.AddWithValue("@NombreUs", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia);
                cmd.Parameters.AddWithValue("@Estado", 1);

                cmd.ExecuteNonQuery();
            }
            catch 
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Modificar al usuario segun el Id
        /// </summary>
        /// <param name="usuario"></param>
        public static void modificar(Entidades.UsuarioEnt usuario)
        {
            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_ModificarUsuario";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@IdRol", usuario.rol.idRol);
                cmd.Parameters.AddWithValue("@NombreUs", usuario.NombreUsuario);
                cmd.Parameters.AddWithValue("@Id", usuario.id);
                cmd.Parameters.AddWithValue("@Contrasenia", usuario.Contrasenia);
                cmd.ExecuteNonQuery();


            }
            catch 
            {
                
                throw;
            }
            finally
            {
                conn.Close();
            }

        }


        /// <summary>
        /// En realidad cambia el estado del usuario a 0.
        /// </summary>
        /// <param name="id"></param>
        public static void EliminarUsuario(int id)
        {
            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_EliminarUsuario";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();

            }
            catch
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
