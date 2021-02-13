using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProdynaTest.Core.Services.NewsItemsService;
using ProdynaTest.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ProdynaTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsItemsService _newsItemsService;

        public HomeController(ILogger<HomeController> logger, INewsItemsService newsItemsService)
        {
            _logger = logger;
            _newsItemsService = newsItemsService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _newsItemsService.GetListAsync();
            
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
