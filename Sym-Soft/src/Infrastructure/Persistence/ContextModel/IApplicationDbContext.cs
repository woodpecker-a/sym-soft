using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.ContextModel;

public interface IApplicationDbContext
{
    DbSet<Customer> Customers { get; set; }
    DbSet<Inventory> Inventories { get; set; }
    DbSet<Product> Products { get; set; }
    DbSet<Salesman> Salesman { get; set; }
}