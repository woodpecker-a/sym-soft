using AutoMapper;
using Domain.Entities;
using Domain.Models;

namespace Utility.Factory;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Customer, CustomerModel>()
            .ReverseMap();

        CreateMap<Inventory, InventoryModel>()
            .ReverseMap();

        CreateMap<Product, ProductModel>()
            .ReverseMap();

        CreateMap<Salesman, SalesmanModel>()
            .ReverseMap();
    }
}