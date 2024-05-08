using Domain.Entities;
using Interface.Repository;
using Microsoft.EntityFrameworkCore;
using Persistence.ContextModel;

namespace Repository;

public class InventoryRepository : BaseRepository<Inventory>, IInventoryRepository, IDisposable
{
    #region Configuration
    public InventoryRepository(IApplicationDbContext context) : base((DbContext)context)
    {
    }

    #endregion

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}