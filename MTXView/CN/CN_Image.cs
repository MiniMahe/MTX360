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
        public DataTable Getimage()
        {
            CD_Image img = new CD_Image();
            DataTable data = new DataTable();
            data = img.LoadImage();
            return data;
        }
        
    }
}
