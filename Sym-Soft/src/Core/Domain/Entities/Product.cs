﻿namespace Domain.Entities;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public double Price { get; set; }
    public string? Description { get; set; }
}
