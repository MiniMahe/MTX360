using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection(ConexionStr());
        public static string ConexionStr()
        {
            string cadenita;
            using (XmlReader lectorxml = XmlReader.Create("XMLFile1.xml"))
            {
                lectorxml.ReadToFollowing("add");
                cadenita = lectorxml.ReadElementContentAsString();
                return cadenita;
            }
        }
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
   
}
