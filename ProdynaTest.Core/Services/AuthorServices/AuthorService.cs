using DataAcces.Infrastructure.Autors;
using ProdynaTest.Shared.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProdynaTest.Core.Services.AuthorServices
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorsEfRepository _authorEfRepository;
        public AuthorService(IAuthorsEfRepository authorsEfRepository)
        {
            _authorEfRepository = authorsEfRepository;
        }
        public async Task<bool> DeleteAuthorAsync(int id)
        {
            return await _authorEfRepository.DeleteAsync(id);
        }

        public async Task<List<AuthorModel>> GetAuthorsListAsync()
        {
            return (List<AuthorModel>)await _authorEfRepository.GetListAsync(); 
        }

        public async Task<int> SaveAuthorAsync(AuthorModel data)
        {
            var result = await _authorEfRepository.InsertAsync(data.Name);

            return result;
        }
    }
}
