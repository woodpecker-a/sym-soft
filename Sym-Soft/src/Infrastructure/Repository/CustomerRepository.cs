using Domain.Entities;
using Interface.Repository;

namespace Repository;

internal class CustomerRepository : BaseRepository<Customer>, ICustomerRepository, IDisposable
{
    #region Configuration
    
    #endregion

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
