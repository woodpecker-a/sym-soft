namespace Domain.Entities;

public class Inventory
{
    public Product Product { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}
