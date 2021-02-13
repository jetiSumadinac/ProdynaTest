﻿using DataAcces.DataModels;
using DataAcces.Infrastructure.Autors;
using DataAcces.Interfaces.Generic;
using Microsoft.EntityFrameworkCore;
using ProdynaTest.Shared.Helpers;
using ProdynaTest.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces.Infrastructure.NewsItems
{
    public class NewsItemsEfRepository : BaseRepository<NewsItemsModel>, INewsItemsEfRepository
    {
        private readonly ProdynaTestDbContext _context;
        private readonly IAuthorsEfRepository _authorsEfRepository;
        public NewsItemsEfRepository(ProdynaTestDbContext prodynaTestDbContext, IAuthorsEfRepository authorsEfRepository)
        {
            _context = prodynaTestDbContext;
            _authorsEfRepository = authorsEfRepository;
        }
        public async Task<bool> DeleteAsync(Guid data)
        {
            var result = false;
            var entity = await _context.NewsItems.FirstOrDefaultAsync(e => e.Id == data);
            _context.NewsItems.Remove(entity);
            
            result = (await _context.SaveChangesAsync()) > 0;
            
            return result;
        }

        public async Task<Guid> EditAsync(DataModels.NewsItems data)
        {
            var entity = await _context.NewsItems.FirstOrDefaultAsync(e => e.Id == data.Id);
            entity = data;
            await _context.SaveChangesAsync();

            return entity.Id;
        }

        public async Task<NewsItemsModel> GetSingleAsync(Expression<Func<NewsItemsModel, bool>> query)
        {
            return await GetEntities().Where(query).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<NewsItemsModel>> GetListAsync(Expression<Func<NewsItemsModel, bool>> query)
        {
            return await GetEntities().Where(query).ToListAsync();
        }

        public async Task<Guid> InsertAsync(DataModels.NewsItems data)
        {
            //TODO: We should have an validation, for author and other stuff
            int result;
            DataModels.NewsItems entity;
            populateEntity(out entity, data);
            //TODO: should Id be generated by database or by backend API

            _context.NewsItems.Add(entity);
            await _context.SaveChangesAsync();

            return entity.Id; //TODO: we might have an exception here because Guid is not generated yet
        }

        #region private methods
        protected override IQueryable<NewsItemsModel> GetEntities()
        {
            return _context.NewsItems.AsQueryable() //TODO we should join Author table
                .Select(e => new NewsItemsModel { 
                    AuthorId = e.AuthorId,
                    Category = (CategoryEnum)e.Category,
                    CreatedTimestamp = e.CreatedTimestamp,
                    Description = e.Description,
                    Id = e.Id,
                    Name = e.Name
                }
            );
            
        }

        private void populateEntity(out DataModels.NewsItems entity, DataModels.NewsItems data) {
            entity = new DataModels.NewsItems();
            entity.Category = data.Category;
            entity.CreatedTimestamp = data.CreatedTimestamp;
            entity.Description = data.Description;
            entity.AuthorId = data.AuthorId;
            //TODO: should Id be generated by database or by backend API
        }
        private bool validateNewsItem(DataModels.NewsItems data) {

            throw new NotImplementedException(nameof(validateNewsItem));
        }
        #endregion

    }
}
