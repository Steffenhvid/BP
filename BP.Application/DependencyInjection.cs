using BP.Application.Common.Interfaces;
using BP.Application.DTO;
using BP.Application.UseCases.Developers;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using static BP.Application.UseCases.Developers.AddDeveloper;
using static BP.Application.UseCases.Developers.GetDevelopers;
using static BP.Application.UseCases.Developers.UpsertDeveloper;

namespace BP.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapperProfile();
            services.AddUseCases();
            return services;
        }

        public static IServiceCollection AddAutoMapperProfile(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }

        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            services.AddTransient<IUseCase<GetDevelopersInput, List<DeveloperDTO>>, GetDevelopers>();
            services.AddTransient<IUseCase<AddDeveloperInput>, AddDeveloper>();
            services.AddTransient<IUseCase<UpsertDeveloperInput, DeveloperDTO>, UpsertDeveloper>();
            return services;
        }
    }
}