using Cascade_Backend_Developer_AssessmentTest.Dtos;
using Cascade_Backend_Developer_AssessmentTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cascade_Backend_Developer_AssessmentTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksContext _context;

        public BooksController(BooksContext context)
        {
            _context = context;
        }

        // GET: api/Books/GetBooksByPublisherThenAuthorThenTitle
        [HttpGet("GetBooksByPublisherThenAuthorThenTitle")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByPublisherThenAuthorThenTitle()
        {
            return await _context.Books.OrderBy(b => b.Publisher).ThenBy( b =>  String.Concat(b.AuthorFirstName, b.AuthorLastName)).ThenBy( b => b.Title).ToListAsync();
        }

        // GET: api/Books/GetBooksByAuthorThenTitle
        [HttpGet("GetBooksByAuthorThenTitle")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByAuthorThenTitle()
        {
            return await _context.Books.OrderBy(b => String.Concat(b.AuthorFirstName, b.AuthorLastName)).ThenBy(b => b.Title).ToListAsync();
        }

        // GET: api/Books/GetBooksByPublisherThenAuthorThenTitleByStoreProcedure
        [HttpGet("GetBooksByPublisherThenAuthorThenTitleByStoreProcedure")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByPublisherThenAuthorThenTitleByStoreProcedure()
        {
            return await _context.Books.FromSqlRaw<Book>("spGetBooksByPublisherThenAuthorThenTitle").ToListAsync();
        }

        // GET: api/Books/GetBooksByAuthorThenTitleByStoreProcedure
        [HttpGet("GetBooksByAuthorThenTitleByStoreProcedure")]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooksByAuthorThenTitleByStoreProcedure()
        {
            return await _context.Books.FromSqlRaw<Book>("spGetBooksByPublisherThenAuthorThenTitleProcedure").ToListAsync();
        }

        // GET: api/Books/GetTotalPriceOfBooks
        [HttpGet("GetTotalPriceOfBooks")]
        public async Task<ActionResult<decimal>> GetTotalPriceOfBooks()
        {
            return await _context.Books.SumAsync(x => x.Price);
        }

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

    }
}
