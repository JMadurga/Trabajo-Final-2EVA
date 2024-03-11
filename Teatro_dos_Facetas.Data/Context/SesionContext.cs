using Teatro_dos_facetas.Model;
using Microsoft.EntityFrameworkCore;

namespace Teatro_dos_facetas.Data{
    public class SesionContext: DbContext
    {
        public SesionContext(DbContextOptions<SesionContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar las relaciones en el modelo
            modelBuilder.Entity<SesionObra>()
                .HasKey(so => new { so.sesionId, so.obraId });

            modelBuilder.Entity<SesionObra>()
                .HasOne(so => so.sesion)
                .WithMany(s => s.SesionObra)
                .HasForeignKey(so => so.sesionId);

            modelBuilder.Entity<SesionObra>()
                .HasOne(so => so.obra)
                .WithMany(o => o.SesionObras)
                .HasForeignKey(so => so.obraId);

            modelBuilder.Entity<SesionAsiento>()
                .HasKey(sa => new { sa.sesionId, sa.asientoId });

            modelBuilder.Entity<SesionAsiento>()
                .HasOne(sa => sa.sesion)
                .WithMany(s => s.SesionAsientos)
                .HasForeignKey(sa => sa.sesionId);

            modelBuilder.Entity<SesionAsiento>()
                .HasOne(sa => sa.asiento)
                .WithMany(a => a.SesionAsientos)
                .HasForeignKey(sa => sa.asientoId);



        }



        public DbSet<Sesion> Sesiones { get; set; }
        public DbSet<SesionObra> SesionObras { get; set; }
        public DbSet<SesionAsiento> SesionAsientos { get; set; }

    }

}