using intership_jenkins.Entities;
using intership_jenkins.Services.BookService;

namespace intership_jenkins.Extentions
{
    public static class ApplicationServiceExtention
    {
        public static IServiceCollection AddApplicationservices(this IServiceCollection services ,IConfiguration config)
        {
            services.Configure<DataBaseConfiguration>(config.GetSection("intershipJenkinsDataBase"));

            services.AddScoped<IBookService, BookService>();
            
            return services;
        }
    }
}
