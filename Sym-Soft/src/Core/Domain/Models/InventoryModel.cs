using Domain.Entities;

namespace Domain.Models;

public class InventoryModel
{
    public Product Product { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
}