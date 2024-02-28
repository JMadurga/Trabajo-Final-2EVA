using Teatro_dos_facetas.Model;
using Microsoft.EntityFrameworkCore;

namespace Teatro_dos_facetas.Data{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {

        }

      protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(o => o.Id);
                entity.Property(o => o.Name).IsRequired();
                entity.Property(o => o.Mail).IsRequired();
                entity.Property(o => o.Password).IsRequired();
                entity.Property(o => o.Phone).IsRequired();
            });


             modelBuilder.Entity<Users>().HasData(
                new Users {Id = 1, Name = "admin", Mail="teatrodosfacetas@gmail.com", Phone = 655455232 }
            );
            

        }

        public DbSet<Users> Users { get; set; }

    }

}