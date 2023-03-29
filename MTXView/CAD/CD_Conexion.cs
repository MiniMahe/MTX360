using System.Data;
using System.Data.SqlClient;
using System.Xml;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class CD_Conexion
    {
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
    }
   
}
