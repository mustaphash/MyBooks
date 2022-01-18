using MyBooks.Data.Models;

namespace MyBooks.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "First Book Title",
                        Description = "First Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 5,
                        Genre = "Action",
                        Author = "Mustafa Shakir",
                        CoverUrl = "https//...",
                        DateAdded = DateTime.Now
                    }, new Book()
                    {
                        Title = "Second Book Title",
                        Description = "Second Book Description",
                        IsRead = false,
                        Genre = "Action",
                        Author = "Mustafa Shakir",
                        CoverUrl = "https//...",
                        DateAdded = DateTime.Now
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
