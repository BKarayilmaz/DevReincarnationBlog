using DevReincarnationBlog.Web.Models;
using DevReincarnationBlog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DevReincarnationBlog.Service.Services.Concretes;

namespace DevReincarnationBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleService articleService;

        public HomeController(ILogger<HomeController> logger, IArticleService articleServices)
        {
            _logger = logger;
            this.articleService = articleServices;
        }

        public async Task<IActionResult> Index()
        {
            var articles=await articleService.GetAllArticlesAsync();
            return View(articles);
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