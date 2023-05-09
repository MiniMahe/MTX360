using CN;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Planta1();
        }
        public IActionResult Planta1()
        {

            ListaClases listaClases = new ListaClases();
            listaClases.RellenarLista();
            ViewData["piso"] = "1";

            return View("Index", listaClases);
        }
        public IActionResult Planta2()
        {
            ListaClases listaClases = new ListaClases();
            listaClases.RellenarLista(1);
            ViewData["piso"] = "2";

            return View("Index", listaClases);
        }
        public IActionResult Planta3()
        {
            ListaClases listaClases = new ListaClases();
            listaClases.RellenarLista(2);
            ViewData["piso"] = "3";


            return View("Index", listaClases);
        }
        public IActionResult Edit(int id, int piso, string name)
        {
            ListaClases clases = new ListaClases();
            clases.RellenarLista(piso - 1);
            ViewData["piso"] = piso;
            clases.id = id;
            clases.name = name;

            return View("Index", clases);
        }
        [HttpPost]
        public IActionResult Edit(ListaClases listaClases)
        {
            ListaClases clases = new ListaClases();
            clases.RellenarLista();
            ViewData["piso"] = 1;
            CN_editar cN_Editar = new CN_editar();
            cN_Editar.Editar(listaClases.id + 1, listaClases.name, listaClases.url);

            return View("Index", clases);
        }
        public async Task<IActionResult> LogOut()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Access");
        }
        public IActionResult Flechas()
        {
            CN_Arrow negocio = new CN_Arrow();
            List<CN_Arrow> lista = new List<CN_Arrow>();
            lista = negocio.GetArrow();
            Arrows flechas = new Arrows();
            foreach (CN_Arrow arrow in lista)
            {
                Arrows flecha = new Arrows();
                flecha.id = arrow.id;
                flecha.id_image = arrow.id_image;
                flecha.nodeid = arrow.nodeid;
                flecha.posicion = arrow.posicion;
                flechas.list.Add(flecha);
            }
            return View(flechas);
        }
        public IActionResult CFlecha()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CFlecha(Arrows flecha)
        {
            CN_Arrow negocio = new CN_Arrow();
            negocio.Crear(flecha.id_image, flecha.nodeid, flecha.posicion);
            return RedirectToAction("Flechas");

        }
        public IActionResult EdFlecha(int id, int idimg, int nodo, string pos)
        {
            Arrows flecha = new Arrows();
            flecha.id = id;
            flecha.id_image = idimg;
            flecha.nodeid = nodo;
            flecha.posicion = pos;
            return View(flecha);
        }
        [HttpPost]
        public IActionResult EdFlecha(Arrows flecha)
        {
            CN_Arrow negocio = new CN_Arrow();
            negocio.Editar(flecha.id, flecha.id_image, flecha.nodeid, flecha.posicion);
            return RedirectToAction("Flechas");
        }
        public IActionResult ElFlecha(int id)
        {
            CN_Arrow negocio = new CN_Arrow();
            negocio.Eliminar(id);
            return RedirectToAction("Flechas");
        }
    }
}