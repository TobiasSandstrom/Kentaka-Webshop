using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kentaka_Webshop.Migrations
{
    public partial class AddContactUsMessageEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "Nvarchar(50)", nullable: false),
                    Subject = table.Column<string>(type: "Nvarchar(50)", nullable: false),
                    UserName = table.Column<string>(type: "Nvarchar(50)", nullable: false),
                    UserEmail = table.Column<string>(type: "Nvarchar(100)", nullable: false),
                    UserMessage = table.Column<string>(type: "Nvarchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMessages", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactMessages");
        }
    }
}
