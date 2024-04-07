using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Teatrodosfacetas.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asientos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isFree = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asientos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Obras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    synopsis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obras", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sesiones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sesiones", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SesionAsientos",
                columns: table => new
                {
                    asientoId = table.Column<int>(type: "int", nullable: false),
                    sesionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SesionAsientos", x => x.asientoId);
                    table.ForeignKey(
                        name: "FK_SesionAsientos_Asientos_asientoId",
                        column: x => x.asientoId,
                        principalTable: "Asientos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SesionAsientos_Sesiones_asientoId",
                        column: x => x.asientoId,
                        principalTable: "Sesiones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SesionObras",
                columns: table => new
                {
                    obraId = table.Column<int>(type: "int", nullable: false),
                    sesionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SesionObras", x => x.obraId);
                    table.ForeignKey(
                        name: "FK_SesionObras_Obras_obraId",
                        column: x => x.obraId,
                        principalTable: "Obras",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SesionObras_Sesiones_obraId",
                        column: x => x.obraId,
                        principalTable: "Sesiones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Asientos",
                columns: new[] { "id", "isFree" },
                values: new object[,]
                {
                    { 1, true },
                    { 2, true },
                    { 3, true },
                    { 4, true },
                    { 5, true },
                    { 6, true },
                    { 7, true },
                    { 8, true },
                    { 9, true },
                    { 10, true },
                    { 11, true },
                    { 12, true },
                    { 13, true },
                    { 14, true },
                    { 15, true },
                    { 16, true },
                    { 17, true },
                    { 18, true },
                    { 19, true },
                    { 20, true },
                    { 21, true },
                    { 22, true },
                    { 23, true },
                    { 24, true },
                    { 25, true },
                    { 26, true },
                    { 27, true },
                    { 28, true },
                    { 29, true },
                    { 30, true },
                    { 31, true },
                    { 32, true },
                    { 33, true },
                    { 34, true },
                    { 35, true },
                    { 36, true },
                    { 37, true },
                    { 38, true },
                    { 39, true },
                    { 40, true }
                });

            migrationBuilder.InsertData(
                table: "Obras",
                columns: new[] { "id", "categoria", "name", "synopsis" },
                values: new object[,]
                {
                    { 1, "Drama", "Menina", " MENINA es la historia de una, de muchas, de todas. De pequeña sus compañeros de clase ya empezaron a llamarle foca, ballena… Ya sabes, cosas de niños, ¿no?. Al llegar al instituto encontró su sitio: la gorda del grupo. Durante una excursión al museo de El Prado adquirió nuevos superlativos y calificativos. De entre todos, ella se quedó con el de «Menina». Pues claro que sí -se dijo-, soy una PUTA obra de Velázquez. Así que puestos a comer y a engordar, con los años ella se propuso comerse el mundo y engordar su ego encima de un escenario." },
                    { 2, "Comedia", "Otra Obra", "Esta es otra obra de teatro que te hará reír a carcajadas. Con personajes divertidos y situaciones cómicas, no podrás parar de reír desde el principio hasta el final." },
                    { 3, "Drama", "Tercera Obra", "Esta es la tercera obra de teatro. Con una trama emocionante y personajes cautivadores, te mantendrá al borde de tu asiento." },
                    { 4, "Comedia", "Cuarta Obra", "Una obra llena de risas y diversión. Los personajes te harán reír a carcajadas con sus ocurrencias." },
                    { 5, "Suspense", "Quinta Obra", "Una obra llena de misterio y suspenso. Te mantendrá intrigado hasta el último momento." },
                    { 6, "Romance", "Sexta Obra", "Una historia de amor apasionante que te hará suspirar. Los protagonistas te llevarán en un viaje emocional." },
                    { 7, "Fantasía", "Séptima Obra", "Una obra llena de magia y fantasía. Te transportará a un mundo lleno de criaturas mágicas y aventuras." },
                    { 8, "Acción", "Octava Obra", "Una obra llena de adrenalina y emociones fuertes. Las escenas de acción te dejarán sin aliento." },
                    { 9, "Comedia", "Novena Obra", "Una comedia hilarante que te hará reír sin parar. Los diálogos ingeniosos te sacarán carcajadas." },
                    { 10, "Drama", "Décima Obra", "Una obra con una historia conmovedora y personajes profundos. Te tocará el corazón." }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "mail", "name", "password", "phone" },
                values: new object[,]
                {
                    { 1, "teatrodosfacetas@gmail.com", "admin", "admin", 655455232 },
                    { 2, "johndoe@example.com", "John Doe", "password123", 123456789 },
                    { 3, "janesmith@example.com", "Jane Smith", "password456", 987654321 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SesionAsientos");

            migrationBuilder.DropTable(
                name: "SesionObras");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Asientos");

            migrationBuilder.DropTable(
                name: "Obras");

            migrationBuilder.DropTable(
                name: "Sesiones");
        }
    }
}
