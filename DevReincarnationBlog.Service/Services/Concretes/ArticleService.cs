using DevReincarnationBlog.Entity.Entities;
using DevReincarnationBlog.Service.Services.Abstractions;
using DevReincarnationBlog.Data.UnitOfWorks;

namespace DevReincarnationBlog.Service.Services.Concretes
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        public ArticleService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;   
        }
        public async Task<List<Article>> GetAllArticlesAsync()
        {
            return await unitOfWork.GetRepository<Article>().GetAllAsync();
        }
    }
}
