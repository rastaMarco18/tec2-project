using Ambev.DeveloperEvaluation.Application.Products.GetProducts;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Filters;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProducts
{
    public class GetProductProfile : Profile
    {
        public GetProductProfile()
        {
            CreateMap<GetProductCommand, GetProductRequest>().ReverseMap();
            CreateMap<GetProductCommand, ProductFilter>().ReverseMap();
            CreateMap<Product, GetProductResponse>().ReverseMap();
        }
    }
}
