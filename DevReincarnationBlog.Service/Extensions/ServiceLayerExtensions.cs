using DevReincarnationBlog.Service.Services.Abstractions;
using DevReincarnationBlog.Service.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace DevReincarnationBlog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
        {

            services.AddScoped<IArticleService, ArticleService>();
            return services;
        }
    }
}
