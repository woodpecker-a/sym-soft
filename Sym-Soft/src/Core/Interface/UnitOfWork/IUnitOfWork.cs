namespace Interface.UnitOfWork;

public interface IUnitOfWork
{
    Task<bool> CompleteAsync();
    void Dispose();
}
