using DataAcces.Interfaces.Generic;
using ProdynaTest.Shared.Models;
using System;

namespace DataAcces.Infrastructure.NewsItems
{
    public interface INewsItemsEfRepository :
        IInsertableAsync<Guid, NewsItemsModel>,
        ISearchableAsync<NewsItemsModel>,
        ISearchableListAsync<NewsItemsModel>,
        IEditableAsync<Guid, NewsItemsModel>,
        IRemovableAsync<bool, Guid>
    {
    }
}