using DataAcces.Interfaces.Generic;
using ProdynaTest.Shared.Models;
using System;

namespace DataAcces.Infrastructure.NewsItems
{
    public interface INewsItemsEfRepository :
        IInsertableAsync<Guid, DataModels.NewsItems>,
        ISearchableAsync<NewsItemsModel>,
        ISearchableListAsync<NewsItemsModel>,
        IEditableAsync<Guid, DataModels.NewsItems>,
        IRemovableAsync<bool, Guid>
    {
    }
}
