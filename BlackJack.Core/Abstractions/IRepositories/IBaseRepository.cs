using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core.Abstractions.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task<bool> AddAsync(T entity);
        Task AddRange(IEnumerable<T> entities);
        Task<bool> UpdateAsync(T entity);
        Task< bool> RemoveAsync(T entity);
        Task<bool> SaveChangeAsync();
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetById(int id);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate);
        Task<T?> GetByIdIncludeAsync(Expression<Func<T, bool>> predicate, string include);
    }
}
