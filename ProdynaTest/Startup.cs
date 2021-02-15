using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAcces.DataModels;
using Microsoft.EntityFrameworkCore;
using DataAcces.Infrastructure.Autors;
using DataAcces.Infrastructure.NewsItems;
using ProdynaTest.Core.Services.AuthorServices;
using ProdynaTest.Core.Services.NewsItemsService;

namespace ProdynaTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<ProdynaTestDbContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("ProdynaTestMsSql")
                )
            );
            //repository services
            services.AddScoped<IAuthorsEfRepository, AuthorsEfRepository>();
            services.AddScoped<INewsItemsEfRepository, NewsItemsEfRepository>();

            //core services
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<INewsItemsService, NewsItemsService>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ProdynaTestDbContext db)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            db.Database.EnsureCreated();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
