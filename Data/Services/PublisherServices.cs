using libdotnet.Data.Models;
using libdotnet.Data.ViewModels;

namespace libdotnet.Data.Services
{
    public class PublisherServices
    {
        private AppDbContext _context;

        public PublisherServices(AppDbContext context)
        {
            _context = context;
        }

        public void AddPublisher(PublisherVM publisherVm)
        {
            var publisher = new Publisher
            {
                Name = publisherVm.Name
            };

            _context.Add(publisher);
            _context.SaveChanges();
        }
    }
}