using ProjetoFinal_RodrigoPaulino.Data;
using ProjetoFinal_RodrigoPaulino.Models;

namespace ProjetoFinal_RodrigoPaulino.Repositorio
{
    public class ProdutosRepositorio : IProdutosRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ProdutosRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<ProdutosModel> BuscarTodos()
        {
            return _bancoContext.Produtos.ToList();
        }

        public ProdutosModel BuscarIdProduto(int idproduto)
        {
            //retornamos uma busca pelo primeiro
            //ou unico registro do banco passando uma
            //expressao lambda
            return _bancoContext.Produtos.FirstOrDefault(p => p.IdProduto == idproduto);

        }
        public ProdutosModel CadastrarProdutos(ProdutosModel produtos)
        {
            _bancoContext.Produtos.Add(produtos);
            _bancoContext.SaveChanges();
            return produtos;

        }
        public ProdutosModel AtualizarProdutos(ProdutosModel produtos)
        {
            //criamos uma varável lojasDb buscando o id da loja
            ProdutosModel produtosDB = BuscarIdProduto(produtos.IdProduto);
            //criamos uma condição se a lojaDb for nula mostramos uma menssagem de erro 
            if (produtosDB == null) throw new Exception("Erro ao atualizar!\n Tente novamente");

            //se ele nao for nulo pegamos o dados do banco recebendo 
            //os dados quem vem da model
            produtosDB.IdProduto = produtos.IdProduto;
            produtosDB.NomeProduto = produtos.NomeProduto;
            produtosDB.Tamanho = produtos.Tamanho;
            produtosDB.Cor = produtos.Cor;
            produtosDB.Valor = produtos.Valor;
            //update no banco de dados
            _bancoContext.Produtos.Update(produtosDB);
            //salva as alteraçoes
            _bancoContext.SaveChanges();
            //retorna ao banco
            return produtosDB;            
        }

        public bool ApagarProdutos(int idproduto)
        {
            //buscamos o id a ser deletado
            ProdutosModel produtosDB = BuscarIdProduto(idproduto);
            //condição onde se a loja for nula mostra a mensagem de erro
            if (produtosDB == null) throw new Exception("Não foi possivel excluir a loja selecionada.\n Tente novamente");
            // remoção do banco
            _bancoContext.Produtos.Remove(produtosDB);
            // grava as alterações
            _bancoContext.SaveChanges();
            return true;
        }

        public ProdutosModel EditarProdutos(int idproduto)
        {
            throw new NotImplementedException();
        }
    }
}
