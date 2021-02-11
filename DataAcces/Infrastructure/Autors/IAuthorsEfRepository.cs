using DataAcces.Interfaces.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Infrastructure.Autors
{
    public interface IAuthorsEfRepository : 
        ISearchableAsync<DataModels.Authors>,
        IInsertableAsync<int, DataModels.Authors>, 
        IRemovableAsync<int, int>
    {

    }
}
