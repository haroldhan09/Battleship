using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Battleship.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", nullable: false),
                    IsVerified = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsAdmin = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "IsAdmin", "IsVerified", "Name", "PasswordHash" },
                values: new object[] { new Guid("47fab74f-f962-4ede-820b-2c978502e0fa"), "battleship-admin@bluehourgames.com", true, true, "Admin", new byte[] { 24, 26, 70, 51, 35, 233, 135, 70, 154, 150, 196, 215, 144, 48, 234, 198, 115, 142, 53, 201, 49, 91, 162, 239, 95, 75, 56, 129, 29, 12, 100, 60, 74, 106, 242, 143, 121, 58, 40, 85, 251, 175, 99, 82, 131, 25, 210, 57, 148, 191, 167, 147, 149, 103, 44, 210, 144, 15, 161, 86, 111, 30, 14, 159 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
