using ProdynaTest.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProdynaTest.Shared.Models
{
    public class NewsItemsModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public CategoryEnum Category { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int CreatedTimestamp { get; set; }
    }
}
