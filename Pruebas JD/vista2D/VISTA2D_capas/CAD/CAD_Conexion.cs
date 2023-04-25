using System.Data;
using System.Data.SqlClient;


namespace CAD
{
    public class CAD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-Q90V882\\SQLEXPRESS;DataBase=MTX360JD; Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();
            }
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }

    }
}
