namespace MyBooks.Data.Models
{
    public class Publisher
    {
        public Publisher()
        {
            Name = String.Empty;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        //Navigation Properties
        public List<Book> Books { get; set; }
    }
}
