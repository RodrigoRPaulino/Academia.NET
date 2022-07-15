using ProjetoFinal_RodrigoPaulino.Data;
using ProjetoFinal_RodrigoPaulino.Models;

namespace ProjetoFinal_RodrigoPaulino.Repositorio
{
    /// <summary>
    /// depois de criar a string de conexão criamos a pasta repositorio
    /// que sera responsavel por adicionar excluir buscar e atualizar as informacoes da tabela de lojas
    /// implementamos a ILojasRepositorio
    /// </summary>
    public class LojasRepositorio : ILojasRepositorio
    {
        /// <summary>
        /// para gravar precisamos injetar o BancoContext aqui na LojasRepositorio
        /// criamos tambem uma variavel privada para usarmos nessa classe
        /// para a injeção de dependencia
        /// </summary>
        private readonly BancoContext _bancoContext;
        public LojasRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        /// <summary>
        /// esse método carrega toda a lista de lojas do banco de dados
        /// </summary>
        /// <returns></returns>
        public List<LojasModel> BuscarTodos()
        {
            return _bancoContext.Lojas.ToList();
        }

        public LojasModel Cadastrar(LojasModel lojas)
        {
            //gravar no banco de dados
            _bancoContext.Lojas.Add(lojas);
            _bancoContext.SaveChanges();
            return lojas;
        }
    }
}
