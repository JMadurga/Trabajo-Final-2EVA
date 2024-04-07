using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Teatrodosfacetas.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AsientosOcupadosid",
                table: "Asientos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "price",
                table: "Asientos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "AsientosOcupados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sesionid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AsientosOcupados", x => x.id);
                    table.ForeignKey(
                        name: "FK_AsientosOcupados_Sesiones_sesionid",
                        column: x => x.sesionid,
                        principalTable: "Sesiones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    total = table.Column<double>(type: "float", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PedidoAsientos",
                columns: table => new
                {
                    pedidoId = table.Column<int>(type: "int", nullable: false),
                    asientoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoAsientos", x => new { x.pedidoId, x.asientoId });
                    table.ForeignKey(
                        name: "FK_PedidoAsientos_AsientosOcupados_asientoId",
                        column: x => x.asientoId,
                        principalTable: "AsientosOcupados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoAsientos_Pedidos_pedidoId",
                        column: x => x.pedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidoSesion",
                columns: table => new
                {
                    pedidoId = table.Column<int>(type: "int", nullable: false),
                    sesionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoSesion", x => new { x.pedidoId, x.sesionID });
                    table.ForeignKey(
                        name: "FK_PedidoSesion_Pedidos_pedidoId",
                        column: x => x.pedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoSesion_Sesiones_sesionID",
                        column: x => x.sesionID,
                        principalTable: "Sesiones",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidoUser",
                columns: table => new
                {
                    pedidoId = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoUser", x => new { x.pedidoId, x.userId });
                    table.ForeignKey(
                        name: "FK_PedidoUser_Pedidos_pedidoId",
                        column: x => x.pedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoUser_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.UpdateData(
                table: "Asientos",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "AsientosOcupadosid", "price" },
                values: new object[] { null, 10.5 });

            migrationBuilder.InsertData(
                table: "Sesiones",
                columns: new[] { "id", "date" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 3, 19, 49, 6, 832, DateTimeKind.Local).AddTicks(5821) },
                    { 2, new DateTime(2024, 4, 4, 19, 49, 6, 832, DateTimeKind.Local).AddTicks(5871) },
                    { 3, new DateTime(2024, 4, 5, 19, 49, 6, 832, DateTimeKind.Local).AddTicks(5875) },
                    { 4, new DateTime(2024, 4, 6, 19, 49, 6, 832, DateTimeKind.Local).AddTicks(5876) },
                    { 5, new DateTime(2024, 4, 7, 19, 49, 6, 832, DateTimeKind.Local).AddTicks(5878) },
                    { 6, new DateTime(2024, 4, 8, 19, 49, 6, 832, DateTimeKind.Local).AddTicks(5879) }
                });

            migrationBuilder.InsertData(
                table: "SesionObras",
                columns: new[] { "obraId", "sesionId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asientos_AsientosOcupadosid",
                table: "Asientos",
                column: "AsientosOcupadosid");

            migrationBuilder.CreateIndex(
                name: "IX_AsientosOcupados_sesionid",
                table: "AsientosOcupados",
                column: "sesionid");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoAsientos_asientoId",
                table: "PedidoAsientos",
                column: "asientoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoSesion_sesionID",
                table: "PedidoSesion",
                column: "sesionID");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoUser_userId",
                table: "PedidoUser",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Asientos_AsientosOcupados_AsientosOcupadosid",
                table: "Asientos",
                column: "AsientosOcupadosid",
                principalTable: "AsientosOcupados",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asientos_AsientosOcupados_AsientosOcupadosid",
                table: "Asientos");

            migrationBuilder.DropTable(
                name: "PedidoAsientos");

            migrationBuilder.DropTable(
                name: "PedidoSesion");

            migrationBuilder.DropTable(
                name: "PedidoUser");

            migrationBuilder.DropTable(
                name: "AsientosOcupados");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Asientos_AsientosOcupadosid",
                table: "Asientos");

            migrationBuilder.DeleteData(
                table: "SesionObras",
                keyColumn: "obraId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SesionObras",
                keyColumn: "obraId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SesionObras",
                keyColumn: "obraId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SesionObras",
                keyColumn: "obraId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SesionObras",
                keyColumn: "obraId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SesionObras",
                keyColumn: "obraId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "AsientosOcupadosid",
                table: "Asientos");

            migrationBuilder.DropColumn(
                name: "price",
                table: "Asientos");
        }
    }
}
