using ProdynaTest.Core.Helpers;
using System;

namespace ProdynaTest.Core.Models
{
    public class NewsItemsModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CategoryEnum Category { get; set; }
        public int AuthorId { get; set; }
        public int CreatedTimestamp { get; set; }
    }
}
