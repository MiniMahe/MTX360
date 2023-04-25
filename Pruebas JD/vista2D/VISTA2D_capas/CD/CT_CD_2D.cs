using CAD;
using System.Data;

namespace CD
{
    public class CT_CD_2D
    {
        public int id { get; set; }
        public string aula { get; set; }
        public string imagen { get; set; }
        public int piso { get; set; }
        public string cordenadas { get; set; }
        public string url { get; set; }



        public List<CT_CD_2D> ConvertirDataTableALista()
        {
            DT_CAD_2D dT_CAD_2D = new DT_CAD_2D();
            DataTable dataTable;
            dataTable = dT_CAD_2D.ObtenerDatatable();

            List<CT_CD_2D> lista = new List<CT_CD_2D>();

            foreach (DataRow row in dataTable.Rows)
            {
                CT_CD_2D modelo = new CT_CD_2D();
                modelo.id = Convert.ToInt32(row["id"]);
                modelo.aula = row["aula"].ToString();
                modelo.imagen = row["imagen"].ToString();
                modelo.piso = Convert.ToInt32(row["piso"]);
                modelo.cordenadas = row["cordenadas"].ToString();
                modelo.url = row["url"].ToString();



                lista.Add(modelo);
            }

            return lista;
        }
    }


}
