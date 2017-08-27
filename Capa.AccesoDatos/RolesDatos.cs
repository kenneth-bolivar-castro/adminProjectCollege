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
    public class RolesDatos
    {   

        /// <summary>
        /// Obtiene los roles que existen en la tabla Roles
        /// </summary>
        /// <returns></returns>
        public static List<Entidades.RolesEnt> ObtenerListaRoles()
        {
            List<Entidades.RolesEnt> listaRol = new List<Entidades.RolesEnt>();


            SqlConnection conn = new SqlConnection(Conexion.cadena);

            string sql = "SP_ObtenerRoles";

            SqlCommand cmd = new SqlCommand(sql,conn);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Entidades.RolesEnt rol = new Entidades.RolesEnt();

                    rol.idRol = (int)reader["ID_ROL"];
                    rol.Descrip = reader["DESCRIP"].ToString();

                    listaRol.Add(rol);
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

            return listaRol;


        }
    }
}
