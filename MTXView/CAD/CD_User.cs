using CapaDatos;
using MySql.Data.MySqlClient;
using System.Data;

namespace Datos
{
    public class CD_User
    {
        MySqlDataReader leer;

        public string Verify(string nombre, string password)
        {
            try
            {
                using (MySqlConnection conexionsql = new(CD_Conexion.ConexionStr()))
                {
                    using (MySqlCommand comando = new MySqlCommand("Verificar", conexionsql))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add("name", MySqlDbType.VarChar).Value = nombre;
                        comando.Parameters.Add("pass", MySqlDbType.VarChar).Value = password;
                        conexionsql.Open();

                        leer = comando.ExecuteReader();

                        if (leer.Read())
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
                }
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
