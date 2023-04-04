using Negocio;
using MVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;
using System.IO;
using Microsoft.AspNetCore.Cors;

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

        [EnableCors] 
        public IActionResult Index()
        {
            string ruta = "Imagen2-Imagen.bin";
            byte[] biteIMG = System.IO.File.ReadAllBytes(ruta);
            string imreBase64Data = Convert.ToBase64String(biteIMG);
            string imgDataURL = string.Format("data:image/png;base64,{0}", imreBase64Data);
            Fotos foto = new Fotos();
            foto.Imagen = imgDataURL;
            ViewBag.Imagen = imgDataURL;
            return View(foto);
        }

    }
}
