using EFCore_001.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_001.Dados
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //Setar os Modelos
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
