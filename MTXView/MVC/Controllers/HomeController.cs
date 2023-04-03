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
        
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public FileContentResult getImage()
        {
            string ruta = "Imagen2-Imagen.bin";
            byte[] biteIMG = System.IO.File.ReadAllBytes(ruta);

            MemoryStream m = new MemoryStream(biteIMG);


            Image image = Image.FromStream(m);

            m = new MemoryStream();

            image.Save(m, ImageFormat.Png);

            m.Position = 0;


            return new FileContentResult(biteIMG, "image/png");
        }

        public async Task<IActionResult> LogOut()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Access");
        }
    }
}