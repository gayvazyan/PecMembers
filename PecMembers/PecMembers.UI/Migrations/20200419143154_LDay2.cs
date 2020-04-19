using Microsoft.EntityFrameworkCore.Migrations;

namespace PecMembers.UI.Migrations
{
    public partial class LDay2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsExtra",
                table: "PecMembersCurrentDb");

            migrationBuilder.DropColumn(
                name: "IsRep",
                table: "PecMembersCurrentDb");

            migrationBuilder.DropColumn(
                name: "IsExtra",
                table: "CurrentElectionDb");

            migrationBuilder.DropColumn(
                name: "IsRep",
                table: "CurrentElectionDb");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsExtra",
                table: "PecMembersCurrentDb",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRep",
                table: "PecMembersCurrentDb",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsExtra",
                table: "CurrentElectionDb",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsRep",
                table: "CurrentElectionDb",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
