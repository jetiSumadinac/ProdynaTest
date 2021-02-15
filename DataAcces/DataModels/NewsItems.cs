using System;

namespace DataAcces.DataModels
{
    public class NewsItems
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Category { get; set; }
        public int AuthorId { get; set; }
        public Authors ItemAuthor { get; set; }
        public long CreatedTimestamp { get; set; }
    }
}
