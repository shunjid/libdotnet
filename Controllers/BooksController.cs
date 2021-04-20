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

        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVM book)
        {
            _booksServices.AddBook(book);
            return Ok();
        }

        [HttpPut("update-book-by-id/{id}")]
        public IActionResult UpdateBookById(int id, [FromBody] BookVM book)
        {
            var updatedBook = _booksServices.UpdateBookById(id, book);
            return Ok(updatedBook);
        }

        [HttpDelete("delete-book-by-id/{id}")]
        public IActionResult DeleteBookById(int id)
        {
            _booksServices.DeleteBookById(id);
            return Ok();
        }
    }
}