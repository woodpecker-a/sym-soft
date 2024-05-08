using Autofac;
using Interface.Repository;
using Interface.Services;
using Persistence.ContextModel;
using Services;
using Repository;

namespace Utility.Factory;

public class DependencyResolver : Module
{
    #region Constructor
    private readonly string _connectionString;
    private readonly string _migrationAssemblyName;

    public DependencyResolver(string connectionString, string migrationAssemblyName)
    {
        _connectionString = connectionString;
        _migrationAssemblyName = migrationAssemblyName;
    }
    #endregion

    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
        .InstancePerLifetimeScope();

        builder.RegisterType<CustomerService>().As<ICustomerService>()
            .InstancePerLifetimeScope();

        builder.RegisterType<CustomerRepository>().As<ICustomerRepository>()
            .InstancePerLifetimeScope();

        builder.RegisterType<InventoryService>().As<IInventoryService>()
            .InstancePerLifetimeScope();

        builder.RegisterType<InventoryRepository>().As<ICustomerRepository>()
            .InstancePerLifetimeScope();

        builder.RegisterType<ProductService>().As<IProductService>()
            .InstancePerLifetimeScope();

        builder.RegisterType<ProductRepository>().As<IProductRepository>()
            .InstancePerLifetimeScope();

        builder.RegisterType<SalesmanService>().As<ISalesmanService>()
            .InstancePerLifetimeScope();

        builder.RegisterType<SalesmanRepository>().As<ISalesmanRepository>()
            .InstancePerLifetimeScope();
    }
}