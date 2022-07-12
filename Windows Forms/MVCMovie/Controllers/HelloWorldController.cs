using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome(string nome, int vezes = 1, int id = 1)
        {
            return HtmlEncoder.Default.Encode($"oi {nome}, vezes: {vezes}. ID: {id}");
        }
        public string teste()
        {
            return "Só pra mostrar como funciona a relação rota x método dentro da controller";
        }
    }
}
