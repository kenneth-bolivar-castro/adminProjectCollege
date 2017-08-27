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
    public class ActividadDatos
    {
        /// <summary>
        /// Obtiene Las actividades segun el proyecto
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<Entidades.ActividadEnt> ObtenerListaActPorProyectos(int id)
        {
            List<Entidades.ActividadEnt> listaAct = new List<Entidades.ActividadEnt>();

            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_ObtenerActividadPorProyecto";


            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProy", id);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {



                    Entidades.ActividadEnt act = new Entidades.ActividadEnt();
                    act.ID = (int)reader["ID"];
                    act.Detalles = reader["DETALLES"].ToString();
                    act.Titulo = reader["TITULO"].ToString();
                    act.TiempoEstimado = (int)reader["TIEMPOEST"];
                    act.TiempoReal = (int)reader["TIEMPOREAL"];
                    act.CostoActividad = (double)reader["COSTO_ACT"];
                    act.Usuario = new Entidades.UsuarioEnt();
                    act.Usuario.id = (int)reader["USID"];
                    act.Usuario.Nombre = reader["NOMBRE"].ToString();
                    act.Estado = reader["ESTADO"].ToString();
                    act.Gravedad = (int)reader["GRAVEDAD"];
                    act.Tipo = new Entidades.TipoActividad();
                    act.Tipo.Id =(int) reader["IDTIPO"];
                    act.Tipo.Nombre = reader["TITULOTIPOAC"].ToString();


                    listaAct.Add(act);
                }

                return listaAct;


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
        /// Obtiene el tipo de actividad para el frame
        /// </summary>
        /// <returns></returns>
        public static List<Entidades.TipoActividad> ObtenerTipoActividad()
        {
            List<Entidades.TipoActividad> ListTipoAct = new List<Entidades.TipoActividad>();


            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_ObtenerTipoActividades";

            SqlCommand cmd = new SqlCommand(sql,conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Entidades.TipoActividad tipo = new Entidades.TipoActividad();
                    tipo.Id = (int)reader["ID"];
                    tipo.Nombre = reader["TITULO"].ToString();
                    ListTipoAct.Add(tipo);
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



            return ListTipoAct;

        }
        /// <summary>
        /// Inserta en la tabla actividad
        /// </summary>
        /// <param name="actividad"></param>
        /// <param name="proy"></param>
        public static void InsertarActividad(Entidades.ActividadEnt actividad, Entidades.ProyectoEnt proy)
        {
            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_InsertarActividad";

            SqlCommand cmd = new SqlCommand(sql, conn);


            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@Titulo", actividad.Titulo);
                cmd.Parameters.AddWithValue("@Detalles", actividad.Detalles);
                cmd.Parameters.AddWithValue("@TiempoEst", actividad.TiempoEstimado);
                cmd.Parameters.AddWithValue("@TiempoReal", actividad.TiempoReal);
                cmd.Parameters.AddWithValue("@Costo_Act", actividad.CostoActividad);
                cmd.Parameters.AddWithValue("@CostoEst_Act", actividad.CostoEstActividad);
                cmd.Parameters.AddWithValue("@ID_Usr", actividad.Usuario.id);
                cmd.Parameters.AddWithValue("@ID_Proy", proy.Id);
                cmd.Parameters.AddWithValue("@Estado", actividad.Estado);
                cmd.Parameters.AddWithValue("@Gravedad", actividad.Gravedad);
                cmd.Parameters.AddWithValue("@ID_TipAct", actividad.Tipo.Id);


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

        public static int ContadorActividades()
        {
            int cont = 0;


            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_ContAct";


            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    cont = (int)reader["Cont"];
                }


                return cont;

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
        public static void ModificarActividad(Entidades.ActividadEnt actividad)
        {
            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_ModificarActividad";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@Id", actividad.ID);
                cmd.Parameters.AddWithValue("@Titulo", actividad.Titulo);
                cmd.Parameters.AddWithValue("@Detalles", actividad.Detalles);
                cmd.Parameters.AddWithValue("@TiempoEst", actividad.TiempoEstimado);
                cmd.Parameters.AddWithValue("@TiempoReal", actividad.TiempoReal);
                cmd.Parameters.AddWithValue("@Costo_Act", actividad.CostoActividad);
                cmd.Parameters.AddWithValue("@CostoEst_Act", actividad.CostoEstActividad);
                cmd.Parameters.AddWithValue("@ID_Usr", actividad.Usuario.id);
                cmd.Parameters.AddWithValue("@Estado", actividad.Estado);
                cmd.Parameters.AddWithValue("@Gravedad", actividad.Gravedad);
                cmd.Parameters.AddWithValue("ID_TipAct", actividad.Tipo.Id);


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
