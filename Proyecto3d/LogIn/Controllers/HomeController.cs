using LogIn.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using LogIn.Data;

namespace AuthProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly BaseDatos _registrar;

        public HomeController(ILogger<HomeController> logger, BaseDatos baseDB)
        {
            _logger = logger;
            _registrar = baseDB;
        }

        public IActionResult Index()
        {
            ViewData["Usuario"] = Request.Cookies["user"];
            return View();
        }

        //public IActionResult Privacy(Datos homemodel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        using (MySqlConnection conexionSQL = new(_registrar._usuario))
        //        {
        //            using (MySqlCommand cmd = new("Login", conexionSQL))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.Parameters.Add("usuario", MySqlDbType.VarChar).Value = homemodel.Email;
        //                cmd.Parameters.Add("contrasena", MySqlDbType.VarChar).Value = homemodel.Password;
        //                conexionSQL.Open();

        //                MySqlDataReader readsql = cmd.ExecuteReader();

        //                if (readsql.Read())
        //                {
        //                    conexionSQL.Clone();
        //                    return View();
        //                }
        //            }
        //        }
        //    }
        //    return View();
        //}

        public async Task<IActionResult> LogOut()
        {

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Access");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}