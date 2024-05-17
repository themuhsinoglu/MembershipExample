using Membership.Application.Interfaces.Repositories;
using Membership.Domain.Common;
using Membership.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Membership.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        readonly MembershipContext _membershipContext;
        public Repository(MembershipContext membershipContext)
        {
            _membershipContext = membershipContext;
        }
        private DbSet<T> Table { get => _membershipContext.Set<T>(); }
        public async Task<T> AddAsync(T model)
        {
            await Table.AddAsync(model);
            await _membershipContext.SaveChangesAsync();
            return model;
        }

        public async Task<T> UpdateAsync(T model)
        {
             Table.Update(model);
            await _membershipContext.SaveChangesAsync();
            return model;
        }

        public async Task<List<T>> GetAsync()
        {
            return await Table.ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<List<T>> GetWhereAsync(Expression<Func<T, bool>> expression)
        {
            return await Table.Where(expression).ToListAsync();
        }

        public async Task<T> RemoveAsync(T model)
        {
            Table.Remove(model);
            await _membershipContext.SaveChangesAsync();
            return model;
        }
    }
}
