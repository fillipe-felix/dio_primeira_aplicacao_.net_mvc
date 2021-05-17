using Microsoft.EntityFrameworkCore;

namespace primeira_aplicacao_.net_mvc.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=CursoMvc;Trusted_Connection=True;");
        }
    }
}