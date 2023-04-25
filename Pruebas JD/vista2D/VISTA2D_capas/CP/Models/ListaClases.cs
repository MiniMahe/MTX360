using CD;

namespace CP.Models
{
    public class ListaClases
    {
        public List<CT_CD_2D> Salas { get; set; }

        public ListaClases()
        {
            Salas = new List<CT_CD_2D>();
        }

        public void RellenarLista()
        {
            CT_CD_2D cT_CD_2D = new CT_CD_2D();
            Salas = cT_CD_2D.ConvertirDataTableALista();
        }
    }
}
