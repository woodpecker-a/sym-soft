﻿namespace Domain.Models;

public class CustomerModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
}