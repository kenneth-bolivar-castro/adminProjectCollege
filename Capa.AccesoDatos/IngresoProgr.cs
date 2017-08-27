using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.AccesoDatos
{
/// <summary>
///Clase que valida el usuario, para ingresar al programa 
/// </summary>
    public class IngresoProgr
    {
        /// <summary>
        /// Metodo statico para ingresar al sistema
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contrasenia"></param>
        /// <returns></returns>
        public static Entidades.UsuarioEnt ingreso(string nombreUsuario,string contrasenia)
        {

            Entidades.UsuarioEnt usuario = null;
            String conexion = Conexion.cadena;
            SqlConnection conn = new SqlConnection(conexion);


            string sql = "SP_IngresarSistema";

            SqlCommand command = new SqlCommand(sql, conn);

            command.CommandType = System.Data.CommandType.StoredProcedure;

            try
            {
                //Abrir conexion
                conn.Open();
                command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                command.Parameters.AddWithValue("@CONTRASENIA", contrasenia);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if ((int)reader["ESTADO"] == 0)
                        return null;

                    usuario = new Entidades.UsuarioEnt();
                    usuario.id = (int)reader["ID"];
                    usuario.Nombre = reader["NOMBRE"].ToString();
                    usuario.rol = new Entidades.RolesEnt();
                    usuario.rol.idRol = (int)reader["ID_ROL"];
                    return usuario;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }

            return usuario;

        }

        
    }
}
