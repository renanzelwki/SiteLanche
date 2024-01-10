using Microsoft.EntityFrameworkCore;
using SiteLanche.Models;

namespace SiteLanche.Contexto
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
    }
}
