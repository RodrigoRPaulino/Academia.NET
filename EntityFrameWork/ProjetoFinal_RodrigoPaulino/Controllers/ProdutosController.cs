using Microsoft.AspNetCore.Mvc;

namespace ProjetoFinal_RodrigoPaulino.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarProdutos()
        {
            return View();
        }


    }
}
