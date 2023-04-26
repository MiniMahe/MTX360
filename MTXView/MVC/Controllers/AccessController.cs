using Negocio;
using MVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;
using System.IO;
using Microsoft.AspNetCore.Cors;
using System.Drawing.Text;
using CN;
using System.Drawing;
using System.ComponentModel;
using System.Reflection;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace LogIn.Controllers
{
    public class AccessController : Controller
    {
        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;

            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");



            return View("Login");
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login modelLogin)
        {

            if (ModelState.IsValid)
            {
                CN_User loginUser = new CN_User();
                string login = loginUser.VerificarUser(modelLogin.Email, modelLogin.Password);

                if (login != null)
                {
                    List<Claim> claims = new List<Claim>() {
                    new Claim(ClaimTypes.NameIdentifier, login),
                    new Claim("OtherProperties","Example Role")

                };

                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                        CookieAuthenticationDefaults.AuthenticationScheme);

                    AuthenticationProperties properties = new AuthenticationProperties()
                    {
                        AllowRefresh = true
                    };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity), properties);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewData["ValidateMessage"] = "No válido";
                    return View();
                }

            }

            ViewData["ValidateMessage"] = "No válido";
            return View();
        }
        public List<Imagen> Allimages()
        {
            CN_Image clase = new CN_Image();
            List<Imagen> lista = new List<Imagen>();

            DataTable tabla = new DataTable();
            tabla = clase.Getimage();
            var query = from DataRow linea in tabla.Rows
                        select new Imagen
                        {
                            id = (int)linea[0],
                            Name = (string)linea[2],
                            ruta = (string)linea[1],
                            piso = (int)linea[3]

                        };
            lista = query.ToList();
            return lista;
        }
        public JsonResult ObtenerListaImagenes()
        {

            List<Imagen> listaImagenes = Allimages();


            return Json(JsonSerializer.Serialize(listaImagenes));
        }


        [EnableCors]
        public IActionResult Index()
        {

            return View();
        }

    }
}
