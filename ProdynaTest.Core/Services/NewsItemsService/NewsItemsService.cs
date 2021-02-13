using DataAcces.Infrastructure.NewsItems;
using ProdynaTest.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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

        public async Task<IEnumerable<NewsItemsModel>> GetListAsync(Expression<Func<NewsItemsModel, bool>> query)
        {
            var result = new List<NewsItemsModel>();

            var entities = await _newsItemsEfRepository.GetListAsync(query);
            foreach (var e in entities) {
                result.Add(e);
            }

            return result;
        }

        public Task<Guid> SaveNewsItem(NewsItemsModel data)
        {
            throw new NotImplementedException();
        }
    }
}
