using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductMicroservices.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image_Name", "Name", "Price", "Rating" },
                values: new object[,]
                {
                    { 1, "Some example text.", "Iphone.jpg", "Iphone", 20000.0, 2 },
                    { 2, "Some example text.", "Bracelet.jpg", "Bracelet", 2000.0, 3 },
                    { 3, "Some example text.", "earphone.webp", "Earphone", 1500.0, 4 },
                    { 4, "Some example text.", "1.jfif", "Book", 1000.0, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
