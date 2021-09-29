using Microsoft.Extensions.DependencyInjection;
using OctaTech.Domain.Interface.Service;
using OctaTech.Service;

namespace OctaTech.Infrastructure.CrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IVehicleService, VehicleService>();
        }
    }
}
