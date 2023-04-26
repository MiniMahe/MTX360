using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class Fotos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Img { get; set; }
    }
}
