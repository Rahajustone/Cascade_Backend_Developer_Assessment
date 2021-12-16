## Note:
 	I just go throug simple approach. I did not used any extry Pattern in this demo project.
 	I can also create a Repository Pattern on top MVC pattern also can add Unit Of Work on the top of Repository pattern. 
 	I also can work with many Pattern and princple even with multi tier application. I am going to share two link of my project in git to show my past work.

 	ERP project link https://github.com/Rahajustone/TempERP/tree/master/SamrERP
 	Dating Api Demo version link: https://github.com/Rahajustone/DatingAppAPI/tree/main/API

## Usage:
	1. Create a database and migration. Go to appsettings.json file and set your connecton string properly
	 after that create a db and migrate
	
		##### From terminal
		```
		dotnet ef migrations add InitialCreate
		dotnet ef database update
		```
		##### From VS
		```
			Add-Migration InitialCreate
			Update-Database
		```



### Problem
1.	Create a REST API using ASP.NET MVC and write a method to return a sorted list of these by Publisher, Author (last, first), then title.

# This method is to get all book with specific order and this async methods. I tried to write everything simple. I can also create for response Dto class but I did not do that.  
```csharp
// GET: api/Books/GetBooksByPublisherThenAuthorThenTitle
[HttpGet("GetBooksByPublisherThenAuthorThenTitle")]
public async Task<ActionResult<IEnumerable<Book>>> GetBooksByPublisherThenAuthorThenTitle()
{
    return await _context.Books.OrderBy(b => b.Publisher).ThenBy( b =>  String.Concat(b.AuthorFirstName, b.AuthorLastName)).ThenBy( b => b.Title).ToListAsync();
}
```

2.	Write another API method to return a sorted list by Author (last, first) then title.
```csharp
// GET: api/Books/GetBooksByAuthorThenTitle
[HttpGet("GetBooksByAuthorThenTitle")]
public async Task<ActionResult<IEnumerable<Book>>> GetBooksByAuthorThenTitle()
{
    return await _context.Books.OrderBy(b => String.Concat(b.AuthorFirstName, b.AuthorLastName)).ThenBy(b => b.Title).ToListAsync();
}
```

3.	If you had to create one or more tables to store the Book data in a MS SQL database, outline the table design along with fields and their datatypes. 

#### For question 7 and 8. I can aslo create an extra table which has a relationship to this table but I did not because it is small demo. 

```csharp
public class Book
{
    [Key]
    public int Id { get; set; }
    public string Publisher { get; set; }
    public string Title { get; set; }
    public string AuthorLastName { get; set; }
    public string AuthorFirstName { get; set; }
    [Column(TypeName = "decimal(18,4)")]
    public decimal Price { get; set; }
    public string TitleOfSource { get; set; }
    public string TitleOfContainer { get; set; }        
    public DateTime? PublicationDate { get; set; }
    public string Location { get; set; }

    public string VolumeNo { get; set; }
    public string IssueNo { get; set; }
    public string URL { get; set; }
}

```


4.	Write stored procedures in MS SQL Server for steps 1 and 2, and use them in separate API methods to return the same results.
# At first I create an empty migration then write down my procedure inside that migration
```csharp
public partial class spGetBooksByPublisherThenAuthorThenTitle : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        string procedure = @"Create procedure spGetBooksByPublisherThenAuthorThenTitle
                        as
                        Begin
                            Select * from Books order by  Books.Publisher, Books.AuthorFirstName+Books.AuthorLastName, Books.Title;
                        End";
        migrationBuilder.Sql(procedure);

    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        string procedure = @"Drop procedure spGetBooksByPublisherThenAuthorThenTitle";
        migrationBuilder.Sql(procedure);
    }
}
```

# Then I call my procedure directly inside my controller via EntityFramework with raw option sql methods
```csharp
// GET: api/Books/GetBooksByAuthorThenTitleByStoreProcedure
[HttpGet("GetBooksByAuthorThenTitleByStoreProcedure")]
public async Task<ActionResult<IEnumerable<Book>>> GetBooksByAuthorThenTitleByStoreProcedure()
{
    return await _context.Books.FromSqlRaw<Book>("spGetBooksByPublisherThenAuthorThenTitleProcedure").ToListAsync();
}
```

####Note: I did also for the second question same proccess

5.	Write an API method to return the total price of all books in the database.
I just write a simple methon which sum the all price
```csharp
// GET: api/Books/GetTotalPriceOfBooks
[HttpGet("GetTotalPriceOfBooks")]
public async Task<ActionResult<decimal>> GetTotalPriceOfBooks()
{
    return await _context.Books.SumAsync(x => x.Price);
}
```

6.	If you have a large list of these in memory and want to save the entire list to the MS SQL Server database, what is the most efficient way to save the list with only one call to the DB server?
# Batching strategies is the best option to use.
Transactions
It seems strange to begin a review of batching by discussing transactions. But the use of client-side transactions has a subtle server-side batching effect that improves performance. And transactions can be added with only a few lines of code, so they provide a fast way to improve performance of sequential operations.

# For example
By this piece of code we can insert many list of data quickly as possible
```csharp
using (SqlConnection connection = new SqlConnection(CloudConfigurationManager.GetSetting("Sql.ConnectionString")))
{
    conn.Open();
    SqlTransaction transaction = conn.BeginTransaction();

    foreach (string commandString in dbOperations)
    {
        SqlCommand cmd = new SqlCommand(commandString, conn, transaction);
        cmd.ExecuteNonQuery();
    }

    transaction.Commit();
}
```

#### Table-valued parameters
This second option
Table-valued parameters support user-defined table types as parameters in Transact-SQL statements, stored procedures, and functions. This client-side batching technique allows you to send multiple rows of data within the table-valued parameter. We can also use stored procedure to improve you speed of you quaries. 

#### SQL bulk copy
SQL bulk copy is another way to insert large amounts of data into a target database. .NET applications can use the SqlBulkCopy class to perform bulk insert operations. SqlBulkCopy is similar in function to the command-line tool, Bcp.exe, or the Transact-SQL statement, BULK INSERT.

For more information: Visit https://docs.microsoft.com/en-us/azure/azure-sql/performance-improve-use-batching

7.	Add a property to the Book class that outputs the MLA (Modern Language Association) style citation as a string (https://images.app.goo.gl/YkFgbSGiPmie9GgWA). Please add whatever additional properties the Book class needs to generate the citation.
For this task I just add some column to the Book entity at first. (I can also create a new table which has one to one relationship with book)
The code look like:
```csharp
// GET: api/Books/GetMLACitations
[HttpGet("GetMLACitations")]
public async Task<ActionResult<IEnumerable<string>>> GetMLACitations()
{
    return await _context.Books.Select( b => 
            string.Format("{0}, {1}.``{2}`` {3}, {4}, {5}, {6}",
                b.AuthorLastName,
                b.AuthorFirstName,
                b.TitleOfSource,
                b.TitleOfContainer,
                b.Publisher,
                (b.PublicationDate.Value.Year).ToString(),
                b.Location)
            ).ToListAsync();
}
```
Here I use ``` string.Format()``` method to combine my string format. There are many ways to do this. But i choose this one. But I think using methods in quaries make your quaries speed slow.


8.	Add another property to generate a Chicago style citation (Chicago Manual of Style) (https://images.app.goo.gl/w3SRpg2ZFsXewdAj7).
#### Did as same as step 7
```csharp
// GET: api/Books/GetChicagoStyleCitations
[HttpGet("GetChicagoStyleCitations")]
public async Task<ActionResult<IEnumerable<string>>> GetChicagoStyleCitations()
{
    return await _context.Books.Select(b =>
           string.Format("{0}, no. {1} ({2}): {3}. {4}",
               b.Title,
               b.VolumeNo,
               b.IssueNo,
               b.Location,
               b.URL
               )
            ).ToListAsync();
}
```
