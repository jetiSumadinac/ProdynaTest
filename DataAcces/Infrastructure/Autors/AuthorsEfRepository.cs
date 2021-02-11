using DataAcces.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Infrastructure.Autors
{
    public class AuthorsEfRepository : BaseRepository<DataModels.Authors>, IAuthorsEfRepository
    {
        public Task<int> DeleteAsync(Authors data)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(Authors data)
        {
            throw new NotImplementedException();
        }

        protected override IQueryable<Authors> GetEntities()
        {
            throw new NotImplementedException();
        }
    }
}
