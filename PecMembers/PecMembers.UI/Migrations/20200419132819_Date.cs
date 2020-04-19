using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PecMembers.UI.Migrations
{
    public partial class Date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndInputTime",
                table: "CurrentElectionDb",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartInputTime",
                table: "CurrentElectionDb",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndInputTime",
                table: "CurrentElectionDb");

            migrationBuilder.DropColumn(
                name: "StartInputTime",
                table: "CurrentElectionDb");
        }
    }
}
