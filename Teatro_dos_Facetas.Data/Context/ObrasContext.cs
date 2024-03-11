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
                entity.HasKey(o => o.id);
                entity.Property(o => o.name).IsRequired();
                entity.Property(o => o.categoria).IsRequired();
                entity.Property(o => o.synopsis).IsRequired();

            });


             modelBuilder.Entity<Obras>().HasData(
                new Obras {id = 1, name = "Menina", categoria="Drama", synopsis=" MENINA es la historia de una, de muchas, de todas. De pequeña sus compañeros de clase ya empezaron a llamarle foca, ballena… Ya sabes, cosas de niños, ¿no?. Al llegar al instituto encontró su sitio: la gorda del grupo. Durante una excursión al museo de El Prado adquirió nuevos superlativos y calificativos. De entre todos, ella se quedó con el de «Menina». Pues claro que sí -se dijo-, soy una PUTA obra de Velázquez. Así que puestos a comer y a engordar, con los años ella se propuso comerse el mundo y engordar su ego encima de un escenario."},
                new Obras {id = 2, name = "Otra Obra", categoria="Comedia", synopsis="Esta es otra obra de teatro que te hará reír a carcajadas. Con personajes divertidos y situaciones cómicas, no podrás parar de reír desde el principio hasta el final."},
                new Obras {id = 3, name = "Tercera Obra", categoria="Drama", synopsis="Esta es la tercera obra de teatro. Con una trama emocionante y personajes cautivadores, te mantendrá al borde de tu asiento."},
                new Obras {id = 4, name = "Cuarta Obra", categoria="Comedia", synopsis="Una obra llena de risas y diversión. Los personajes te harán reír a carcajadas con sus ocurrencias."},
                new Obras {id = 5, name = "Quinta Obra", categoria="Suspense", synopsis="Una obra llena de misterio y suspenso. Te mantendrá intrigado hasta el último momento."},
                new Obras {id = 6, name = "Sexta Obra", categoria="Romance", synopsis="Una historia de amor apasionante que te hará suspirar. Los protagonistas te llevarán en un viaje emocional."},
                new Obras {id = 7, name = "Séptima Obra", categoria="Fantasía", synopsis="Una obra llena de magia y fantasía. Te transportará a un mundo lleno de criaturas mágicas y aventuras."},
                new Obras {id = 8, name = "Octava Obra", categoria="Acción", synopsis="Una obra llena de adrenalina y emociones fuertes. Las escenas de acción te dejarán sin aliento."},
                new Obras {id = 9, name = "Novena Obra", categoria="Comedia", synopsis="Una comedia hilarante que te hará reír sin parar. Los diálogos ingeniosos te sacarán carcajadas."},
                new Obras {id = 10, name = "Décima Obra", categoria="Drama", synopsis="Una obra con una historia conmovedora y personajes profundos. Te tocará el corazón."}
            );            
        }

        public DbSet<Obras> Obras { get; set; }

    }

}