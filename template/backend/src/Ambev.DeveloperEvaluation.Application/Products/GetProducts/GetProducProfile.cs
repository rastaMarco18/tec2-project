using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Products.GetProducts
{
    public class GetProducProfile : Profile
    {
        public GetProducProfile()
        {
            CreateMap<Product, GetProductResult>().ReverseMap();
        }
    }
}