using DevReincarnationBlog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace DevReincarnationBlog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class HomeController : Controller
    {
        private readonly IArticleService articleService;

        public HomeController(IArticleService articleServices)
        {
            this.articleService = articleServices;
        }

        public async Task<IActionResult> Index()
        {
            var articles = await articleService.GetAllArticlesAsync();
            return View(articles);
        }
    }
}
