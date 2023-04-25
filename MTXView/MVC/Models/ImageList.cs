namespace MVC.Models
{
    public class ImageList
    {
        public List<Imagen> Images { get; set; }

        public ImageList() 
        {
            List<Imagen> images = new List<Imagen>();
        }
    }
}
