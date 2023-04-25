using CapaDatos;
using Microsoft.Identity.Client;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Security.Claims;

namespace Image
{
    public class CD_Image
    {
        MySqlDataReader leer;
        public DataTable LoadImage()
        {
            using (MySqlConnection conexionsql = new(CD_Conexion.ConexionStr()))
            {
                MySqlCommand comando = new MySqlCommand("todaslasimagenes", conexionsql);
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(comando);
                DataTable dataTable = new DataTable();
                adapter1.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
