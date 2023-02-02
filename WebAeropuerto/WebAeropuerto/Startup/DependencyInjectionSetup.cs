using WebAeropuerto.Data.Repositories;

namespace WebAeropuerto.Startup
{
    public static class DependencyInjectionSetup
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ILlegadaRepository, LlegadaRepository>();
            services.AddScoped<ISalidaRepository, SalidaRepository>();

            return services;
        }
    }
}
