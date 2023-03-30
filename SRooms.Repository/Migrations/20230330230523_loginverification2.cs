using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SRooms.Repository.Migrations
{
    /// <inheritdoc />
    public partial class loginverification2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Verification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerificationCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verification", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 3, 31, 2, 5, 23, 143, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 3, 31, 2, 5, 23, 143, DateTimeKind.Local).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 3, 31, 2, 5, 23, 143, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 3, 31, 2, 5, 23, 143, DateTimeKind.Local).AddTicks(4890));

            migrationBuilder.InsertData(
                table: "Verification",
                columns: new[] { "Id", "CreateTime", "ExpirationTime", "PhoneNumber", "UpdateTime", "VerificationCode" },
                values: new object[] { 1, new DateTime(2023, 3, 31, 2, 5, 23, 143, DateTimeKind.Local).AddTicks(8090), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5377110446", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "bauz" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Verification");

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 3, 31, 2, 1, 19, 994, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 3, 31, 2, 1, 19, 994, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 3, 31, 2, 1, 19, 994, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 3, 31, 2, 1, 19, 994, DateTimeKind.Local).AddTicks(7440));
        }
    }
}
