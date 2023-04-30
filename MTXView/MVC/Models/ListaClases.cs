using Negocio;

namespace MVC.Models
{
    public class ListaClases
    {
        public List<CT_CD_2D> Salas { get; set; }

        public ListaClases()
        {
            Salas = new List<CT_CD_2D>();
        }

        public void RellenarLista(int idpiso = 0)
        {
            CT_CD_2D cT_CD_2D = new CT_CD_2D();
            Salas = cT_CD_2D.ConvertirDataTableALista(idpiso);
        }
        public int id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }
}
