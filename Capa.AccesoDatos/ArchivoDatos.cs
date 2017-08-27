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
    public class ArchivoDatos
    {
        /// <summary>
        /// Inserta un archivo en la tabla Archivos
        /// </summary>
        /// <param name="archivo">El archivo COMPLETO</param>
        /// <param name="IdAct">El Id de la actividad perteneciente</param>
        public static void InsertarArchivo(Entidades.ArchivoEnt archivo, int IdAct)
        {
            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_InsertarArchivo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@Nombre", archivo.Nombre);
                cmd.Parameters.AddWithValue("@Bites", archivo.ArrByte);
                cmd.Parameters.AddWithValue("@ID_Act", IdAct);

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
        /// Obtiene los archivos de una actividad
        /// </summary>
        /// <param name="idAct"></param>
        /// <returns></returns>
        public static List<Entidades.ArchivoEnt> ObtenerArchivos(int idAct)
        {
            List<Entidades.ArchivoEnt> listaArchivos = new List<Entidades.ArchivoEnt>();

            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_ObtenerArchivos";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@IdAct", idAct);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Entidades.ArchivoEnt archivo = new Entidades.ArchivoEnt();
                    archivo.Id = (int)reader["ID"];
                    archivo.Nombre = reader["NOMBRE"].ToString();
                    archivo.ArrByte = (Byte[])reader["BITES"];
                    listaArchivos.Add(archivo);

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

            return listaArchivos;
        }

        /// <summary>
        /// El unico metodo que en realidad elimina de la tabla Archivos
        /// </summary>
        /// <param name="idArch"></param>
        public static void EliminarArchivo(int idArch)
        {
            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_EliminarArchivo";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();

                cmd.Parameters.AddWithValue("@IdArchi", idArch);

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
