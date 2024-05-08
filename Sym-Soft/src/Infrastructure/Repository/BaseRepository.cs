using Interface.Base;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class BaseRepository<T> : IRepository<T> where T : class
{
    #region Configuration

    protected DbContext _dbContext;
    protected DbSet<T> _dbSet;

    protected BaseRepository(DbContext context)
    {
        _dbContext = context;
        _dbSet = _dbContext.Set<T>();
    }

    public DbSet<T> Table
    {
        get
        {
            var set = _dbContext.Set<T>();
            return set;
        }
    }

    #endregion

    public async Task AddAsync(T entity)
    {
        if (entity == null) throw new ArgumentNullException();
        await _dbSet.AddAsync(entity);
    }

    public async Task<ICollection<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        var data = await _dbSet.FindAsync(id) as T;
        return data;
    }

    public async Task RemoveAsync(T entity)
    {
        if (entity == null) throw new ArgumentNullException();
        _dbSet.Remove(entity);
    }

    public async Task UpdateAsync(T entity)
    {
        if (entity == null) throw new ArgumentNullException();
        try
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
        catch (InvalidOperationException e)
        {
            if (e.Message.ToLower().Contains("attach") || e.Message.ToLower().Contains("multiple instances"))
            {
                _dbContext.Entry(entity).State = EntityState.Detached;
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
