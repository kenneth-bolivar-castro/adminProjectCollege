using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.AccesoDatos
{
    /// <summary>
    /// Clase que Comunica SQL SERVER con el Programa
    /// </summary>
    public class ProyectosDatos
    {
        /// <summary>
        /// Obtiene todos los proyectos
        /// </summary>
        /// <returns></returns>
        public static List<Entidades.ProyectoEnt> ObtenerTodosProyectos()
        {
            List<Entidades.ProyectoEnt> listaProyectos = new List<Entidades.ProyectoEnt>();

            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_ObtenerTodosProyectos";




            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    Entidades.ProyectoEnt proy = new Entidades.ProyectoEnt();

                    proy.Id = (int)reader["ID"];
                    proy.Nombre = reader["NOMBRE"].ToString();
                    proy.Estado = reader["ESTADO"].ToString();
                    proy.TotCosto = (double)reader["TOTAL_COSTO"];
                    proy.TiempoTotalTrab = (int)reader["TIEMPOTOT"];
                    proy.TiempoEstimTrab = (int)reader["TIEMPOEST"];
                    proy.EstimCosto = (double)reader["ESTIMADO_COSTO"];
                    proy.CostoHora = (double)reader["COSTO_HORA"];
                    listaProyectos.Add(proy);
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


            return listaProyectos;
        }

        /// <summary>
        /// Obtener los proyectos por Usuarios
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public static List<Entidades.ProyectoEnt> ObtenerTodosProyectosPorUsuarios(int idUsuario)
        {
            List<Entidades.ProyectoEnt> listaProyectos = new List<Entidades.ProyectoEnt>();

            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_ObtenerProyectosPorUsuarios";



            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDUSER", idUsuario);

                SqlDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    Entidades.ProyectoEnt proy = new Entidades.ProyectoEnt();

                    proy.Id = (int)reader["ID"];
                    proy.Nombre = reader["NOMBRE"].ToString();
                    proy.Estado = reader["ESTADO"].ToString();
                    proy.TotCosto = (double)reader["TOTAL_COSTO"];
                    proy.TiempoTotalTrab = (int)reader["TIEMPOTOT"];
                    proy.TiempoEstimTrab = (int)reader["TIEMPOEST"];
                    proy.EstimCosto = (double)reader["ESTIMADO_COSTO"];
                    proy.CostoHora = (double)reader["COSTO_HORA"];

                    listaProyectos.Add(proy);
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


            return listaProyectos;
        }


        /// <summary>
        /// Extraer usuarios segun el Proyecto
        /// </summary>
        /// <param name="idProy"></param>
        /// <returns></returns>
        public static List<Entidades.UsuarioEnt> ObtenerTodosUsuariosPorProyetos(int idProy)
        {
            List<Entidades.UsuarioEnt> listaProyectos = new List<Entidades.UsuarioEnt>();

            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_ObtenerUsuariosPorProyect";




            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDPROY", idProy);

                SqlDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    Entidades.UsuarioEnt usuario = new Entidades.UsuarioEnt();

                    usuario.id = (int)reader["ID"];
                    usuario.Nombre = reader["NOMBRE"].ToString();
                    usuario.NombreUsuario = reader["NOMBREUSUAR"].ToString();
                    listaProyectos.Add(usuario);
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


            return listaProyectos;
        }


        /// <summary>
        /// Inserta el proyecto en la base de datos
        /// </summary>
        /// <param name="proyecto"></param>
        public static void InsertarProyecto(Entidades.ProyectoEnt proyecto)
        {
            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_InsertarProyecto";

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", proyecto.Nombre);
                cmd.Parameters.AddWithValue("@CostoHora", proyecto.CostoHora);
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
        /// Crea la relacion de los usuarios con los proyectos.
        /// </summary>
        /// <param name="IDProy"></param>
        /// <param name="IDUsr"></param>
        public static void InsertarTablaProyUsuarios(int IdProy, int IdUsr)
        {
            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_IncluirProyUsuar";


            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@idProy", IdProy);
                cmd.Parameters.AddWithValue("@idUsr", IdUsr);

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
        /// Metodo para obtener el id agregado
        /// </summary>
        /// <returns></returns>
        public static int ContadorProycts()
        {
            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_ContadorProy";

            SqlCommand cmd = new SqlCommand(sql,conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return (int)reader["CONTADOR"];

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
            return 0;
        }

        /// <summary>
        /// Modifica el valor en la tabla proyecto, segun su ID
        /// </summary>
        /// <param name="proyecto"></param>
        public static void ModificarProyecto(Entidades.ProyectoEnt proyecto)
        {
            SqlConnection conn = new SqlConnection(Conexion.cadena);
            string sql = "SP_ModificarProyecto";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@IdProy", proyecto.Id);
                cmd.Parameters.AddWithValue("@Nombre", proyecto.Nombre);
                cmd.Parameters.AddWithValue("@CostoHora", proyecto.CostoHora);

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
        /// Cambia el estado a Inactivo no lo elimina
        /// </summary>
        /// <param name="id"></param>
        public static void EliminarProyecto(int id)
        {
            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_EliminarProyecto";


            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@IdProy", id);

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
        /// Elimina de la tabla Usuarios Proyectos, su relacion
        /// </summary>
        /// <param name="idProy"></param>
        /// <param name="IdUsr"></param>
        public static void EliminarUsuariosProyecto(int idProy,int IdUsr)
        {
            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_EliminarUsuarProy";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@IdProy", idProy);
                cmd.Parameters.AddWithValue("@IdUsuar", IdUsr);

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
