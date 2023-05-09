using Image;

namespace CN
{
    public class CN_editar
    {
        public void Editar(int id, string nonmbre, string ruta)
        {
            CD_Image negocio = new CD_Image();
            negocio.Editar(id, nonmbre, ruta);
        }

    }
}
