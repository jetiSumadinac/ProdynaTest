using ProdynaTest.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProdynaTest.Core.Services.NewsItemsService
{
    public interface INewsItemsService
    {
        Task<Guid> SaveNewsItem(NewsItemsModel data);
        Task<bool> DeleteNewsItem(Guid id);
        Task<IEnumerable<NewsItemsModel>> GetListAsync(Expression<Func<NewsItemsModel, bool>> query = null);
    }
}
