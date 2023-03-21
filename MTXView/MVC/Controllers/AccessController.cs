using Negocio;
using LogIn.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Claims;


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
    
}
}
