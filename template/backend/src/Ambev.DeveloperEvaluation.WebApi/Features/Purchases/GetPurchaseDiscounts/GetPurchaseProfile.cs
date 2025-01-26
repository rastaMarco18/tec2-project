using Ambev.DeveloperEvaluation.Application.Purchases.GetDiscounts;
using Ambev.DeveloperEvaluation.WebApi.Features.Discounts.GetDiscount;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Purchases.GetPurchaseDiscounts;

public class GetPurchaseProfile : Profile
{
    public GetPurchaseProfile()
    {
        CreateMap<GetDiscountPurchaseCommand, GetDiscountRequest>().ReverseMap();
        CreateMap<GetDiscountPurchaseResult, GetPurchaseResponse>().ReverseMap();
        CreateMap<ProductQuantityResult, ProductQuantityResponse>().ReverseMap();
        CreateMap<ProductPurchaseRequest, ProductPurchaseCommand>().ReverseMap();
    }
}
