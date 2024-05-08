using Domain.Entities;
using Interface.Repository;
using Microsoft.EntityFrameworkCore;
using Persistence.ContextModel;

namespace Repository;

public class SalesmanRepository : BaseRepository<Salesman>, ISalesmanRepository, IDisposable
{
    #region Configuration
    public SalesmanRepository(IApplicationDbContext context) : base((DbContext)context)
    {
    }

    #endregion

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
