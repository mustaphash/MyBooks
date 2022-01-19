using MyBooks.Data.Models;
using MyBooks.Data.ViewModels;

namespace MyBooks.Data.Services
{
    public class PublishersService
    {
        private AppDbContext _context;
        public PublishersService(AppDbContext context)
        {
            _context = context;
        }
        public void AddPublisher(PublisherVM publisher)
        {
            var _publisher = new Publisher()
            {
                Name = publisher.Name
            };
            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }

        public PublisherWithBooksAndAuthorsVM GetPublisherData(int publisherId)
        {
            var _publisher = _context.Publishers.Where(p => p.Id == publisherId).Select(p => new PublisherWithBooksAndAuthorsVM()
            {
                Name = p.Name,
                BookAuthors = p.Books.Select(n => new BookAuthorVM()
                {
                    BookName = n.Title,
                    BookAuthor = n.Book_Authors.Select(n => n.Author.FullName).ToList()
                }).ToList(),
            }).FirstOrDefault();

            return _publisher;
        }
    }
}
