using GestãoCarros.Models;
using Microsoft.EntityFrameworkCore;

namespace GestãoCarros.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options) {}

        public DbSet<Fabricante> Fabricantes { get; set; }

        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Venda> Vendas { get; set; }
    }
}