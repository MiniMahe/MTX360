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

        if(ModelState.IsValid)
        {
            CN_User loginUser = new CN_User();
            string login = loginUser.VerificarUser(modelLogin.Email, modelLogin.Password);
                
            if(login != null)
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
            CN_Arrow claseflecha = new CN_Arrow();
            List<CN_Image> todaslasimagenes = new List<CN_Image>();
            List<Imagen> lista = new List<Imagen>();
            todaslasimagenes = clase.Getimage();
            List<CN_Arrow> listaflechas = new List<CN_Arrow>();
            listaflechas = claseflecha.GetArrow();
            foreach (CN_Image Negocio in todaslasimagenes)
            {
                Imagen imagen = new Imagen();
                imagen.id = Negocio.id;
                imagen.Name = Negocio.Name;
                imagen.ruta = Negocio.ruta;
                foreach(CN_Arrow flecha in listaflechas)
                {
                    if(imagen.id== flecha.id_image)
                    {
                        Arrows arrows = new Arrows();
                        arrows.id = flecha.id;
                        arrows.id_image = flecha.id_image;
                        arrows.nodeid = flecha.nodeid;
                        arrows.posicion = flecha.posicion;
                        imagen.flechas.Add(arrows);
                    }
                }
                lista.Add(imagen);
            }
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
            return Planta1();
        }

        public IActionResult Planta1()
        {

            ListaClases listaClases = new ListaClases();
            listaClases.RellenarLista();
            ViewData["piso"] = "1";

            return View("2Dview", listaClases);
        }
        public IActionResult Fotoinicial( int numero ) 
        {
            return View("Sphere", numero);
        }
        public IActionResult Planta2()
        {
            ListaClases listaClases = new ListaClases();
            listaClases.RellenarLista(1);
            ViewData["piso"] = "2";

            return View("2Dview", listaClases);
        }
        public IActionResult Planta3()
        {
            ListaClases listaClases = new ListaClases();
            listaClases.RellenarLista(2);
            ViewData["piso"] = "3";


            return View("2Dview", listaClases);
        }

    }
}
