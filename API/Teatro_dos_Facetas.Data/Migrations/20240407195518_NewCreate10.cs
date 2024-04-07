using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teatrodosfacetas.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewCreate10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sesionid",
                table: "Pedidos",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Sesionid",
                table: "Pedidos",
                column: "Sesionid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Sesiones_Sesionid",
                table: "Pedidos",
                column: "Sesionid",
                principalTable: "Sesiones",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Sesiones_Sesionid",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_Sesionid",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Sesionid",
                table: "Pedidos");

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 1,
                column: "date",
                value: new DateTime(2024, 4, 7, 21, 47, 59, 613, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 2,
                column: "date",
                value: new DateTime(2024, 4, 8, 21, 47, 59, 613, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 3,
                column: "date",
                value: new DateTime(2024, 4, 9, 21, 47, 59, 613, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 4,
                column: "date",
                value: new DateTime(2024, 4, 10, 21, 47, 59, 613, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 5,
                column: "date",
                value: new DateTime(2024, 4, 11, 21, 47, 59, 613, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Sesiones",
                keyColumn: "id",
                keyValue: 6,
                column: "date",
                value: new DateTime(2024, 4, 12, 21, 47, 59, 613, DateTimeKind.Local).AddTicks(1188));
        }
    }
}
