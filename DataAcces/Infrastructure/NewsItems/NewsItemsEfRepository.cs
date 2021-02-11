using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Infrastructure.NewsItems
{
    public class NewsItemsEfRepository : BaseRepository<DataModels.NewsItems>, INewsItemsEfRepository
    {
        
        public NewsItemsEfRepository()
        {

        }
        public Task<int> DeleteAsync(Guid data)
        {
            throw new NotImplementedException();
        }

        public Task<int> EditAsync(DataModels.NewsItems data)
        {
            throw new NotImplementedException();
        }

        public Task<DataModels.NewsItems> GetSingleAsync(Expression<Func<DataModels.NewsItems, bool>> query)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(DataModels.NewsItems data)
        {
            throw new NotImplementedException();
        }

        protected override IQueryable<DataModels.NewsItems> GetEntities()
        {
            throw new NotImplementedException();
        }
    }
}
