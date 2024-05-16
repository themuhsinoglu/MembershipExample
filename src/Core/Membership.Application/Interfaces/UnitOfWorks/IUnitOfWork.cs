using Membership.Application.Interfaces.Repositories;

namespace Membership.Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        int Complete();
    }
}
