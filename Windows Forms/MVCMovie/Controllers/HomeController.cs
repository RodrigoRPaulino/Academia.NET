using Microsoft.AspNetCore.Mvc;
using MVCMovie.Models;
using System.Diagnostics;

namespace MVCMovie.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Sobre()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Pessoa p)
        {
            //string nome = p.Nome;
            //string cpf = p.Cpf;
            return View("Pessoa",p);
        }
        public IActionResult Pessoa(Pessoa p)
        {
            return View(p);
        }
        public IActionResult Cadastrar()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}