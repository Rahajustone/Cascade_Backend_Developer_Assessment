using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cascade_Backend_Developer_AssessmentTest.Migrations
{
    public partial class ChicagoStyleCitationFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IssueNo",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VolumeNo",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2021, 12, 14, 23, 22, 29, 477, DateTimeKind.Local).AddTicks(1255));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2021, 12, 14, 23, 22, 29, 482, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2021, 12, 14, 23, 22, 29, 482, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2021, 12, 14, 23, 22, 29, 482, DateTimeKind.Local).AddTicks(1686));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IssueNo",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "URL",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "VolumeNo",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublicationDate",
                value: new DateTime(2021, 12, 14, 23, 12, 21, 857, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublicationDate",
                value: new DateTime(2021, 12, 14, 23, 12, 21, 860, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublicationDate",
                value: new DateTime(2021, 12, 14, 23, 12, 21, 860, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublicationDate",
                value: new DateTime(2021, 12, 14, 23, 12, 21, 860, DateTimeKind.Local).AddTicks(5685));
        }
    }
}
