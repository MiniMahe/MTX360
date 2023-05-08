using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CapaDatos;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public void Crear(int idim,int nodo, string pos)
        {
            using (MySqlConnection conexionsql = new(CD_Conexion.ConexionStr()))
            {
                using (MySqlCommand command = new MySqlCommand("CrearFlecha", conexionsql))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idimg", idim).Direction = ParameterDirection.InputOutput;
                    command.Parameters.AddWithValue("@node", nodo).Direction = ParameterDirection.InputOutput;
                    command.Parameters.AddWithValue("@posicion", pos).Direction = ParameterDirection.InputOutput;

                    conexionsql.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Editar(int id,int idimg, int node, string pos)
        {
            using (MySqlConnection conexionsql = new(CD_Conexion.ConexionStr()))
            {
                using (MySqlCommand command = new MySqlCommand("EditarFlecha", conexionsql))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id).Direction = ParameterDirection.InputOutput;
                    command.Parameters.AddWithValue("@idimg", idimg).Direction = ParameterDirection.InputOutput;
                    command.Parameters.AddWithValue("@node", node).Direction = ParameterDirection.InputOutput;
                    command.Parameters.AddWithValue("@posicion", pos).Direction = ParameterDirection.InputOutput;

                    conexionsql.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void Eliminar(int id)
        {
            using (MySqlConnection conexionsql = new(CD_Conexion.ConexionStr()))
            {
                using (MySqlCommand command = new MySqlCommand("EliminarFlecha", conexionsql))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@id", id).Direction = ParameterDirection.InputOutput;

                    conexionsql.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
