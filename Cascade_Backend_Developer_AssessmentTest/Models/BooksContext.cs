using Microsoft.EntityFrameworkCore;

namespace Cascade_Backend_Developer_AssessmentTest.Models
{
    public class BooksContext : DbContext
    {
        public BooksContext(DbContextOptions<BooksContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Publisher = "GEEKULAR",
                    Title = "Testable book",
                    AuthorLastName = "Torres",
                    AuthorFirstName = "Wilder",
                    Price = 33.5m,
                    TitleOfSource = "Behind the Blue Pencil: Censorship: Cencorship?",
                    TitleOfContainer = "On Writing, Editing",
                    PublicationDate = System.DateTime.Now,
                    Location = "pp. 120-126",
                    VolumeNo = "2",
                    IssueNo = "February 1935",
                    URL = "https://www.wikihow.com/images/9/90/Cite-Sources-in-Chicago-Manual-of-Style-Format-Step-26-Version-2.jpg"
                },
                new Book
                {
                    Id = 2,
                    Publisher = "VERBUS",
                    Title = "Being goog boy",
                    AuthorLastName = "Goodman",
                    AuthorFirstName = "Obrien",
                    Price = 125.5m,
                    TitleOfSource = "Behind the Blue Pencil: Censorship: Cencorship?",
                    TitleOfContainer = "On Writing, Editing, and Publishing",
                    PublicationDate = System.DateTime.Now,
                    Location = "pp. 120-126",
                    VolumeNo = "2",
                    IssueNo = "February 1935",
                    URL = "https://www.wikihow.com/images/9/90/Cite-Sources-in-Chicago-Manual-of-Style-Format-Step-26-Version-2.jpg"
                },
                new Book
                {
                    Id = 3,
                    Publisher = "VERBUS",
                    Title = "Being goog boy",
                    AuthorLastName = "Goodman",
                    AuthorFirstName = "Obrien",
                    Price = 125.5m,
                    TitleOfSource = "Behind the Blue Pencil: Censorship: Cencorship?",
                    TitleOfContainer = "On Writing, Editing, and Publishing",
                    PublicationDate = System.DateTime.Now,
                    Location = "pp. 120-126",
                    VolumeNo = "2",
                    IssueNo = "February 1935",
                    URL = "https://www.wikihow.com/images/9/90/Cite-Sources-in-Chicago-Manual-of-Style-Format-Step-26-Version-2.jpg"
                },
                new Book
                {
                    Id = 4,
                    Publisher = "Ahmet",
                    Title = "Being goog boy",
                    AuthorLastName = "Sadaf",
                    AuthorFirstName = "Hello",
                    Price = 125.3m,
                    TitleOfSource = "Behind the Blue Pencil: Censorship: Cencorship?",
                    TitleOfContainer = "On Writing, Editing, and Publishing",
                    PublicationDate = System.DateTime.Now,
                    Location = "pp. 120-126",
                    VolumeNo = "2",
                    IssueNo = "February 1935",
                    URL = "https://www.wikihow.com/images/9/90/Cite-Sources-in-Chicago-Manual-of-Style-Format-Step-26-Version-2.jpg"

                }
            ); ;
        }
    }
}
