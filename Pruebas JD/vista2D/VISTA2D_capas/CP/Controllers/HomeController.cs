using CP.Models;
using Microsoft.AspNetCore.Mvc;

namespace CP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ListaClases listaClases = new ListaClases();
            listaClases.RellenarLista();

            return View(listaClases);
        }

        public IActionResult Prueba()
        {
            ListaClases listaClases = new ListaClases();
            listaClases.RellenarLista();

            return View(listaClases);
        }

    }
}