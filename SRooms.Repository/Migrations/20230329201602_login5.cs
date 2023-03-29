using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SRooms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class login5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FailedLoginAttempts",
                table: "Login");

            migrationBuilder.DropColumn(
                name: "LastLoginTime",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FailedLoginAttempts",
                table: "Login",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLoginTime",
                table: "Login",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateTime", "FailedLoginAttempts", "LastLoginTime" },
                values: new object[] { new DateTime(2023, 3, 29, 22, 58, 16, 578, DateTimeKind.Local).AddTicks(7790), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 22, 58, 16, 578, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 22, 58, 16, 578, DateTimeKind.Local).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 22, 58, 16, 578, DateTimeKind.Local).AddTicks(7930));
        }
    }
}
