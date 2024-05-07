using Domain.Entities;
using Interface.Repository;
using Interface.Services;
using Interface.UnitOfWork;

namespace Services;

public class ProductService : BaseService<Product>, IProductService
{
    #region Configuration
    private IProductRepository _iRepository;
    private readonly IUnitOfWork _iunitOfWork;

    public ProductService(IProductRepository iRepository,
        IUnitOfWork iUnitOfWork) : base(iRepository, iUnitOfWork)
    {
        _iRepository = iRepository;
        _iunitOfWork = iUnitOfWork;
    }
    #endregion
}