using BP.Infrastructure.DataAccess;
using BP.Infrastructure.DataAccess.Repositories;
using BP.Infrastructure.Entities;
using BP.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BP.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddRepositories();
            return services;
        }

        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BPContext>(opt =>
                opt.UseNpgsql(configuration.GetConnectionString("postgres")));

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IRepository<DeveloperEntity>, GenericRepository<DeveloperEntity>>();
            services.AddTransient<IDeveloperRepository, DeveloperRepository>();
            return services;
        }
    }
}