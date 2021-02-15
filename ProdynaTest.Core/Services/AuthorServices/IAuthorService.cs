using ProdynaTest.Shared.Models;
using System.Threading.Tasks;

namespace ProdynaTest.Core.Services.AuthorServices
{
    public interface IAuthorService
    {
        Task<int> SaveAuthorAsync(AuthorModel data);
        Task<bool> DeleteAuthor(int id);
    }
}
