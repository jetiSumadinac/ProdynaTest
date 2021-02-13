using DataAcces.Interfaces.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Infrastructure.NewsItems
{
    public interface INewsItemsEfRepository :
        IInsertableAsync<Guid, DataModels.NewsItems>,
        ISearchableAsync<DataModels.NewsItems>,
        ISearchableListAsync<DataModels.NewsItems>,
        IEditableAsync<Guid, DataModels.NewsItems>,
        IRemovableAsync<bool, Guid>
    {
    }
}
