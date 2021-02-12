using ProdynaTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProdynaTest.Core.Services.AuthorServices
{
    public interface IAuthorService
    {
        Task<int> SaveAuthor(AuthorModel data);
        Task<bool> DeleteAuthor(int id);
    }
}
