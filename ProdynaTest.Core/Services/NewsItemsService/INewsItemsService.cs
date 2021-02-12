using ProdynaTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProdynaTest.Core.Services.NewsItemsService
{
    public interface INewsItemsService
    {
        Guid SaveNewsItem(NewsItemsModel data);
        bool DeleteNewsItem(Guid id);
    }
}
