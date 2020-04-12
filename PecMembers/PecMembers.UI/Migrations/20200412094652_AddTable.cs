using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PecMembers.UI.Migrations
{
    public partial class AddTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PecMembersCurrentDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictId = table.Column<int>(nullable: true),
                    SubDistrictCode = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SubDistrict = table.Column<string>(nullable: true),
                    WorkPositionId = table.Column<int>(nullable: false),
                    WorkPosition = table.Column<string>(nullable: true),
                    ElectionDay = table.Column<DateTime>(nullable: false),
                    CreatedDay = table.Column<DateTime>(nullable: false),
                    PartyName = table.Column<string>(nullable: true),
                    IsEmpty = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    Passport = table.Column<string>(nullable: true),
                    Certeficate = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    SSN = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PecMembersCurrentDb", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PecMembersCurrentDb");
        }
    }
}
