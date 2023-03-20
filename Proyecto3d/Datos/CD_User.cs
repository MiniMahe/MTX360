using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class CD_User {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        public string Verify(string nombre, string password)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Verificar";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@email", nombre);
            comando.Parameters.AddWithValue("@password", password);
            leer = comando.ExecuteReader();
            if(leer.Read())
            {
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return nombre;
            }
            //comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return null;
        }

    }
}