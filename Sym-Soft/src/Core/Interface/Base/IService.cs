using System.Linq.Expressions;

namespace Interface.Base
{
    public interface IService<T> where T : class
    {
        long CurrentUserId { get; set; }
        string BaseUrl { get; set; }

        Task<T> GetByIdAsync(long id, bool isTracking = true);

        Task<bool> AddAsync(T entity);

        Task<bool> UpdateAsync(T entity);

        Task RemoveAsync(T entity);
    }
}
