using System.Collections.Generic;
using System.Linq;
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

        public List<Publisher> GetPublishers() => _context.Publishers.ToList();

        public Publisher GetPublisher(int id) => _context.Publishers.FirstOrDefault(p => p.Id == id);

        public void AddPublisher(PublisherVM publisherVm)
        {
            var publisher = new Publisher
            {
                Name = publisherVm.Name
            };

            _context.Publishers.Add(publisher);
            _context.SaveChanges();
        }
    }
}