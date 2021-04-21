using libdotnet.Data.Services;
using libdotnet.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace libdotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private PublisherServices _publisherServices;

        public PublishersController(PublisherServices publisherServices)
        {
            _publisherServices = publisherServices;
        }

        [HttpPost("add-publisher")]
        public IActionResult AddPublisher(PublisherVM publisherVm)
        {
            _publisherServices.AddPublisher(publisherVm);
            return Ok();
        }
    }
}