
using Microsoft.AspNetCore.Mvc;
using ProjetoFinal_RodrigoPaulino.Models;
using ProjetoFinal_RodrigoPaulino.Repositorio;

namespace ProjetoFinal_RodrigoPaulino.Controllers
{
    /// <summary>
    /// aqui eu chamo os métodos 
    /// </summary>
    public class ListagemLojas : Controller
    {
        // crio a variavel extraindo o Irepositoriolojas 
        private readonly IRepositorioLojas _repositorioLojas;
        //crio uma classe e importo o repositor de lojas fazendo sua injeção
        public ListagemLojas(IRepositorioLojas repositorioLojas)
        {
            //injeção de dependencia
            _repositorioLojas = repositorioLojas;
        }
        public IActionResult Index()
        {
            List<LojasModel> lojas = _repositorioLojas.ExibirTodos();
            return View(lojas);
        }
      
        public IActionResult Cadastrar()
        {
            return View();
        }
        // aqui eu chamo o método de buscar os elementos  pelo id
        public IActionResult Editar(int id)
        {
          LojasModel lojas = _repositorioLojas.BuscarId(id);
            return View(lojas);
        }
        public IActionResult ApagarConfirmar()
        {
            return View();
        }
        //vou informar que esse método e do tipo HttpPost
        [HttpPost]
        //método para criar lojas
        public IActionResult Cadastrar(LojasModel lojas)
        {

            _repositorioLojas.Cadastrar(lojas);
            //retorno redirecionando a index 
            return RedirectToAction("Index");
        }
        [HttpPost]
        //método para adicionar lojas
        public IActionResult Alterar(LojasModel lojas)
        {

            _repositorioLojas.Atualizar(lojas);
            //retorno redirecionando a index 
            return RedirectToAction("Index");
        }

    }
}
