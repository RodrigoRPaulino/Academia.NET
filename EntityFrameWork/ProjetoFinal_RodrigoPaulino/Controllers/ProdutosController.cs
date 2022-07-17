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
            List<ProdutosModel> produtos = _produtosRepositorio.BuscarTodos();
            return View(produtos);
        }
        public IActionResult CadastrarProdutos()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult CadastrarProdutos(ProdutosModel produtos)
        {
            try
            {
                //criando condição : se o valor da modelstate for valida o if ira passar os comandos de cadastro
                if (ModelState.IsValid)
                {
                    _produtosRepositorio.CadastrarProdutos(produtos);
                    // criando menssagem temporária para exibir o exito no cadastro
                    TempData["MenssagemSucesso"] = "Cadastro realizado com sucesso";
                    //retorno redirecionando a index 
                    return RedirectToAction("Index");
                }
                return View(produtos);
            }
            catch (Exception erro)
            {

                TempData["MenssagemErro"] = $"Erro ao efetuar o cadastro, tente novamente mais tarde, {erro.Message}";
                //retorno redirecionando a index 
                return RedirectToAction("Index");
            }          
        }
        public IActionResult EditarProdutos(int id)
        {
            //variável com o método de buscar o id
            ProdutosModel produtos = _produtosRepositorio.BuscarIdProduto(id);
            //retornamos na view o id do banco 
            return View(produtos);
        }

        /// <summary>
        /// depois de fazer o método de edição
        /// crio o método de alterar a loja
        /// </summary>
        /// <param name="lojas"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AlterarProdutos(ProdutosModel produtos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _produtosRepositorio.AtualizarProdutos(produtos);
                    TempData["MenssagemSucesso"] = "Alterações realizadas com sucesso";
                    //retorno redirecionando a index 
                    return RedirectToAction("Index");
                }
                //forçamos o retorno da view 
                return View("EditarProdutos", produtos);
            }
            catch (Exception erro)
            {

                TempData["MenssagemErro"] = $"Erro ao alterar as informações, tente novamente mais tarde, {erro.Message}";
                //retorno redirecionando a index 
                return RedirectToAction("Index");
            }

        }

        /// <summary>
        /// método para confirmação de deleção
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult ApagarConfirmacao(int id)
        {
            ProdutosModel produtos = _produtosRepositorio.BuscarIdProduto(id);
            return View(produtos);
        }


        public IActionResult ApagarProdutos(int id)
        {
            try
            {
                bool apagado = _produtosRepositorio.ApagarProdutos(id);
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





    }
}
