using Microsoft.EntityFrameworkCore.Migrations;

namespace Cascade_Backend_Developer_AssessmentTest.Migrations
{
    public partial class spGetBooksByAuthorThenTitleProcedure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Create procedure spGetBooksByPublisherThenAuthorThenTitleProcedure
                            as
                            Begin
	                            Select * from Books order by Books.AuthorFirstName+Books.AuthorLastName, Books.Title;
                            End";
            migrationBuilder.Sql(procedure);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"Drop procedure spGetBooksByPublisherThenAuthorThenTitleProcedure";
            migrationBuilder.Sql(procedure);
        }
    }
}
