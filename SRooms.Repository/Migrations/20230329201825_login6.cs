using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SRooms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class login6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FailedLoginAttempts",
                table: "Login",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "FailedLoginAttempts" },
                values: new object[] { new DateTime(2023, 3, 29, 23, 18, 25, 525, DateTimeKind.Local).AddTicks(7700), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 23, 18, 25, 525, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 23, 18, 25, 525, DateTimeKind.Local).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 23, 18, 25, 525, DateTimeKind.Local).AddTicks(7810));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FailedLoginAttempts",
                table: "Login");

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 23, 16, 2, 633, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 23, 16, 2, 633, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 23, 16, 2, 633, DateTimeKind.Local).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 23, 16, 2, 633, DateTimeKind.Local).AddTicks(9370));
        }
    }
}
