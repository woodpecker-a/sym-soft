using Domain.Entities;
using Interface.Repository;
using Microsoft.EntityFrameworkCore;
using Persistence.ContextModel;

namespace Repository;

public class ProductRepository : BaseRepository<Product>, IProductRepository, IDisposable
{
    #region Configuration
    public ProductRepository(IApplicationDbContext context) : base((DbContext)context)
    {
    }

    #endregion

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}