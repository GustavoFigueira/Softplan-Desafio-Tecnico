using Microsoft.Extensions.DependencyInjection;
using Softplan.DesafioTecnico.Application.Services;
using Softplan.DesafioTecnico.Domain.Interfaces;

namespace Softplan.DesafioTecnico.IoC.Extensions
{
    public static class ServicesCollectionExtensions
    {
        public static IServiceCollection AddCompoundInterestExtensions(this IServiceCollection services)
        {
            services.AddScoped<ICompoundInterestService, CompoundInterestService>();

            return services;
        }
    }
}
