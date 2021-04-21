using libdotnet.Data.Services;
using libdotnet.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace libdotnet.Controllers
{
    [Route("author/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private AuthorServices _authorServices;

        public AuthorsController(AuthorServices authorServices)
        {
            _authorServices = authorServices;
        }

        [HttpGet("get-authors")]
        public IActionResult GetAuthors()
        {
            var authors = _authorServices.GetAuthors();
            return Ok(authors);
        }
        
        [HttpGet("get-author-by-id/{id:int}")]
        public IActionResult GetAuthorById(int id)
        {
            var author = _authorServices.GetAuthorById(id);
            return Ok(author);
        }

        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            _authorServices.AddAuthor(author);
            return Ok();
        }
    }
}