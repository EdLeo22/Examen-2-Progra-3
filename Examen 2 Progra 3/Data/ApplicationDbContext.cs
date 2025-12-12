namespace Examen_2_Progra_3.Data
{
    using Examen_2_Progra_3.Models;
    using Microsoft.EntityFrameworkCore;
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options) { }

        public DbSet<Meta> Metas { get; set; }
        public DbSet<Tarea> Tareas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ejemplo: eliminar en cascada (si borras una Meta, borra sus Tareas)
            modelBuilder.Entity<Meta>()
                .HasMany(m => m.Tareas)
                .WithOne(t => t.Meta)
                .HasForeignKey(t => t.MetaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
