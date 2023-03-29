using CapaDatos;
using Microsoft.Identity.Client;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Security.Claims;

namespace Datos
{
    public class CD_User {
        MySqlDataReader leer;
        MySqlCommand comando = new MySqlCommand();
        MySqlConnection conexionsql = new(CD_Conexion.ConexionStr());
        public string Verify(string nombre, string password)
        {
            try
            {
                            comando.CommandType = CommandType.StoredProcedure;
                            comando.Parameters.Add("email", MySqlDbType.VarChar).Value = nombre;
                            comando.Parameters.Add("password", MySqlDbType.VarChar).Value = password;
                            conexionsql.Open();

                            MySqlDataReader leectorsql = comando.ExecuteReader();

                            if (leectorsql.Read())
                            {
                                conexionsql.Close();
                                return nombre;
                            }
                            else
                            {
                                conexionsql.Close();
                              
                                return null;
                            }
                      
                

            }
            catch (Exception)
            {

                return null;
            }
        }
    }

    }
