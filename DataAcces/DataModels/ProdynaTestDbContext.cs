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
    }
}
