using ProdynaTest.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ProdynaTest.Shared.ViewModels;

namespace ProdynaTest.Core.Services.NewsItemsService
{
    public interface INewsItemsService
    {
        Task<Guid> SaveNewsItem(NewsItemsModel data);
        Task<bool> DeleteNewsItem(Guid id);
        Task<HomeViewModel> GetNewsListAsync(Expression<Func<NewsItemsModel, bool>> query = null);
    }
}
