using DataAcces.Interfaces.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Infrastructure.NewsItems
{
    public interface INewsItemsEfRepository :
        IInsertableAsync<int, DataModels.NewsItems>,
        ISearchableAsync<DataModels.NewsItems>,
        IEditableAsync<int, DataModels.NewsItems>,
        IRemovableAsync<int, Guid>
    {
    }
}
