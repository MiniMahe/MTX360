namespace MVC.Models
{
    public class Imagen
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string ruta { get; set; }
        public int piso { get; set; }
        public List<Arrows> flechas { get; set; }
        public Imagen()
        {
            flechas = new List<Arrows>();
        }
    }
}
