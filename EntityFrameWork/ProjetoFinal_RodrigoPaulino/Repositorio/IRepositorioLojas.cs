using ProjetoFinal_RodrigoPaulino.Models;

namespace ProjetoFinal_RodrigoPaulino.Repositorio
{
    public interface IRepositorioLojas
    {
        LojasModel BuscarId(int id);
        List<LojasModel> ExibirTodos();
        LojasModel Cadastrar(LojasModel lojas);
        LojasModel Atualizar(LojasModel lojas);
        //Método para apagar de fato um registro do banco de dados
        bool Apagar(int id);
        
    }
}
