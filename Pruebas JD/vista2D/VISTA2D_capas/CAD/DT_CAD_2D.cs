using System.Data;
using System.Data.SqlClient;

namespace CAD
{
    public class DT_CAD_2D
    {
        private CAD_Conexion conexion = new CAD_Conexion();


        public DataTable ObtenerDatatable()
        {
            string query1 = "SELECT * FROM imagen";

            SqlConnection conexionConnection = conexion.AbrirConexion();
            SqlCommand command1 = new SqlCommand(query1, conexionConnection);
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);

            DataTable table1 = new DataTable("imagen");
            adapter1.Fill(table1);

            return table1;
        }

    }
}
