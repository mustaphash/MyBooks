﻿namespace MyBooks.Data.ViewModels
{
    public class BookWithAuthorsVM
    {
        public BookWithAuthorsVM()
        {
            Title = String.Empty;
            Description = String.Empty;
            Genre = String.Empty;
            CoverUrl = String.Empty;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string CoverUrl { get; set; }

        public string PublisherName { get; set; }
        public List<string> AuthorNames { get; set; }
    }
}
