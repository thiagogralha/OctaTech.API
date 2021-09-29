using Microsoft.Extensions.DependencyInjection;
using OctaTech.Domain.Interface.Repository;
using OctaTech.Infrastructure.Data.Repository;

namespace OctaTech.Infrastructure.CrossCutting.InversionOfControl
{
    public static class RepositoryDependency
    {
        public static void AddRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IVehicleRepository, VehicleRepository>();
        }
    }
}
