using Microsoft.EntityFrameworkCore;
using TutorialAspNetKnockoutJS.Models;

namespace TutorialAspNetKnockoutJS.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração para a entidade Todo
            modelBuilder.Entity<Todo>(entity =>
            {
                // Define a chave primária
                entity.HasKey(t => t.Id);

                // Configuração para o campo Title
                entity.Property(t => t.Title)
                    .IsRequired() // Campo obrigatório
                    .HasMaxLength(200); // Limita o tamanho máximo a 200 caracteres

                // Configuração para o campo IsDone (não precisa de validação adicional)
                entity.Property(t => t.IsDone)
                    .HasDefaultValue(false); // Valor padrão como falso
                    
            });
        }
    }
}
