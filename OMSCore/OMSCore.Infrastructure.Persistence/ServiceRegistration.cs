using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OMSCore.Application.Interfaces;
using OMSCore.Application.Interfaces.Repositories;
using OMSCore.Infrastructure.Persistence.Persistence.Contexts;
using OMSCore.Infrastructure.Persistence.Persistence.Repositories;
using OMSCore.Infrastructure.Persistence.Persistence.Services;

namespace OMSCore.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseInMemoryDatabase("ApplicationDb"));
            }
            else
            {
                var connectionString = configuration.GetConnectionString("DefaultConnection");

                services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySQL(connectionString,
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
            }

            services.AddTransient<IUserMasterService, UserMasterService>();

            #region Repositories

            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<IUserMasterRepositoryAsync, UserMasterRepositoryAsync>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion Repositories
        }
    }
}