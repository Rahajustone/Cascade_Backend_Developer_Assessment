using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cascade_Backend_Developer_AssessmentTest.Migrations
{
    public partial class ChicagoStyleCitationSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IssueNo", "PublicationDate", "URL", "VolumeNo" },
                values: new object[] { "February 1935", new DateTime(2021, 12, 14, 23, 34, 26, 775, DateTimeKind.Local).AddTicks(5203), "https://www.wikihow.com/images/9/90/Cite-Sources-in-Chicago-Manual-of-Style-Format-Step-26-Version-2.jpg", "2" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IssueNo", "PublicationDate", "URL", "VolumeNo" },
                values: new object[] { "February 1935", new DateTime(2021, 12, 14, 23, 34, 26, 777, DateTimeKind.Local).AddTicks(9199), "https://www.wikihow.com/images/9/90/Cite-Sources-in-Chicago-Manual-of-Style-Format-Step-26-Version-2.jpg", "2" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IssueNo", "PublicationDate", "URL", "VolumeNo" },
                values: new object[] { "February 1935", new DateTime(2021, 12, 14, 23, 34, 26, 777, DateTimeKind.Local).AddTicks(9227), "https://www.wikihow.com/images/9/90/Cite-Sources-in-Chicago-Manual-of-Style-Format-Step-26-Version-2.jpg", "2" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IssueNo", "PublicationDate", "URL", "VolumeNo" },
                values: new object[] { "February 1935", new DateTime(2021, 12, 14, 23, 34, 26, 777, DateTimeKind.Local).AddTicks(9232), "https://www.wikihow.com/images/9/90/Cite-Sources-in-Chicago-Manual-of-Style-Format-Step-26-Version-2.jpg", "2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IssueNo", "PublicationDate", "URL", "VolumeNo" },
                values: new object[] { null, new DateTime(2021, 12, 14, 23, 22, 29, 477, DateTimeKind.Local).AddTicks(1255), null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IssueNo", "PublicationDate", "URL", "VolumeNo" },
                values: new object[] { null, new DateTime(2021, 12, 14, 23, 22, 29, 482, DateTimeKind.Local).AddTicks(1616), null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IssueNo", "PublicationDate", "URL", "VolumeNo" },
                values: new object[] { null, new DateTime(2021, 12, 14, 23, 22, 29, 482, DateTimeKind.Local).AddTicks(1679), null, null });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IssueNo", "PublicationDate", "URL", "VolumeNo" },
                values: new object[] { null, new DateTime(2021, 12, 14, 23, 22, 29, 482, DateTimeKind.Local).AddTicks(1686), null, null });
        }
    }
}
