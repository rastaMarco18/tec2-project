using Ambev.DeveloperEvaluation.Application.Sales.GetSales;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Filters;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSale
{
    public class GetSaleProfile : Profile
    {
        public GetSaleProfile()
        {
            CreateMap<GetSaleRequestView, GetSaleRequest>().ReverseMap();
            CreateMap<GetSaleCommand, GetSaleRequest>().ReverseMap();
            CreateMap<GetSaleCommand, SaleFilter>().ReverseMap();
            CreateMap<Sale, GetSaleResponse>().ReverseMap();
            CreateMap<GetSalesResultResponse, GetSaleResponse>().ReverseMap();
            CreateMap<SaleProductsResponse, Product>().ReverseMap();
        }
    }
}
