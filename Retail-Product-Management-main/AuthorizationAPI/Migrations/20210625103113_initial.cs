using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthorizationAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BanTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Counter = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BanTime", "Counter", "Password", "Username" },
                values: new object[] { 1, "Mumbai", new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "AMZH5+Prxpry5IqMILeEusZ83iIZ7+A7VoJzlyX88qDCtIqX8QYW0cHC4tktZWaUYg==", "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "BanTime", "Counter", "Password", "Username" },
                values: new object[] { 2, "Delhi", new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "ABh5u83q6aJLTRqLHEA/QpXWCunzGgSXcnyXumo+n1xqNM4njalKAYe5AlY6M3E0BQ==", "user" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
