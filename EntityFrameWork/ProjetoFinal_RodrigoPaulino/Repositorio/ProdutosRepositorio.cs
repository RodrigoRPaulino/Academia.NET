using ProjetoFinal_RodrigoPaulino.Models;

namespace ProjetoFinal_RodrigoPaulino.Repositorio
{
    /// <summary>
    /// eu chamo os métodos
    /// </summary>
    public class ProdutosRepositorio
    {
        public ProdutosModel CadastrarProdutos(ProdutosModel produtos)
        {
            //gravar no banco de dados
            _bancoContext.Produtos.Add(produtos);
            _bancoContext.SaveChanges();
            return produtos;
        }

    }
}
