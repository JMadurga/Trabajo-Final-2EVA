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

        public DbSet<Users> Users { get; set; }

    }

}