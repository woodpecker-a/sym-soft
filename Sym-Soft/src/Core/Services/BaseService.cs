using Interface.Base;
using Interface.UnitOfWork;

namespace Services;

public class BaseService<T> : IService<T> where T : class
{
    protected IRepository<T> MapRepository;
    private readonly IUnitOfWork _iUnitOfWork;
    public long CurrentUserId { get; set; }
    public string BaseUrl { get; set; }

    public BaseService() { }

    public BaseService(IRepository<T> infoMapRepository, IUnitOfWork iUnitOfWork)
    {
        MapRepository = infoMapRepository;
        _iUnitOfWork = iUnitOfWork;
    }

    public async Task<bool> AddAsync(T entity)
    {
        await MapRepository.AddAsync(entity);
        var result = await _iUnitOfWork.CompleteAsync();
        return result;
    }

    public virtual async Task<ICollection<T>> GetAllAsync()
    {
        return await MapRepository.GetAllAsync();
    }

    public virtual async Task<T> GetByIdAsync(Guid id, bool isTracking = true)
    {
        return await MapRepository.GetByIdAsync(id);
    }

    public virtual async Task<bool> UpdateAsync(T entity)
    {
        await MapRepository.UpdateAsync(entity);
        var result = await _iUnitOfWork.CompleteAsync();
        return result;
    }

    public virtual async Task RemoveAsync(T entity)
    {
        await MapRepository.RemoveAsync(entity);
    }

}