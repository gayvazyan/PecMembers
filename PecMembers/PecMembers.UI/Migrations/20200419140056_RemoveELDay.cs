using Microsoft.EntityFrameworkCore.Migrations;

namespace PecMembers.UI.Migrations
{
    public partial class RemoveELDay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ElectionId",
                table: "PecMembersCurrentDb");

            migrationBuilder.DropColumn(
                name: "ElectionId",
                table: "CurrentElectionDb");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ElectionId",
                table: "PecMembersCurrentDb",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ElectionId",
                table: "CurrentElectionDb",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
