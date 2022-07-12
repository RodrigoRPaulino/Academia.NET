using Microsoft.EntityFrameworkCore;
using ProjetoFinal_RodrigoPaulino.Models;


namespace ProjetoFinal_RodrigoPaulino.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        // LojasModel representa o banco de dados lojas sera o nome da minha tabela
        public DbSet<LojasModel> lojas{ get; set; }
       
           
    }
}
