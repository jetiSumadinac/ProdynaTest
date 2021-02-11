using DataAcces.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Infrastructure.Autors
{
    public class AuthorsEfRepository : BaseRepository<DataModels.Authors>, IAuthorsEfRepository
    {
        private readonly ProdynaTestDbContext _context;
        public AuthorsEfRepository(ProdynaTestDbContext context)
        {
            _context = context;
        }
        public async Task<int> DeleteAsync(int Id)
        {
            //if(_context.) //TODO: examine if any NewsItem exists first

            var data = await _context.Authors.FirstOrDefaultAsync(entity => entity.Id == Id);
            _context.Authors.Remove(data);
            
            return await _context.SaveChangesAsync();
        }

        public async Task<Authors> GetSingleAsync(Expression<Func<Authors, bool>> query)
        {
            return await GetEntities().FirstOrDefaultAsync(query);
        }

        public async Task<int> InsertAsync(string name)
        {
            int result;
            var entity = new Authors();
            entity.Name = name;

            _context.Authors.Add(entity);
            result = await _context.SaveChangesAsync();

            return result;
        }

        protected override IQueryable<Authors> GetEntities()
        {
            return _context.Authors;
        }
        #region private methods

        #endregion
    }
}
