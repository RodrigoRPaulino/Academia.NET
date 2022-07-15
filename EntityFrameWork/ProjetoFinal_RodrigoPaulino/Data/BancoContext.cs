using Microsoft.EntityFrameworkCore;
using ProjetoFinal_RodrigoPaulino.Models;

namespace ProjetoFinal_RodrigoPaulino.Data
{
    /// <summary>
    /// depois de criar a model de lojas que sera nossa tabela,
    /// crio uma pasta data para criar o banco de dados
    /// precisamos herdar o contexto do banco de dados
    /// fazemos uma configuração padrão e vamos injetar como 
    /// parametro de entrada o DbContextOptions e tipar ele como BancoContext
    /// com o nome de options e passamos a informação do options 
    /// chamando o :base(options).
    /// </summary>
    public class BancoContext:DbContext
    {
        //                Parametro de entrada           retorno para o DbContext
        public BancoContext(DbContextOptions<BancoContext> options) :base(options)
        {
            
        }
        /// <summary>
        /// configurando LojasModel pra dentro do banco
        /// </summary>
        public DbSet<LojasModel> Lojas { get; set; }
    }
}
