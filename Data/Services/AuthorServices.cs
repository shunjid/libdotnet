using System.Collections.Generic;
using System.Linq;
using libdotnet.Data.Models;
using libdotnet.Data.ViewModels;

namespace libdotnet.Data.Services
{
    public class AuthorServices
    {
        private AppDbContext _context;

        public AuthorServices(AppDbContext context)
        {
            _context = context;
        }

        public List<Author> GetAuthors() => _context.Authors.ToList();

        public Author GetAuthorById(int id) => _context.Authors.FirstOrDefault(a => a.Id == id);

        public void AddAuthor(AuthorVM author)
        {
            var _author = new Author
            {
                Name = author.FullName
            };

            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
    }
}