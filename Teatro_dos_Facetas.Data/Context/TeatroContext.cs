using Teatro_dos_facetas.Model;
using Microsoft.EntityFrameworkCore;

namespace Teatro_dos_facetas.Data
{
    public class TeatroContext : DbContext
    {
        public TeatroContext(DbContextOptions<TeatroContext> options)
            : base(options)
        {

        }
        // ...

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    // Configuración de Asientos
    modelBuilder.Entity<Asientos>(entity =>
    {
        entity.HasKey(o => o.id);
        entity.Property(o => o.isFree).IsRequired();
    });

    modelBuilder.Entity<Asientos>().HasData(
                new Asientos    {id = 1, isFree = true},
                new Asientos    {id = 2, isFree = true},
                new Asientos    {id = 3, isFree = true},
                new Asientos    {id = 4, isFree = true},
                new Asientos    {id = 5, isFree = true},
                new Asientos    {id = 6, isFree = true},
                new Asientos    {id = 7, isFree = true},
                new Asientos    {id = 8, isFree = true},
                new Asientos    {id = 9, isFree = true},
                new Asientos    {id = 10, isFree = true},
                new Asientos    {id = 11, isFree = true},
                new Asientos    {id = 12, isFree = true},
                new Asientos    {id = 13, isFree = true},
                new Asientos    {id = 14, isFree = true},
                new Asientos    {id = 15, isFree = true},
                new Asientos    {id = 16, isFree = true},
                new Asientos    {id = 17, isFree = true},
                new Asientos    {id = 18, isFree = true},
                new Asientos    {id = 19, isFree = true},
                new Asientos    {id = 20, isFree = true},
                new Asientos    {id = 21, isFree = true},
                new Asientos    {id = 22, isFree = true},
                new Asientos    {id = 23, isFree = true},
                new Asientos    {id = 24, isFree = true},
                new Asientos    {id = 25, isFree = true},
                new Asientos    {id = 26, isFree = true},
                new Asientos    {id = 27, isFree = true},
                new Asientos    {id = 28, isFree = true},
                new Asientos    {id = 29, isFree = true},
                new Asientos    {id = 30, isFree = true},
                new Asientos    {id = 31, isFree = true},
                new Asientos    {id = 32, isFree = true},
                new Asientos    {id = 33, isFree = true},
                new Asientos    {id = 34, isFree = true},
                new Asientos    {id = 35, isFree = true},
                new Asientos    {id = 36, isFree = true},
                new Asientos    {id = 37, isFree = true},
                new Asientos    {id = 38, isFree = true},
                new Asientos    {id = 39, isFree = true},
                new Asientos    {id = 40, isFree = true}
           
    );

    // Configuración de Obras
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

    // Configuración de Sesiones
    modelBuilder.Entity<Sesion>(entity =>
    {
        entity.HasKey(s => s.id);
        entity.Property(s => s.date).IsRequired();

        // Relación Sesiones - SesionObras
        entity.HasMany(s => s.SesionObra)
              .WithOne(so => so.sesion)
              .HasForeignKey(so => so.sesionId);

        // Relación Sesiones - SesionAsientos
        entity.HasMany(s => s.SesionAsientos)
              .WithOne(sa => sa.sesion)
              .HasForeignKey(sa => sa.sesionId);
    });

    modelBuilder.Entity<SesionObra>(entity =>
    {
        // Relación SesionObras - Obras
        entity.HasOne(so => so.obra)
              .WithMany(o => o.SesionObras)
              .HasForeignKey(so => so.obraId);
    });

    modelBuilder.Entity<SesionAsiento>(entity =>
    {
        // Relación SesionAsientos - Asientos
        entity.HasOne(sa => sa.asiento)
              .WithMany(a => a.SesionAsientos)
              .HasForeignKey(sa => sa.asientoId);
    });

    // Configuración de Usuarios
    modelBuilder.Entity<Users>(entity =>
    {
        entity.HasKey(o => o.id);
        entity.Property(o => o.name).IsRequired();
        entity.Property(o => o.mail).IsRequired();
        entity.Property(o => o.password).IsRequired();
        entity.Property(o => o.phone).IsRequired();
    });

    modelBuilder.Entity<Users>().HasData(
        new Users {id = 0, name = "admin", mail="teatrodosfacetas@gmail.com", password="admin", phone = 655455232 },
        new Users {id = 1, name = "John Doe", mail="johndoe@example.com", password="password123", phone = 123456789 },
        new Users {id = 2, name = "Jane Smith", mail="janesmith@example.com", password="password456", phone = 987654321 }
            
    );
}

// ...



        // Definición de DbSet para cada entidad
        public DbSet<Asientos> Asientos { get; set; }
        public DbSet<Obras> Obras { get; set; }
        public DbSet<Sesion> Sesiones { get; set; }
        public DbSet<SesionObra> SesionObras { get; set; }
        public DbSet<SesionAsiento> SesionAsientos { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
