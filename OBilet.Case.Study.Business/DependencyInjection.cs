using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OBilet.Case.Study.API.Client.Abstract;
using OBilet.Case.Study.API.Client.Concrete;
using OBilet.Case.Study.Business.Abstractions;
using OBilet.Case.Study.Business.Services;
using OBilet.Case.Study.Business.Utilities;

namespace OBilet.Case.Study.Business
{
    public static class DependencyInjection
    {
        public static void RegisterBLLDependencies(this IServiceCollection services, IConfiguration Configuration)
        {
            string redisConnectionString = Configuration.GetSection("Redis:ConnectionString").Value;

            services.AddAutoMapper(typeof(AutoMapperProfiles));


            services.AddScoped<IBusService, BusService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IOBiletService, OBiletService>();
            services.AddSingleton<IRedisService>(provider => new RedisService(redisConnectionString));

        }
    }
}
