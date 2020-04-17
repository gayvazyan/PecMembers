using Microsoft.EntityFrameworkCore.Migrations;

namespace PecMembers.UI.Migrations
{
    public partial class PermissionModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PermissionModelDb",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageName = table.Column<string>(nullable: true),
                    Admin = table.Column<bool>(nullable: false),
                    Party = table.Column<bool>(nullable: false),
                    Tec = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionModelDb", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PermissionModelDb",
                columns: new[] { "Id", "Admin", "PageName", "Party", "Tec" },
                values: new object[,]
                {
                    { 1, true, "Index", false, false },
                    { 2, true, "PecMembersGen", false, false },
                    { 3, true, "PecMemberReports", false, false },
                    { 4, true, "PecMembersTec", false, false },
                    { 5, true, "PecMembersAdd", false, false },
                    { 6, true, "PecMembersEdit", false, false },
                    { 7, true, "PecMembersParty", false, false },
                    { 8, true, "PecMembersPartyAdd", false, false },
                    { 9, true, "PecMembersPartyEdit", false, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PermissionModelDb");
        }
    }
}
