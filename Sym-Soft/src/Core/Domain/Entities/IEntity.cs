namespace Domain.Entities;

public interface IEntity<Guid>
{
    Guid Id { get; set; }
}
