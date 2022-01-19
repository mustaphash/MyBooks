using MyBooks.Data.Models;
using MyBooks.Data.ViewModels;

namespace MyBooks.Data.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }
        public void AddAuthor(AuthorVM book)
        {
            var _author = new Author()
            {
                FullName = book.FullName
            };
            _context.Author.Add(_author);
            _context.SaveChanges();
        }

        public AuthorWithBooksVM GetAuthorWithBooks(int authorId)
        {
            var _author = _context.Author.Where(n => n.Id == authorId).Select(a => new AuthorWithBooksVM()
            {
                FullName = a.FullName,
                BookTitles = a.Book_Authors.Select(n => n.Book.Title).ToList()
            }).FirstOrDefault();

            return _author;
        }
    }
}
