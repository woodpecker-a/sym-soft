using Domain.Interfaces.UnitOfWorks;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.UnitOfWorks;

public class ApplicationUnitOfWork : UnitOfWork, IApplicationUnitOfWork
{

    public ApplicationUnitOfWork(IApplicationDbContext dbContext) : base((DbContext)dbContext)
    {
    }
}
