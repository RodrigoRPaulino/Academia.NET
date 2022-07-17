using ProjetoFinal_RodrigoPaulino.Data;
using ProjetoFinal_RodrigoPaulino.Models;

namespace ProjetoFinal_RodrigoPaulino.Repositorio
{
  public interface IProdutosRepositorio 
    {
        ProdutosModel BuscarIdProduto( int id);
        List<ProdutosModel> BuscarTodos();
        ProdutosModel AtualizarProdutos(ProdutosModel produtos);
        ProdutosModel CadastrarProdutos(ProdutosModel produtos);
        ProdutosModel EditarProdutos(int id);
        bool ApagarProdutos(int id);
       
      

       
    }
}
