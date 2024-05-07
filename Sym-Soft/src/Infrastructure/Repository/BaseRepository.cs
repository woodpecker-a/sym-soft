using Interface.Base;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class BaseRepository<T> : IRepository<T> where T : class
{
    #region Configuration

    protected BaseRepository(DbContext context)
    {
        Db = context;
    }

    public DbSet<T> Table
    {
        get
        {
            var set = Db.Set<T>();
            return set;
        }
    }

    protected DbContext Db { get; set; }

    protected DbSet<T> Set => Db.Set<T>();

    #endregion

    public async Task AddAsync(T entity)
    {
        if (entity == null) throw new ArgumentNullException();
        await Set.AddAsync(entity);
    }

    public async Task<ICollection<T>> GetAllAsync()
    {
        return await Set.ToListAsync();
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        var data = await Set.FindAsync(id) as T;
        return data;
    }

    public async Task RemoveAsync(T entity)
    {
        if (entity == null) throw new ArgumentNullException();
        Set.Remove(entity);
    }

    public async Task UpdateAsync(T entity)
    {
        if (entity == null) throw new ArgumentNullException();
        try
        {
            Set.Attach(entity);
            Db.Entry(entity).State = EntityState.Modified;
        }
        catch (InvalidOperationException e)
        {
            if (e.Message.ToLower().Contains("attach") || e.Message.ToLower().Contains("multiple instances"))
            {
                Db.Entry(entity).State = EntityState.Detached;
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
