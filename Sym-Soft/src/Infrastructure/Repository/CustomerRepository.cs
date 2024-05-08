using Domain.Entities;
using Interface.Repository;
using Microsoft.EntityFrameworkCore;
using Persistence.ContextModel;

namespace Repository;

public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository, IDisposable
{
    #region Configuration
    public CustomerRepository(IApplicationDbContext context) : base((DbContext)context)
    {
    }

    #endregion

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}