using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CAD
{
    public class CAD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Server=JOSED\\SQLEXPRESS;DataBase=PorDecidir; Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if(Conexion.State == ConnectionState.Closed) 
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
