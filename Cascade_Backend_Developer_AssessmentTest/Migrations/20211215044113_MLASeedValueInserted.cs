using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cascade_Backend_Developer_AssessmentTest.Migrations
{
    public partial class MLASeedValueInserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PublicationDate", "TitleOfContainer", "TitleOfSource" },
                values: new object[] { new DateTime(2021, 12, 14, 22, 41, 13, 16, DateTimeKind.Local).AddTicks(8998), "On Writing, Editing", "Behind the Blue Pencil: Censorship: Cencorship?" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PublicationDate", "TitleOfContainer", "TitleOfSource" },
                values: new object[] { new DateTime(2021, 12, 14, 22, 41, 13, 23, DateTimeKind.Local).AddTicks(1746), "On Writing, Editing, and Publishing", "Behind the Blue Pencil: Censorship: Cencorship?" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PublicationDate", "TitleOfContainer", "TitleOfSource" },
                values: new object[] { new DateTime(2021, 12, 14, 22, 41, 13, 23, DateTimeKind.Local).AddTicks(1775), "On Writing, Editing, and Publishing", "Behind the Blue Pencil: Censorship: Cencorship?" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PublicationDate", "TitleOfContainer", "TitleOfSource" },
                values: new object[] { new DateTime(2021, 12, 14, 22, 41, 13, 23, DateTimeKind.Local).AddTicks(1779), "On Writing, Editing, and Publishing", "Behind the Blue Pencil: Censorship: Cencorship?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PublicationDate", "TitleOfContainer", "TitleOfSource" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PublicationDate", "TitleOfContainer", "TitleOfSource" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PublicationDate", "TitleOfContainer", "TitleOfSource" },
                values: new object[] { null, null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PublicationDate", "TitleOfContainer", "TitleOfSource" },
                values: new object[] { null, null, null });
        }
    }
}
