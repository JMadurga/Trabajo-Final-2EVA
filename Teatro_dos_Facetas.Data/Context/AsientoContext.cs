using Teatro_dos_facetas.Model;
using Microsoft.EntityFrameworkCore;

namespace Teatro_dos_facetas.Data{
    public class AsientoContext: DbContext
    {
        public AsientoContext(DbContextOptions<AsientoContext> options)
            : base(options)
        {

        }

      protected override void OnModelCreating(ModelBuilder modelBuilder) {

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
            

        }

        public DbSet<Asientos> Asientos { get; set; }

    }

}