using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OMSCore.Application.Interfaces;
using OMSCore.Domain.Settings;
using OMSCore.Infrastructure.Shared.Services;

namespace OMSCore.Infrastructure.Shared
{
    public static class ServiceRegistration
    {
        public static void AddSharedInfrastructure(this IServiceCollection services, IConfiguration _config)
        {
            //services.Configure<JWTSettings>(_config.GetSection("JWTSettings"));
            services.AddTransient<IUserMasterService, UserMasterService>();
        }
    }
}