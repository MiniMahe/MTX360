using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;

namespace Negocio
{
    public class CN_User
    {
        private CD_User usuario = new CD_User();
        public string VerificarUser(string user, string password)
        {
            string tabla;
            tabla = usuario.Verify(user, password);
            return tabla;
        }
        public Image Convertir_Bytes_Imagen(byte[] bytes)
        {
            if (bytes == null) return null;

            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;
            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            return bm;
        }
    } 
}