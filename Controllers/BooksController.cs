using libdotnet.Data.Services;
using libdotnet.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace libdotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BooksServices _booksServices;

        public BooksController(BooksServices booksServices)
        {
            _booksServices = booksServices;
        }

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _booksServices.AddBook(book);
            return Ok();
        }

        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks()
        {
            var allBooks = _booksServices.GetAllBooks();
            return Ok(allBooks);
        }
        
        [HttpGet("get-book-by-id/{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = _booksServices.GetBook(id);
            return Ok(book);
        }
    }
}