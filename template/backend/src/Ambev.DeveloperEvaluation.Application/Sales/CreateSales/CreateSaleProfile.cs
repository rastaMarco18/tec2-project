using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSales;

public class CreateSaleProfile : Profile
{
    public CreateSaleProfile() 
    {
        CreateMap<CreateSaleCommand, Sale>().ReverseMap();
        CreateMap<Sale, CreateSaleResult>().ReverseMap();
    }
}
