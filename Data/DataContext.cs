using Microsoft.EntityFrameworkCore;
using Marketplace.Models.Entidades;

namespace Marketplace.Data {
    public class DataContext : DbContext {
     
        public DataContext(DbContextOptions<DataContext> options) : base(options){
        }

       public DbSet<Categoria> Categorias { get; set; }

       public DbSet<Empresa> Empresas { get; set; }

       public DbSet<Produto> Produtos { get; set; }
       public DbSet<Usuario> Usuarios { get; set; }
       public DbSet<Cliente> Clientes { get; set; }
       public DbSet<Funcionario> Funcionarios { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
            modelBuilder.Entity<Empresa>().HasIndex(p => p.Cnpj).IsUnique();     
       }
    }
}