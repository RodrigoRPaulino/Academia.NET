using Microsoft.EntityFrameworkCore;
using ProjetoFinal_RodrigoPaulino.Models;


namespace ProjetoFinal_RodrigoPaulino.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<LojasModel> lojas { get; set; }
       
           
    }
}
