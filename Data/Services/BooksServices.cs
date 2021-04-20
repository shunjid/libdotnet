using System;
using System.Collections.Generic;
using System.Linq;
using libdotnet.Data.Models;
using libdotnet.Data.ViewModels;

namespace libdotnet.Data.Services
{
    public class BooksServices
    {
        private AppDbContext _context;

        public BooksServices(AppDbContext context)
        {
            _context = context;
        }

        public void AddBook(BookVM book)
        {
            var _book = new Book
            {
                Title = book.Title,
                Description = book.Description,
                IsRead = book.IsRead,
                DateRead = book.IsRead ? book.DateRead : null,
                Rate = book.IsRead ? book.Rate : null,
                Genre = book.Genre,
                CoverUrl = book.CoverUrl,
                Author = book.Author,
                DateAdded = DateTime.Now
            };

            _context.Books.Add(_book);
            _context.SaveChanges();
        }

        public List<Book> GetAllBooks() => _context.Books.ToList();

        public Book GetBook(int bookId) => _context.Books.FirstOrDefault(b => b.Id == bookId);
    }
}