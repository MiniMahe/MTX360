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
    } 
}