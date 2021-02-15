using DataAcces.DataModels;
using Microsoft.EntityFrameworkCore;
using ProdynaTest.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAcces.Infrastructure.Autors
{
    public class AuthorsEfRepository : BaseRepository<AuthorModel>, IAuthorsEfRepository
    {
        private readonly ProdynaTestDbContext _context;
        public AuthorsEfRepository(ProdynaTestDbContext context)
        {
            _context = context;
        }
        public async Task<bool> DeleteAsync(int Id)
        {
            //if(_context.) //TODO: examine if any NewsItem exists first
            bool result = false;
            var data = await _context.Authors.FirstOrDefaultAsync(entity => entity.Id == Id);
            _context.Authors.Remove(data);

            result = (await _context.SaveChangesAsync()) > 0;

            return result;
            
        }

        public async Task<IEnumerable<AuthorModel>> GetListAsync(Expression<Func<AuthorModel, bool>> query = null)
        {
            if (query != null)
                return await GetEntities().Where(query).ToListAsync();
            return await GetEntities().ToListAsync();
        }

        public async Task<AuthorModel> GetSingleAsync(Expression<Func<AuthorModel, bool>> query)
        {
            var result = new AuthorModel();
            var entity = await GetEntities().FirstOrDefaultAsync(query);
            result.Id = entity.Id;
            result.Name = entity.Name;
            
            return result;
        }

        public async Task<int> InsertAsync(string name)
        {
            var entity = new Authors();
            entity.Name = name;

            _context.Authors.Add(entity);
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        protected override IQueryable<AuthorModel> GetEntities()
        {
            return _context.Authors.AsQueryable().Select(e => new AuthorModel
            {
                Id = e.Id,
                Name = e.Name
            });
        }
        #region private methods

        #endregion
    }
}
