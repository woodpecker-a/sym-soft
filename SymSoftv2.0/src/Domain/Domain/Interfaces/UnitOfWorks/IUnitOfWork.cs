namespace Domain.Interfaces.UnitOfWorks;

public interface IUnitOfWork : IDisposable
{
    void Save();
}
