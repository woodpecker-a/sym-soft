using System.Linq.Expressions;

namespace Interface.Base;

public interface IRepository<T> where T : class
{
    Task<ICollection<T>> GetAllAsync();

    Task<T> GetByIdAsync(Guid id);

    Task AddAsync(T entity);

    Task UpdateAsync(T entity);

    Task RemoveAsync(T entity);
}

