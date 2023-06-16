using DevReincarnationBlog.Entity.Entities;
using DevReincarnationBlog.Service.Services.Abstractions;
using DevReincarnationBlog.Data.UnitOfWorks;
using DevReincarnationBlog.Entity.DTOs.Articles;
using AutoMapper;

namespace DevReincarnationBlog.Service.Services.Concretes
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        public ArticleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;   
            this.mapper = mapper;
        }
        public async Task<List<ArticleDto>> GetAllArticlesAsync()
        {
            var articles= await unitOfWork.GetRepository<Article>().GetAllAsync();
            var map = mapper.Map<List<ArticleDto>>(articles);

            return map;
        }
    }
}
