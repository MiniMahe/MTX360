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
        public IActionResult Planta2()
        {
            ListaClases listaClases = new ListaClases();
            listaClases.RellenarLista(1);

            return View("Index", listaClases);
        }
        public IActionResult Planta3()
        {
            ListaClases listaClases = new ListaClases();
            listaClases.RellenarLista(2);

            return View("Index",listaClases);
        }
        

    }
}