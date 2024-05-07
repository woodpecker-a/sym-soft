using Domain.Entities;
using Interface.Repository;
using Interface.Services;
using Interface.UnitOfWork;

namespace Services;

public class SalesmanService : BaseService<Salesman>, ISalesmanService
{
    #region Configuration
    private ISalesmanRepository _iRepository;
    private readonly IUnitOfWork _iunitOfWork;

    public SalesmanService(ISalesmanRepository iRepository,
        IUnitOfWork iUnitOfWork) : base(iRepository, iUnitOfWork)
    {
        _iRepository = iRepository;
        _iunitOfWork = iUnitOfWork;
    }
    #endregion
}