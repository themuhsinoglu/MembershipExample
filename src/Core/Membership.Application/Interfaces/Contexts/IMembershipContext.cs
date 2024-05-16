using Membership.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Membership.Application.Interfaces.Contexts
{
    public interface IMembershipContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
