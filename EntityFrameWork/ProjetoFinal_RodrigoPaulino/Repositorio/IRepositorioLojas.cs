using ProjetoFinal_RodrigoPaulino.Models;

namespace ProjetoFinal_RodrigoPaulino.Repositorio
{
    public interface IRepositorioLojas
    {
        List<LojasModel> ExibirTodos();
        LojasModel Cadastrar(LojasModel lojas);
    }
}
