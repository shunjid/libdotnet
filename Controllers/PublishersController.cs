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

        [HttpGet("get-publishers")]
        public IActionResult GetPublishers()
        {
            var publishers = _publisherServices.GetPublishers();
            return Ok(publishers);
        }
        
        [HttpGet("get-publisher-by-id/{id:int}")]
        public IActionResult GetPublisherById(int id)
        {
            var publisher = _publisherServices.GetPublisher(id);
            return Ok(publisher);
        }

        [HttpPost("add-publisher")]
        public IActionResult AddPublisher(PublisherVM publisherVm)
        {
            _publisherServices.AddPublisher(publisherVm);
            return Ok();
        }
    }
}