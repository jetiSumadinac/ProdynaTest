using ProdynaTest.Shared.Helpers;
using ProdynaTest.Shared.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProdynaTest.Shared.ViewModels
{
    public class InsertNewsItemViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<CategoryEnum> Categories { get; set; }
        public CategoryEnum SelectedCategory { get; set; }
        public AuthorModel Author { get; set; }
        public List<AuthorModel> Authors { get; set; }
        public int CreatedTimestamp { get; set; }
    }
}
