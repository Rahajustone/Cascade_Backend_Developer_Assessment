using Microsoft.EntityFrameworkCore.Migrations;

namespace Cascade_Backend_Developer_AssessmentTest.Migrations
{
    public partial class ChangeSeedDataForBookPriceTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 125.3m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Price",
                value: 125.5m);
        }
    }
}
