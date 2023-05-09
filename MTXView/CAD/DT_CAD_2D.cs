using CapaDatos;
using MySql.Data.MySqlClient;
using System.Data;


namespace Datos
{
    public class DT_CAD_2D
    {


        public DataTable ObtenerDatatable()
        {
            using (MySqlConnection conexionsql = new(CD_Conexion.ConexionStr()))
            {
                string query1 = "SELECT * FROM `cordenadas`";

                MySqlCommand command1 = new MySqlCommand(query1, conexionsql);
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(command1);

                DataTable table1 = new DataTable("cordenadas");
                adapter1.Fill(table1);

                return table1;
            }
        }

    }
}
