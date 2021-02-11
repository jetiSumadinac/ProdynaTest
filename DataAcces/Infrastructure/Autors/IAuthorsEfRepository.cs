using DataAcces.Interfaces.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Infrastructure.Autors
{
    public interface IAuthorsEfRepository : 
        IInsertableAsync<int, DataModels.Authors>, 
        IRemovableAsync<int, DataModels.Authors>
    {

    }
}
