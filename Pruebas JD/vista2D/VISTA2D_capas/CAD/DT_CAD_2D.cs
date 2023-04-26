using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace CAD
{
    public class DT_CAD_2D
    {
        private CAD_Conexion conexion = new CAD_Conexion();


        public DataTable ObtenerDatatable()
        {
            string query1 = "SELECT * FROM `cordenadas`";

            MySqlConnection conexionConnection = conexion.AbrirConexion();
            MySqlCommand command1 = new MySqlCommand(query1, conexionConnection);
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(command1);

            DataTable table1 = new DataTable("cordenadas");
            adapter1.Fill(table1);

            return table1;
        }

    }
}
