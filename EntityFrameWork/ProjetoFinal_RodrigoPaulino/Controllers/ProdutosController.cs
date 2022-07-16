using Microsoft.AspNetCore.Mvc;
using ProjetoFinal_RodrigoPaulino.Models;
using ProjetoFinal_RodrigoPaulino.Repositorio;

namespace ProjetoFinal_RodrigoPaulino.Controllers
{  
    public class ProdutosController : Controller
    {

        private readonly IProdutosRepositorio _produtosRepositorio;
        public ProdutosController(IProdutosRepositorio produtosRepositorio)
        {
            _produtosRepositorio = produtosRepositorio;
        }
       

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CadastrarProdutos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarProdutos(ProdutosModel produtos)
        {
            _produtosRepositorio.CadastrarProdutos(produtos);
            return RedirectToAction("Index");
        }
       

    }
}
