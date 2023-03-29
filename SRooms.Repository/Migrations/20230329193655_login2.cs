using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SRooms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class login2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 22, 36, 55, 248, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 22, 36, 55, 248, DateTimeKind.Local).AddTicks(3940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 22, 36, 55, 248, DateTimeKind.Local).AddTicks(3940));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 22, 28, 25, 285, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 22, 28, 25, 285, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 22, 28, 25, 285, DateTimeKind.Local).AddTicks(1500));
        }
    }
}
