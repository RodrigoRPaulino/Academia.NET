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
            return _bancoContext.lojas.FirstOrDefault(x => x.Id == id);
        }
        public List<LojasModel> ExibirTodos()
        {
            return _bancoContext.lojas.ToList();
        }
        //método para cadastro de novas lojas no banco
        public LojasModel Cadastrar(LojasModel lojas)
        {
            //Gravar no banco de dados
            _bancoContext.lojas.Add(lojas);
            // aqui comitamos a informação 
            _bancoContext.SaveChanges();
            //retorno para loja
            return lojas;
        }
        /// <summary>
        /// precisamos buscar o contato do banco e com as informaçoes novas atualizarmos os dados
        /// </summary>
        /// <param name="lojas"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public LojasModel Atualizar(LojasModel lojas)
        {
            LojasModel lojasDB = BuscarId(lojas.Id);
            if (lojasDB == null) 
            {
                throw new System.Exception("Erro ao atualizar!\n Tente novamente");
            }
            else 
            {
                lojasDB.NomeLoja = lojas.NomeLoja;
                lojasDB.Localizacao = lojas.Localizacao;
                lojasDB.Telefone = lojas.Telefone;
                _bancoContext.lojas.Update(lojasDB);
                _bancoContext.SaveChanges();

                return lojasDB;
            }
  
        }


    }
}
