using Membership.Application.Interfaces.Repositories;
using Membership.Domain.Entities;
using Membership.Persistence.Contexts;

namespace Membership.Persistence.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(MembershipContext membershipContext) : base(membershipContext)
        {
        }
    }
}
