using Membership.Application.Interfaces.Repositories;
using Membership.Application.Interfaces.UnitOfWorks;
using Membership.Persistence.Contexts;

namespace Membership.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly MembershipContext _membershipContext;

        public UnitOfWork(MembershipContext membershipContext, ICustomerRepository customer)
        {
            _membershipContext = membershipContext;
            Customers = customer;
        }
        public ICustomerRepository Customers { get; }


        public int Complete()
        {
            return _membershipContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _membershipContext.Dispose();
            }
        }
    }
}
