using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StudentAdministration.Database.Repositories;


namespace StudentAdministration.Database.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IStudentRepository, StudentRepository>();
            services.AddScoped<IStudiesProgramRepository, StudiesProgramRepository>();
            services.AddScoped<IStudiesSubjectRepository, StudiesSubjectRepository>();
            services.AddScoped<IStudiesSubSubjectRepository, StudiesSubSubjectRepository>();
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Database")));
            return services;
        }
    }
}
