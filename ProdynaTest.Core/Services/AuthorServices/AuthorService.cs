﻿using DataAcces.Infrastructure.Autors;
using ProdynaTest.Shared.Models;
using System;
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
        public async Task<bool> DeleteAuthor(int id)
        {
            return await _authorEfRepository.DeleteAsync(id);
        }

        public async Task<int> SaveAuthor(AuthorModel data)
        {
            throw new NotImplementedException();
        }
    }
}