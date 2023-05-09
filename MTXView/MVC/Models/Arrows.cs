namespace MVC.Models
{
    public class Arrows
    {
        public int id { get; set; }
        public int id_image { get; set; }
        public int nodeid { get; set; }
        public string posicion { get; set; }
        public List<Arrows> list = new List<Arrows>();
    }
}
