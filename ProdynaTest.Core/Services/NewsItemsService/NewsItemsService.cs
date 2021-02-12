using DataAcces.Infrastructure.NewsItems;
using ProdynaTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProdynaTest.Core.Services.NewsItemsService
{
    public class NewsItemsService : INewsItemsService
    {
        private readonly INewsItemsEfRepository _newsItemsEfRepository;
        public NewsItemsService(INewsItemsEfRepository newsItemsEfRepository)
        {
            _newsItemsEfRepository = newsItemsEfRepository;
        }
        public async Task<bool> DeleteNewsItem(Guid id)
        {
            return await _newsItemsEfRepository.DeleteAsync(id);
        }

        public Task<Guid> SaveNewsItem(NewsItemsModel data)
        {
            throw new NotImplementedException();
        }
    }
}
