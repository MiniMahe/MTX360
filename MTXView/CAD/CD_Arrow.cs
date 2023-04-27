using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using MySql.Data.MySqlClient;

namespace CAD
{
    public class CD_Arrow
    {
        MySqlDataReader leer;
        public DataTable LoadArrow()
        {
            using (MySqlConnection conexionsql = new(CD_Conexion.ConexionStr()))
            {
                MySqlCommand comando = new MySqlCommand("todaslasflechas", conexionsql);
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(comando);
                DataTable dataTable = new DataTable();
                adapter1.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
