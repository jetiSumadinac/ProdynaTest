using ProdynaTest.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProdynaTest.Core.Services.AuthorServices
{
    public interface IAuthorService
    {
        Task<List<AuthorModel>> GetAuthorsListAsync();
        Task<int> SaveAuthorAsync(AuthorModel data);
        Task<bool> DeleteAuthorAsync(int id);
    }
}
