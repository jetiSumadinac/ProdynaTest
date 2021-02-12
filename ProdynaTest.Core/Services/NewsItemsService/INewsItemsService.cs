using ProdynaTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProdynaTest.Core.Services.NewsItemsService
{
    public interface INewsItemsService
    {
        Task<Guid> SaveNewsItem(NewsItemsModel data);
        Task<bool> DeleteNewsItem(Guid id);
    }
}
