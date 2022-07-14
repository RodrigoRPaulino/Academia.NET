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
        public DbSet<ProdutosModel> Produtos { get; set; }
        // esse método vai fazer o relacionamento entre as tabelas
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<ProdutosModel>()
                .HasOne(p => p.Loja)
                .WithMany(l => l.Produtos)
                .HasForeignKey(p => p.IdLoja)
                .OnDelete(DeleteBehavior.Cascade);
        }


    }
}
