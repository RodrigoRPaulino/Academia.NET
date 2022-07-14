
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
        public IActionResult ApagarConfirmar(int id)
        {
            LojasModel lojas = _repositorioLojas.BuscarId(id);
            return View(lojas);
        }
        /// <summary>
        /// método que apaga de fato o registro do banco
        /// </summary>
        /// <returns></returns>
        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado =_repositorioLojas.Apagar(id);
                if (apagado)
                {
                    TempData["MenssagemSucesso"] = "Informações apagadas com sucesso";
                }
                else
                {
                    TempData["MenssagemErro"] = $"Erro ao apagar as informações, tente novamente mais tarde";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {

                TempData["MenssagemErro"] = $"Erro ao apagar as informações, tente novamente mais tarde,{erro.Message}";
                //retorno redirecionando a index 
                return RedirectToAction("Index");
            }
        }

        //vou informar que esse método e do tipo HttpPost
        [HttpPost]
        //método para criar lojas
        public IActionResult Cadastrar(LojasModel lojas)
        {    
            try
            {
                //criando condição : se o valor da modelstate for valida o if ira passar os comandos de cadastro
                if (ModelState.IsValid)
                {
                    _repositorioLojas.Cadastrar(lojas);
                    // criando menssagem temporária para exibir o exito no cadastro
                    TempData["MenssagemSucesso"] = "Cadastro realizado com sucesso";
                    //retorno redirecionando a index 
                    return RedirectToAction("Index");
                }
                return View(lojas);
            }
            catch (System.Exception erro)
            {

                TempData["MenssagemErro"] = $"Erro ao efetuar o cadastro, tente novamente mais tarde, {erro.Message}";
                //retorno redirecionando a index 
                return RedirectToAction("Index");
            }
                

        }
        [HttpPost]
        //método para adicionar lojas
        public IActionResult Alterar(LojasModel lojas)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repositorioLojas.Atualizar(lojas);
                    TempData["MenssagemSucesso"] = "Alterações realizadas com sucesso";
                    //retorno redirecionando a index 
                    return RedirectToAction("Index");
                }
                //forçamos o retorno da view 
                return View("Editar", lojas);
            }
            catch (System.Exception erro)
            {

                TempData["MenssagemErro"] = $"Erro ao alterar as informações, tente novamente mais tarde, {erro.Message}";
                //retorno redirecionando a index 
                return RedirectToAction("Index");
            }
            
        }

    }
}
