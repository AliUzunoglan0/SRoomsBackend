using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SRooms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class login3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerificationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastLoginTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FailedLoginAttempts = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Login",
                columns: new[] { "Id", "CreateTime", "FailedLoginAttempts", "LastLoginTime", "PasswordHash", "PhoneNumber", "UpdateTime", "UserId", "VerificationCode" },
                values: new object[] { 1, new DateTime(2023, 3, 29, 22, 56, 18, 306, DateTimeKind.Local).AddTicks(9670), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "alitayyip", "5377110446", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4444, "bauz" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 22, 56, 18, 306, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 22, 56, 18, 306, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 3, 29, 22, 56, 18, 306, DateTimeKind.Local).AddTicks(9770));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");

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
    }
}
