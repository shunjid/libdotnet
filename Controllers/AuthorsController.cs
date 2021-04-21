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

        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {
            _authorServices.AddAuthor(author);
            return Ok();
        }
    }
}