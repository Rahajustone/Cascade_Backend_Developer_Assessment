using Microsoft.EntityFrameworkCore.Migrations;

namespace Cascade_Backend_Developer_AssessmentTest.Migrations
{
    public partial class SeedToDbAddSomeRecords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorFirstName", "AuthorLastName", "Price", "Publisher", "Title" },
                values: new object[] { 4, "Hello", "Sadaf", 125m, "Ahmet", "Being goog boy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
