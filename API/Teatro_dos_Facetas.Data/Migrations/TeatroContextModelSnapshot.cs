﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Teatro_dos_facetas.Data;

#nullable disable

namespace Teatrodosfacetas.Data.Migrations
{
    [DbContext(typeof(TeatroContext))]
    partial class TeatroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Teatro_dos_facetas.Model.Asientos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("AsientosOcupadosid")
                        .HasColumnType("int");

                    b.Property<bool>("isFree")
                        .HasColumnType("bit");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.HasIndex("AsientosOcupadosid");

                    b.ToTable("Asientos");

                    b.HasData(
                        new
                        {
                            id = 1,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 2,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 3,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 4,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 5,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 6,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 7,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 8,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 9,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 10,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 11,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 12,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 13,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 14,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 15,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 16,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 17,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 18,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 19,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 20,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 21,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 22,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 23,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 24,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 25,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 26,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 27,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 28,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 29,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 30,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 31,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 32,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 33,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 34,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 35,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 36,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 37,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 38,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 39,
                            isFree = true,
                            price = 10.5
                        },
                        new
                        {
                            id = 40,
                            isFree = true,
                            price = 10.5
                        });
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.AsientosOcupados", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("sesionid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("sesionid");

                    b.ToTable("AsientosOcupados");
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.Obras", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("synopsis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Obras");

                    b.HasData(
                        new
                        {
                            id = 1,
                            categoria = "Drama",
                            name = "Menina",
                            synopsis = " MENINA es la historia de una, de muchas, de todas. De pequeña sus compañeros de clase ya empezaron a llamarle foca, ballena… Ya sabes, cosas de niños, ¿no?. Al llegar al instituto encontró su sitio: la gorda del grupo. Durante una excursión al museo de El Prado adquirió nuevos superlativos y calificativos. De entre todos, ella se quedó con el de «Menina». Pues claro que sí -se dijo-, soy una PUTA obra de Velázquez. Así que puestos a comer y a engordar, con los años ella se propuso comerse el mundo y engordar su ego encima de un escenario."
                        },
                        new
                        {
                            id = 2,
                            categoria = "Comedia",
                            name = "Otra Obra",
                            synopsis = "Esta es otra obra de teatro que te hará reír a carcajadas. Con personajes divertidos y situaciones cómicas, no podrás parar de reír desde el principio hasta el final."
                        },
                        new
                        {
                            id = 3,
                            categoria = "Drama",
                            name = "Tercera Obra",
                            synopsis = "Esta es la tercera obra de teatro. Con una trama emocionante y personajes cautivadores, te mantendrá al borde de tu asiento."
                        },
                        new
                        {
                            id = 4,
                            categoria = "Comedia",
                            name = "Cuarta Obra",
                            synopsis = "Una obra llena de risas y diversión. Los personajes te harán reír a carcajadas con sus ocurrencias."
                        },
                        new
                        {
                            id = 5,
                            categoria = "Suspense",
                            name = "Quinta Obra",
                            synopsis = "Una obra llena de misterio y suspenso. Te mantendrá intrigado hasta el último momento."
                        },
                        new
                        {
                            id = 6,
                            categoria = "Romance",
                            name = "Sexta Obra",
                            synopsis = "Una historia de amor apasionante que te hará suspirar. Los protagonistas te llevarán en un viaje emocional."
                        },
                        new
                        {
                            id = 7,
                            categoria = "Fantasía",
                            name = "Séptima Obra",
                            synopsis = "Una obra llena de magia y fantasía. Te transportará a un mundo lleno de criaturas mágicas y aventuras."
                        },
                        new
                        {
                            id = 8,
                            categoria = "Acción",
                            name = "Octava Obra",
                            synopsis = "Una obra llena de adrenalina y emociones fuertes. Las escenas de acción te dejarán sin aliento."
                        },
                        new
                        {
                            id = 9,
                            categoria = "Comedia",
                            name = "Novena Obra",
                            synopsis = "Una comedia hilarante que te hará reír sin parar. Los diálogos ingeniosos te sacarán carcajadas."
                        },
                        new
                        {
                            id = 10,
                            categoria = "Drama",
                            name = "Décima Obra",
                            synopsis = "Una obra con una historia conmovedora y personajes profundos. Te tocará el corazón."
                        });
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.Pedidos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int?>("Sesionid")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("sesionId")
                        .HasColumnType("int");

                    b.Property<double>("total")
                        .HasColumnType("float");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Sesionid");

                    b.HasIndex("sesionId");

                    b.HasIndex("userId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.PedidosAsiento", b =>
                {
                    b.Property<int>("pedidoId")
                        .HasColumnType("int");

                    b.Property<int>("asientoId")
                        .HasColumnType("int");

                    b.HasKey("pedidoId", "asientoId");

                    b.HasIndex("asientoId");

                    b.ToTable("PedidoAsientos");
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.Sesion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("obraId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("obraId");

                    b.ToTable("Sesiones");

                    b.HasData(
                        new
                        {
                            id = 1,
                            date = new DateTime(2024, 4, 7, 21, 55, 18, 174, DateTimeKind.Local).AddTicks(6607),
                            obraId = 1
                        },
                        new
                        {
                            id = 2,
                            date = new DateTime(2024, 4, 8, 21, 55, 18, 174, DateTimeKind.Local).AddTicks(6646),
                            obraId = 2
                        },
                        new
                        {
                            id = 3,
                            date = new DateTime(2024, 4, 9, 21, 55, 18, 174, DateTimeKind.Local).AddTicks(6655),
                            obraId = 3
                        },
                        new
                        {
                            id = 4,
                            date = new DateTime(2024, 4, 10, 21, 55, 18, 174, DateTimeKind.Local).AddTicks(6657),
                            obraId = 4
                        },
                        new
                        {
                            id = 5,
                            date = new DateTime(2024, 4, 11, 21, 55, 18, 174, DateTimeKind.Local).AddTicks(6658),
                            obraId = 5
                        },
                        new
                        {
                            id = 6,
                            date = new DateTime(2024, 4, 12, 21, 55, 18, 174, DateTimeKind.Local).AddTicks(6660),
                            obraId = 6
                        });
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.SesionAsiento", b =>
                {
                    b.Property<int>("asientoId")
                        .HasColumnType("int");

                    b.Property<int>("sesionId")
                        .HasColumnType("int");

                    b.HasKey("asientoId", "sesionId");

                    b.HasIndex("sesionId");

                    b.ToTable("SesionAsientos");
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phone")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            id = 1,
                            mail = "teatrodosfacetas@gmail.com",
                            name = "admin",
                            password = "admin",
                            phone = 655455232
                        },
                        new
                        {
                            id = 2,
                            mail = "johndoe@example.com",
                            name = "John Doe",
                            password = "password123",
                            phone = 123456789
                        },
                        new
                        {
                            id = 3,
                            mail = "janesmith@example.com",
                            name = "Jane Smith",
                            password = "password456",
                            phone = 987654321
                        });
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.Asientos", b =>
                {
                    b.HasOne("Teatro_dos_facetas.Model.AsientosOcupados", null)
                        .WithMany("asientosOcupados")
                        .HasForeignKey("AsientosOcupadosid");
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.AsientosOcupados", b =>
                {
                    b.HasOne("Teatro_dos_facetas.Model.Sesion", "sesion")
                        .WithMany()
                        .HasForeignKey("sesionid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sesion");
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.Pedidos", b =>
                {
                    b.HasOne("Teatro_dos_facetas.Model.Sesion", null)
                        .WithMany("pedidos")
                        .HasForeignKey("Sesionid");

                    b.HasOne("Teatro_dos_facetas.Model.Sesion", "sesion")
                        .WithMany()
                        .HasForeignKey("sesionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Teatro_dos_facetas.Model.Users", "user")
                        .WithMany("pedidos")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("sesion");

                    b.Navigation("user");
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.PedidosAsiento", b =>
                {
                    b.HasOne("Teatro_dos_facetas.Model.AsientosOcupados", "asientos")
                        .WithMany("pedidoAsientos")
                        .HasForeignKey("asientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Teatro_dos_facetas.Model.Pedidos", "pedido")
                        .WithMany("pedidoAsientos")
                        .HasForeignKey("pedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("asientos");

                    b.Navigation("pedido");
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.Sesion", b =>
                {
                    b.HasOne("Teatro_dos_facetas.Model.Obras", "obra")
                        .WithMany("sesiones")
                        .HasForeignKey("obraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("obra");
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.SesionAsiento", b =>
                {
                    b.HasOne("Teatro_dos_facetas.Model.Asientos", "asiento")
                        .WithMany("SesionAsientos")
                        .HasForeignKey("asientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Teatro_dos_facetas.Model.Sesion", "sesion")
                        .WithMany("SesionAsientos")
                        .HasForeignKey("sesionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("asiento");

                    b.Navigation("sesion");
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.Asientos", b =>
                {
                    b.Navigation("SesionAsientos");
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.AsientosOcupados", b =>
                {
                    b.Navigation("asientosOcupados");

                    b.Navigation("pedidoAsientos");
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.Obras", b =>
                {
                    b.Navigation("sesiones");
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.Pedidos", b =>
                {
                    b.Navigation("pedidoAsientos");
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.Sesion", b =>
                {
                    b.Navigation("SesionAsientos");

                    b.Navigation("pedidos");
                });

            modelBuilder.Entity("Teatro_dos_facetas.Model.Users", b =>
                {
                    b.Navigation("pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
