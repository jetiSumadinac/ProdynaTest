﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProdynaTest.Core.Services.AuthorServices;
using ProdynaTest.Core.Services.NewsItemsService;
using ProdynaTest.Models;
using ProdynaTest.Shared.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProdynaTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsItemsService _newsItemsService;
        private readonly IAuthorService _authorService;

        public HomeController(ILogger<HomeController> logger, 
            INewsItemsService newsItemsService,
            IAuthorService authorService)
        {
            _logger = logger;
            _newsItemsService = newsItemsService;
            _authorService = authorService;
        }

        public async Task<IActionResult> Index()
        {
            var data  = await _newsItemsService.GetNewsListAsync();

            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> InsertAuthor(AuthorModel data) {
            bool result;
            await _authorService.SaveAuthorAsync(data);

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
