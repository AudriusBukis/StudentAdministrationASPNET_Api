using Microsoft.Extensions.DependencyInjection;
using StudentAdministration.BusinessLogic.Services;

namespace StudentAdministration.BusinessLogic.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services)
        {

            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IStudiesProgramService, StudiesProgramService>();
            services.AddScoped<IStudiesSubjectService, StudiesSubjectService>();
            services.AddScoped<IStudiesSubSubjectService, StudiesSubSubjectService>();
            services.AddScoped<IMapper, Mapper>();
            return services;
        }
    }
}
