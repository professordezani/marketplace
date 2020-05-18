using Microsoft.EntityFrameworkCore;
using Marketplace.Models;

namespace Marketplace.Data {
    public class DataContext : DbContext {
     
        public DataContext(DbContextOptions<DataContext> options) : base(options){
        }

       public DbSet<Categoria> Categorias { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
          modelBuilder.Entity<Categoria>().Property(p => p.Descricao).HasMaxLength(50).IsRequired();
       }
    }
}