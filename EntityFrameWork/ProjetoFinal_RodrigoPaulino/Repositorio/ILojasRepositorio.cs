using ProjetoFinal_RodrigoPaulino.Models;

namespace ProjetoFinal_RodrigoPaulino.Repositorio
{
    /// <summary>
    /// depois de criar a string de conexão criamos a pasta repositorio
    /// que sera responsavel por adicionar excluir buscar e atualizar as informacoes da tabela de lojas
    /// </summary>
    public interface ILojasRepositorio
    {
        /// <summary>
        /// depois que inserimos o novo cadastro no banco de dados 
        /// criamos um método para buscar do banco
        /// </summary>
        /// <returns></returns>
        List<LojasModel> BuscarTodos();

        /// <summary>
        /// criamos um método para Cadastrar as lojas no banco
        /// </summary>
        /// <param name="lojas"></param>
        /// <returns></returns>
        LojasModel Cadastrar(LojasModel lojas);
    }
}
