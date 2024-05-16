using Membership.Application.Interfaces.Repositories;
using Membership.Application.Interfaces.UnitOfWorks;
using Membership.Persistence.Contexts;
using Membership.Persistence.Repositories;
using Membership.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Membership.Persistence
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<MembershipContext>(options => options.UseInMemoryDatabase("MembershipDatabase"));
            serviceCollection.AddTransient<ICustomerRepository, CustomerRepository>();
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();

            return serviceCollection;
        }
    }
}
