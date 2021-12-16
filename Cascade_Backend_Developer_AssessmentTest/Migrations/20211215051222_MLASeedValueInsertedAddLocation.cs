using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cascade_Backend_Developer_AssessmentTest.Migrations
{
    public partial class MLASeedValueInsertedAddLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Location", "PublicationDate" },
                values: new object[] { "pp. 120-126", new DateTime(2021, 12, 14, 23, 12, 21, 857, DateTimeKind.Local).AddTicks(4554) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Location", "PublicationDate" },
                values: new object[] { "pp. 120-126", new DateTime(2021, 12, 14, 23, 12, 21, 860, DateTimeKind.Local).AddTicks(5641) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Location", "PublicationDate" },
                values: new object[] { "pp. 120-126", new DateTime(2021, 12, 14, 23, 12, 21, 860, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Location", "PublicationDate" },
                values: new object[] { "pp. 120-126", new DateTime(2021, 12, 14, 23, 12, 21, 860, DateTimeKind.Local).AddTicks(5685) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Location", "PublicationDate" },
                values: new object[] { null, new DateTime(2021, 12, 14, 22, 41, 13, 16, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Location", "PublicationDate" },
                values: new object[] { null, new DateTime(2021, 12, 14, 22, 41, 13, 23, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Location", "PublicationDate" },
                values: new object[] { null, new DateTime(2021, 12, 14, 22, 41, 13, 23, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Location", "PublicationDate" },
                values: new object[] { null, new DateTime(2021, 12, 14, 22, 41, 13, 23, DateTimeKind.Local).AddTicks(1779) });
        }
    }
}
