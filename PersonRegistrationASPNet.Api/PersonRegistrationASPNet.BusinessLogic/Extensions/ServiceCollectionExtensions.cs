using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersonRegistrationASPNet.BusinessLogic.Services;

namespace PersonRegistrationASPNet.BusinessLogic.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services)
        {

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IManagementService, ManagementService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<IMapper, Mapper>();
            return services;
        }
    }
}
