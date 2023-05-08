using MVC.Models;
using System;
using Negocio;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using CN;

namespace AuthProject.Controllers
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
            clases.RellenarLista(piso-1);
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
            cN_Editar.Editar(listaClases.id+1,listaClases.name,listaClases.url);

            return View("Index", clases);
        }
        public async Task<IActionResult> LogOut()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Access");
        }
        public IActionResult CFlecha(int idimg, int node, string pos)
        {
            Arrows flecha = new Arrows();
            flecha.id_image = idimg;
            flecha.nodeid = node;
            flecha.posicion = pos;
            return View();
        }
        [HttpPost]
        public IActionResult CFlecha(Arrows flecha)
        {
            CN_Arrow negocio = new CN_Arrow();
            negocio.Crear(flecha.id_image, flecha.nodeid, flecha.posicion);
            return View("CFlecha");
        }
        public IActionResult EdFlecha(int id,int idimg, int node, string pos)
        {
            Arrows flecha = new Arrows();
            flecha.id = id;
            flecha.id_image = idimg;
            flecha.nodeid = node;
            flecha.posicion = pos;
            return View();
        }
        [HttpPost]
        public IActionResult EdFlecha(Arrows flecha)
        {
            CN_Arrow negocio = new CN_Arrow();
            negocio.Editar(flecha.id,flecha.id_image, flecha.nodeid, flecha.posicion);
            return View("EdFlecha");
        }
        public IActionResult ElFlecha(int id)
        {
            Arrows flecha = new Arrows();
            flecha.id = id;
            return View();
        }
        [HttpPost]
        public IActionResult ElFlecha(Arrows flecha)
        {
            CN_Arrow negocio = new CN_Arrow();
            negocio.Eliminar(flecha.id);
            return View("CFlecha");
        }
    }
}