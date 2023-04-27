using System;
using System.Collections.Generic;
using System.Data;
using CapaDatos;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Image;

namespace CN
{
    public class CN_Image
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string ruta { get; set; }
        public int piso { get; set; }
        public List<CN_Image> Getimage()
        {
            List<CN_Image> imagenes = new List<CN_Image>();
            CD_Image img = new CD_Image();
            DataTable data = new DataTable();
            data = img.LoadImage();
            var query = from DataRow linea in data.Rows
                        select new CN_Image
                        {
                            id = (int)linea[0],
                            ruta = (string)linea[1],
                            Name = (string)linea[2],
                            piso = (int)linea[3]
                        };
            imagenes = query.ToList();
            return imagenes;
        }
        
    }
}
