using CAD;
using System.Data;

namespace CN
{

    public class CN_Arrow
    {
        public int id { get; set; }
        public int id_image { get; set; }
        public int nodeid { get; set; }
        public string posicion { get; set; }
        public List<CN_Arrow> GetArrow()
        {
            List<CN_Arrow> flechas = new List<CN_Arrow>();
            CD_Arrow img = new CD_Arrow();
            DataTable data = new DataTable();
            data = img.LoadArrow();
            var query = from DataRow linea in data.Rows
                        select new CN_Arrow
                        {
                            id = (int)linea[0],
                            id_image = (int)linea[1],
                            nodeid = (int)linea[2],
                            posicion = (string)linea[3]
                        };
            flechas = query.ToList();
            return flechas;
        }
        public void Crear(int idimg, int node, string pos)
        {
            CD_Arrow flechas = new CD_Arrow();
            flechas.Crear(idimg, node, pos);
        }
        public void Editar(int id, int idimg, int node, string pos)
        {
            CD_Arrow flechas = new CD_Arrow();
            flechas.Editar(id, idimg, node, pos);
        }
        public void Eliminar(int id)
        {
            CD_Arrow flechas = new CD_Arrow();
            flechas.Eliminar(id);
        }
    }
}
