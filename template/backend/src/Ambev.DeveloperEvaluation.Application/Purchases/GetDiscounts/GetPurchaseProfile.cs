using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Purchases.GetDiscounts;

public class GetPurchaseProfile : Profile
{
    public GetPurchaseProfile()
    {
        CreateMap<ProductPurchaseCommand, ProductQuantityResult>().ReverseMap();
    }
}
