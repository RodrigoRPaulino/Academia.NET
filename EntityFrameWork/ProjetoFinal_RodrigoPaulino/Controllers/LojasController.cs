using Microsoft.AspNetCore.Mvc;
using ProjetoFinal_RodrigoPaulino.Models;
using ProjetoFinal_RodrigoPaulino.Repositorio;

namespace ProjetoFinal_RodrigoPaulino.Controllers
{/// <summary>
/// Meu terceiro passo foi criar uma controller vazia 
/// </summary>
    public class LojasController : Controller
    {
        private readonly ILojasRepositorio _lojasRepositorio;
        public LojasController(ILojasRepositorio lojasRepositorio)
        {
            _lojasRepositorio = lojasRepositorio;
        }
        //clico com o botao direito em View e adiciono uma nova view vazia
        public IActionResult Index()
        {
           List<LojasModel> lojas = _lojasRepositorio.BuscarTodos();
            return View(lojas);
        }
        /// <summary>
        /// Quinto passo será criar as actions das paginas de cadastro, ediçao  e deleção 
        /// e a criação das views de cada action
        /// </summary>
        /// <returns></returns>
        public IActionResult Cadastrar()
        {
            return View();
        }

        /// <summary>
        /// assinamos o método de cadastrar como httppost
        /// é ele que recebe e cadastra a informação
        /// </summary>
        /// <param name="lojas"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Cadastrar(LojasModel lojas)
        {
            _lojasRepositorio.Cadastrar(lojas);
            return RedirectToAction("Index");
        }
        //depois de terminar o método de cadastrar vamos a program para configurar
        //a injeção de dependencia da ILojasRepositório   

        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult ApagarConfirmacao()
        {
            return View();
        }


    }
}
