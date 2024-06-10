using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teatrodosfacetas.Data.Migrations
{
    /// <inheritdoc />
    public partial class Pedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SesionAsientos_Asientos_asientoId",
                table: "SesionAsientos");

            migrationBuilder.AddColumn<int>(
                name: "Asientosid",
                table: "SesionAsientos",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 1,
                column: "date",
                value: new DateTime(2024, 6, 9, 21, 52, 6, 558, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2024, 6, 10, 21, 52, 6, 558, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 3,
                column: "date",
                value: new DateTime(2024, 6, 11, 21, 52, 6, 558, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 4,
                column: "date",
                value: new DateTime(2024, 6, 12, 21, 52, 6, 558, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 5,
                column: "date",
                value: new DateTime(2024, 6, 13, 21, 52, 6, 558, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 6,
                column: "date",
                value: new DateTime(2024, 6, 14, 21, 52, 6, 558, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.CreateIndex(
                name: "IX_SesionAsientos_Asientosid",
                table: "SesionAsientos",
                column: "Asientosid");

            migrationBuilder.AddForeignKey(
                name: "FK_SesionAsientos_Asientos_Asientosid",
                table: "SesionAsientos",
                column: "Asientosid",
                principalTable: "Asientos",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SesionAsientos_Asientos_Asientosid",
                table: "SesionAsientos");

            migrationBuilder.DropIndex(
                name: "IX_SesionAsientos_Asientosid",
                table: "SesionAsientos");

            migrationBuilder.DropColumn(
                name: "Asientosid",
                table: "SesionAsientos");

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 1,
                column: "date",
                value: new DateTime(2024, 4, 7, 21, 55, 18, 174, DateTimeKind.Local).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2024, 4, 8, 21, 55, 18, 174, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 3,
                column: "date",
                value: new DateTime(2024, 4, 9, 21, 55, 18, 174, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 4,
                column: "date",
                value: new DateTime(2024, 4, 10, 21, 55, 18, 174, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 5,
                column: "date",
                value: new DateTime(2024, 4, 11, 21, 55, 18, 174, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 6,
                column: "date",
                value: new DateTime(2024, 4, 12, 21, 55, 18, 174, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.AddForeignKey(
                name: "FK_SesionAsientos_Asientos_asientoId",
                table: "SesionAsientos",
                column: "asientoId",
                principalTable: "Asientos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
