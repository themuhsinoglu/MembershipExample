using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;
using FluentValidation.AspNetCore;

namespace Membership.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //Tüm command ve handler bulup birbiri ile eşleştirme sağlamaktadır. 
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });

            services.AddFluentValidation(config =>
            {
            config.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            });

            return services;
        }

}
}
