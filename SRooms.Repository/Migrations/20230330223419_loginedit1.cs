using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SRooms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class loginedit1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FailedLoginAttempts",
                table: "Login");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Login",
                newName: "Token");

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 3, 31, 1, 34, 19, 728, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 3, 31, 1, 34, 19, 728, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 3, 31, 1, 34, 19, 728, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 3, 31, 1, 34, 19, 728, DateTimeKind.Local).AddTicks(8470));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Token",
                table: "Login",
                newName: "PasswordHash");

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
                values: new object[] { new DateTime(2023, 3, 31, 1, 29, 47, 561, DateTimeKind.Local).AddTicks(6310), 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 3, 31, 1, 29, 47, 561, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 3, 31, 1, 29, 47, 561, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 3, 31, 1, 29, 47, 561, DateTimeKind.Local).AddTicks(6430));
        }
    }
}
