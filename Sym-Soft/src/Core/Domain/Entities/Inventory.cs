namespace Domain.Entities;

public class Inventory : IEntity<Guid>
{
    public Guid Id { get; set; }
    public Product Product { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}
