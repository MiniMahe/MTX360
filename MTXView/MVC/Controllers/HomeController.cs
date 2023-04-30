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
        public IActionResult Edit(int id, int piso,string name)
        {
            ListaClases clases = new ListaClases();
            clases.RellenarLista();
            ViewData["piso"] = piso;
            clases.id = id;
            clases.name = name;

            return View("Index",clases);
        }

        public async Task<IActionResult> LogOut()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Access");
        }
    }
}