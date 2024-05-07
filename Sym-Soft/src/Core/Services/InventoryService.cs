using Domain.Entities;
using Interface.Repository;
using Interface.Services;
using Interface.UnitOfWork;

namespace Services;

public class InventoryService : BaseService<Inventory>, IInventoryService
{
    #region Configuration
    private IInventoryRepository _iRepository;
    private readonly IUnitOfWork _iunitOfWork;

    public InventoryService(IInventoryRepository iRepository,
        IUnitOfWork iUnitOfWork) : base(iRepository, iUnitOfWork)
    {
        _iRepository = iRepository;
        _iunitOfWork = iUnitOfWork;
    }
    #endregion
}