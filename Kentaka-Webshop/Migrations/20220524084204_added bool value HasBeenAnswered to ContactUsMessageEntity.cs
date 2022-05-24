using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kentaka_Webshop.Migrations
{
    public partial class addedboolvalueHasBeenAnsweredtoContactUsMessageEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasBeenAnswered",
                table: "ContactMessages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasBeenAnswered",
                table: "ContactMessages");
        }
    }
}
