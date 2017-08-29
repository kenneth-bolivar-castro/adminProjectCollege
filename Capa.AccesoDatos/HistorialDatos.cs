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
    public class HistorialDatos
    {




        /// <summary>
        /// Inserta en la tabla historial
        /// </summary>
        /// <param name="historial"></param>
        public static void InsertarHistorial(Entidades.HistorialEnt historial)
        {
            SqlConnection conn = new SqlConnection(Conexion.cadena);


            string sql = "SP_InsertarHistorial";

            SqlCommand cmd = new SqlCommand(sql, conn);


            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@Fecha_Cambio", historial.FechaCambio);
                cmd.Parameters.AddWithValue("@TIPOREP", historial.TipoCambio);
                cmd.Parameters.AddWithValue("@ID_ACT", historial.actividad.ID);
                cmd.Parameters.AddWithValue("@ID_USUARI", historial.usuario.id);

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
