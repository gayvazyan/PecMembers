using Microsoft.EntityFrameworkCore.Migrations;

namespace PecMembers.UI.Migrations
{
    public partial class PermissionModelArm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PageArmenianName",
                table: "PermissionModelDb",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PermissionModelDb",
                keyColumn: "Id",
                keyValue: 1,
                column: "PageArmenianName",
                value: "Սկիզբ");

            migrationBuilder.UpdateData(
                table: "PermissionModelDb",
                keyColumn: "Id",
                keyValue: 2,
                column: "PageArmenianName",
                value: "ՏԸՀ կազմ(գենեռացնել)");

            migrationBuilder.UpdateData(
                table: "PermissionModelDb",
                keyColumn: "Id",
                keyValue: 3,
                column: "PageArmenianName",
                value: "ՏԸՀ կազմ(պահպանել)");

            migrationBuilder.UpdateData(
                table: "PermissionModelDb",
                keyColumn: "Id",
                keyValue: 4,
                column: "PageArmenianName",
                value: "ՏԸՀ ընտր․ Դիտել");

            migrationBuilder.UpdateData(
                table: "PermissionModelDb",
                keyColumn: "Id",
                keyValue: 5,
                column: "PageArmenianName",
                value: "ՏԸՀ ընտր․ Ավելացնել");

            migrationBuilder.UpdateData(
                table: "PermissionModelDb",
                keyColumn: "Id",
                keyValue: 6,
                column: "PageArmenianName",
                value: "ՏԸՀ ընտր․ Խմբագրել");

            migrationBuilder.UpdateData(
                table: "PermissionModelDb",
                keyColumn: "Id",
                keyValue: 7,
                column: "PageArmenianName",
                value: "ՏԸՀ կուսակց․ Դիտել");

            migrationBuilder.UpdateData(
                table: "PermissionModelDb",
                keyColumn: "Id",
                keyValue: 8,
                column: "PageArmenianName",
                value: "ՏԸՀ կուսակց․ Լրացնել");

            migrationBuilder.UpdateData(
                table: "PermissionModelDb",
                keyColumn: "Id",
                keyValue: 9,
                column: "PageArmenianName",
                value: "ՏԸՀ կուսակց․ Խմբագրել");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageArmenianName",
                table: "PermissionModelDb");
        }
    }
}
