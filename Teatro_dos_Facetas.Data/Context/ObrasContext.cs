using Teatro_dos_facetas.Model;
using Microsoft.EntityFrameworkCore;

namespace Teatro_dos_facetas.Data{
    public class ObrasContext: DbContext
    {
        public ObrasContext(DbContextOptions<ObrasContext> options)
            : base(options)
        {

        }

      protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Obras>(entity =>
            {
                entity.HasKey(o => o.Id);
                entity.Property(o => o.Name).IsRequired();
                entity.Property(o => o.Synopsis).IsRequired();

            });


             modelBuilder.Entity<Obras>().HasData(
                new Obras {Id = 1, Name = "Menina", Synopsis=" MENINA es la historia de una, de muchas, de todas. De pequeña sus compañeros de clase ya empezaron a llamarle foca, ballena… Ya sabes, cosas de niños, ¿no?. Al llegar al instituto encontró su sitio: la gorda del grupo. Durante una excursión al museo de El Prado adquirió nuevos superlativos y calificativos. De entre todos, ella se quedó con el de «Menina». Pues claro que sí -se dijo-, soy una PUTA obra de Velázquez. Así que puestos a comer y a engordar, con los años ella se propuso comerse el mundo y engordar su ego encima de un escenario."}
            );
            

        }

        public DbSet<Obras> Obras { get; set; }

    }

}