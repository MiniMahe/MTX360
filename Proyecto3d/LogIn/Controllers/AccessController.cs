using LogIn.Data;
using Negocio;
using LogIn.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Claims;


namespace LogIn.Controllers
{
public class AccessController : Controller
{
    private readonly BaseDatos _registrar;
    public AccessController(BaseDatos baseDB)
    {
        _registrar = baseDB;
    }
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

    public IActionResult Registro()
    {
        return View();
    }
    [HttpPost]
    public async Task<ActionResult> Registro(Registro registro)
    {
        if (ModelState.IsValid)
        {
            using (MySqlConnection conexionSQL = new(_registrar._usuario))
            {
                using (MySqlCommand cmd = new("Registrar", conexionSQL))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("Nombre", MySqlDbType.VarChar).Value = registro.Nombre;
                    cmd.Parameters.Add("Telefono", MySqlDbType.VarChar).Value = registro.Telefono;
                    cmd.Parameters.Add("DNI", MySqlDbType.VarChar).Value = registro.DNI;
                    cmd.Parameters.Add("Email", MySqlDbType.VarChar).Value = registro.User;
                    cmd.Parameters.Add("contrasena", MySqlDbType.VarChar).Value = registro.Contraseña;
                    conexionSQL.Open();
                    cmd.ExecuteNonQuery();
                    conexionSQL.Close();
                    ViewData["ValidarRegistro"] = "Usuario registrado, puede entrar con sus datos";
                    return RedirectToAction("Login", "Access");
                }

            }
                
        }
        return View();
    }
}
}
