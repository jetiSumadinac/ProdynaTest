using DataAcces.Infrastructure.NewsItems;
using ProdynaTest.Shared.Models;
using ProdynaTest.Shared.ViewModels;
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

        public async Task<HomeViewModel> GetNewsListAsync(Expression<Func<NewsItemsModel, bool>> query = null)
        {
            var result = new HomeViewModel();
            result.NewsList = (List<NewsItemsModel>)await _newsItemsEfRepository.GetListAsync(query);
            
            return result;
        }

        public async Task<Guid> SaveNewsItem(NewsItemsModel data)
        {
            var result = await _newsItemsEfRepository.InsertAsync(data);
            
            return result;
        }
    }
}
