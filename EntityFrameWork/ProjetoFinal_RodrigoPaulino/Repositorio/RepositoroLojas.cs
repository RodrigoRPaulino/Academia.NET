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
        // método para buscar o id
        public LojasModel BuscarId(int id)
        {
            //retorna procurando o primeiro registro ou o unico registro 
            return _bancoContext.lojas.FirstOrDefault();
        }
        public List<LojasModel> ExibirTodos()
        {
            return _bancoContext.lojas.ToList();
        }
        //método para inserir informacoes na tabela 
        public LojasModel Cadastrar(LojasModel lojas)
        {
            //Gravar no banco de dados
            _bancoContext.lojas.Add(lojas);
            // aqui comitamos a informação 
            _bancoContext.SaveChanges();
            //retorno para loja
            return lojas;
        }

       
    }
}
