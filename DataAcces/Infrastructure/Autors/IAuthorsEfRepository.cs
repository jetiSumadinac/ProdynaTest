using DataAcces.Interfaces.Generic;
using ProdynaTest.Shared.Models;

namespace DataAcces.Infrastructure.Autors
{
    public interface IAuthorsEfRepository : 
        ISearchableAsync<AuthorModel>,
        IInsertableAsync<int, string>, 
        IRemovableAsync<bool, int>
    {

    }
}
