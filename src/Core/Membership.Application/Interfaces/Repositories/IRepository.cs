using Membership.Domain.Common;
using System.Linq.Expressions;

namespace Membership.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAsync();
        Task<List<T>> GetWhereAsync(Expression<Func<T, bool>> expression);
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T model);
        Task<T> RemoveAsync(T model);
    }
}
