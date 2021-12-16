using Microsoft.EntityFrameworkCore.Migrations;

namespace Cascade_Backend_Developer_AssessmentTest.Migrations
{
    public partial class SeedToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorFirstName", "AuthorLastName", "Price", "Publisher", "Title" },
                values: new object[] { 1, "Wilder", "Torres", 33m, "GEEKULAR", "Testable book" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorFirstName", "AuthorLastName", "Price", "Publisher", "Title" },
                values: new object[] { 2, "Obrien", "Goodman", 125m, "VERBUS", "Being goog boy" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorFirstName", "AuthorLastName", "Price", "Publisher", "Title" },
                values: new object[] { 3, "Obrien", "Goodman", 125m, "VERBUS", "Being goog boy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
