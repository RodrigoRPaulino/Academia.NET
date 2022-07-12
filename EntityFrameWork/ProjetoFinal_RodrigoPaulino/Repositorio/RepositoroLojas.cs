using ProjetoFinal_RodrigoPaulino.Data;
using ProjetoFinal_RodrigoPaulino.Models;

namespace ProjetoFinal_RodrigoPaulino.Repositorio
{
    public class RepositoroLojas : IRepositorioLojas
    {
        private readonly BancoContext _bancoContext;
        public RepositoroLojas(BancoContext bancoContext)
        {
                _bancoContext = bancoContext;
        }
        //método para inserir informacoes na tabela 
        public LojasModel Adicionar(LojasModel loja)
        {
            //Gravar no banco de dados
            _bancoContext.lojas.Add(loja);
            // aqui comitamos a informação 
            _bancoContext.SaveChanges();
            //retorno para loja
            return loja;
        }
    }
}
