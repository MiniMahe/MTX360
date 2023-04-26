using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;



namespace CAD
{
    public class CAD_Conexion
    {
        private MySqlConnection Conexion = new MySqlConnection("Server=\"mlmvc.com.mialias.net\";DataBase=\"mtxview\";User Id=\"lmmvc\";Password=\"testmvc1\"");

        public MySqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }

        public MySqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }

    }
}
