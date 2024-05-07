using Domain.Entities;
using Interface.Repository;
using Interface.Services;
using Interface.UnitOfWork;
using System.Linq.Expressions;

namespace Services;

public class CustomerService : BaseService<Customer>, ICustomerService
{
    #region Configuration
    private ICustomerRepository _iRepository;
    private readonly IUnitOfWork _iunitOfWork;

    public CustomerService(ICustomerRepository iRepository,
        IUnitOfWork iUnitOfWork) : base(iRepository, iUnitOfWork)
    {
        _iRepository = iRepository;
        _iunitOfWork = iUnitOfWork;
    }
    #endregion
}