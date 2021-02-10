using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.DataModels
{
    public class ProdynaTestDbContext : DbContext
    {
        public DbSet<NewsItems> NewsItems { get; set; }
        public DbSet<Authors> Authors { get; set; }
        
        public ProdynaTestDbContext(DbContextOptions<ProdynaTestDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>(entity => {
                entity.HasKey(m => m.Id);
                entity.Property(m => m.Id).IsRequired();
                entity.Property(m => m.Name).IsRequired();
                
                entity.HasOne<NewsItems>(m => m.NewsItem)
                    .WithOne(a => a.ItemAuthor)
                    .HasForeignKey<NewsItems>(fk => fk.AuthorId);
            });

            modelBuilder.Entity<NewsItems>(entity =>
            {
                entity.HasKey(m => m.Id);
                entity.Property(m => m.Name).IsRequired();
                entity.Property(m => m.CreatedTimestamp).IsRequired();
                entity.Property(m => m.Category).IsRequired();
                entity.Property(m => m.AuthorId).IsRequired();
            });
        }
    }
}
