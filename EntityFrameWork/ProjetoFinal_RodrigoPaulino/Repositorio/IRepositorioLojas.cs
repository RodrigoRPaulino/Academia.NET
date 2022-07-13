using ProjetoFinal_RodrigoPaulino.Models;

namespace ProjetoFinal_RodrigoPaulino.Repositorio
{
    public interface IRepositorioLojas
    {
        LojasModel BuscarId(int id);
        List<LojasModel> ExibirTodos();
        LojasModel Cadastrar(LojasModel lojas);
        LojasModel Atualizar(LojasModel lojas);
        
    }
}
