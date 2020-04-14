using Microsoft.EntityFrameworkCore.Migrations;

namespace PecMembers.UI.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UName",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UName",
                table: "AspNetUsers");
        }
    }
}
