using DevReincarnationBlog.Service.Services.Abstractions;
using DevReincarnationBlog.Service.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DevReincarnationBlog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtensions(this IServiceCollection services)
        {
            var assembly=Assembly.GetExecutingAssembly();
            
            services.AddScoped<IArticleService, ArticleService>();
            
            services.AddAutoMapper(assembly);
            return services;
        }
    }
}
